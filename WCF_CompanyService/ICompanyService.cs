using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CompanyService
{
    // Şirket dışı kullanıcılar için sevicecontract
    //Bu contract netHttpBinding ile ulaşılabilecek
    [ServiceContract]
    public interface ICompanyPublicService
    {
        [OperationContract]
        string GetPublicInformatiın();
    }
    //Şirket içi kullanıcılar için servicecontract
    //Bu contract netTcpBinding ile ulaşılabilecek
    [ServiceContract]
    public interface ICompanyConfidentialService
    {
        [OperationContract]
        string GetConfidentialInformatiın();
    }
}
