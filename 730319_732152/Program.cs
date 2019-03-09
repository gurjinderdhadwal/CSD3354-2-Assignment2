using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _730319_732152
{
    class Program
    {
        public delegate void MyDelegate();
        void Method()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }

        public void Method2()
        {
            Delegate Delegate = new MyDelegate(Method1);
            myDelegate(50);
        }

        private void Method1()
        {
            throw new NotImplementedException();
        }

        private void myDelegate(int v)
        {
            throw new NotImplementedException();
        }
    }
}

namespace DelegatesAndEvents
{
 class Program
{ 
static void Main(string[] args)
{
    // TO DO: Call Method 2 from the Delegate Exercises Class
        }
    }
}