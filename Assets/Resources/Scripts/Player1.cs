﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {

    Transform t;
    GameObject bullet;
    public int pSpeed;
    public int bSpeed;
    public float reload;
    private float rTimer;
    
    void Start ()
    {
        t = GetComponent<Transform>();
        bullet = (GameObject)Resources.Load("Prefabs/P1Bullet");
        rTimer = reload;
	}
	
	void Update ()
    {
        Move();
        Rotate();
        rTimer -= Time.deltaTime;
        Debug.Log(rTimer);
	}
    
    private void Move()
    {
        Vector2 pos = t.position;
        pos.x += Input.GetAxis("HorizontalP1") * Time.deltaTime * pSpeed;
        pos.y += Input.GetAxis("VerticalP1") * Time.deltaTime * pSpeed;
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
            Fire();
        }
    }
    
    private void Fire()
    {
        if (rTimer <= 0)
        {
            Vector2 angle = new Vector2(Input.GetAxis("FireP1H"), Input.GetAxis("FireP1V"));
            angle.Normalize();
            Instantiate(bullet, transform.position, transform.rotation).GetComponent<Rigidbody2D>().AddForce(angle * bSpeed, ForceMode2D.Impulse);
            rTimer = reload;
        }
    }
}