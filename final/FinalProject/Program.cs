using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TweetSharp;
using System.Threading.Tasks;
using System.Timers;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"<{DateTime.Now}> - Bot Started");

        Credentials credentials = new Credentials();
        TwitterService service = new TwritterService(credentials.customerKey, credentials.customerKeySecret);


    }
}