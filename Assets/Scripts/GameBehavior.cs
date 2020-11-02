using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehavior : MonoBehaviour
{
    public static GameBehavior instance;
	public float marbleHealth;
	public float goalsCollected;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        instance.marbleHealth = 100;
        instance.goalsCollected = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
