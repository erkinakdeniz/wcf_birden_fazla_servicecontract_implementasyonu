﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace CompanyServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host=new ServiceHost(typeof(WCF_CompanyService.CompanyService)))
            {
                host.Open();
                Console.WriteLine("SERVİCE STARTED");
                Console.ReadKey();
            }
        }
    }
}
