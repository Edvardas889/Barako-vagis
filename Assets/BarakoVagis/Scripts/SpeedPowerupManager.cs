using UnityEngine;
using System.Collections;

public class SpeedPowerupManager : MonoBehaviour {

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
        if (Input.GetKeyDown(KeyCode.P) && !notificationText.active)
        { 
            StartCoroutine(EnableSpeedTemporarily());
        }      
    }

    IEnumerator EnableSpeedTemporarily()
    {
        notificationText.SetActive(true);
        GameObject player = GameObject.Find("Player");
        MovementScript playerMovement = player.GetComponent<MovementScript>();
        playerMovement.playerSpeed += value;
        GetComponent<AudioSource>().Play();

        yield return new WaitForSeconds(5);       
        playerMovement.playerSpeed -= value;
        notificationText.SetActive(false);
        powerUp.SetActive(false);              
    }
}
