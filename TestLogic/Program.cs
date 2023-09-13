
namespace TestLogic
{
    public delegate void EventDeleg();
    public class MyClass
    {
        public event EventDeleg? myEven = null;

        public void InvokeDelegate()
        {
            myEven.Invoke();
        }
    }

    class Programm
    {
        public static void Handler1()
        {
            Console.WriteLine("handler1");
        }

        public static void Handler2()
        {
            Console.WriteLine("handler2");
        }

       

        public static void Main()
        { 
            MyClass myClass = new MyClass();
            myClass.myEven += Handler1;
            Console.WriteLine("---");
            myClass.myEven += Handler2;

            myClass.InvokeDelegate();
        }
    }
}