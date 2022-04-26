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

    private MeshRenderer mr;

    private void Awake()
    {
        mr = GetComponent<MeshRenderer>();
    }
    private void Start()
    {
        ChangeColor(CardColor.Default);
    }
    private void OnMouseDown()
    {
        
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
        ChangeColor(CardColor.Default);
    }

}
