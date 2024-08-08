using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    // Clase Principal
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Diseña un sistema de clases para representar vehículos. 
             * Utiliza herencia para organizar las clases en una jerarquía que incluya 
             * una clase principal, una clase padre y una clase hija.
             */

            // Inicialización con un constructor parametrizado
            Auto auto = new Auto("Chevrolet", "Aveo", 2019, 3);

            // Imprime los datos del vehículo
            auto.imprimirDatos();
            // Imprime el valor del vehículo según su número de puertas
            auto.calculoPrecio();
            Console.ReadKey();
        }
    }
}
