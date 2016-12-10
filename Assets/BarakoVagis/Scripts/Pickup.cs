using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{

    GameObject[] gos;
    public GameObject gameWinText;
    public GameObject scoreText;
    public AudioClip pickup;
    public PowerUpEntry[] powerUps;

    void OnTriggerEnter2D(Collider2D other)
    {
		GetComponent<AudioSource> ().playOnAwake = false;
        GetComponent<AudioSource> ().clip = pickup;
		
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
			GetComponent<AudioSource> ().Play ();

            gos = GameObject.FindGameObjectsWithTag("Pickup");
            if (gos.Length == 0)
            {
                
                gameWinText.SetActive(true);
                scoreText.SetActive(true);
                gameObject.SetActive(false);
                GameObject timmer = GameObject.Find("timeInSec");
                TimeManager tm = timmer.GetComponent<TimeManager>();
                tm.updateOn = false;
            }
        }
        if (other.gameObject.tag.Contains("Powerup"))
        {
            GameObject powerUp = null;
            foreach (PowerUpEntry entry in powerUps)
            {
                if (other.gameObject.tag.Equals(entry.powerUpTag)) {
                    powerUp = entry.powerUpController;
                }
            }

            other.gameObject.SetActive(false);
            powerUp.SetActive(true);
			GetComponent<AudioSource> ().Play ();
        }
    }

    [System.Serializable]
    public class PowerUpEntry
    {
        public string powerUpTag;
        public GameObject powerUpController;
    }

}

public class PowerUpsMap : ScriptableObject
{

}
