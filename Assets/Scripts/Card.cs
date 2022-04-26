using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public enum CardColor
    {
        Yellow,
        Blue,
        Red,
        Green,
        Cyan,
        Default
    }

    [SerializeField] private CardColor cardColor;
    [SerializeField] private GameManager gm;

    private MeshRenderer mr;
    private const int colorCount = 6;

    private void Awake()
    {
        mr = GetComponent<MeshRenderer>();
    }
    private void Start()
    {
        ChangeColor(CardColor.Default);
    }

    private void OnMouseUp()
    {
        ChangeColor(cardColor);
        gm.AssignCard(this);
    }

    private void ChangeColor(CardColor color)
    {
        switch (color)
        {
            case CardColor.Yellow:
                mr.material.color = Color.yellow;
                break;
            case CardColor.Blue:
                mr.material.color = Color.blue;
                break;
            case CardColor.Red:
                mr.material.color = Color.red;
                break;
            case CardColor.Green:
                mr.material.color = Color.green;
                break;
            case CardColor.Cyan:
                mr.material.color = Color.cyan;
                break;
            default:
                mr.material.color = Color.white;
                break;
        }
    }

    public CardColor GetCardColor() => cardColor;
    public void TurnOff()
    {
        Debug.Log("Cambiado a blanco", gameObject);
        ChangeColor(CardColor.Default);
    }

    public static int GetColorCount() => colorCount-1;
    public int GetColorID()
    {
        int id = 0;
        switch (cardColor)
        {
            case CardColor.Yellow: 
                id = 0;
                break;
            case CardColor.Blue:
                id = 1;
                break;
            case CardColor.Red:
                id = 2;
                break;
            case CardColor.Green:
                id = 3;
                break;
            case CardColor.Cyan:
                id = 4;
                break;
            case CardColor.Default:
                id = 5;
                break;
            default:
                Debug.LogError("NO HAY ID PORQUE NO HAY COLOR");
                break;
        }
        return id;
    }

}
