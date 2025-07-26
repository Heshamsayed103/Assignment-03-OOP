using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3.Interface_Ex02
{
    internal class SeriesByTwo : Iseries
    {
        public int Current { get; set; } // 0

        public void Next()
        {
            Current +=2;
        }

       
    }
}
