using System;
using Library;

namespace Ucu.Poo.Vehiculos
{
    public static class Program
    {
        public static void Main()
        {
            Vehiculo electrico = MetodosDeCreacion.CrearElectrico(
                        "Tesla",
                        "Model E");
            Vehiculo combustion = MetodosDeCreacion.CrearCombustion(
                        "Ford",
                        "Focus");
            Console.WriteLine("=== VEHÍCULO ELÉCTRICO ===");
            Console.WriteLine(electrico.MostrarEstado());
            Console.WriteLine(electrico.Encender());
            Console.WriteLine(electrico.Frenar());
            Console.WriteLine(electrico.Apagar());
            Console.WriteLine();
            Console.WriteLine("=== VEHÍCULO COMBUSTIÓN ===");
            Console.WriteLine(combustion.MostrarEstado());
            Console.WriteLine(combustion.Encender());
            Console.WriteLine(combustion.Frenar());
            Console.WriteLine(combustion.Apagar());
        }
    }
}