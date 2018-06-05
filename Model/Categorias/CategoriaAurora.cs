using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgramaAurora.Model
{
    public class CategoriaAurora : Categoria
    {
        public int calcularPontos(ValoresDoDado valoresDoDado)
        {
            ordenarDado(valoresDoDado);   
            Pontos = 0;
            Boolean iguais = false;

            for (int i = 0; i < 4; i++)
            {
                if (valoresDoDado.ValorDados[i] == valoresDoDado.ValorDados[i + 1])
                {
                    iguais = true;
                    continue;
                }

                else
                {
                    iguais = false;
                    break;
                }
            }

            if (iguais == true)
            {
                Pontos = 50;
                return Pontos;
            }

            else
            {
                return Pontos;
            }
        }
    }
}