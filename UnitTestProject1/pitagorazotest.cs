using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class pitagorazo_prueba
    {
        [TestMethod]
        public void Test_sacar_hipotenusa()
        {
            // preparacion
            
            double a = 5;
            double b = 12;
            double resultado_esperado = 13;
            pitagorazo.Form1 calculo = new pitagorazo.Form1();

            //ejecutar
            double result = calculo.calcular_hipotenusa( a, b);

            //assert
            Assert.AreEqual(resultado_esperado, result);

        }
    }
}
