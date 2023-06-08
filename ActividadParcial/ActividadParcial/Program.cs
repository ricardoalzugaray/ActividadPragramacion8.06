using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadParcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Promedio miPromedio = new Promedio();
            int opcion, acumulador = 0, contador = 0;
            do
            {
                Menu();
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        {
                            miPromedio.AgregarValor();
                            Console.ReadKey();
                            Console.Clear();
                        } break;
                    case 2:
                        { 
                            miPromedio.CalcularPromedio(acumulador,contador);
                            Console.ReadKey();
                            Console.Clear();

                        } break;
                    case 3:
                        {

                        } break;
                }
            } while (opcion != 3);
            void Menu()
            {
                Console.WriteLine("1- Agregar Valor");
                Console.WriteLine("2- Promedio");
                Console.WriteLine("3- Salir");
            }
        }
    }
}
