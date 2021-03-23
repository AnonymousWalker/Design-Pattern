using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.source.Composite
{
    class Client
    {
        /*
         * Use the Composite pattern when:
         * - You have to implement a tree-like hierarchy of objects.
         * - You want the client code to treat both simple and complex objects uniformly.
         */
         public void Use()
        {
            var branch = new CompositeBranch();
            var leaf1 = new Leaf();

            branch.AddComponent(leaf1);

            var subBranch = new CompositeBranch();
            var leaf2 = new Leaf();
            
            subBranch.AddComponent(leaf2);
            branch.AddComponent(subBranch);

            branch.Execute();
        }
    }
}
