using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TweetSharp;
using System.Threading.Tasks;
using System.Timers;
using System.Runtime.CompilerServices;
using System.Net;

namespace TwitterBot
{
    class WriteTweetCmd : ICommand 
    {
        private string _tweet;
        private TwitterService _service;
        public WriteTweetCmd(TwitterService service)
        {
            this._service = service;
        }

        public void Send(TwitterService service, string tweet)
        {
            service.SendTweet(new SendTweetOptions{Status = tweet}, (tweet, response) =>
            {
                if(response.StatusCode == HttpStatusCode.OK)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"<{DateTime.Now}> - Tweet Sent!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"<ERROR> " + response.Error.Message);
                    Console.ResetColor();  
                }
            });


        }
       public void Execute()
       {
            Console.WriteLine("Write what you want to tweet:");
            _tweet = Console.ReadLine();
            Send(_service, _tweet);
           
       }
        

    }
}