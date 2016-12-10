using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {

    GameObject[] gos;
    public GameObject pu1;
    public GameObject pu2;
    private Text score;

    // Use this for initialization
    void Start () {
        score = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        gos = GameObject.FindGameObjectsWithTag("Pickup");

        if (gos.Length == 0)
        {
            GameObject timmer = GameObject.Find("timeInSec");
            TimeManager tm = timmer.GetComponent<TimeManager>();
            if (pu1.active || pu2.active)
                score.text = "SCORE: " + Mathf.Round(tm.startingTime * 100 + 1000) + " ";
            else
                score.text = "SCORE: " + Mathf.Round(tm.startingTime * 100) + " ";

        }
	
	}
}
