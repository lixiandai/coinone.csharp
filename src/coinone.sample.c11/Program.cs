using System;
using System.Text;

namespace Coinone.Sample.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = CodePagesEncodingProvider.Instance;
            Encoding.RegisterProvider(provider);

            CoinOne.Start();
            
            while (Console.ReadLine() != "quit")
                Console.WriteLine("Enter 'quit' to stop the services and end the process...");
        }
    }
}