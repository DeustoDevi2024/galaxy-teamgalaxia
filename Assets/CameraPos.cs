using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckMovement();
        
    }
    private void CheckMovement()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //posZ = transform.position.z + velocidad;
            transform.position += Vector3.up * 5;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //posZ = transform.position.z - velocidad;
            transform.position += Vector3.down * 5;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            //posX = transform.position.x - velocidad;
            transform.position += Vector3.left * 5;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            //posX = transform.position.x + velocidad;
            transform.position += Vector3.right * 5;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //posX = transform.position.x + velocidad;
            transform.position += Vector3.forward * 5;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            //posX = transform.position.x + velocidad;
            transform.position += Vector3.back * 5;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.rotation *= Quaternion.Euler(new Vector3(0, -5, 0));
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.rotation *= Quaternion.Euler(new Vector3(0, 5, 0));
        }
        

    }
}
