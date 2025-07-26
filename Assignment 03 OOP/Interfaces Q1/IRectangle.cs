using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOP.Interfaces
{
    public interface IRectangle : IShape
    {
        double Width { get; }
        double Height { get; }
    }


}
