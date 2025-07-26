using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOP.Interface_Ex01
{
    internal class MyType : IMyType /*:--> Implemente*/
    {
        public double Salary { get; set; }

        public void MyFun()
        {
            Console.WriteLine("Hello World ");
        }
    }
}
