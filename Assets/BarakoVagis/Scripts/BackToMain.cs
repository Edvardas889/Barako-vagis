﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackToMain : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("Main_Menu");

    }
}
