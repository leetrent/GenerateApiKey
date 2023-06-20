using System;
using System.Security.Cryptography;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate the API key
            string apiKey = GenerateApiKey();

            Console.WriteLine("Generated API key: " + apiKey);
            Console.ReadLine();
        }

        static string GenerateApiKey()
        {
            byte[] apiKeyBytes = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(apiKeyBytes);
            }
            return Convert.ToBase64String(apiKeyBytes);
        }
    }
}
