using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pickup : MonoBehaviour
{
    public GameObject powerUp;
    GameObject[] gos;

    public GameObject gameWinText;
	public AudioClip saw;

    void OnTriggerEnter2D(Collider2D other)
    {
		GetComponent<AudioSource> ().playOnAwake = false;
        GetComponent<AudioSource> ().clip = saw;
		
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
			GetComponent<AudioSource> ().Play ();

            gos = GameObject.FindGameObjectsWithTag("Pickup");
            if (gos.Length == 0)
            {
                gameWinText.SetActive(true);
                gameObject.SetActive(false);
                GameObject timmer = GameObject.Find("timeInSec");
                TimeManager tm = timmer.GetComponent<TimeManager>();
                tm.updateOn = false;

            }
        }

        if (other.gameObject.CompareTag("Powerup"))
        {
            
            other.gameObject.SetActive(false);
            powerUp.SetActive(true);
        }
    }
}
