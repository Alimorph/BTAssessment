using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCardGame
{
    internal static class CardGameCalc
    {
        public static bool sanitiseInput(string input)
        {
            Regex rgx = new Regex("[^0-9A-Z,]");
            return !rgx.IsMatch(input);
        }

        public static string convertScore(string input)
        {
            string[] hand = input.Split(',');
            List<string> processedCards = new List<string>();
            int score = 0;
            int jokerCount = 0;

            foreach (string card in hand)
            {
                if (card.Equals("JK"))
                {
                    jokerCount++;
                }
                else
                {
                    if (processedCards.Contains(card))
                    {
                        return "Cards cannot be duplicated";
                    }
                    else
                    {
                        processedCards.Add(card);
                    }

                    int suit = getSuitMultiplier(card[1]);
                    int value = getValueScore(card[0]);
                    if (suit == 0 || value == 0)
                    {
                        return "Card not recognised";
                    }
                    score = score + (value * suit);
                }
            }
            if (jokerCount > 2)
            {
                return "A hand cannot contain more than two Jokers";
            }
            else if (jokerCount > 0)
            {
                return "Your score is:" + score * (jokerCount * 2);
            }
            else
            {
                return "Your score is:" + score;
            }
        }

        private static int getValueScore(char value)
        {
            switch (value)
            {
                case '2':
                    return 2;
                case '3':
                    return 3;
                case '4':
                    return 4;
                case '5':
                    return 5;
                case '6':
                    return 6;
                case '7':
                    return 7;
                case '8':
                    return 8;
                case '9':
                    return 9;
                case 'T':
                    return 10;
                case 'J':
                    return 11;
                case 'Q':
                    return 12;
                case 'K':
                    return 13;
                case 'A':
                    return 14;
                default:
                    return 0;
            }
        }

        private static int getSuitMultiplier(char suit)
        {
            switch (suit)
            {
                case 'C':
                    return 1;
                case 'D':
                    return 2;
                case 'H':
                    return 3;
                case 'S':
                    return 4;
                default:
                    return 0;
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form());
        }
    }
}
