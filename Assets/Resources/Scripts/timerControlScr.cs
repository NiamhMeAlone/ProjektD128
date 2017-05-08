using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerControlScr : MonoBehaviour {

    public Sprite second00;
    public Sprite second01;
    public Sprite second02;
    public Sprite second03;
    public Sprite second04;
    public Sprite second05;
    public Sprite second06;
    public Sprite second07;
    public Sprite second08;
    public Sprite second09;
    public Sprite second10;
    public Sprite round00;
    public Sprite round01;
    public Sprite round02;
    public Sprite round03;
    public Sprite round04;
    public Sprite round05;
    public Sprite round06;
    public Sprite round07;
    public Sprite round08;
    public Sprite round09;
    public Sprite round10;

    public bool mainTimerActive = true;
    public float timerTimer = 0;
    public int timerSecondValue = 10;
    public float roundNumber = 0;
    public GameObject background;
    
	void Start () {
	}
	
	void Update () {
        
        if (mainTimerActive == true)
        {
            GetComponent<TextMesh>().text = "" + timerSecondValue;
            timerTimer = timerTimer + 1 * Time.deltaTime;
            background.GetComponent<Animator>().SetInteger("Second", timerSecondValue);
        };
        if(timerTimer >= 1)
        {
            timerTimer = 0;
            timerSecondValue--;
        }
        if (timerSecondValue <= 1)
        {
            Debug.Log("IMPACT");
            GameObject.Find("Player1").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("Player2").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("satelliteGrid").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("satelliteGrid2").GetComponent<SpriteRenderer>().enabled = false;
        };
        if (timerSecondValue <= 0)
        {
            Debug.Log("ROUND " + roundNumber + " OVER");
            GameObject.Find("Player1").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("Player2").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("satelliteGrid").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("satelliteGrid2").GetComponent<SpriteRenderer>().enabled = true;
            timerSecondValue = 10;
            roundNumber++;
        };
        if (roundNumber >= 11)
        {
            Debug.Log("GAME END");
            roundNumber = 1;
        };




        if (timerSecondValue == 0)
        {
            GameObject.Find("TimeSpr").GetComponent<SpriteRenderer>().sprite = second00;
        }
        if (timerSecondValue == 1)
        {
            GameObject.Find("TimeSpr").GetComponent<SpriteRenderer>().sprite = second01;
        }
        if (timerSecondValue == 2)
        {
            GameObject.Find("TimeSpr").GetComponent<SpriteRenderer>().sprite = second02;
        }
        if (timerSecondValue == 3)
        {
            GameObject.Find("TimeSpr").GetComponent<SpriteRenderer>().sprite = second03;
        }
        if (timerSecondValue == 4)
        {
            GameObject.Find("TimeSpr").GetComponent<SpriteRenderer>().sprite = second04;
        }
        if (timerSecondValue == 5)
        {
            GameObject.Find("TimeSpr").GetComponent<SpriteRenderer>().sprite = second05;
        }
        if (timerSecondValue == 6)
        {
            GameObject.Find("TimeSpr").GetComponent<SpriteRenderer>().sprite = second06;
        }
        if (timerSecondValue == 7)
        {
            GameObject.Find("TimeSpr").GetComponent<SpriteRenderer>().sprite = second07;
        }
        if (timerSecondValue == 8)
        {
            GameObject.Find("TimeSpr").GetComponent<SpriteRenderer>().sprite = second08;
        }
        if (timerSecondValue == 9)
        {
            GameObject.Find("TimeSpr").GetComponent<SpriteRenderer>().sprite = second09;
        }
        if (timerSecondValue == 10)
        {
            GameObject.Find("TimeSpr").GetComponent<SpriteRenderer>().sprite = second10;
        }

        if (roundNumber == 0)
        {
            GameObject.Find("RoundSpr").GetComponent<SpriteRenderer>().sprite = round00;
        }
        if (roundNumber == 1)
        {
            GameObject.Find("RoundSpr").GetComponent<SpriteRenderer>().sprite = round01;
        }
        if (roundNumber == 2)
        {
            GameObject.Find("RoundSpr").GetComponent<SpriteRenderer>().sprite = round02;
        }
        if (roundNumber == 3)
        {
            GameObject.Find("RoundSpr").GetComponent<SpriteRenderer>().sprite = round03;
        }
        if (roundNumber == 4)
        {
            GameObject.Find("RoundSpr").GetComponent<SpriteRenderer>().sprite = round04;
        }
        if (roundNumber == 5)
        {
            GameObject.Find("RoundSpr").GetComponent<SpriteRenderer>().sprite = round05;
        }
        if (roundNumber == 6)
        {
            GameObject.Find("RoundSpr").GetComponent<SpriteRenderer>().sprite = round06;
        }
        if (roundNumber == 7)
        {
            GameObject.Find("RoundSpr").GetComponent<SpriteRenderer>().sprite = round07;
        }
        if (roundNumber == 8)
        {
            GameObject.Find("RoundSpr").GetComponent<SpriteRenderer>().sprite = round08;
        }
        if (roundNumber == 9)
        {
            GameObject.Find("RoundSpr").GetComponent<SpriteRenderer>().sprite = round09;
        }
        if (roundNumber == 10)
        {
            GameObject.Find("RoundSpr").GetComponent<SpriteRenderer>().sprite = round10;
        }
    }
}
