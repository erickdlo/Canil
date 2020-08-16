using Canil_Eduardo.Modelos;
using Canil_Eduardo.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class TesteCanil
    {
        [TestMethod]
        public void Teste_Sucesso_MelhorCanil_MeuCaninoFeliz_DiaDeSemana()
        {
            string data = "17/08/2020";
            CanilNegocio negCanil = new CanilNegocio();
            MelhorCanil retorno = negCanil.BuscarMelhorCanil(data, 1, 1);
            Assert.AreEqual(retorno.NomeCanil, "Meu Canino Feliz");
            Assert.AreEqual(retorno.PrecoTotal, 60);
        }
        [TestMethod]
        public void Teste_Sucesso_MelhorCanil_MeuCaninoFeliz_FinalDeSemana()
        {
            string data = "16/08/2020";
            CanilNegocio negCanil = new CanilNegocio();
            MelhorCanil retorno = negCanil.BuscarMelhorCanil(data, 1, 1);
            Assert.AreEqual(retorno.NomeCanil, "Meu Canino Feliz");
            Assert.AreEqual(retorno.PrecoTotal, 72);
        }
        [TestMethod]
        public void Teste_Sucesso_MelhorCanil_VaiRex_DiaDeSemana()
        {
            string data = "17/08/2020";
            CanilNegocio negCanil = new CanilNegocio();
            MelhorCanil retorno = negCanil.BuscarMelhorCanil(data, 1, 1);
            Assert.AreEqual(retorno.NomeCanil, "Meu Canino Feliz");
            Assert.AreEqual(retorno.PrecoTotal, 60);
        }
        [TestMethod]
        public void Teste_Sucesso_MelhorCanil_VaiRex_FinalDeSemana()
        {
            string data = "17/08/2020";
            CanilNegocio negCanil = new CanilNegocio();
            MelhorCanil retorno = negCanil.BuscarMelhorCanil(data, 1, 1);
            Assert.AreEqual(retorno.NomeCanil, "Meu Canino Feliz");
            Assert.AreEqual(retorno.PrecoTotal, 60);
        }
        [TestMethod]
        public void Teste_Sucesso_MelhorCanil_ChowChawgas()
        {
            string data = "17/08/2020";
            CanilNegocio negCanil = new CanilNegocio();
            MelhorCanil retorno = negCanil.BuscarMelhorCanil(data, 1, 1);
            Assert.AreEqual(retorno.NomeCanil, "Meu Canino Feliz");
            Assert.AreEqual(retorno.PrecoTotal, 60);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Teste_Falha_QuantidadeCaesP()
        {
            string data = "17/08/2020";
            CanilNegocio negCanil = new CanilNegocio();
            negCanil.BuscarMelhorCanil(data, -2, 1);
            
        }
        [TestMethod]
        public void Teste_Falha_QuantidadeCaesG()
        {
            Exception excecao = null;
            try
            {
                string data = "17/08/2020";
                CanilNegocio negCanil = new CanilNegocio();
                negCanil.BuscarMelhorCanil(data, 1, -22);
            }
            catch (Exception ex)
            {
                excecao = ex;
            }            
            Assert.IsNotNull(excecao);
            Assert.AreEqual(excecao.Message, "Valor incorreto de caes grandes");



        }
    }
}
