using NUnit.Framework;
using WebCalculadora.Controllers;

namespace NUnitTestCalculadora
{
    public class TestCalculadora
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSumaPost1()
        {
            //Arrange=Preparacion
            int num1 = 5;
            int num2 = 7;
            int esperado = 12;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.sumar(num1, num2);


            //Assert=Verificacion 
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestSumaPost2()
        {
            //Arrange=Preparacion
            int num1 = 8;
            int num2 = 10;
            int esperado = 18;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.sumar(num1, num2);


            //Assert=Verificacion 
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestSumaPost3()
        {
            //Arrange=Preparacion
            int num1 = 17;
            int num2 = 10;
            int esperado = 27;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.sumar(num1, num2);


            //Assert=Verificacion 
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestSumaGet1()
        {
            //Arrange=Preparacion
            int num1 = 5;
            int num2 = 10;
            int esperado = 15;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.suma(num1, num2);


            //Assert=Verificacion 
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestSumaGet2()
        {
            //Arrange=Preparacion
            int num1 = 9;
            int num2 = 10;
            int esperado = 19;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.suma(num1, num2);


            //Assert=Verificacion 
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestSumaGet3()
        {
            //Arrange=Preparacion
            int num1 = 15;
            int num2 = 10;
            int esperado = 25;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.suma(num1, num2);


            //Assert=Verificacion 
            Assert.AreEqual(esperado, resultado);

        }
    }
}