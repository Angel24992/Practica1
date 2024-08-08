using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    // Clase hija, hereda de Vehiculo
    internal class Auto: Vehiculo
    {
        // Atributo específico de la clase Auto
        public int numeroPuertas;
        // Metodo constructor que se utiliza para incializar el atributo de la clase Auto
        public Auto(string marca, string modelo, int año, int numeroPuertas) : base(marca, modelo, año) // Llama al constructor de la clase Vehiculo
        {
            // Inicializa el atributo específico de la clase Auto
            this.numeroPuertas = numeroPuertas;
        }
        // Metodo para calcular el precio basado por el número de puertas
        public void calculoPrecio()
        {
            if (numeroPuertas == 5)
            {
                Console.WriteLine("El auto con 5 puertas vale $5000");
            }
            else if (numeroPuertas == 3)
            {
                Console.WriteLine("El auto con 3 puertas vale $3000");
            }
            else
            {
                Console.WriteLine("Número de puertas ingresadas invalido");
            }
        }
        // Metodo sobreescrito para imprimir informacion del vehículo
        public override void imprimirDatos()
        {
            Console.WriteLine($"Marca: {marca}, modelo: {modelo}, año: {anio}, número de puertas: {numeroPuertas}");
        }
    }
    
}
