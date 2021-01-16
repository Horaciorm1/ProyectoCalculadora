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

        [Test]
        public void TestRestaGet1()
        {
            //Arrange=Preparacion
            int num1 = 20;
            int num2 = 10;
            int esperado = 10;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.resta(num1, num2);


            //Assert=Verificacion 
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestRestaGet2()
        {
            //Arrange=Preparacion
            int num1 = 30;
            int num2 = 10;
            int esperado = 20;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.resta(num1, num2);


            //Assert=Verificacion 
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestRestaGet3()
        {
            //Arrange=Preparacion
            int num1 = 40;
            int num2 = 10;
            int esperado = 30;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.resta(num1, num2);


            //Assert=Verificacion 
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestRestaPost1()
        {
            //Arrange=Preparacion
            int num1 = 20;
            int num2 = 10;
            int esperado = 10;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.restar(num1, num2);


            //Assert=Verificacion 
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestRestaPost2()
        {
            //Arrange=Preparacion
            int num1 = 400;
            int num2 = 10;
            int esperado = 390;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.restar(num1, num2);


            //Assert=Verificacion 
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestRestaPost3()
        {
            //Arrange=Preparacion
            int num1 = 80;
            int num2 = 10;
            int esperado = 70;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.restar(num1, num2);


            //Assert=Verificacion 
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestMultiGet1()
        {
            //Arrange=Preparacion
            int num1 = 40;
            int num2 = 10;
            int esperado = 400;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.multi(num1, num2);


            //Assert=Verificacion 
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestMultiGet2()
        {
            //Arrange=Preparacion
            int num1 = 40;
            int num2 = 1;
            int esperado = 40;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.multi(num1, num2);


            //Assert=Verificacion 
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestMultiGet3()
        {
            //Arrange=Preparacion
            int num1 = 4;
            int num2 = 1;
            int esperado = 4;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.multi(num1, num2);


            //Assert=Verificacion 
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestMultiPost1()
        {
            //Arrange=Preparacion
            int num1 = 4;
            int num2 = 10;
            int esperado = 40;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.multix(num1, num2);


            //Assert=Verificacion 
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestMultiPost2()
        {
            //Arrange=Preparacion
            int num1 = 5;
            int num2 = 10;
            int esperado = 50;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.multix(num1, num2);


            //Assert=Verificacion 
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestMultiPost3()
        {
            //Arrange=Preparacion
            int num1 = 4;
            int num2 = 6;
            int esperado = 24;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.multix(num1, num2);


            //Assert=Verificacion 
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestDivGet1()
        {
            //Arrange=Preparacion
            int num1 = 10;
            int num2 = 5;
            int esperado = 2;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.div(num1, num2);


            //Assert=Verificacion 
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestDivGet2()
        {
            //Arrange=Preparacion
            int num1 = 20;
            int num2 = 5;
            int esperado = 4;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.div(num1, num2);


            //Assert=Verificacion 
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestDivGet3()
        {
            //Arrange=Preparacion
            int num1 = 20;
            int num2 = 5;
            int esperado = 4;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.div(num1, num2);


            //Assert=Verificacion 
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestDivPost1()
        {
            //Arrange=Preparacion
            int num1 = 100;
            int num2 = 5;
            int esperado = 20;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.divs(num1, num2);


            //Assert=Verificacion 
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestDivPost2()
        {
            //Arrange=Preparacion
            int num1 = 25;
            int num2 = 5;
            int esperado = 5;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.divs(num1, num2);


            //Assert=Verificacion 
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestDivPost3()
        {
            //Arrange=Preparacion
            int num1 = 30;
            int num2 = 5;
            int esperado = 6;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.divs(num1, num2);


            //Assert=Verificacion 
            Assert.AreEqual(esperado, resultado);

        }
    }
}