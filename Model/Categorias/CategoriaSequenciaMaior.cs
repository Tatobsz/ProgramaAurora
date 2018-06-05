using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgramaAurora.Model
{
    public class CategoriaSequenciaMaior : Categoria
    {
        public int calcularPontos(ValoresDoDado valoresDoDado)
        {
            ordenarDado(valoresDoDado);
            
            int[] numTeste1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] numTeste2 = new int[5] { 2, 3, 4, 5, 6 };
            Pontos = 0;

            eliminarRepeticoes(valoresDoDado);

            if (valoresDoDado.ValorDadosFrequencia.Length == 5)
            {
                if (valoresDoDado.ValorDadosFrequencia[0] == numTeste1[0] &&
                    valoresDoDado.ValorDadosFrequencia[1] == numTeste1[1] &&
                    valoresDoDado.ValorDadosFrequencia[2] == numTeste1[2] &&
                    valoresDoDado.ValorDadosFrequencia[3] == numTeste1[3] &&
                    valoresDoDado.ValorDadosFrequencia[4] == numTeste1[4])
                {
                    return Pontos = 20;
                }

                else if (valoresDoDado.ValorDadosFrequencia[0] == numTeste2[0] &&
                    valoresDoDado.ValorDadosFrequencia[1] == numTeste2[1] &&
                    valoresDoDado.ValorDadosFrequencia[2] == numTeste2[2] &&
                    valoresDoDado.ValorDadosFrequencia[3] == numTeste2[3] &&
                    valoresDoDado.ValorDadosFrequencia[4] == numTeste2[4])
                {
                    return Pontos = 20;
                }
            }
            return Pontos;
        }
    }
}