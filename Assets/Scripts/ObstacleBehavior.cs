using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehavior : MonoBehaviour
{
	  public float obstacleHealth = 100;
    void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.name == "Blast(Clone)")
       {
       		obstacleHealth -= 10;
       		if (obstacleHealth <= 0) 
       		{
       			Destroy(this.gameObject);
       		}
       }
    }
}