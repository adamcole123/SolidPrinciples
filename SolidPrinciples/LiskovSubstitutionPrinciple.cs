using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    internal class LiskovSubstitutionPrinciple
    {
        // Defined by Barbara Liskov in 1988

        // Definition: "If for each object o1 of type S there is an object o2 of type T,
        //  such that for all programs P defined in terms of T, the behavior of P is
        //  unchanged when o1 is substituted for o2 then S is a subtype of T."

        // Simplified: "Derived classes must be usable through the base class interface,
        //  without the need for the user to know the difference."
        //  - Uncle Bob SOLID principles (Video)
    }
}
