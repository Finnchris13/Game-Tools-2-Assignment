using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Arrow")
        {
            Destroy(gameObject);
            ScoreScript.scoreValue += 50;
        }

        if(other.tag == "Core")
        {
            Destroy(gameObject);
            CoreHP.coreHealth -= 1;
        }

    }
}
