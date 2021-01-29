using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MovementSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movementVector = Vector3.zero;
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            movementVector.x -= MovementSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movementVector.x += MovementSpeed;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            movementVector.y += MovementSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            movementVector.y -= MovementSpeed;
        }

        movementVector *= Time.deltaTime;

        transform.Translate(movementVector);

    }
}
