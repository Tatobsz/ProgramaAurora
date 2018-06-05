using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgramaAurora.Model
{
    public class CategoriaSeis: Categoria
    {
        public int calcularPontos(ValoresDoDado valoresDoDado)
        {
            ordenarDado(valoresDoDado);
            Pontos = 0;

            foreach (var face in valoresDoDado.ValorDados)
            {
                if (face == 6)
                {
                   Pontos += face;
                }
            }
            return Pontos;
        }
    }
}