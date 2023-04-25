using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardHandler : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    [SerializeField] private Hand playerhand;
    [SerializeField] private GameObject hand;
    public int[] cardsHolding = new int[12];
    public int[] handValues = new int[5];

    private Dictionary<string, int> cardSuits = new Dictionary<string, int>()
    {
        { "Spades", 0 },
        { "Hearts", 0 },
        { "Clubs", 0 },
        { "Diamonds", 0 }
    };
    
    // public string assessHand()
    // {
    //     // assess which cards are in the hand and return a string of the hand's value
    //     for (int i = 0; i < 5; i++)
    //     {
    //         //cardsHolding[hand.handValues[i].cardValue] += 1;
    //         cardsHolding[handValues[i]] += 1;
    //         
    //     }
    // }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
