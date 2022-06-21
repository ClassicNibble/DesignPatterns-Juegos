using System;
using System.Collections.Generic;

namespace JuegoDeCartas {
    public class Deck {
        List<Card> cards = new List<Card>();
        string name;
        int cardNumber;

        public Deck(List<Card> cards, string name)
        {
            this.cards = cards;
            this.name = name;
            this.cardNumber = this.cards.Count;
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

        public Card top()
        {
            if (this.cardNumber != 0) return (this.cards[this.cardNumber - 1]);
            else return null;
        }

        public Card bottom()
        {
            return (this.cards[0]);
        }

        public void pop(Card c)
        {
            this.cards.Remove(c);
            this.cardNumber--;
        }

        public List<Card> getCards()
        {
            return this.cards;
        }

        public int getCardNumber()
        {
            return this.cardNumber;
        }

    }
}