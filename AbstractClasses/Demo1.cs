﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class Demo1
    {
        public abstract void fun1();

        public void fun2()
        {
            Console.WriteLine("This is Second Function");
        }

        public abstract void fun3();
    }
}
