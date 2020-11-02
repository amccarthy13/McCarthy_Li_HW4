using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameBehavior : MonoBehaviour
{
    public static GameBehavior instance;
    public Text Status;
    public Text endText;
	public float marbleHealth;
	public float goalsCollected;
    GameObject[] endObjects;

    public GameObject canvas;
    // Start is called before the first frame update

    void Start()
    {
        Time.timeScale = 1;
        endObjects = GameObject.FindGameObjectsWithTag("ShowOnEnd");
        hideEnd();
        Status = GameObject.Find("Status").GetComponent<Text>();
        instance = this;
        instance.marbleHealth = 100;
        instance.goalsCollected = 0;
    }

    // Update is called once per frame
    void Update()
    {
        bool endTrigger = false;



        if (marbleHealth <= 0) 
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                showEnd();
                endText = GameObject.Find("EndText").GetComponent<Text>();
                endText.text = "game over, you lose!";
            }
        }

        else if (goalsCollected >= 4) 
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                showEnd();
                endText = GameObject.Find("EndText").GetComponent<Text>();
                endText.text = "You Win!";
            }
        }
        Status.text = marbleHealth.ToString() + "          " + goalsCollected.ToString();

    }

    public void Reload() 
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void showEnd()
    {
        foreach(GameObject g in endObjects)
        {
            g.SetActive(true);
        }
    }
    public void hideEnd()
    {
        foreach(GameObject g in endObjects)
        {
            g.SetActive(false);
        }
    }
}
