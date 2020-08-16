using System;
using Canil_Eduardo.Modelos;

namespace Canil_Eduardo.Services
{
    public class CanilNegocio
    {
        public MelhorCanil BuscarMelhorCanil(string data, int caesP, int caesG)
        {
            int dataNumero = ValidarData(data);
            ValidarValorCaes(caesP, caesG);
            MelhorCanil melhorCanil;

            if (dataNumero == 6 || dataNumero == 0)
            {
                melhorCanil = CalcularFinalDeSemana(caesP, caesG);
            }
            else
            {
                melhorCanil = CalcularDiaDeSemana(caesP, caesG);
            }
            return melhorCanil;

        }

        private void ValidarValorCaes(int caesP, int caesG)
        {
            if (caesP < 0)
            {
                throw new Exception("Valor incorreto de caes pequenos");
            }else if (caesG < 0)
            {
                throw new Exception("Valor incorreto de caes grandes");
            }

        }
        private int ValidarData(string data)
        {
            try
            {
                int dataNumero;
                DateTime date = DateTime.Parse(data);
                dataNumero = ((int)date.DayOfWeek);
                return dataNumero;
            }
            catch
            {
                throw new Exception("Formato de Data Incorreto");
            }
        }
        private MelhorCanil CalcularFinalDeSemana(int caesP, int caesG)
        {
            double meuCaninoFeliz;
            double vaiRex;
            double chowChawgas;
            string nome;
            double valor;
            meuCaninoFeliz = ((caesP * (20 * 1.2)) + caesG * (40 * 1.2));
            vaiRex = ((caesP * 20) + (caesG * 55));
            chowChawgas = ((caesP * 30) + (caesG * 45));
            if (chowChawgas <= vaiRex && chowChawgas <= meuCaninoFeliz)
            {
                nome = "Chow Chawgas";
                valor = chowChawgas;
                MelhorCanil retorno = new MelhorCanil
                {
                    NomeCanil = nome,
                    PrecoTotal = valor
                };
                return retorno;
            }
            else if (vaiRex < chowChawgas && vaiRex <= meuCaninoFeliz)
            {
                nome = "Vai Rex";
                valor = vaiRex;
                MelhorCanil retorno = new MelhorCanil
                {
                    NomeCanil = nome,
                    PrecoTotal = valor
                };
                return retorno;
            }
            else
            {
                nome = "Meu Canino Feliz";
                valor = meuCaninoFeliz;
                MelhorCanil retorno = new MelhorCanil
                {
                    NomeCanil = nome,
                    PrecoTotal = valor
                };
                return retorno;
            }
        }

        private MelhorCanil CalcularDiaDeSemana(int caesP, int caesG)
        {
            double meuCaninoFeliz;
            double vaiRex;
            double chowChawgas;
            string nome;
            double valor;
            meuCaninoFeliz = ((caesP * 20) + (caesG * 40));
            vaiRex = ((caesP * 15) + (caesG * 50));
            chowChawgas = ((caesP * 30) + (caesG * 45));
            if (chowChawgas <= vaiRex && chowChawgas <= meuCaninoFeliz)
            {
                nome = "Chow Chawgas";
                valor = chowChawgas;
                MelhorCanil retorno = new MelhorCanil
                {
                    NomeCanil = nome,
                    PrecoTotal = valor
                };
                return retorno;
            }
            else if (vaiRex < chowChawgas && vaiRex <= meuCaninoFeliz)
            {
                nome = "Vai Rex";
                valor = vaiRex;
                MelhorCanil retorno = new MelhorCanil
                {
                    NomeCanil = nome,
                    PrecoTotal = valor
                };
                return retorno;
            }
            else
            {
                nome = "Meu Canino Feliz";
                valor = meuCaninoFeliz;
                MelhorCanil retorno = new MelhorCanil
                {
                    NomeCanil = nome,
                    PrecoTotal = valor
                };
                return retorno;
            }
        }

    }
}
