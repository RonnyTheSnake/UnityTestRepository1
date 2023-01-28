using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    [SerializeField] public Transform player;
    [SerializeField] public float smoothedSpeed = 0.750f;
    [SerializeField] private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothedSpeed * Time.deltaTime);
        transform.position = smoothedPosition;

        transform.LookAt(player);
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X")* 4f, 0));

        }
    }
}
