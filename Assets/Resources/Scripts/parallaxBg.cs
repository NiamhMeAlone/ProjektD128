using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallaxBg : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector3(
            (GameObject.Find("Player1").GetComponent<Transform>().position.x 
            + GameObject.Find("Player2").GetComponent<Transform>().position.x) / 12,

            (GameObject.Find("Player1").GetComponent<Transform>().position.y
            + GameObject.Find("Player2").GetComponent<Transform>().position.y) / 12,

            transform.position.z);
    }
}
