using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movementY = Vector3.down * Time.deltaTime * 3;

        transform.Translate(movementY);

        if (transform.position.y < -6)
        {
            Destroy(this.gameObject);
        }

    }
}
