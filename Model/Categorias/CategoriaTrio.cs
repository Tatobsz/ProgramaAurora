using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgramaAurora.Model
{
    public class CategoriaTrio: Categoria
    {
        public int calcularPontos(ValoresDoDado valoresDoDado)
        {
            ordenarDado(valoresDoDado);
            Pontos = 0;

            var dados = valoresDoDado.ValorDados.GroupBy(x => x).Select(a => new { Item = a.Key, Quant = a.Count() }).ToArray();

            foreach (var a in dados)
            {
                if (a.Quant == 3)
                {
                    Pontos = a.Item * 3;
                    return Pontos;
                }
            }

            return Pontos;
        }
    }
}