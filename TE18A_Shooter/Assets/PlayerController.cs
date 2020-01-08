using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float controlX = Input.GetAxisRaw("Horizontal");

        Vector3 movementX = Vector3.right * Time.deltaTime * 2 * controlX;

        transform.Translate(movementX);

    }
}
