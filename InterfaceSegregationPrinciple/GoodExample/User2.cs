using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.GoodExample
{
    internal class User2
    {
        public User2(U2Ops ops)
        {
            ops.OP2();
        }
    }
}
