using System;

// Сервис.

namespace HelloWCF
{
    class Service : IContract
    {
        // Реализация контракта - IContract.
        public string Say(string input)
        {
            Console.WriteLine("Сообщение получено, Тело содержит:  {0}", input);
            string strout = String.Format("Body {0}. Дякую", input);

            // Ответ клиенту.
            return strout;
        }
    }
}
