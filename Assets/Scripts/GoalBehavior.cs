using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBehavior : MonoBehaviour
{
	private bool hit = true;
    void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.name == "Marble")
       {
       		if (hit)
            {
            	GameBehavior.instance.goalsCollected++;
            }
       		hit = false;
            Destroy(this.gameObject);
            Debug.Log("Collision: " + gameObject.name);
        }
    }
}
