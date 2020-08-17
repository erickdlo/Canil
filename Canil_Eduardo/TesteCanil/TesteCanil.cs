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
        public void Teste_Sucesso_MelhorPetShop_MeuCaninoFeliz_DiaDeSemana()
        {
            string data = "17/08/2020";
            CanilNegocio negCanil = new CanilNegocio();
            MelhorPetShop retorno = negCanil.BuscarMelhorPetShop(data, 1, 1);
            Assert.AreEqual(retorno.NomeCanil, "Meu Canino Feliz");
            Assert.AreEqual(retorno.PrecoTotal, 60);
        }
        [TestMethod]
        public void Teste_Sucesso_MelhorPetShop_MeuCaninoFeliz_FinalDeSemana()
        {
            string data = "16/08/2020";
            CanilNegocio negCanil = new CanilNegocio();
            MelhorPetShop retorno = negCanil.BuscarMelhorPetShop(data, 1, 1);
            Assert.AreEqual(retorno.NomeCanil, "Meu Canino Feliz");
            Assert.AreEqual(retorno.PrecoTotal, 72);
        }
        [TestMethod]
        public void Teste_Sucesso_MelhorPetShop_VaiRex_DiaDeSemana()
        {
            string data = "17/08/2020";
            CanilNegocio negCanil = new CanilNegocio();
            MelhorPetShop retorno = negCanil.BuscarMelhorPetShop(data, 3, 1);
            Assert.AreEqual(retorno.NomeCanil, "Vai Rex");
            Assert.AreEqual(retorno.PrecoTotal, 95);
        }
        [TestMethod]
        public void Teste_Sucesso_MelhorPetShop_VaiRex_FinalDeSemana()
        {
            string data = "16/08/2020";
            CanilNegocio negCanil = new CanilNegocio();
            MelhorPetShop retorno = negCanil.BuscarMelhorPetShop(data, 3, 1);
            Assert.AreEqual(retorno.NomeCanil, "Vai Rex");
            Assert.AreEqual(retorno.PrecoTotal, 115);
        }
        [TestMethod]
        public void Teste_Sucesso_MelhorPetShop_ChowChawgas_FinalDeSemana()
        {
            string data = "16/08/2020";
            CanilNegocio negCanil = new CanilNegocio();
            MelhorPetShop retorno = negCanil.BuscarMelhorPetShop(data, 1, 4);
            Assert.AreEqual(retorno.NomeCanil, "Chow Chawgas");
            Assert.AreEqual(retorno.PrecoTotal, 210);
        }
        [TestMethod]
        public void Teste_Sucesso_MelhorPetShop_ChowChawgas_Empate_MeuCaninoFeliz_FinalDeSemana()
        {
            string data = "16/08/2020";
            CanilNegocio negCanil = new CanilNegocio();
            MelhorPetShop retorno = negCanil.BuscarMelhorPetShop(data, 1, 2);
            Assert.AreEqual(retorno.NomeCanil, "Chow Chawgas");
            Assert.AreEqual(retorno.PrecoTotal, 120);
        }
        
        [TestMethod]
        public void Teste_Falha_QuantidadeCaesP()
        {
            Exception excecao = null;
            try
            {
                string data = "17/08/2020";
                CanilNegocio negCanil = new CanilNegocio();
                negCanil.BuscarMelhorPetShop(data, -11, 2);
            }
            catch (Exception ex)
            {
                excecao = ex;
            }
            Assert.IsNotNull(excecao);
            Assert.AreEqual(excecao.Message, "Valor incorreto de caes pequenos");
        }
        [TestMethod]
        public void Teste_Falha_QuantidadeCaesG()
        {
            Exception excecao = null;
            try
            {
                string data = "17/08/2020";
                CanilNegocio negCanil = new CanilNegocio();
                negCanil.BuscarMelhorPetShop(data, 1, -22);
            }
            catch (Exception ex)
            {
                excecao = ex;
            }            
            Assert.IsNotNull(excecao);
            Assert.AreEqual(excecao.Message, "Valor incorreto de caes grandes");
        }
        [TestMethod]
        public void Teste_Falha_QuantidadeCaesP_e_QuantidadeCaesG_IgualZero()
        {
            Exception excecao = null;
            try
            {
                string data = "17/08/2020";
                CanilNegocio negCanil = new CanilNegocio();
                negCanil.BuscarMelhorPetShop(data, 0, 0);
            }
            catch (Exception ex)
            {
                excecao = ex;
            }
            Assert.IsNotNull(excecao);
            Assert.AreEqual(excecao.Message, "Valor incorreto de caes grandes e caes pequenos");
        }
        [TestMethod]
        public void Teste_Falha_Data_Vazia()
        {
            Exception excecao = null;
            try
            {
                string data = "";
                CanilNegocio negCanil = new CanilNegocio();
                negCanil.BuscarMelhorPetShop(data, 1, 1);
            }
            catch (Exception ex)
            {
                excecao = ex;
            }
            Assert.IsNotNull(excecao);
            Assert.AreEqual(excecao.Message, "Valor de Data incorreto");
        }
    }
}
