using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

    public Text[] buttonList;
    private string XorO;
    private int moveCount;

    // Start is called before the first frame update
    void Awake()
    {
        SetGameControllerReferenceOnButtons();
        XorO = "X";
        moveCount = 0;
    }

    void SetGameControllerReferenceOnButtons() { 
        for (int i = 0; i < buttonList.Length; i++) {
            buttonList[i].GetComponentInParent<GridSpace>().SetGameControlReference(this);
        }
    }

    public string GetPlayerSide() {
        return XorO;
    }

    public void EndTurn() {

        if (buttonList[0].text == XorO && buttonList[1].text == XorO && buttonList[2].text == XorO) {
            GameOver(XorO);
        }
        if (buttonList[3].text == XorO && buttonList[4].text == XorO && buttonList[5].text == XorO)
        {
            GameOver(XorO);
        }
        if (buttonList[6].text == XorO && buttonList[7].text == XorO && buttonList[8].text == XorO)
        {
            GameOver(XorO);
        }
        if (buttonList[0].text == XorO && buttonList[3].text == XorO && buttonList[6].text == XorO)
        {
            GameOver(XorO);
        }
        if (buttonList[1].text == XorO && buttonList[4].text == XorO && buttonList[7].text == XorO)
        {
            GameOver(XorO);
        }
        if (buttonList[3].text == XorO && buttonList[5].text == XorO && buttonList[8].text == XorO)
        {
            GameOver(XorO);
        }
        if (buttonList[0].text == XorO && buttonList[4].text == XorO && buttonList[8].text == XorO)
        {
            GameOver(XorO);
        }
        if (buttonList[2].text == XorO && buttonList[4].text == XorO && buttonList[6].text == XorO)
        {
            GameOver(XorO);
        }

        XorO = (XorO == "X") ? "O" : "X";
        // same thing as
        //if (XorO == "X") {
        //    XorO = "O";
        //} else { 
        //    XorO = "X"; 
        //}

        moveCount++;
        if (moveCount > 8) {
            GameOver("No one");
        }

    }

    void GameOver(string whois) { 
        for (int i = 0; i < buttonList.Length; i++) {
            buttonList[i].GetComponentInParent<Button>().interactable = false;
        }

        Debug.Log(whois + " is the winner!!");
    }

}
