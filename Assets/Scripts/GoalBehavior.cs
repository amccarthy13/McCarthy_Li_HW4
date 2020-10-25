using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBehavior : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.name == "Marble")
         {
             Destroy(this.gameObject);
             Debug.Log("Item collected!");
         }
    }
}
