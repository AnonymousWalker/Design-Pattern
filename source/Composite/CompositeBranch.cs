using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.source.Composite
{
    /*
     * Composite contains leaves and other child composites.
     */
    class CompositeBranch : Component
    {
        private readonly ICollection<Component> children;

        public CompositeBranch()
        {
            children = new List<Component>();
        }

        public void AddComponent(Component component)
        {
            children.Add(component);
        }

        public void RemoveComponent(Component component)
        {
            children.Remove(component);
        }

        public IEnumerable<Component> GetChildren()
        {
            return children;
        }

        public void Execute()
        {
            foreach(var child in children)
            {
                child.Execute(); // delegates the work to its children
            }
        }
    }
}
