using System;

// Сервис.

namespace HelloWCF
{
    class Service : IContract
    {
        // Реализация контракта - IContract.
        public void Say(string input)
        {
            Console.WriteLine("Сообщение получено, Тело содержит:  {0}", input);
        }
    }
}
