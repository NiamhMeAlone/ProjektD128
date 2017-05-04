using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Bullet : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1"))
        {
            collision.GetComponent<Player1>().Kill();
            Destroy(gameObject);
        }
    }
}