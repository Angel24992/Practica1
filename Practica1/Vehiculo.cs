using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{

    // Clase padre
    internal class Vehiculo
    {
        // Atributos protegidos de la clase Vehículo
        protected string marca;
        protected string modelo;
        protected int anio;
        // Metodo constructor que se utiliza para inicializar los atributos de la clase Vehiculo
        public Vehiculo(string marca, string modelo, int año)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.anio = año;
        }
        // Metodo virtual para imprimir la información del Vehículo
        public virtual void imprimirDatos()
        {
            Console.WriteLine($"Marca: {marca}, modelo{modelo}, año{anio}");
        }
    }
}
