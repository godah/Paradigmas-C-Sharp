using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    abstract class Figura
    {
        internal int x { get; set; }
        internal int y { get; set; }
        internal abstract double Area();
    }
}
