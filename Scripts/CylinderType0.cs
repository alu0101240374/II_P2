using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CylinderType0 : MonoBehaviour
{
    static int playerScore = 0; 

    void OnCollisionEnter(Collision col) 
    {
        if(col.gameObject.tag == "Player") 
        {
            playerScore += 1;
            Debug.Log("Player score: " + playerScore);
            transform.localScale += new Vector3(.2f, .2f, .2f);
        }
    }
}
