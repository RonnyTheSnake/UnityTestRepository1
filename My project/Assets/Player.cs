using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int speed = 5;
    [SerializeField] float jump = 0;
    [SerializeField] float gravity = 0.5f;
    [SerializeField] float jumpHeight = 50f;

    public Vector3 moving;
    

    // Start is called before the first frame update
    void Start()
    {
        moving = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 input = new Vector3();
        //transform.position += new Vector3(0, 5, 0) * Time.deltaTime;
        moving = transform.position += new Vector3(Input.GetAxis("Horizontal") * 2, 0, Input.GetAxis("Vertical") * 2) * Time.deltaTime;
        moving*= speed;
        

        if (Input.GetButton("Jump"))
        {
            moving = transform.position += new Vector3(0, Input.GetAxis("Jump") * 4, 0) * Time.deltaTime;
        }
        

        moving.y -= gravity * Time.deltaTime;
    }
}
