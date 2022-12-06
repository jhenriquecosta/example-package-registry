using MyPack;

namespace MyPackTest
{
    public class CalculadoraTest
    {
        private Calculadora  _calculadora;
        [SetUp]
        public void Setup()
        {
            _calculadora = new Calculadora();
        }

        [Test]
        public void Somar_Return_True()
        {
            var result = _calculadora.Soma(1, 1);
            Assert.That(result, Is.EqualTo(2));
        }
    }
}