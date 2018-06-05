using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgramaAurora.Model
{
    public class CategoriaDoisPares: Categoria
    {
        public int calcularPontos(ValoresDoDado valoresDoDado, int par)
        {
            ordenarDado(valoresDoDado);
            Boolean primeiraVez = true;
            Pontos = 0;
            var dados = valoresDoDado.ValorDados.GroupBy(x => x).Select(a => new { Item = a.Key, Quant = a.Count() }).ToArray();

            foreach (var a in dados)
            {
                if (a.Quant == 2)
                {
                    if (primeiraVez)
                    {
                        primeiraVez = false;
                        continue;
                    }

                    else
                    {
                        Pontos = a.Item * 2 + par;
                        return Pontos;
                    }
                }
            }
            return Pontos;
        }
    }
}