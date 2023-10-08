//Base Class
//class BaseClass
//{
//    public BaseClass()
//    {
//        Console.WriteLine("Hello from Base Class");
//    }
//    public BaseClass(int xBaseClass)
//    {
//        this.xBaseClass = xBaseClass;
//        Console.WriteLine(xBaseClass);
//    }
//    protected int xBaseClass;
//    protected void PrintBaseClass()
//    {
//        Console.WriteLine("Hello from Base Class");
//    }
//}

////DerivedClass

//class DerivedClass : BaseClass
//{
//    protected int xDerivedClass;
//    public DerivedClass(int xDerivedClass, int xBaseClass) : base(xBaseClass) 
//    {
//        this.xDerivedClass = xDerivedClass;
//        Console.WriteLine(xDerivedClass);
//    }
//    protected void PrintDerivedClass()
//    {
//        PrintBaseClass();
//        Console.WriteLine("Hello from DerivedClass");
//    }
//}

//DerivedDerivedClass

//class DerivedDerivedClass : DerivedClass
//{
//    public void PrintDerivedDerivedClass()
//    {
//        PrintDerivedClass();
//        PrintBaseClass();
//        Console.WriteLine("Hello from DerivedDerivedClass");
//    }
//}
namespace Lesson11
{
    class Program
    {
        static void Main()
        {
           Weapon knife = new Knife();
            knife.Attack();
           Weapon rifle = new Rifle();
            rifle.Attack();
           Weapon granade = new Granade();
            granade.Attack();
            Console.ReadKey();
        }
    }

}
