using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3.Interface_Ex03
{
    internal class Car : IMoveable
    {
        public int Speed { get ; set; }

        public void Backword()
        {
            Console.WriteLine("Car IMoveable Backword");
        }

        public void Forword()
        {
            Console.WriteLine("Car IMoveable Forword");
        }

        public void Left()
        {
            Console.WriteLine("Car IMoveable Left");
        }

        public void Right()
        {
            Console.WriteLine("Car IMoveable Right");

        }
    }
}
