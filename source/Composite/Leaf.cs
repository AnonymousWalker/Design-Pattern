using System;

namespace DesignPattern.source.Composite
{
    /*
     * This class does the actual work
     */
    class Leaf : Component
    {
        public void Execute()
        {
            Console.WriteLine("Leaf does some work!");
        }
    }
}
