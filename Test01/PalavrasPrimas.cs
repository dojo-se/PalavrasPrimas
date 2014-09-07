using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PalavrasPrimas
{

    class Dojo
    {
        public int resultado = 1;

        static void Main(string[] args)
        {

        }

        public int calculaValor(String palavra) 
        {
            int _ret = 0;
            for (int i = 0; i < palavra.Length; i++)
            {
                char c = palavra[i];
                _ret += c >= 'a' && c <= 'z' ? c - 'a' + 1 : c - 'A' + 27;
            }

            return _ret;
        }


        public bool ePrimo(int p)
        {
            for (int i = 2; i <= p/2; i++)
            {
                if (p % i == 0)
                {
                    return false;
                }
            }            
            return true;
        }

        public bool palavraEhPrima(String palavra)
        {
            return this.ePrimo(this.calculaValor(palavra));
        }
    }

    [TestClass]
    public class DojoUnitTest
    {
        private Dojo dojo;

        [TestInitialize]
        public void setup()
        {
            this.dojo = new Dojo();
        }

        [TestMethod]
        public void TestarCalculaPalavraa()
        {
            
            Assert.AreEqual(1, this.dojo.calculaValor("a"));
        }

        [TestMethod]
        public void TestarCalculaPalavraaa()
        {

            Assert.AreEqual(2, this.dojo.calculaValor("aa"));
        }

        [TestMethod]
        public void TestarCalculaPalavraA()
        {

            Assert.AreEqual(27, this.dojo.calculaValor("A"));
        }

        [TestMethod]
        public void TestarCalculaPalavraAaA()
        {

            Assert.AreEqual(27*2+1, this.dojo.calculaValor("AaA"));
        }

        [TestMethod]
        public void TestarCalculaPalavraz()
        {

            Assert.AreEqual(26, this.dojo.calculaValor("z"));
        }

        [TestMethod]
        public void TestarNumerosPrimos()
        {

            Assert.AreEqual(true, this.dojo.ePrimo(1));
            Assert.AreEqual(true, this.dojo.ePrimo(2));
            Assert.AreEqual(true, this.dojo.ePrimo(3));
            Assert.AreEqual(false, this.dojo.ePrimo(4));
            Assert.AreEqual(true, this.dojo.ePrimo(5));
            Assert.AreEqual(true, this.dojo.ePrimo(11));
            Assert.AreEqual(false, this.dojo.ePrimo(12));
        }

        [TestMethod]
        public void TestarPalavraPrima()
        {
            Assert.AreEqual(false, this.dojo.palavraEhPrima("GDG"));
            Assert.AreEqual(true, this.dojo.palavraEhPrima("k"));
        }

    }
}
