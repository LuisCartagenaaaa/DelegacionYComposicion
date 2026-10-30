using System;
using Library;

namespace Ucu.Poo.Vehiculos
{
public interface IMotor
{
    string TipoEnergia { get; }
    string Arrancar();
    string Detener();
    }
}