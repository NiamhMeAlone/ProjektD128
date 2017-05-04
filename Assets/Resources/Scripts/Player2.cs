using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{

    Transform t;
    GameObject bullet;
    public int speed;
    public float reload;
    private float rTimer;

    void Start()
    {
        t = GetComponent<Transform>();
        bullet = (GameObject)Resources.Load("Prefabs/P2Bullet");
        rTimer = reload;
    }
    
    void Update()
    {
        Move();
        Rotate();
        rTimer -= Time.deltaTime;
    }

    private void Move()
    {
        Vector2 pos = t.position;
        pos.x += Input.GetAxis("HorizontalP2") * Time.deltaTime * speed;
        pos.y += Input.GetAxis("VerticalP2") * Time.deltaTime * speed;
        t.position = pos;
    }

    private void Rotate()
    {
        if (!(Input.GetAxis("FireP2H") == 0 && Input.GetAxis("FireP2V") == 0))
        {
            if (Input.GetAxis("FireP2H") > 0)
            {
                t.rotation = Quaternion.Euler(0, 0, -Vector2.Angle(new Vector2(Input.GetAxis("FireP2H"), Input.GetAxis("FireP2V")), Vector2.up));
            }
            else
            {
                t.rotation = Quaternion.Euler(0, 0, Vector2.Angle(new Vector2(Input.GetAxis("FireP2H"), Input.GetAxis("FireP2V")), Vector2.up));
            }
            Fire();
        }
    }

    private void Fire()
    {
        if (rTimer <= 0)
        {
            Vector2 angle = new Vector2(Input.GetAxis("FireP2H"), Input.GetAxis("FireP2V"));
            angle.Normalize();
            Instantiate(bullet, transform.position, transform.rotation).GetComponent<P1Bullet>().angle = angle;
            rTimer = reload;
        }
    }
}