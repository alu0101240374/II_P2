using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyController : MonoBehaviour
{

    public float speed = .1f;
    public Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      PlayerMovement();
    }

    void PlayerMovement()
    {
      float x = Input.GetAxis("Horizontal");
      float z = Input.GetAxis("Vertical");
      Vector3 direction = transform.right * x + transform.forward * z;
      direction *= speed;
      direction.y = 0;
      rigid.velocity = direction;
    }
}
