using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 3;

    public GameObject boltPrefab;


    void Start()
    {
        
    }

    void Update()
    {

        float controlX = Input.GetAxisRaw("Horizontal");
        float controlY = Input.GetAxisRaw("Vertical");

        Vector3 movementX = Vector3.right * controlX * Time.deltaTime * speed;
        Vector3 movementY = Vector3.up * controlY * Time.deltaTime * speed;

        transform.Translate(movementX + movementY);
        
        if (Mathf.Abs(transform.position.x) > 5)
        {
            transform.Translate(-movementX);
        }

        if (Mathf.Abs(transform.position.y) > 5)
        {
            transform.Translate(-movementY);
        }



        float controlFire = Input.GetAxisRaw("Fire1");

        if (controlFire > 0)
        {
            //print("Pew!");

            GameObject newBolt = Instantiate(boltPrefab);

            newBolt.transform.position = transform.position;
        }

    }
}
