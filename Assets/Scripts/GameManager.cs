using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private Card card1;
    private Card card2;

    private bool[] correctColors = new bool[Card.GetColorCount()];

    private bool playerWin = false;

    private void Start()
    {
        for (short i = 0; i < correctColors.Length; i++)
        {
            correctColors[i] = false;
        }
    }

    public void AssignCard(Card card)
    {
        if(card1 == null)
        {
            card1 = card;
        }
        else
        {
            card2 = card;
            
            Invoke("CompareCards",0.4f);
        }
    }
    private void CompareCards()
    {
        if (card1.GetCardColor() == card2.GetCardColor())
        {
            Debug.Log("Well Combinated");
            correctColors[card1.GetColorID()]= true;
            Invoke("CheckForWin",0.4f);
        }
        else
        {
            Debug.Log("Bad Combination");
            card1.TurnOff();
            card2.TurnOff();
        }
        card1 = null;
        card2 = null;
    }

    private void CheckForWin()
    {
        for (short i = 0; i < correctColors.Length; i++)
        {
            if (!correctColors[i]) return;
        }
        Debug.Log("El jugador gana el juego :D");
        playerWin = true;
    }

}
