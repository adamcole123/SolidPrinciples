using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.GoodExample
{
    internal class User1
    {
        public User1(U1Ops ops)
        {
            ops.OP1();
        }
    }
}
