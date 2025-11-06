namespace PolymorphismDemo.Models
{
    public abstract class AbstractBase
    {
        public abstract void Display(); // phải override trong derived
    }

    public class ConcreteDerived : AbstractBase
    {
        public override void Display()
        {
            Console.WriteLine("ConcreteDerived.Display() called (override abstract)");
        }
    }
}