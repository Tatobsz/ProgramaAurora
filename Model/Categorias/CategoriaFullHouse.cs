using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgramaAurora.Model
{
    public class CategoriaFullHouse: Categoria
    {
        public int calcularPontos(ValoresDoDado valoresDoDado)
        {
            ordenarDado(valoresDoDado);
            var CategoriaPar  = new CategoriaPar();
            var CategoriaTrio = new CategoriaTrio();

            Pontos = 0;

            if (CategoriaPar.calcularPontos(valoresDoDado) > 0 && CategoriaTrio.calcularPontos(valoresDoDado) > 0)
            {
                Pontos = CategoriaPar.calcularPontos(valoresDoDado) + CategoriaTrio.calcularPontos(valoresDoDado);
                return Pontos;
            }

            return Pontos;
        }
    }
}