using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast : MonoBehaviour
{

    Transform t;
    public int speed;
    public Vector2 angle;

    void Start()
    {
        t = GetComponent<Transform>();
    }

    void Update()
    {
        Move();
        if (Vector2.Distance(Vector2.zero, new Vector2(t.position.x, t.position.y)) >= 3.55)
        {
            Destroy(gameObject);
        }
    }

    private void Move()
    {
        Vector2 pos = t.position;
        pos.x += angle.x * Time.deltaTime * speed;
        pos.y += angle.y * Time.deltaTime * speed;
        t.position = pos;
    }
}