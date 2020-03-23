using System;
using System.Threading.Tasks;
using Balances.Client;

namespace TestClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Press enter to start");
            Console.ReadLine();

            var client = new BalancesClient(new BalancesClientSettings {ServiceAddress = "http://localhost:5001"});

            var balances = await client.Balances.GetAllAsync("test-2");

            foreach (var balance in balances)
                Console.WriteLine($"{balance.AssetId}\t{balance.Amount}\t{balance.Timestamp}");

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
