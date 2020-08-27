using System;
using System.Threading;

namespace PokerHandClassifier
{
    class Program
    {
        static void Main()
        {
            bool runProg = true;
            Console.WriteLine("Welcome to the Poker Hand Classifier 2000!");

            do
            {
                try
                {
                    //Launch and obtain Cards
                    Console.Write("Please enter your cards: ");
                    var pokerHand = Console.ReadLine();
                    //string pokerHand = "AS, 10C, 10C, 3D, 3S";   //TODO: remove --for debugging


                    //Check is cards are valid
                    var checkCards = new CardsChecker();
                    string validCardsResponse = checkCards.VerifyCards(pokerHand);

                    if (validCardsResponse != "")
                    {
                        Console.WriteLine("The poker hand is invalid. " + validCardsResponse);
                        Console.WriteLine("Please enter a correct list of cards. e.g. AS, KD, 10C, 9H, 9C");
                    }
                    else
                    {
                        //Call Card classifier
                        var API = new APIUtil();
                        string handType = API.MakePostRequest(); //TODO: Complete

                        Console.WriteLine("Your best hand is " + handType);
                        Console.WriteLine("Press any key to continue");
                        var temp = Console.ReadLine();
                        Console.Clear();
                    }

                    //Check for retry
                    Console.Write("Do you want to check another poker hand? (Y/N): ");
                    var response = Console.ReadLine();
                    if (response == "Y" || response == "Yes")
                    {
                        Console.Clear();
                    }
                    else
                    {
                        runProg = false;
                    }
                }

                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine("The proram has encountered the following problem and will shut down - " + e.Message);
                    Thread.Sleep(2000);

                    runProg = false;
                }

            } while (runProg);
            
            Environment.Exit(0);
        }
    }
}
