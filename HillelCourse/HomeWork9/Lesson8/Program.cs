using System.Threading.Channels;

namespace Lesson8
{
    /*internal*/
    class MyClass1  // default modificator  = internal
    {
        // поля - описують стан обєкта
        /*private*/
        int myValue = 5; // default modificator  = private
        public int MyPropertyForMyValue
        {
            get
            {
                if (myValue == 5)
                {
                    myValue = 6;
                }
                return myValue;
            }
            set
            {
                if (myValue == 5)
                {
                    myValue = value;
                }
            }
        }

        public int MyPropertyAuto { get; set; } = 56;

        public int MyPropertyAutoGet { get; } = 89; // get property

        int myPropertyAutoSet;
        public int MyPropertyAutoSet
        {
            set
            {
                myPropertyAutoSet = value;
            }
        } // set property

        public int myValuePublic;

        // методи - описують поведінку обєкта
        int GetValue()
        {
            return myValue;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;


            //MyClass1 myClass1; // null reference
            //MyClass1 myClass = null; 

            MyClass1 myClass1 = new MyClass1(); // Створення екземпляра класу за сильним посиланням
            MyClass1 myClass2 = new MyClass1(); // Створення іншого екземпляра класу

            //int test = myClass1.myValue; // Error через модифікатор private
            int test1 = myClass1.myValuePublic; // через модифікатор public

            int test2 = new MyClass1().myValuePublic; // доступ до поля класу за слабким посиланням  

            Console.WriteLine(myClass2.MyPropertyForMyValue); // 6
            myClass2.MyPropertyForMyValue = 10;
            Console.WriteLine(myClass2.MyPropertyForMyValue); // 10

            Console.WriteLine(myClass2.MyPropertyAuto); // 56

            int a = myClass2.MyPropertyAutoGet;
            // myClass2.MyPropertyAutoGet = 88; Error read only

            // Console.WriteLine(myClass2.MyPropertyAutoSet); Error get accessor

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var address = new Address() { Index = 5889 };
            // address.Index = 5668; другий спосіб ініціалізації
            address.PrintAddress();
        }
    }
}
