using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AddressBookServer;
using Grpc.Net.Client;

namespace AddressBookClient
{
    class Program
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
            var client = new Address.AddressClient(channel);

            StringBuilder sb = new StringBuilder();

            while (true)
            {
                sb.Clear();

                // Our shopper repository contains details of shopper's with IDs ranging from 1-5
                Console.WriteLine("Enter a addressId to search (1, 2 or 3), empty for all, or 0 (zero) to exit");

                string command = Console.ReadLine();

                if (command != "0")
                {
                    var profile = await client.GetAsync(new AddressBookRequest() { Id = command });

                    if (profile != null && profile.People != null)
                    {
                        foreach (Person person in profile.People)
                        {
                            sb.Append("-------------------------------------------------------------------------------");
                            sb.AppendLine();
                            sb.Append("PersonId: " + person.Id + " | Name: " + person.Name + " | Email: " + person.Email);
                            sb.AppendLine();

                            if (person.Phones != null)
                            {
                                foreach (var phone in person.Phones)
                                {
                                    sb.Append("Number: " + phone.Number + " | Type: " + phone.Type.ToString());
                                    sb.AppendLine();
                                }
                            }

                            sb.Append("LastUpdated: " + person.LastUpdated.ToDateTimeOffset());
                            sb.AppendLine();
                            sb.Append("Duration: " + person.Duration.ToTimeSpan());
                            sb.AppendLine();

                            double? doubleTestNullType = person.DoubleTestNullType;
                            float? floaTestNullType = person.FloaTestNullType;
                            int? int32TestNullType = person.Int32TestNullType;
                            long? int64TestNullType = person.Int64TestNullType;
                            string stringTestNullType = person.StringTestNullType;

                            sb.Append("-------------------------------------------------------------------------------");
                            sb.AppendLine();
                        }
                    }

                    Console.WriteLine(sb.ToString());
                }
                else
                {
                    break;
                }
            }
        }
    }
}
