using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour {

    public float startingTime;
    public GameObject gameOverText;

    private Text theText;

	// Use this for initialization
	void Start () {

        theText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

        if (startingTime >= 0)
        {
            if(Mathf.Round(startingTime) == 0)
            {
                gameOverText.SetActive(true);
                SceneManager.LoadScene("mapas");
                
            }
                
            startingTime -= Time.deltaTime;
            theText.text = "" + Mathf.Round(startingTime) + " SEC";
        }

        
    }
}
