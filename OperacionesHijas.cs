using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class OperacionesHijas : Operaciones
    {
        public void Imprimir()
        {
            Console.WriteLine("Resultados de las operaciones:");
            
            double area = CalcularArea(5);  // círculo con radio 5
            Console.WriteLine($"Área de un círculo con un radio de 5 u : {area}");

            double perimetro = CalcularPerimetro(4);  // cuadrado con lado 4
            Console.WriteLine($"Perímetro de un cuadrado de 4 u por lado: {perimetro}");

            double volumen = CalcularVolumen(3);  // cubo con lado 3
            Console.WriteLine($"Volumen de un cubo 3 u por lado: {volumen}");
        }
    }
}
