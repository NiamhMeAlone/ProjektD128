using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {

    Transform t;
    public int speed;

    // Use this for initialization
    void Start ()
    {
        t = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Move();
        Debug.Log(Mathf.Floor(Input.GetAxis("HorizontalP1") * 10) + " " + (Input.GetAxis("HorizontalP1") * 10));
	}
    
    private void Move()
    {
        Vector2 pos = t.position;
        pos.x += Input.GetAxis("HorizontalP1") * Time.deltaTime * speed;
        pos.y += Input.GetAxis("VerticalP1") * Time.deltaTime * speed;
        t.position = pos;
    }
}
