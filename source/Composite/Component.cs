
namespace DesignPattern.source.Composite
{
    /*
     * This interface should (declare) maximize the common operations between leaf and composite
     * so that the clients are unaware of the specific classes.
     */
    interface Component
    {
        public void Execute();
    }
}
