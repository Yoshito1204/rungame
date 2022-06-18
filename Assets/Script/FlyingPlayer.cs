using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlyingPlayer : MonoBehaviour
{
    private CharacterController controller;
    private Animator animator;
    private Vector3 direction;
    public float forwardSpeed;
    public float maxSpeed;
    const int DefaultLife = 3;

    private int desiredLane = 1;
    public float laneDistance = 4;
    int life = DefaultLife;

    public float jumpForce;
    public float Gravity;
    public GameObject Plane;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        Gravity = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayerManager.isGameStarted)
            return;

        if (forwardSpeed < maxSpeed)
        {
            forwardSpeed += 0.1f * Time.deltaTime;
        }

        direction.z = forwardSpeed;
        animator.SetBool("fly", direction.z > 0.0f);


        

        

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
        if (!PlayerManager.isGameStarted)
            return;
        controller.Move(direction * Time.fixedDeltaTime);
    }

    public int Life()
    {
        return life;
    }

    

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag == "Robo")
        {
            PlayerManager.gameOver = true;
            life--;
        }
        if (hit.transform.tag == "Black")
        {
            Plane.GetComponent<ChangeColor>().ChangeBlack();
        }
        if (hit.transform.tag == "Blue")
        {
            Plane.GetComponent<ChangeColor>().ChangeBlue();
        }
        if (hit.transform.tag == "Green")
        {
            Plane.GetComponent<ChangeColor>().ChangeGreen();
        }
        if (hit.transform.tag == "Red")
        {
            Plane.GetComponent<ChangeColor>().ChangeRed();
        }
        if (hit.transform.tag == "Yellow")
        {
            Plane.GetComponent<ChangeColor>().ChangeYellow();
        }
        

    }

    

}
