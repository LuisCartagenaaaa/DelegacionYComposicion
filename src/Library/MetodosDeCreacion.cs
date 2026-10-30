using System;
using Library;

namespace Ucu.Poo.Vehiculos
{
    public static class MetodosDeCreacion
    {
        public static Vehiculo CrearElectrico(string marca, string modelo)
        {
            return new Vehiculo(marca, modelo, new MotorElectrico());
        }
        public static Vehiculo CrearCombustion(string marca, string modelo)
        {
            return new Vehiculo(marca, modelo, new MotorCombustion());
        }
    }
}