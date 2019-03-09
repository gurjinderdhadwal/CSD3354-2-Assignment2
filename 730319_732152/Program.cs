﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DelegatesAndEvents
{

    namespace DelegatesAndEvents
    {
        public class Program
        {
            public delegate int MyDelegate(int intValue);

            public static void Main(string[] args)

            {
                DelegateExercises de = new DelegateExercises();
                de.Method3();
                DelegateExercises delegateExercises = new DelegateExercises();
                delegateExercises.Method3();
            }
        }

        public class DelegateExercises
        {
            public delegate int MyDelegate();
            public int Method1()
            {

                Console.WriteLine("MyDelegate");
                return 1;
            }

            public void Method3()
            {

                MyDelegate myDelegate = new MyDelegate(Method1);
                myDelegate();
                Console.ReadLine();
            }
        }
    }
}