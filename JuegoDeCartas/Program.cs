using System;
using System.Collections.Generic;
using JuegoDeCartas;

namespace Main
{
    class Program
    {

        static void Main(string[] args)
        {
            string comando;
            List<Card> cards = new List<Card>();
            cards.Add(new Card("Diego", 0, 0, "Bien escualido"));
            cards.Add(new Card("Elias", 5, 5, "Bien normal"));
            cards.Add(new Card("Marco", 2, 2, "Bien medio escualido"));
            cards.Add(new Card("Edsson", 9, 9, "Bien fuertote"));

            Deck deck = new Deck(cards, "Deck chido");

            Player jug1 = new Player("Diego", deck);

            ImprimirDatos(jug1);
            bool imprimir;
            while (true)
            {
                comando = Console.ReadLine();
                imprimir = true;
                if (comando == "draw") jug1.draw(1);
                else if (comando == "shuffle") jug1.getDeck().shuffle();
                else if (comando.Length < 1) imprimir = false;

                if (imprimir) ImprimirDatos(jug1);
            }
        }

        public static void ImprimirDatos(Player jugador)
        {
            for (int i = 0; i < jugador.getHand().getCardNumber(); i++)
            {
                Console.WriteLine(jugador.getHand().getCards()[i].toString());
            }

            Console.WriteLine("CARTAS EN MANO:" + jugador.getHand().getCardNumber());
            Console.WriteLine("CARTAS EN DECK:" + jugador.getDeck().getCardNumber());
        }
    }
}