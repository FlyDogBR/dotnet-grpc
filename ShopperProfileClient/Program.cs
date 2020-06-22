using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Grpc.Net.Client;
using ShopperProfileServer;

namespace ShopperProfileClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            new Program().RunConsumer().Wait();
        }

        public async Task RunConsumer()
        {
            var serverAddress = "https://localhost:5000";

            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                // macOS doesn't support ASP.NET Core gRPC with TLS. So we're serving our app on an unsecure endpoint
                // This switch must be set before creating the GrpcChannel/HttpClient.
                // For more information see https://docs.microsoft.com/en-us/aspnet/core/grpc/troubleshoot?view=aspnetcore-3.1
                // The following statement allows you to call insecure services. To be used only in development environments.
                AppContext.SetSwitch(
                    "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
                serverAddress = "http://localhost:5000";
            }

            // The port number(5000) must match the port of the gRPC server.
            var channel = GrpcChannel.ForAddress(serverAddress);
            var client = new ShopperProfile.ShopperProfileClient(channel);

            // Our shopper repository contains details of shopper's with IDs ranging from 1-5
            Console.WriteLine("Enter a shopperId to search for (1-5)");
            var profile = await client.GetShopperProfileAsync(new ShopperProfileRequest() { ShopperId = Console.ReadLine() });

            Console.WriteLine($"Shopper profile | Id: {profile.ShopperDetails.ShopperId} | Name: {profile.ShopperDetails.Name}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}