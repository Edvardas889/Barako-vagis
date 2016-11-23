using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Main_menu : MonoBehaviour
{
    public GameObject startButton;
    void onMouseEnter(Collider2D other)
    {
        if (other.gameObject.CompareTag("Click"))
            SceneManager.LoadScene("Level_1");
    }
    
}
