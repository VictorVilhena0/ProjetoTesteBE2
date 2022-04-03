using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoTesteBE2;

namespace OperacoesTesteBE2
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
    }
}