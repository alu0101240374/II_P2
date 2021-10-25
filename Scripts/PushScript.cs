using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushScript : MonoBehaviour
{
    static float force = 1000f;
    void OnCollisionEnter(Collision col) 
    {
        if (col.gameObject.tag == "Player") 
        {    
            if (Input.GetKey(KeyCode.Space)) 
            {
              Vector3 direction = transform.position - col.transform.position;
              GetComponent<Rigidbody>().AddForce(direction * force);
            }
          }
    }
}
