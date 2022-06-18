using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaMove : MonoBehaviour
{
    //���[���̈ړ��̐��l�����ꂼ��̕ϐ��Ő錾���܂��B
    const int MinLane = -2;
    const int MaxLane = 2;
    const float LaneWidth = 1.0f;
    const int DefaultLife = 3;
    const float StunDuration = 0.5f;

    //CharacterController�^��ϐ�controller�Ő錾���܂��B
    CharacterController controller;
    //Animator�^��ϐ�animator�Ő錾���܂��B
    Animator animator;

    //���ꂼ��̍��W���O�Ő錾���܂��B
    Vector3 moveDirection = Vector3.zero;
    //int�^��ϐ�targetLane�Ő錾���܂��B
    int targetLane;
    int life = DefaultLife;
    float recoverTime = 0.0f;

    //���ꂼ��̃p�����[�^�[�̐ݒ��Inspector�ŕς���l�ɂ��܂��B
    public float gravity;
    public float speedZ;
    public float speedX;
    public float speedJump;
    public float accelerationZ;

    //�X�^�[�g�n�_�ƃG���h�n�_�̍��W
    private Vector3 touchStartPos;
    private Vector3 touchEndPos;

    //���C�t���擾����֐�
    public int Life()
    {
        return life;
    }

    public bool IsStan()
    {
        //�C�┻�菈��
        return recoverTime > 0.0f || life <= 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent��CharacterControllerwp�擾���ĕϐ�controllse�ŎQ�Ƃ��܂��B
        controller = GetComponent<CharacterController>();
        //GetComponent��Animator���擾���ĕϐ�animator�ŎQ�Ƃ��܂��B
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        string Direction = " ";
        Vector3 tmp = GameObject.Find("Running").transform.position;
        Flick();
        GetDirection();

        switch (Direction)
        {

            case "up":
                if (controller.isGrounded)
                {
                    //Y�����ɐ��l�������͂������܂��B
                    moveDirection.y = speedJump;
                    animator.SetTrigger("jump");
                }

                break;

            case "right":
                if (IsStan()) return;
                GameObject.Find("Running").transform.position = new Vector3(2, tmp.y, tmp.z);
                break;

            case "left":
                if (IsStan()) return;
                GameObject.Find("Running").transform.position = new Vector3(-2, tmp.y, tmp.z);
                break;


        }
        transform.position = tmp;
        //���ꂼ��̖�󂪉����ꂽ�炻�ꂼ��̊֐������s���܂��B
        if (Input.GetKeyDown("left")) MoveToLeft();
        if (Input.GetKeyDown("right")) MoveToRight();
        if (Input.GetKeyDown("space")) Jump();

        //�C�₵�����̏���
        if (IsStan())
        {
            //�������~�߂ă��C�t�����炵�ĕ��A�J�E���g�B
            moveDirection.x = 0.0f;
            moveDirection.z = 0.0f;
            recoverTime -= Time.deltaTime;
        }
        else
        {
            //���X�ɉ�������Z�����ɏ�ɉ���������B
            float acceleratedZ = moveDirection.z + (accelerationZ * Time.deltaTime);
            moveDirection.z = Mathf.Clamp(acceleratedZ, 0, speedZ);
            //X�����͖ڕW�̃|�W�V�����܂ł̍����̊����ő��x���v�Z�B
            float ratioX = (targetLane * LaneWidth - transform.position.x) / LaneWidth;
            moveDirection.x = ratioX * speedX;
        }
        //�d�͕��̗͂𖈃t���[���ǉ����܂��B
        moveDirection.y -= gravity * Time.deltaTime;
        //�ړ������s���܂��B
        Vector3 globalDirection = transform.TransformDirection(moveDirection);
        controller.Move(globalDirection * Time.deltaTime);
        //�ړ���ڒn���Ă�����Y�����̑��x�̓��Z�b�g����B
        if (controller.isGrounded) moveDirection.y = 0;
        //���x���O�ȏ�Ȃ瑖���Ă���t���O��true�ɂ���B
        animator.SetBool("run", moveDirection.z > 0.0f);


    }

    //�V����������֐��̂��ꂼ��̏����B
    //���̃��[���Ɉړ��B
    public void MoveToLeft()
    {
        //�C�⎞�̓��͂��L�����Z�����܂��B
        if (IsStan()) return;
        if (controller.isGrounded && targetLane > MinLane) targetLane--;
    }
    //�E�̃��[���Ɉړ��B
    public void MoveToRight()
    {
        if (IsStan()) return;
        if (controller.isGrounded && targetLane < MaxLane) targetLane++;
    }
    //�W�����v���̏����B
    public void Jump()
    {
        if (IsStan()) return;
        if (controller.isGrounded)
        {
            //Y�����ɐ��l�������͂������܂��B
            moveDirection.y = speedJump;
            //�g���K�[�Őݒ肳��Ă���A�j���[�V����jump�����s���܂��B
            animator.SetTrigger("jump");
        }
    }
    //CharacterController�ɃR���C�_�[�������������̏����B
    

    void Flick()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            touchStartPos = new Vector3(Input.mousePosition.x,
                                        Input.mousePosition.y,
                                        Input.mousePosition.z);
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            touchEndPos = new Vector3(Input.mousePosition.x,
                                      Input.mousePosition.y,
                                      Input.mousePosition.z);
            GetDirection();
        }
    }

    void GetDirection()
    {
        float directionX = touchEndPos.x - touchStartPos.x;
        float directionY = touchEndPos.y - touchStartPos.y;
        string Direction = " ";
        Vector3 tmp = GameObject.Find("Running").transform.position;
        

        if (Mathf.Abs(directionY) < Mathf.Abs(directionX))
        {
            if (30 < directionX)
            {
                //�E�����Ƀt���b�N
                Direction = "right";
            }
            else if (-30 > directionX)
            {
                //�������Ƀt���b�N
                Direction = "left";
            }
        }
        else if (Mathf.Abs(directionX) < Mathf.Abs(directionY))
        {
            if (30 < directionY) 
            {
                //������Ƀt���b�N
                Direction = "up";
            }
            
        }

        
       
    }

    
}
