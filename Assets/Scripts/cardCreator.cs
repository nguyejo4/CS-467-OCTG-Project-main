using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardCreator : MonoBehaviour
{
    [SerializeField] private Card cardTemplate;
    [SerializeField] private Sprite cardBack;
    [SerializeField] private Sprite cardFrame;
    [SerializeField] private Sprite[] cardArt;

    //code idea use an array of IDs, shuffle, then procedurally generate cards
    //public opponentDeckIDs = 
    // Start is called before the first frame update
    void Start()
    {
        // original card position
        Vector3 startPos = cardTemplate.transform.position;

        // use an array of ints to create the players deck
        int[] playerDeck = {0, 1, 2};
        ShuffleDeck(playerDeck);

        // loop over deck size
        for (int i = 0; i < playerDeck.Length; i++)
        {
            //create new instance of card
            Card newCard = Instantiate(cardTemplate) as Card;

            // attach cardBack to cardTemplate
            newCard.setCardBack(cardBack);

            //attaching frame
            //future code will have different frames for different types.
            newCard.setCardFrame(playerDeck[i], cardFrame);

            //attaching cardArt
            newCard.setCardArt(playerDeck[i], cardArt[playerDeck[i]]);

            // moving card onto board
            newCard.transform.position = new Vector3(-10 + (4 * i), 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShuffleDeck (int[] deck)
    {
        for (int i = 0; i < deck.Length; i++)
        {
            int tmp = deck[i];
            int r = Random.Range(i, deck.Length);
            deck[i] = r;
            deck[r] = tmp;
        }
    }
}
