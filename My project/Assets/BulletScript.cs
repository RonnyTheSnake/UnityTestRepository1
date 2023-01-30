using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] float bulletsSpeed;
    [SerializeField] int lifeTime;
    [SerializeField] int damage;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * bulletsSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider collider)
    {
        //if(collider.gameObject.tag == "Player")
        //{
        //    collider.gameObject.GetComponent<Player>().TakeDamage(damage);
        //}

        Destroy(gameObject);
    }
}
