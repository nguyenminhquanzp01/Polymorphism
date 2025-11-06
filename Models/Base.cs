namespace PolymorphismDemo.Models
{
    public class Base
    {
        public virtual void Show()
        {
            Console.WriteLine("Base.Show() called");
        }
        public void Describe()
        {
            Console.WriteLine("Base.Describe() called");
        }
        public virtual void Print()
        {
            Console.WriteLine("Base.Print() called");
        }
    }
}
