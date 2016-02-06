using System.ServiceModel;

// Контракт.

namespace HelloWCF
{    
    [ServiceContract]
    interface IContract //Согласние между консьюмером и сервером
    {
        [OperationContract]
        void Say(string input);
    }
}


