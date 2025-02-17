using Opc.UaFx.Server;

namespace Traeger.ComplexParameter.Fail
{
    internal static class Program
    {
        internal static void Main(string[] args)
        {
            var server = new OpcServer("opc.tcp://localhost:4840/artemis", new ArtemisNodeManager());

            server.RequestProcessing += HandleRequestProcessing;

            server.Start();

            Console.WriteLine("Server is running. Press any key to exit...");
            Console.ReadKey();

            server.Stop();
        }

        private static void HandleRequestProcessing(object sender, OpcRequestProcessingEventArgs e)
        {
            if (e.Request.ToString() == "CallRequest")
            {
                Console.WriteLine("Processing: " + e.Request.ToString());
            }
        }
    }
}