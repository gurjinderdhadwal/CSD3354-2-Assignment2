using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 730319_732152
namespace DelegatesAndEvents
{
    public class DelegateExercises
    {
        public delegate void MyDelegate(int num);
        void Method1(int num);

        public static void Main(string[] args)
        {
            DelegateExercises de = new DelegateExercises();
            de.Method2();
        }

        void Method1(int i)
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate(50);
            myDelegate(60);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            DelegateExercises de = new DelegateExercises();
            de.Method2();
        }
    }

}