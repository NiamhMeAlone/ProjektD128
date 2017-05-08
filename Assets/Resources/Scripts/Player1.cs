using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {

    Transform t;
    GameObject bullet;
    public GameObject p1Score;
    public GameObject p2Score;
    public GameObject Player2;
    public int speed;
    public float reload;
    public bool dead = false;
    public bool dashing = false;
    private bool dashCooling = false;
    public float dashCD;
    private float dashCDTimer;
    public float dashLength;
    private float dashTraveled;
    public float dashMult;
    private Vector2 dashVector;
    private Vector2 aimVector = Vector2.down;
    private float rTimer;
    
    void Start () {
        t = GetComponent<Transform>();
        bullet = (GameObject)Resources.Load("Prefabs/P1Shot");
        rTimer = reload;
	}
	
	void Update () {
        if (!dead) {
            if (!dashing) {
                Debug.Log(dashCooling);
                if (!Input.GetKey(KeyCode.Joystick1Button4) || dashCooling)
                {
                    Move();
                    Rotate();
                    rTimer -= Time.deltaTime;
                    if (dashCDTimer >= 0)
                    {
                        dashCDTimer -= Time.deltaTime;
                    }
                    else
                    {
                        dashCooling = false;
                    }
                }
                else
                {
                    Debug.Log(dashing);
                    dashing = true;
                    dashVector = new Vector2(Input.GetAxis("HorizontalP1"), Input.GetAxis("VerticalP1"));
                    dashTraveled = dashLength;
                }
            }
            else
            {
                Vector2 pos = t.position;
                pos.x += dashVector.x * Time.deltaTime * speed * dashMult;
                pos.y += dashVector.y * Time.deltaTime * speed * dashMult;
                t.position = pos;
                dashTraveled -= Time.deltaTime;
            }

            if (dashing && dashTraveled <= 0)
            {
                dashing = false;
                dashCDTimer = dashCD;
                dashCooling = true;
            }
        }
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
        if (!(Input.GetAxis("AimP1H") == 0 && Input.GetAxis("AimP1V") == 0))
        {
            aimVector = new Vector2(Input.GetAxis("AimP1H"), Input.GetAxis("AimP1V"));
            if (Input.GetAxis("AimP1H") > 0)
            {
                t.rotation = Quaternion.Euler(0, 0, -Vector2.Angle(aimVector, Vector2.up));
            }
            else
            {
                t.rotation = Quaternion.Euler(0, 0, Vector2.Angle(aimVector, Vector2.up));
            }
        }
        if (Input.GetAxis("FireP1") == 1)
        {
            Fire();
        }
    }
    
    private void Fire()
    {
        if (rTimer <= 0)
        {
            aimVector.Normalize();
            Instantiate(bullet, transform.position, transform.rotation).GetComponent<Blast>().angle = aimVector;
            rTimer = reload;
        }
    }

    public void Kill()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        p1Score.GetComponent<boundaryScoreSprites>().playerScore--;
        p2Score.GetComponent<boundaryScoreSprites>().playerScore++;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("P2Bullet"))
        {
            dead = true;
            Kill();
            Destroy(collision.gameObject);
        }
    }
}