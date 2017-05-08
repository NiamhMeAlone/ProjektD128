using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score2 : MonoBehaviour
{

    public Sprite score00;
    public Sprite score01;
    public Sprite score02;
    public Sprite score03;
    public Sprite score04;
    public Sprite score05;
    public Sprite score06;
    public Sprite score07;
    public Sprite score08;
    public Sprite score09;
    public Sprite score10;

    public int playerScore = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (playerScore == 0)
        {
            GetComponent<SpriteRenderer>().sprite = score00;
        }
        if (playerScore == 1)
        {
            GetComponent<SpriteRenderer>().sprite = score01;
        }
        if (playerScore == 2)
        {
            GetComponent<SpriteRenderer>().sprite = score02;
        }
        if (playerScore == 3)
        {
            GetComponent<SpriteRenderer>().sprite = score03;
        }
        if (playerScore == 4)
        {
            GetComponent<SpriteRenderer>().sprite = score04;
        }
        if (playerScore == 5)
        {
            GetComponent<SpriteRenderer>().sprite = score05;
        }
        if (playerScore == 6)
        {
            GetComponent<SpriteRenderer>().sprite = score06;
        }
        if (playerScore == 7)
        {
            GetComponent<SpriteRenderer>().sprite = score07;
        }
        if (playerScore == 8)
        {
            GetComponent<SpriteRenderer>().sprite = score08;
        }
        if (playerScore == 9)
        {
            GetComponent<SpriteRenderer>().sprite = score09;
        }
        if (playerScore == 10)
        {
            GetComponent<SpriteRenderer>().sprite = score10;
        }

    }
}
