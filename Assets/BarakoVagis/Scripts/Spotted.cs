using UnityEngine;
using System.Collections;

public class Spotted : MonoBehaviour {

    public GameObject gameOverText;
    public GameObject helpText;
    public GameObject background;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Spotted"))
        {
            background.GetComponent<AudioSource>().Stop();
            gameOverText.SetActive(true);
            helpText.SetActive(true);
            gameObject.SetActive(false);
            GameObject timmer = GameObject.Find("timeInSec");
            TimeManager tm = timmer.GetComponent<TimeManager>();
            tm.updateOn = false;
        }
    }
}
