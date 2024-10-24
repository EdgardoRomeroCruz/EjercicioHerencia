using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Operaciones
    {
        // calculo de area criculo Pi x r2 osea 3.1416 x r x r
        public double CalcularArea(double radio)
        {
            double pi = 3.1416;
            return (pi * radio * radio);
         }
        //------------------------------------------------//
        // calculo de longitud de un perimetro
        public double CalcularPerimetro(double lado) 
        {
            return 4 * lado;
        }
        //--------------------------------------------------//
        // calculo de Volumen lado por lado por lado
        public double CalcularVolumen(double lado) 
            { 
            return lado *lado* lado;
        }
    }
}
