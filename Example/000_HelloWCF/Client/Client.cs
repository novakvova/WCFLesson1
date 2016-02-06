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
            Uri address = new Uri("http://localhost:4000/IContract");  // ADDRESS.   (A)

            // Указание, как обмениваться сообщениями.
            BasicHttpBinding binding = new BasicHttpBinding();         // BINDING.   (B)

            // Создание Конечной Точки.
            EndpointAddress endpoint = new EndpointAddress(address);

            // Создание фабрики каналов.
            ChannelFactory<IContract> factory = new ChannelFactory<IContract>(binding, endpoint);  // CONTRACT.  (C) 

            // Использование factory для создания канала (прокси).
            IContract channel = factory.CreateChannel();
            
            // Использование канала для отправки сообщения получателю.
            channel.Say("Hello WCF!");// сложный механизм

            // Задержка.
            Console.ReadKey();
        }
    }
}
