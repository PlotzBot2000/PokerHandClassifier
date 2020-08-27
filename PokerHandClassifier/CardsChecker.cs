using System;
using System.Collections.Generic;
using System.Text;

namespace PokerHandClassifier
{
    class CardsChecker
    {
        public CardsChecker() { }
        public string VerifyCards(string allCards)
        {
            string verificationOutput = "";

            try
            {
                //Check for valid formats
                //TODO: Create format checks
                
                //Check for duplicates             
                //TODO: Create duplicate checks
            }

            catch (Exception e)

            {
                verificationOutput = "Unable to verify poker hand: " + e.Message;
            }

            return verificationOutput;
        }
    }
}
