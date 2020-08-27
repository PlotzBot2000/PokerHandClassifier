using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Net;

namespace PokerHandClassifier
{
    //Might change this whole class to utilise own classifier
    class APIUtil
    {
        public APIUtil() { }

        public string MakePostRequest() // TODO: Enter arguments ... string endpoint, string jsonInput, DataTable headers etc...
        {
            string strOutput = "";
            try
            {
                //TODO: Create Post Creation upon confirmation of poker classifier web service

            }
            catch (Exception e)
            {
                strOutput = "Exception: " + e.Message;
            }
            
            return strOutput;
        }
    }
}
