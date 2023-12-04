using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    internal class CompositionRoot
    {
        Application application = new Application(new NewServiceFactory());

        void Main() { 
            application.Run(); 
        }
    }
}
