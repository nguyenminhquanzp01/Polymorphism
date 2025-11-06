namespace PolymorphismDemo.Models
{
    public class Derived : Base
    {
        public override void Show()
        {
            Console.WriteLine("Derived.Show() called (override Base.Show)");
        }
        public new void Describe()
        {
            Console.WriteLine("Derived.Describe() called (hides Base.Describe)");
        }
        public override void Print()
        {
            Console.WriteLine("Derived.Print() called (override Base.Print)");
        }
    }
}
