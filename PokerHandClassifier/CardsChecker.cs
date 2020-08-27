using System;
using System.Collections.Generic;
using System.Text;

namespace PokerHandClassifier
{
    public class CardsChecker
    {
        public CardsChecker() { }
        public string VerifyCards(string allCards)
        {
            string verificationOutput = "";

            try
            {
                //Splits string to array
                allCards.Replace(" ", "");
                string[] CardArray = allCards.ToUpper().Split(',');

                //Checks amount, suits, values of cards as well as duplicates
                VerifyAmount(CardArray);
                VerifySuit(CardArray);
                VerifyValue(CardArray);
                CheckForDuplicates(CardArray);
            }

            catch (Exception e)

            {
                verificationOutput = "Unable to verify poker hand: " + e.Message;
            }

            return verificationOutput;
        }

        public void VerifyAmount(string[] CardArray)
        {
            //Count cards
            if (CardArray.Length != 5)
                throw new System.ArgumentException("Five cards not entered");
        }

        public void VerifySuit(string[] CardArray)
        {
            //Check suits and verify values
            foreach (string testString in CardArray)
            {
                char Suit = testString[testString.Length - 1];

                if (!(Suit == 'C' || Suit == 'D' || Suit == 'H' || Suit == 'S'))
                    throw new System.ArgumentException("Incorrect suit entered");
            }

        }
        public void VerifyValue(string[] CardArray)
        {
            //Check suits and verify values
            foreach (string testString in CardArray)
            {
                string CardValue = testString.Substring(0, testString.Length - 1);
                int tmpInt;

                //Check for numbers 
                if (int.TryParse(CardValue, out tmpInt))
                {
                    if (tmpInt >= 2 && tmpInt <= 10)
                        continue;
                    else
                        throw new System.ArgumentException("Incorrect card value entered");

                }
                //Check for face cards
                else if (!(CardValue == "J" || CardValue == "Q" || CardValue == "K" || CardValue == "A"))
                    throw new System.ArgumentException("Incorrect value entered");
            }

        }

        public void CheckForDuplicates(string[] CardArray)
        {
            var hashSet = new HashSet<string>();
            //Checks for duplicates
            foreach (string testString in CardArray)
            {
                if (!hashSet.Add(testString))
                    throw new System.ArgumentException("Duplicate cards entered");
                
            }

        }

    }
}
