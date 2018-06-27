using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlurlDemo
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var client = new Client();

            // simple GET
            var result = await client.GetDataUsingFlurl<List<HackerNewsEntity>>("http://node-hnapi.herokuapp.com/news");

            Console.WriteLine($"Number of results: {result.Count}");
            result.ForEach(item => Console.WriteLine(item.Title));

            // GET with parameters

        }
    }
}
