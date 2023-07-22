using System;
namespace PickRandomCards
{
    public class CardPicker
    {

        static Random random = new Random();

        public CardPicker()
        {
        }

        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            int value = random.Next(1, 5);
            //if (value == 1) return "Spades";
            //if (value == 2) return "Spades";
            //if (value == 3) return "Spades";
            //return "Diamonds";


            switch (value)
            {
                case 1:
                    return "Spades";
                case 2:
                    return "Hearts";
                case 3:
                    return "Clubs";
                default:
                    return "Diamonds";
            }
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            switch (value)
            {
                case 1:
                    return "Ace";
                case 11:
                    return "Jack";
                case 12:
                    return "Queen";
                case 13:
                    return "King";
                default:
                    return value.ToString();
            }
        }
    }
}

