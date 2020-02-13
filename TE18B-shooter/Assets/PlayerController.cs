using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 3;

    public GameObject explosion;
    public GameObject bolt;

    float timer = 0;

    public float timeBetweenShots = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float controlX = Input.GetAxisRaw("Horizontal");
        float controlY = Input.GetAxisRaw("Vertical");

        

        //print(controlX);

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

        timer += Time.deltaTime;

        if (timer > timeBetweenShots && controlFire > 0)
        {
            GameObject newBolt = Instantiate(bolt);

            newBolt.transform.position = transform.position;

            timer = 0;
        }




    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Instantiate(explosion, transform.position, transform.rotation);

            Destroy(this.gameObject);
        }
    }
}
