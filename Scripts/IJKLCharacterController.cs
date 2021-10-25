using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IJKLCharacterController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        SecondPlayerMovement();
    }

    void SecondPlayerMovement()   
    {
        if (Input.GetKey(KeyCode.I))
        {
            moveObject(new Vector3(0, 0, 1));
        }
        if (Input.GetKey(KeyCode.K))
        {
            moveObject(new Vector3(0, 0, -1));
        }
        if (Input.GetKey(KeyCode.J))
        {
            moveObject(new Vector3(-1, 0, 0));
        }
        if (Input.GetKey(KeyCode.L))
        {
            moveObject(new Vector3(1, 0, 0));
        }
    }

    void moveObject(Vector3 inputVector)
    {
      Vector3 direction = inputVector;
      direction *= speed * Time.fixedDeltaTime;
      rigid.AddForce(direction);
    }
}
