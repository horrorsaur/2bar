using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    Round1,
    Round2,
    Round3,
    NotStarted,
    Waiting,
    Paused,
    Ended,
}

public class GameManager : NetworkBehaviour
{
    // super testy atm, think I need to figure out how the multiplayer will work first to get this done correctly
    // mirror supports a variety of low level transports
    // however, it might be lighter to just use something specific for web sockets (webgl)
    // Perhaps implement Singleton pattern for this (might be the best case)
    [Header("Cards that are going to be used this game")]
    [SerializeField]
    private List<Card> listOfCards = new List<Card>(); // list since it can be dynamically updated yada yada
    private List<Hand> playerHands = new List<Hand>();
    private List<GameObject> players = new List<GameObject>();

    private int numberOfPlayers = 0;

    private void Start()
    {
        SetNumberOfPlayers();
        DistributeCards();
    }

    private void Update()
    {
        numberOfPlayers = NetworkManager.singleton.numPlayers;
    }


    private void DistributeCards()
    {
        // Some kind of randomizer to select from a list of cards
        // For each player - assign their card.
        //for (int i = 0; i < numberOfPlayers; i++)
        //{

        //}
        //playerHand.SetCurrentCard(card);
    }

    private void SetNumberOfPlayers()
    {
        //for (int i = 0; i < numberOfPlayers; i++)
        //{
        //    playerHands.Add(players[i].GetComponent<Hand>());
        //}
    }
}
