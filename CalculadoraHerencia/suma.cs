using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraHerencia
{
    class suma : Operacion
    {

        public double operar(double va1, double va2)
        {
            Val1 = va1;
            Val2 = va2;

            //Se hace el calculo
            Result = Val1 + Val2;

            return Result;
        }
    }
}
