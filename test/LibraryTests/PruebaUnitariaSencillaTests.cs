using NUnit.Framework;
using Library;
using Ucu.Poo.Vehiculos;

namespace LibraryTests
{
    public class PruebaUnitariaSencillaTests
    {
        [Test]
        public void Encender_WhenVehiculoElectrico_ReturnsElectricMessage()
        {
            Vehiculo vehiculo = MetodosDeCreacion.CrearElectrico(
                "Tesla",
                "Model E");

            string resultado = vehiculo.Encender();

            Assert.That(
                resultado,
                Does.Contain("eléctrico"));
        }
    }
}