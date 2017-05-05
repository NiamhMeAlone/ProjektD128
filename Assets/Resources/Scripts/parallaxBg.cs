using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallaxBg : MonoBehaviour {

    public int parallaxStrength = 12;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector3(
            (GameObject.Find("Player1").GetComponent<Transform>().position.x 
            + GameObject.Find("Player2").GetComponent<Transform>().position.x) / parallaxStrength,

            (GameObject.Find("Player1").GetComponent<Transform>().position.y
            + GameObject.Find("Player2").GetComponent<Transform>().position.y) / parallaxStrength,

            transform.position.z);
    }
}
