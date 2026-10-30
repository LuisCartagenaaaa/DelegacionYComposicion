using System;
using Library;

namespace Ucu.Poo.Vehiculos
{
public class MotorCombustion : IMotor
{
    public string TipoEnergia => "Combustible";
    public string Arrancar()
    {
        return "Motor de combustión encendido";
    }
    public string Detener()
    {
        return "Motor de combustión detenido";
        }
    }
}