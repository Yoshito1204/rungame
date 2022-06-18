using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaMove : MonoBehaviour
{
    //レーンの移動の数値をそれぞれの変数で宣言します。
    const int MinLane = -2;
    const int MaxLane = 2;
    const float LaneWidth = 1.0f;
    const int DefaultLife = 3;
    const float StunDuration = 0.5f;

    //CharacterController型を変数controllerで宣言します。
    CharacterController controller;
    //Animator型を変数animatorで宣言します。
    Animator animator;

    //それぞれの座標を０で宣言します。
    Vector3 moveDirection = Vector3.zero;
    //int型を変数targetLaneで宣言します。
    int targetLane;
    int life = DefaultLife;
    float recoverTime = 0.0f;

    //それぞれのパラメーターの設定をInspectorで変える様にします。
    public float gravity;
    public float speedZ;
    public float speedX;
    public float speedJump;
    public float accelerationZ;

    //スタート地点とエンド地点の座標
    private Vector3 touchStartPos;
    private Vector3 touchEndPos;

    //ライフを取得する関数
    public int Life()
    {
        return life;
    }

    public bool IsStan()
    {
        //気絶判定処理
        return recoverTime > 0.0f || life <= 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        //GetComponentでCharacterControllerwp取得して変数controllseで参照します。
        controller = GetComponent<CharacterController>();
        //GetComponentでAnimatorを取得して変数animatorで参照します。
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
                    //Y方向に数値分だけ力を加えます。
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
        //それぞれの矢印が押されたらそれぞれの関数を実行します。
        if (Input.GetKeyDown("left")) MoveToLeft();
        if (Input.GetKeyDown("right")) MoveToRight();
        if (Input.GetKeyDown("space")) Jump();

        //気絶した時の処理
        if (IsStan())
        {
            //動きを止めてライフを減らして復帰カウント。
            moveDirection.x = 0.0f;
            moveDirection.z = 0.0f;
            recoverTime -= Time.deltaTime;
        }
        else
        {
            //徐々に加速してZ方向に常に加速させる。
            float acceleratedZ = moveDirection.z + (accelerationZ * Time.deltaTime);
            moveDirection.z = Mathf.Clamp(acceleratedZ, 0, speedZ);
            //X方向は目標のポジションまでの差分の割合で速度を計算。
            float ratioX = (targetLane * LaneWidth - transform.position.x) / LaneWidth;
            moveDirection.x = ratioX * speedX;
        }
        //重力分の力を毎フレーム追加します。
        moveDirection.y -= gravity * Time.deltaTime;
        //移動を実行します。
        Vector3 globalDirection = transform.TransformDirection(moveDirection);
        controller.Move(globalDirection * Time.deltaTime);
        //移動後接地していたらY方向の速度はリセットする。
        if (controller.isGrounded) moveDirection.y = 0;
        //速度が０以上なら走っているフラグをtrueにする。
        animator.SetBool("run", moveDirection.z > 0.0f);


    }

    //新しく作った関数のそれぞれの処理。
    //左のレーンに移動。
    public void MoveToLeft()
    {
        //気絶時の入力をキャンセルします。
        if (IsStan()) return;
        if (controller.isGrounded && targetLane > MinLane) targetLane--;
    }
    //右のレーンに移動。
    public void MoveToRight()
    {
        if (IsStan()) return;
        if (controller.isGrounded && targetLane < MaxLane) targetLane++;
    }
    //ジャンプ時の処理。
    public void Jump()
    {
        if (IsStan()) return;
        if (controller.isGrounded)
        {
            //Y方向に数値分だけ力を加えます。
            moveDirection.y = speedJump;
            //トリガーで設定されているアニメーションjumpを実行します。
            animator.SetTrigger("jump");
        }
    }
    //CharacterControllerにコライダーが当たった時の処理。
    

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
                //右向きにフリック
                Direction = "right";
            }
            else if (-30 > directionX)
            {
                //左向きにフリック
                Direction = "left";
            }
        }
        else if (Mathf.Abs(directionX) < Mathf.Abs(directionY))
        {
            if (30 < directionY) 
            {
                //上向きにフリック
                Direction = "up";
            }
            
        }

        
       
    }

    
}
