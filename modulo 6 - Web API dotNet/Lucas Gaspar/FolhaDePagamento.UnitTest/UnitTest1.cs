using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FolhaDePagamento;

namespace FolhaDePagamento.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            GerarDemonstrativo g1 = new GerarDemonstrativo(200, 5000, 50, 10);
            Demonstrativo d = g1.gerarDemonstrativo();
            Assert.AreEqual(5000, d.SalarioBase);
            Assert.AreEqual(1250, d.HorasExtras);
            Assert.AreEqual(250, d.HorasDescontadas);
            Assert.AreEqual(6000, d.TotalProventos);
            Assert.AreEqual(600, d.Inss);
            Assert.AreEqual(1485, d.Irrf);
            Assert.AreEqual(2085, d.TotalDescontos);
            Assert.AreEqual(3915, d.TotalLiquido);
            Assert.AreEqual(660, d.Fgts);
        }
    }
}
