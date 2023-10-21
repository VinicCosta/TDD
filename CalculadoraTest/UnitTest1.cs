using System;
using Xunit;
using Calculadora;

namespace CalculadoraTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData (1,2,3)]
        [InlineData (4,5,9)]
        public void TesteSomar(int val1, int val2, int res)
        {
            Calculadoraa _calc = new Calculadoraa();

            //act
            int resultadoCalculadora = _calc.somar(val1, val2);

            //assert
            Assert.Equal(res, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(5, 2, 3)]
        public void TesteSubstrair(int val1, int val2, int res)
        {
            Calculadoraa _calc = new Calculadoraa();

            //act
            int resultadoCalculadora = _calc.subtrair(val1, val2);

            //assert
            Assert.Equal(res, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int res)
        {
            Calculadoraa _calc = new Calculadoraa();

            //act
            int resultadoCalculadora = _calc.multiplicar(val1, val2);

            //assert
            Assert.Equal(res, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(4, 4, 1)]
        public void TesteDividr(int val1, int val2, int res)
        {
            Calculadoraa _calc = new Calculadoraa();

            //act
            int resultadoCalculadora = _calc.dividir(val1, val2);

            //assert
            Assert.Equal(res, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadoraa _calc = new Calculadoraa();

            Assert.Throws<DivideByZeroException>(() => _calc.dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadoraa _calc = new Calculadoraa();

            _calc.somar(1, 2);
            _calc.somar(3, 2);
            _calc.somar(1, 5);
            _calc.somar(1, 4);
            _calc.somar(3, 2);

            var lista = _calc.historico();

            Assert.NotEmpty(_calc.historico());
            Assert.Equal(3, lista.Count);
        }
    }
}
