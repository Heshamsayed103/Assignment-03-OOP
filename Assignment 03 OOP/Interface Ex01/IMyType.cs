using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOP.Interface_Ex01
{
    internal interface IMyType
    {
        // What CAn Write Inside Interface :
        // 1. Signature of Properties
        // 2. Signature of Methods [Name ,Parameter ,Return Type ]
        // 3. Default implmented Methods [Fully Implmented Methods]


        // 2. Signature of Methods [Name ,Parameter ,Return Type ]

        void MyFun();


        // 1. Signature of Properties
        double Salary { get; set; }

        // 3. Default implmented Methods [Fully Implmented Methods]
        void Print()
        {
            Console.WriteLine("Default implmented Methods [Fully Implmented Methods]");
        }


    }
}
