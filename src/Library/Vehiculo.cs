using System;
using Library;

namespace Ucu.Poo.Vehiculos
{
public class Vehiculo
{
    public string Marca { get; private set; }
    public string Modelo { get; private set; }
    private IMotor motor;
    private SistemaFrenos frenos;
    private Tablero tablero;
    public Vehiculo(string marca, string modelo, IMotor motor)
    {
        Marca = marca;
        Modelo = modelo;
        this.motor = motor;
        frenos = new SistemaFrenos();
        tablero = new Tablero();
    }
    public string Encender()
    {
        return motor.Arrancar();
    }
    public string Apagar()
    {
        return motor.Detener();
    }
    public string Frenar()
    {
        return frenos.Frenar();
    }
    public string MostrarEstado()
    {
        return tablero.MostrarEstado(
            Marca,
            Modelo,
            motor.TipoEnergia);
        }
    }
}
