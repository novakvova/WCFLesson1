using System;
using System.ServiceModel;

// Клиент - (отправитель сообщения)

namespace Client
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.Title = "CLIENT";

            // Указание, где ожидать входящие сообщения.
            Uri address = new Uri("http://localhost:4000/IContract");

            // Указание, как обмениваться сообщениями.
            BasicHttpBinding binding = new BasicHttpBinding();

            // Создание Конечной Точки. 
            EndpointAddress endpoint = new EndpointAddress(address);

            // Создание фабрики каналов.
            ChannelFactory<IContract> factory = new ChannelFactory<IContract>(binding, endpoint);

            // Использование factory для создания канала (прокси).
            IContract channel = factory.CreateChannel();
            
            // Использование канала для отправки сообщения получателю и приема ответа.
            string response = channel.Say("Hello WCF!");

            Console.WriteLine(response);

            // Задержка.
            Console.ReadKey();
        }
    }
}
