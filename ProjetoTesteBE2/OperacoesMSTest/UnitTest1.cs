using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoTesteBE2;

namespace OperacoesMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestarMetodoMultiplicar()
        {
            // Arrange - Organizar
            double primeroNumero = 10;
            double segundoNumero = 10;

            // Act - Executar
            var resultado = Operacoes.Multiplicar(primeroNumero, segundoNumero);

            // Assert - Verificar
            Assert.AreEqual(100, resultado);
        }

        [DataTestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(2, 2, 4)]
        [DataRow(5, 4, 16)]
        public void TestarMetodoMultiplicar_Diversos(double pNumero, double sNumero, double tNumero)
        {
            // Act - Executar
            var resultado = Operacoes.Multiplicar(pNumero, sNumero);

            // Assert - Verifica
            Assert.AreEqual(tNumero, resultado);
        }
    }
}