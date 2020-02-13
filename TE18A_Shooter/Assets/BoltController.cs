using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltController : MonoBehaviour
{
    float speed = 3;

    // Update is called once per frame
    void Update()
    {
        Vector3 movementY = Vector3.up * Time.deltaTime * speed;
        transform.Translate(movementY);

        if (transform.position.y > 7)
        {
            Destroy(this.gameObject);
        }

    }
}
