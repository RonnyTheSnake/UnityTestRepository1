using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int speed = 5;
    [SerializeField] float jump = 0;
    [SerializeField] float gravity = 0.5f;

    [SerializeField] float jumpForce = 1f;
    [SerializeField] Vector3 velocity;
    [SerializeField] KeyCode jumpButton;
    [SerializeField] KeyCode dashButton;

    [SerializeField] GameObject groundCheck;
    [SerializeField] bool isGrounded;
    [SerializeField] LayerMask groundMask;

    [SerializeField] float smoothTime = 0.1f;
    [SerializeField] float dashMultiplier = 1;


    //public Vector3 moving;

    // Start is called before the first frame update
    void Start()
    {

        //moving = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        #region Unity Workshop Code

        isGrounded = Physics.CheckBox(groundCheck.transform.position, groundCheck.GetComponent<Collider>().bounds.size, Quaternion.identity, groundMask);

        velocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if (Input.GetKeyDown(jumpButton) && isGrounded)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpForce, 0));
        }

        Vector3 targetPosition = transform.position + new Vector3(velocity.x + 20, 0, 0) * dashMultiplier;

        if (Input.GetKeyDown(dashButton))
        {
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        }

        transform.position += velocity * speed * Time.deltaTime;

        #endregion

        #region My Code
        //Old movement code
        //Vector3 input = new Vector3();
        //transform.position += new Vector3(0, 5, 0) * Time.deltaTime;

        //Movement code
        //moving = transform.position += new Vector3(Input.GetAxis("Horizontal") * 2, 0, Input.GetAxis("Vertical") * 2) * Time.deltaTime;
        //moving*= speed;


        //if (Input.GetButton("Jump"))
        //{
        //    moving = transform.position += new Vector3(0, Input.GetAxis("Jump") * 4, 0) * Time.deltaTime;
        //}


        //moving.y -= gravity * Time.deltaTime;
        #endregion



    }
}
