using System;
using Library;

namespace Ucu.Poo.Vehiculos
{
public class MotorElectrico : IMotor
{
    public string TipoEnergia => "Electricidad";
    public string Arrancar()
    {
        return "Motor eléctrico encendido";
    }
    public string Detener()
    {
        return "Motor eléctrico detenido";
        }
    }
}