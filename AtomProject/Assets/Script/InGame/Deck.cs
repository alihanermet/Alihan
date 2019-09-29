using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    List<int> cards;

    void Start()
    {
        ///Shuffle();   TODO: only HOST can shuffle the cards
        ///make guı for host to adjust settings on game
        ///shuffle before game starts
    }

    public void Shuffle()
    {
        if (cards == null)
        {
            cards = new List<int>();
        }
        else
        {
            cards.Clear();
        }

        for (int i = 0; i < 52; i++)
        {
            cards.Add(i);
        }

        int n = cards.Count;
        while (n > 1)
        {
            int k = Random.Range(0, n);
            n--;
            int temp = cards[k];
            cards[k] = cards[n];
            cards[n] = temp;
        }

    }
}
