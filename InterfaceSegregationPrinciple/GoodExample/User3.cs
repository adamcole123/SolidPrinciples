using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.GoodExample
{
    internal class User3
    {
        public User3(U3Ops ops)
        {
            ops.OP3();
        }
    }
}
