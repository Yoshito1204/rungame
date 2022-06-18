using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitlePlayer : MonoBehaviour
{
    private CharacterController controller;
    private Animator animator;
    public AudioClip hitting;
    AudioSource audioSource;
    private Vector3 direction;
    public float forwardSpeed;
    public float maxSpeed;
    const int DefaultLife = 3;
    const int damage = 1;

    private int desiredLane = 1;
    public float laneDistance = 4;
    int life = DefaultLife;

    public float jumpForce;
    public float Gravity = -20;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (forwardSpeed < maxSpeed)
        {
            forwardSpeed += 0.1f * Time.deltaTime;
        }

        direction.z = forwardSpeed;
        animator.SetBool("run", direction.z > 0.0f);

        if (controller.isGrounded)
        {
            direction.y = -1;
            if (SwipeManagement.swipeUp)
            {
                Jump();
            }
        }
        else
        {
            direction.y += Gravity * Time.deltaTime;
        }

        if (SwipeManagement.swipeDown)
        {
            StartCoroutine(Sliding());
        }

        if (SwipeManagement.swipeRight)
        {
            desiredLane++;
            if (desiredLane == 3)
            {
                desiredLane = 2;
            }
        }

        if (SwipeManagement.swipeLeft)
        {
            desiredLane--;
            if (desiredLane == -1)
            {
                desiredLane = 0;
            }
        }

        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;

        if (desiredLane == 0)
        {
            targetPosition += Vector3.left * laneDistance;
        }
        else if (desiredLane == 2)
        {
            targetPosition += Vector3.right * laneDistance;
        }

        // transform.position = Vector3.Lerp(transform.position, targetPosition, 80 * Time.deltaTime);

        if (transform.position == targetPosition)
            return;
        Vector3 diff = targetPosition - transform.position;
        Vector3 moveDir = diff.normalized * 25 * Time.deltaTime;
        if (moveDir.sqrMagnitude < diff.sqrMagnitude)
            controller.Move(moveDir);
        else
            controller.Move(diff);


        
    }

    private void FixedUpdate()
    {
        
        controller.Move(direction * Time.fixedDeltaTime);
    }

    public int Life()
    {
        return life;
    }

    private void Jump()
    {
        direction.y = jumpForce;
        animator.SetTrigger("jump");
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag == "Robo")
        {
            forwardSpeed = 0;
            animator.SetTrigger("death");
            Invoke(nameof(DelayGamaOver), 0.1f);
            audioSource.PlayOneShot(hitting);
        }


    }


    private void DelayGamaOver()
    {
        PlayerManager.gameOver = true;
    }

    private IEnumerator Sliding()
    {
        animator.SetBool("Slide", true);
        controller.height -= 0.5f;

        yield return new WaitForSeconds(1.3f);

        animator.SetBool("Slide", false);
        controller.height += 0.5f;
    }

}
