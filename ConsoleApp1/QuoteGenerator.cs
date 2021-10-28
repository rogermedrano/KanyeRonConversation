using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ConsoleApp1
{

    public class QuoteGenerator
    {
        public static void KanyeRonConversation()
        {
            var client = new HttpClient();

            for (int i = 0; i < 5; i++)
            {                
                var kanyeResponse = client.GetStringAsync("https://api.kanye.rest").Result;
                var ronResponse = client.GetStringAsync(" https://ron-swanson-quotes.herokuapp.com/v2/quotes").Result;


                var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
                var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

                Console.WriteLine("");
                Console.WriteLine($"Kanye: {kanyeQuote}");
                Console.WriteLine($"Ron: {ronQuote}");


                Console.WriteLine();
                Console.WriteLine();
            }
        }
        //public static void RonQuote()
        //{
        //    var client1 = new HttpClient();
        //    var ronURL = " https://ron-swanson-quotes.herokuapp.com/v2/quotes";
        //    var ronResponse = client1.GetStringAsync(ronURL).Result;
        //    var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

        //    Console.WriteLine("");
        //    Console.WriteLine($"Ron: {ronQuote}");

        //    Console.WriteLine();
        //    Console.WriteLine("..............................................");
        //}

    }
}
