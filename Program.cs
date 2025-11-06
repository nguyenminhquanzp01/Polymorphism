using PolymorphismDemo.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Polymorphism Demo ===\n");

        Base baseRef = new Derived();  // ref type = Base, runtime type = Derived
        baseRef.Show();                
        baseRef.Print();               
        baseRef.Describe();            
        Console.WriteLine();

        Derived derived = new Derived();
        derived.Show();               
        derived.Print();               
        derived.Describe();           
        Console.WriteLine();

        Console.WriteLine("=== Abstract override demo ===");
        AbstractBase obj = new ConcreteDerived();
        obj.Display();
    }
}