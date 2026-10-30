using System;
using Library;

namespace Ucu.Poo.Vehiculos
{
public class Tablero
{
    public string MostrarEstado(
        string marca,
        string modelo,
        string energia)
    {
        return $"{marca} {modelo} - Energía: {energia}";
        }
    }
}