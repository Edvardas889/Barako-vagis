using UnityEngine;
using System.Collections;

public class ClockPowerupManager : MonoBehaviour {

    public GameObject notificationText;
    public GameObject powerUp;
	public AudioClip powerUpSound;
	public float value = 5;
	
	 // Use this for initialization
    void Start () {
		GetComponent<AudioSource> ().playOnAwake = false;
        GetComponent<AudioSource> ().clip = powerUpSound;
	}

    // Update is called once per frame
    void Update () {
        if (!notificationText.active)
        {
                StartCoroutine(ShowNotification());

                GameObject timmer = GameObject.Find("timeInSec");
                TimeManager tm = timmer.GetComponent<TimeManager>();
                tm.startingTime += value;
				GetComponent<AudioSource> ().Play ();
         }      
    }
	
    IEnumerator ShowNotification()
    {
        notificationText.SetActive(true);
        yield return new WaitForSeconds(2);
        notificationText.SetActive(false);
        powerUp.SetActive(false);
    }
}
