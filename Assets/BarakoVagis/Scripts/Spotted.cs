using UnityEngine;
using System.Collections;

public class Spotted : MonoBehaviour {

    public GameObject gameOverText;
    public GameObject helpText;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Spotted"))
        {
            gameOverText.SetActive(true);
            helpText.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
