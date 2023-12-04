using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    internal class DependencyInversionPrinciple
    {
        // "The most flexible systems are those in which source code dependencies refer only to abstractions, not to concretions."
        
        // In a statically typed language like Java or C#, "use, import, and include" should only refer to
        // source modules containing interfaces, abstract classes, or some other kind of abstract declaration.
        // Nothing concrete should be depended on.

        // To implement this we need to use a service factory

        // Higher level abstractions should not depend on lower level details
        // e.g. Employee entity depending on a database framework that directly interacts with the database

        // Dependency Injection
    }
}
