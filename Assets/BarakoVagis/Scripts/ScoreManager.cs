using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {

    GameObject[] gos;
    GameObject[] pos;
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
            score.text = "SCORE: "+Mathf.Round(tm.startingTime*100)+" ";
        }
	
	}
}
