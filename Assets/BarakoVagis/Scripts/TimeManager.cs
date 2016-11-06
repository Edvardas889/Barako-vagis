using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

public class TimeManager : MonoBehaviour {

    public float startingTime;
    public GameObject gameOverText;
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
            SceneManager.LoadScene("mapas");

        if (updateOn == true)
        {
            
            if (startingTime >= 0)
            {
                if (Mathf.Round(startingTime) == 0)
                {
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
