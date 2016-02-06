using System;
using System.ServiceModel;

// Сервер - (получатель сообщения).

namespace HelloWCF
{      
    class Server
    {        
        static void Main()
        {
            Console.Title = "SERVER";

            // Указание адреса, где ожидать входящие сообщения.
            Uri address = new Uri("http://localhost:4000/IContract"); // ADDRESS.    (A)

            // Указание привязки, как обмениваться сообщениями.
            BasicHttpBinding binding = new BasicHttpBinding();        // BINDING.    (B)

            // Указание контракта.
            Type contract = typeof(IContract);                        // CONTRACT.   (C) 


            // Создание провайдера Хостинга с указанием Сервиса.
            ServiceHost host = new ServiceHost(typeof(Service));

            // Добавление "Конечной Точки".
            host.AddServiceEndpoint(contract, binding, address);

            // Начало ожидания прихода сообщений.
            host.Open();


            Console.WriteLine("Приложение готово к приему сообщений.");
            Console.ReadKey();


            // Завершение ожидания прихода сообщений.
            host.Close();
        }
    }
}
