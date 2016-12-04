using UnityEngine;
using System.Collections;

public class PowerupManager : MonoBehaviour {

    public GameObject notificationText;
    public GameObject powerUp;

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        { 
                StartCoroutine(ShowNotification());

                GameObject timmer = GameObject.Find("timeInSec");
                TimeManager tm = timmer.GetComponent<TimeManager>();
                tm.startingTime += 30;
         }      

    }
    IEnumerator ShowNotification()
    {
        notificationText.SetActive(true);
        yield return new WaitForSeconds(3);
        notificationText.SetActive(false);
        powerUp.SetActive(false);
    }
}
