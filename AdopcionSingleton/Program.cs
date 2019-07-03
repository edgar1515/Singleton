using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopcionSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Datos datos1 = Datos.GetInstancia();
            datos1.ListaPerros.Add(new Perro() { Id = 1, Nombre = "perro #1" });
            datos1.ListaPerros.Add(new Perro() { Id = 2, Nombre = "perro #2" });
            datos1.ListaPerros.Add(new Perro() { Id = 3, Nombre = "perro #3" });
            datos1.ListaPerros.Add(new Perro() { Id = 4, Nombre = "perro #4" });
            datos1.ListaPerros.Add(new Perro() { Id = 5, Nombre = "perro #5" });

            CargarDatos();
            foreach (Perro perro in datos1.ListaPerros)
            {
                Console.WriteLine("Id = " + perro.Id + " Nombre = " + perro.Nombre);
            }

            Console.Read();
        }

        static void CargarDatos()
        {
            Datos datos2 = Datos.GetInstancia();
            datos2.ListaPerros.Add(new Perro() { Id = 6, Nombre = "perro #6" });
            datos2.ListaPerros.Add(new Perro() { Id = 7, Nombre = "perro #7" });
            datos2.ListaPerros.Add(new Perro() { Id = 8, Nombre = "perro #8" });
            datos2.ListaPerros.Add(new Perro() { Id = 9, Nombre = "perro #9" });
            datos2.ListaPerros.Add(new Perro() { Id = 10, Nombre = "perro #10" });

        }
    }
}
