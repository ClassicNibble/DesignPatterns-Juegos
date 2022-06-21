using System;
using System.Collections.Generic;

namespace JuegoDeCartas
{
    public class Hand
    {
        List<Card> cards = new List<Card>();
        int cardNumber;

        public Hand() {
            this.cardNumber = 0;
        }

        public void shuffle()
        {
            Random rand = new Random();
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int k = rand.Next(i + 1);
                Card card = cards[k];
                cards[k] = cards[i];
                cards[i] = card;
            }
        }

        public void add(Card c) {
            this.cards.Add(c);
        }

        public List<Card> getCards()
        {
            return this.cards;
        }

        public int getCardNumber()
        {
            return this.cardNumber;
        }

        public void increaseCardNumber()
        {
            this.cardNumber++;
        }

    }
}