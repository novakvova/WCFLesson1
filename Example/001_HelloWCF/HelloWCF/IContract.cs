using System.ServiceModel;

// Контракт.

namespace HelloWCF
{    
    [ServiceContract]
    interface IContract
    {
        [OperationContract]
        string Say(string input);
    }
}
