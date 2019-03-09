﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DelegatesAndEvents
{

    namespace DelegatesAndEvents
    {
        class Program
        {

            public static void Main(string[] args)
            {
                DelegateExercises de = new DelegateExercises();
                de.Method3();
                Console.Read();
            }
        }
        public delegate void MyDelegate();
        public class DelegateExercises
        {
            void Method1()
            {
                System.Console.WriteLine("Method1");
            }
            public void Method3()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                myDelegate();
                Console.WriteLine(myDelegate.ToString());
            }
        }

    }
}