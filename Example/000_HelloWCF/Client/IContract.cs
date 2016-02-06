using System.ServiceModel;

// Контракт.

namespace Client
{    
    [ServiceContract]
    interface IContract
    {
        [OperationContract]
        void Say(string input);
    }
}
