using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    internal class ServiceFactory : IServiceFactory
    {
        public IService MakeService()
        {
            return new Service();
        }
    }
}
