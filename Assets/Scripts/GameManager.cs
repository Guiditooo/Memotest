using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private static Card card1;
    private static Card card2;

    public static void AssignCard(Card card)
    {
        if(card1 == null)
        {
            card1 = card;
        }
        else
        {
            card2 = card;
            
            //("CompareCards",1.0f);
        }
    }
    private static void CompareCards()
    {
        if (card1.GetCardColor() == card2.GetCardColor())
        {
            Debug.Log("Well Combinated");
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

}
