using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CompanyService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CompanyService" in both code and config file together.
    public class CompanyService : ICompanyPublicService, ICompanyConfidentialService
    {
        public string GetConfidentialInformatiın()
        {
            return "This is Confidential Information, TCP";
        }

        public string GetPublicInformatiın()
        {
            return "this is Public information, HTTP";
        }
    }
}
