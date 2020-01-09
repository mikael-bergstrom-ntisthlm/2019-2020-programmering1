using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        float y = Random.Range(-5f, 5f);

        Vector3 newPosition = new Vector3(y, 6);

        transform.position = newPosition;


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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }
}
