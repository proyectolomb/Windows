using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LOMB.Clases;

namespace LOMBPU
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void loginFalse()
        {
            Boolean resultado = InicioSesion.login("", "");
            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void loginTrue()
        {
            Boolean resultado = InicioSesion.login("FRAN", "4321");
            Assert.AreEqual(true, resultado);
        }
    }
}
