using System;
using System.Collections.Generic;
using APIsAndJSON;
using Newtonsoft.Json.Linq;



namespace APIsAndJSON
{
    internal class RonVSKanyeAPI
    {
        public static string Ron()
        {
            var client = new HttpClient(); //object allowing requests

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes"; //endpoint

            string ronResp = client.GetStringAsync(ronURL).Result; //receives data as string

            var ronQuote = JArray.Parse(ronResp).ToString().Replace('[', ' ').Replace(']', ' ').Trim(); //.Parse to string


            return ronQuote; //return

        }

        public static string Kanye()
        {
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest/";

            string kayneResp = client.GetStringAsync(kanyeURL).Result;

            var kayneQuote = JObject.Parse(kayneResp).GetValue("quote").ToString();

            return kayneQuote;
        }
    }
}
