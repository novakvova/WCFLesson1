using System.ServiceModel;

// Контракт.

namespace Client
{    
    [ServiceContract]
    interface IContract
    {
        [OperationContract]
        string Say(string input);
    }
}
