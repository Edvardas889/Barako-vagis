using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

public class TimeManager : MonoBehaviour {

    public float startingTime;
    public GameObject gameOverText;
    public GameObject background;
    public GameObject helpText;
    public GameObject playerToDisable;
    public bool updateOn = true;

    private Text theText;
    private bool beingHandled = false;

    // Use this for initialization
    void Start () {

        theText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	 void Update () {

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (Application.loadedLevelName == "Level_1")
                SceneManager.LoadScene("Level_1");
            else if(Application.loadedLevelName == "Level_2")
                SceneManager.LoadScene("Level_2");
        }
           
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("Main_Menu");

        if (updateOn == true)
        {
            
            if (startingTime >= 0)
            {
                if (Mathf.Round(startingTime) == 0)
                {
                    background.GetComponent<AudioSource>().Stop();
                    gameOverText.SetActive(true);
                    helpText.SetActive(true);
                    playerToDisable.SetActive(false);
                    updateOn = false;
                }

                startingTime -= Time.deltaTime;
                theText.text = "" + Mathf.Round(startingTime) + " SEC";
            }
        }
    }
}
