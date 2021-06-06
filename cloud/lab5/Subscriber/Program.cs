using System;
using Shared;

namespace Subscriber
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = "localhost";
            var newMessage = false;
            Console.WriteLine("Welcome in ClientOne application. To quit press any key.");

            var rabbitMQManager = new RabbitMqManager(host);

            var connection = rabbitMQManager.Factory.CreateConnection();
            var channel = connection.CreateModel();

            rabbitMQManager.SubscribeQueue(channel, QueueNames.HELLO_WORLD,
                (message) =>
                {
                    Console.WriteLine($">>> Received message: '{message}' <<<");
                    newMessage = true;
                });


            while (true)
            {
                if (newMessage)
                {
                    Console.Write($"Wpisz jak się nazywasz: ");
                    var userMessage = Console.ReadLine();
                    if (userMessage == "q")
                        return;
                    rabbitMQManager.SendMessage(QueueNames.HELLO_ADAM, userMessage);
                    newMessage = false;
                }
            }
        }
    }
}