using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3.Interface_Ex03
{
    internal interface IFlyable
    {
        int Speed { get; set; }

        void Forword();
        void Backword();
        void Left();
        void Right();
    }
}
