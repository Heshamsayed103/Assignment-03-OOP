using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3.Interface_Ex02
{
    internal class SeriesByFour : Iseries
    {
        public int Current { get; set; }

        public void Next()
        {
            Current += 4;

        }

     
    }
}
