using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    internal class InterfaceSegregationPrinciple
    {
        // It is harmful to depend on modules that contain more than you need

        // Depending on more than you need means that you will be subject to
        // unnecessary recompilation and redeployment

        // Depending on something that carries baggage that you don't need can
        // cause you troubles that you didn't expect
    }
}
