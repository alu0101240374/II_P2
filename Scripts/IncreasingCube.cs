using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingCube : MonoBehaviour
{
    public Transform player;
    public GameObject sphere;
    public float mininumDistance = 10;
    void Start()
    {
        sphere = GameObject.FindGameObjectWithTag("Sphere");
    }

    void FixedUpdate()
    {
        float distanceWithPlayer = Vector3.Distance(transform.position, player.position);
        float distanceWithSphere = Vector3.Distance(transform.position, sphere.transform.position);
        if (distanceWithPlayer <= mininumDistance)
        {
          transform.localScale -= new Vector3(.01f, .01f, .01f);
        }
        if (distanceWithSphere <= mininumDistance)
        {
          transform.localScale += new Vector3(.01f, .01f, .01f);
        }
    }
}
