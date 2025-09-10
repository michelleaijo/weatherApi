using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            Console.Write("Enter a city: ");
            string city = Console.ReadLine();

            // Build the URL
            string url = $"https://wttr.in/{city}?format=3"; // Short format

            try
            {
                // Make the request
                string weather = await client.GetStringAsync(url);

                // Show the result
                Console.WriteLine("Weather Info:");
                Console.WriteLine(weather);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("There was a problem getting the weather.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}