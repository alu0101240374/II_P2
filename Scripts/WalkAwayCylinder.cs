using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAwayCylinder : MonoBehaviour
{
    public Transform player;
    public float mininumDistance = 10;
    public float speed = 2f;

    // Update is called once per frame
    void FixedUpdate()
    {
        float distanceBetweenObjects = Vector3.Distance(transform.position, player.position);
        if (distanceBetweenObjects <= mininumDistance)
        {
          Vector3 direction = transform.position - player.position;
          GetComponent<Rigidbody>().AddForce(direction.normalized * speed);
        }
    }
}
