using System;
using System.Collections.Generic;

namespace MyApp 
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] validFaces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            string[] validSuits = new string[] { "S" , "H" , "D" ,"C"};


            List<Card> cards = new List<Card>();

            string[] input = Console.ReadLine().Split(", ");
            foreach (string item in input)
            {
                bool IsValid = false;

                string face = "";
                string suit = "";
                if (item.Length==4||item.Length==3)
                {
                    if (item.Length==4)
                    {
                        face = item.Substring(0, 2);
                        suit = item[3].ToString();
                    }
                    else
                    {
                        face = item[0].ToString();
                        suit = item[2].ToString();
                    }

                }
                 

                foreach (var currentFace in validFaces)
                {
                    if (face==currentFace)
                    {
                        IsValid = true;
                    }
                   
                }
                foreach (var currentSuit in validSuits)
                {
                    if (suit==currentSuit)
                    {
                        IsValid = true;
                    }
                   
                }
                if (IsValid)
                {
                    Card card = new Card();
                    card.Face = face;

                    switch (suit)
                    {
                        case "S":
                            card.Suit = "\u2660";
                            break;
                        case "H":
                            card.Suit = "\u2665";
                            break;
                        case "D":
                            card.Suit = "\u2666";
                            break;
                        case "C":
                            card.Suit = "\u2663";
                            break;
                    }

                    cards.Add(card);
                }
                else
                {
                    Console.WriteLine("Invalid card!");
                }
            }

            foreach (Card card in cards)
            {
                Console.Write(card.ToString()+" ");
            }

        }

    }
    class Card
    {
        public string Face { get; set; }

        public string Suit { get; set; }

        public override string ToString()
        {
            return $"[{this.Face}{this.Suit}]";
        }

    }
}