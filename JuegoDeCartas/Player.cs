using System;
using System.Collections.Generic;

namespace JuegoDeCartas
{
    public class Player
    {
        string name;
        Hand hand;
        Deck deck;

        public Player(string name, Deck deck)
        {
            this.name = name;
            this.hand = new Hand();
            this.deck = deck;
        }

        public void draw(int num)
        {
            if (this.deck.getCardNumber() == 0) { num = 0; }
            while(num > 0) {
                this.hand.add(this.deck.top());
                this.deck.pop(this.deck.top());
                this.hand.increaseCardNumber();
                num--;
            }
        }

        public Deck getDeck()
        {
            return this.deck;
        }

        public Hand getHand()
        {
            return this.hand;
        }


    }
}