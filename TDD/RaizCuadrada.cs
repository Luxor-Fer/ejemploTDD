using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class RaizCuadrada
    {
        public double CalcularRaizCuadrada(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            else
            {
                return Math.Sqrt(num);
            }
        }

    }
}
