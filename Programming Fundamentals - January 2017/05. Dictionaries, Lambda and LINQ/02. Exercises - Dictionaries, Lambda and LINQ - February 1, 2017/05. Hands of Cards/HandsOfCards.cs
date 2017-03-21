namespace _05.Hands_of_Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HandsOfCards
    {
        //// You are given a sequence of people and for every person what cards he draws from the deck.
        //// The input will be separate lines in the format:
        //// {personName}: {PT, PT, PT,… PT} Where P(2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A) is the power 
        //// of the card and T(S, H, D, C) is the type. The input ends when a "JOKER" is drawn. The name 
        //// can contain any ASCII symbol except ':'. The input will always be valid and in the format 
        //// described, there is no need to check it.

        //// A single person cannot have more than one card with the same power and type, if he draws 
        //// such a card he discards it. The people are playing with multiple decks. Each card has 
        //// a value that is calculated by the power multiplied by the type. Powers 2 to 10 have the same 
        //// value and J to A are 11 to 14. Types are mapped to multipliers the following way 
        //// (S -> 4, H-> 3, D -> 2, C -> 1).

        //// Finally print out the total value each player has in his hand in the format: {personName}: {value}

        public static void Main()
        {
            var cardPowers = GetCardPowers();
            var cardTypes = GetCardTypes();

            var cards = new Dictionary<string, HashSet<int>>();

            var inputLine = Console.ReadLine();

            while (inputLine != "JOKER")
            {
                var tokens = inputLine.Split(':');

                var name = tokens[0];
                var playerCards = tokens[1].Split(", ".ToArray(), StringSplitOptions.RemoveEmptyEntries);

                foreach (var card in playerCards)
                {
                    var cardPower = card.Substring(0, card.Length - 1);
                    var cardType = card.Substring(card.Length - 1);

                    var sum = cardPowers[cardPower] * cardTypes[cardType];

                    if (!cards.ContainsKey(name))
                    {
                        cards[name] = new HashSet<int>();
                    }

                    cards[name].Add(sum);
                }

                inputLine = Console.ReadLine();
            }

            foreach (var pair in cards)
            {
                var name = pair.Key;
                var cardSum = pair.Value.Sum();

                Console.WriteLine($"{name}: {cardSum}");
            }
        }

        private static Dictionary<string, int> GetCardPowers()
        {
            var powers = new Dictionary<string, int>();

            for (int i = 2; i <= 10; i++)
            {
                powers[i.ToString()] = i;

                powers["J"] = 11;
                powers["Q"] = 12;
                powers["K"] = 13;
                powers["A"] = 14;
            }

            return powers;
        }

        private static Dictionary<string, int> GetCardTypes()
        {
            var cardTypes = new Dictionary<string, int>();

            cardTypes["S"] = 4;
            cardTypes["H"] = 3;
            cardTypes["D"] = 2;
            cardTypes["C"] = 1;

            return cardTypes;
        }
    }
}