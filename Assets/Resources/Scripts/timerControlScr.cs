using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerControlScr : MonoBehaviour {

    public bool mainTimerActive = true;
    public float timerTimer = 0;
    public int timerSecondValue = 10;
    public float roundNumber = 0;
    public GameObject background;
    
	void Start () {
	}
	
	void Update () {
        background.GetComponent<Animator>().SetInteger("Second", timerSecondValue);
        if (mainTimerActive == true)
        {
            GetComponent<TextMesh>().text = "" + timerSecondValue;
            timerTimer = timerTimer + 1 * Time.deltaTime;
        };
        if(timerTimer >= 1)
        {
            timerTimer = 0;
            timerSecondValue--;
        }
        if (timerSecondValue <= 0)
        {
            Debug.Log("ROUND " + roundNumber + " OVER");
            timerSecondValue = 10;
            roundNumber++;
        };
        if (roundNumber >= 11)
        {
            Debug.Log("GAME END");
            roundNumber = 1;
        };
        	
	}
}
