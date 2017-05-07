using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerControlScr : MonoBehaviour {

    public Sprite player1spr;
    public Sprite player2spr;
    public Sprite playerSilhouette;

    public bool mainTimerActive = true;
    public float timerTimer = 0;
    public int timerSecondValue = 11;
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
            GameObject.Find("Player1").GetComponent<SpriteRenderer>().sprite = playerSilhouette;
            GameObject.Find("Player2").GetComponent<SpriteRenderer>().sprite = playerSilhouette;
        };
        if (timerSecondValue <= 0)
        {
            Debug.Log("ROUND " + roundNumber + " OVER");
            GameObject.Find("Player1").GetComponent<SpriteRenderer>().sprite = player1spr;
            GameObject.Find("Player2").GetComponent<SpriteRenderer>().sprite = player2spr;
            timerSecondValue = 11;
            roundNumber++;
        };
        if (roundNumber >= 12)
        {
            Debug.Log("GAME END");
            roundNumber = 1;
        };
        	
	}
}
