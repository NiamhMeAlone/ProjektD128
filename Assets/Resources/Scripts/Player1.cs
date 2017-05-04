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
        Rotate();
        Debug.Log(Mathf.Floor(Input.GetAxis("FireP1H") * 10) + " " + (Input.GetAxis("FireP1V") * 10));
	}
    
    private void Move()
    {
        Vector2 pos = t.position;
        pos.x += Input.GetAxis("HorizontalP1") * Time.deltaTime * speed;
        pos.y += Input.GetAxis("VerticalP1") * Time.deltaTime * speed;
        t.position = pos;
    }

    private void Rotate()
    {
        if (!(Input.GetAxis("FireP1H") == 0 && Input.GetAxis("FireP1V") == 0))
        {
            if (Input.GetAxis("FireP1H") > 0)
            {
                t.rotation = Quaternion.Euler(0, 0, -Vector2.Angle(new Vector2(Input.GetAxis("FireP1H"), Input.GetAxis("FireP1V")), Vector2.up));
            }
            else
            {
                t.rotation = Quaternion.Euler(0, 0, Vector2.Angle(new Vector2(Input.GetAxis("FireP1H"), Input.GetAxis("FireP1V")), Vector2.up));
            }
        }
    }
}
