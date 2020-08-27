using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
//using System.Net;
using RestSharp;

namespace PokerHandClassifier
{
    //Might change this whole class to utilise own classifier
    public class APIUtil
    {
        public APIUtil() { }

        public string MakePostRequest(string allCards)
        {
            string strOutput = "";
            try
            {
                //Splits string to array
                allCards.Replace(" ", "");
                string[] CardArray = allCards.ToUpper().Split(',');

                object strJSON = "{\r\n   \"card_1\":\"" + CardArray[0] +
                                  "\",\r\n   \"card_2\":\"" + CardArray[1] +
                                  "\",\r\n   \"card_3\":\"" + CardArray[2] +
                                  "\",\r\n   \"card_4\":\"" + CardArray[3] +
                                  "\",\r\n   \"card_5\":\"" + CardArray[4] +
                                  "\"\r\n}\r\n";

                //Generated using postman
                //=======================//
                var client = new RestClient("https://pokerhandclassifier2000.herokuapp.com/hand");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", strJSON, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                //=======================//

                string ResponseString = response.Content;
                int posInt = ResponseString.IndexOf('{'); 
                strOutput = ResponseString.Substring(2, posInt - 4);
            }
            catch (Exception e)
            {
                strOutput = "Exception: " + e.Message;
            }
            
            return strOutput;
        }
    }
}
