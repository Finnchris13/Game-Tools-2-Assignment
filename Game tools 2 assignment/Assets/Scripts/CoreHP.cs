using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoreHP : MonoBehaviour {

    public static int coreHealth = 10;
    Text health;

	// Use this for initialization
	void Start () {

        health = GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {

        health.text = "Core Health:" + coreHealth;

        if (coreHealth == 0)
        {
            SceneManager.LoadScene(3);
        }
	}
}
