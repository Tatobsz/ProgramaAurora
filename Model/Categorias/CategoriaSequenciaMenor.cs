using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgramaAurora.Model
{
    public class CategoriaSequenciaMenor: Categoria
    {
        public int calcularPontos(ValoresDoDado valoresDoDado)
        {
            ordenarDado(valoresDoDado);
            int[] numTeste1 = new int[4] { 1, 2, 3, 4 };
            int[] numTeste2 = new int[4] { 2, 3, 4, 5 };
            int[] numTeste3 = new int[4] { 3, 4, 5, 6 };
            Pontos = 0;

            eliminarRepeticoes(valoresDoDado);

            if (valoresDoDado.ValorDadosFrequencia.Length >= 4)
            {
                if (valoresDoDado.ValorDadosFrequencia[0] == numTeste1[0] &&
                valoresDoDado.ValorDadosFrequencia[1] == numTeste1[1] &&
                valoresDoDado.ValorDadosFrequencia[2] == numTeste1[2] &&
                valoresDoDado.ValorDadosFrequencia[3] == numTeste1[3])
                {
                    return Pontos = 15;
                }

                else if (valoresDoDado.ValorDadosFrequencia[1] == numTeste1[0] &&
                  valoresDoDado.ValorDadosFrequencia[2] == numTeste1[1] &&
                  valoresDoDado.ValorDadosFrequencia[3] == numTeste1[2] &&
                  valoresDoDado.ValorDadosFrequencia[4] == numTeste1[3])
                {
                    return Pontos = 15;
                }

                else if (valoresDoDado.ValorDadosFrequencia[1] == numTeste2[0] &&
                  valoresDoDado.ValorDadosFrequencia[2] == numTeste2[1] &&
                  valoresDoDado.ValorDadosFrequencia[3] == numTeste2[2] &&
                  valoresDoDado.ValorDadosFrequencia[4] == numTeste2[3])
                {
                    return Pontos = 15;
                }

                else if (valoresDoDado.ValorDadosFrequencia[0] == numTeste2[0] &&
                    valoresDoDado.ValorDadosFrequencia[1] == numTeste2[1] &&
                    valoresDoDado.ValorDadosFrequencia[2] == numTeste2[2] &&
                    valoresDoDado.ValorDadosFrequencia[3] == numTeste2[3])
                {
                    return Pontos = 15;
                }
                else if (valoresDoDado.ValorDadosFrequencia[0] == numTeste3[0] &&
                    valoresDoDado.ValorDadosFrequencia[1] == numTeste3[1] &&
                    valoresDoDado.ValorDadosFrequencia[2] == numTeste3[2] &&
                    valoresDoDado.ValorDadosFrequencia[3] == numTeste3[3])
                {
                    return Pontos = 15;
                }
            }
            return Pontos;
        }
    }
}