using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadParcial
{
    internal class Promedio
    {
        int valor;
        int contador = 0;
        int acumulador = 0;
        double promedio;
        public void AgregarValor(int valor)
        {
            Console.WriteLine("Ingrese Valor");
            valor = Convert.ToInt32(Console.ReadLine());
            acumulador += valor;
            contador++;
        }
        public double CalcularPromedio(int acumulador,int contador)
        {
            double promedio = 0;
            if (contador != 0)
            {
                return promedio = acumulador / contador;
            }
            else
            {
                return 0;
            }
            
        }
    }
}
