using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    private Card currentCard;


    #region Setters
    public Card SetCurrentCard(Card card) => currentCard = card;
    #endregion
}
