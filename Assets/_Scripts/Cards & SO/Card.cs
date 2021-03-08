using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Can probably move this out to some sort of file to read from???
public enum CardType
{
    Agent,
    Ahab,
    Ambassador,
    Anarchist,
    Angel,
    BlueSpy,
    BlueTeam,
    BombBot,
    Bomber,
    Butler,
    Clown,
    Coyboy,
    Criminal,
    Dealer,
    Demon,
    Gambler,
    HotPotato,
    Immunologist,
    Invincible,
    Juliet,
    Leprechaun,
    Maid,
    Mayor,
    Medic,
    Mi6,
    Mime,
    Mistress,
    Moby,
    Mummy,
    Negotiator,
    President,
    Psychologist,
    RedSpy,
    RedTeam,
    Rival,
    Romeo,
    Security,
    ShyGuy,
    Thug,
    Traveler,
    Wife,
    Zombie
}

public enum ColorType
{
    Red,
    Blue,
    Grey,
    Green,
    Purple
}

[CreateAssetMenu(fileName = "New Card", menuName = "Card/Create Card", order = 1)]
public class Card : ScriptableObject
{
    [SerializeField] 
    private string cardName;
    [SerializeField]
    [TextArea]
    private string description;
    [SerializeField] 
    private CardType cardType;
    [SerializeField] 
    private ColorType colorType;

    #region Getters
    public string CardName => cardName;
    public CardType Type => cardType;
    public ColorType Color => colorType;
    #endregion
}
