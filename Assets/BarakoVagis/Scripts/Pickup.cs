using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
