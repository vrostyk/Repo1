﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Git;
using GitLib_Al;

namespace Git_V
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine(class1.Method(10));
            ClassAlex classAlex = new ClassAlex();
            Console.WriteLine(classAlex.GetGreetings());
            Console.ReadKey();
        }
    }
}
