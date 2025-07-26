using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3.Interface_Ex03
{
    internal class AirPlan : IMoveable,IFlyable
    {
        int IMoveable.Speed { get ; set; }
        int IFlyable.Speed { get  ; set; }

         void IMoveable.Backword()
        {
            Console.WriteLine("Car IMoveable Backword");
        }

         void IMoveable.Forword()
        {
            Console.WriteLine("Car IMoveable Forword");
        }

         void IMoveable.Left()
        {
            Console.WriteLine("Car IMoveable Left");
        }

         void IMoveable.Right()
        {
            Console.WriteLine("Car IMoveable Right");

        }

        void IFlyable.Backword()
        {
            Console.WriteLine("Car IFlyable Backword");
        }

        void IFlyable.Forword()
        {
            Console.WriteLine("Car IFlyable Forword");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("Car IFlyable Left");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("Car IFlyable Right");

        }
    }
}
