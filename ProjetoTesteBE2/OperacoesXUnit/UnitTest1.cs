using ProjetoTesteBE2;
using Xunit;

namespace OperacoesXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void TestarMetodoMultiplicar()
        {
            // Arrange - Organizar
            double primeroNumero = 10;
            double segundoNumero = 10;

            // Act - Executar
            var resultado = Operacoes.Multiplicar(primeroNumero, segundoNumero);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(10, 10, 100)]
        [InlineData(6, 2, 12)]
        [InlineData(7, 9, 54)]
        public void TestarMetodoMultiplicar_Diversos(double pNumero, double sNumero, double tNumero)
        {
            // Act - Executar
            var resultado = Operacoes.Multiplicar(pNumero, sNumero);

            // Assert - Verifica
            Assert.Equal(tNumero, resultado);
        }
    }
}