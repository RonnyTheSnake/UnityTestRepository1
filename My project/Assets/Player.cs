using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int speed = 5;
    [SerializeField] float jump = 0;
    [SerializeField] float gravity = 0.5f;
    [SerializeField] float jumpHeight = 25f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 input = new Vector3();
        //transform.position += new Vector3(0, 5, 0) * Time.deltaTime;
        transform.position += new Vector3(Input.GetAxis("Horizontal") * 2, jump, Input.GetAxis("Vertical") * 2) * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump += jumpHeight;
        }
        if(jump > 0)
        {
            jump -= gravity;
        }
        if( jump < 0)
        {
            jump = 0;
        }
    }
}
