using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgramaAurora.Model
{
    public class MelhorJogada
    {        
        CategoriaAurora categoriaAurora = new CategoriaAurora();
        CategoriaUns categoriaUns = new CategoriaUns();
        CategoriaDois categoriaDois = new CategoriaDois();
        CategoriaTres categoriaTres = new CategoriaTres();
        CategoriaQuatro categoriaQuatro = new CategoriaQuatro();
        CategoriaCinco categoriaCinco = new CategoriaCinco();
        CategoriaSeis categoriaSeis = new CategoriaSeis();
        CategoriaPar categoriaPar = new CategoriaPar();
        CategoriaDoisPares categoriaDoisPares = new CategoriaDoisPares();
        CategoriaTrio categoriaTrio = new CategoriaTrio();
        CategoriaQuadra categoriaQuadra = new CategoriaQuadra();
        CategoriaFullHouse categoriaFullHouse = new CategoriaFullHouse();
        CategoriaSequenciaMaior categoriaSequenciaMaior = new CategoriaSequenciaMaior();
        CategoriaSequenciaMenor categoriaSequenciaMenor = new CategoriaSequenciaMenor();

        public int pontosTotal { get; set; }                     

        public string MostrarMelhorJogada(ValoresDoDado valoresDoDado)
        {
            int[] pontos = new int[]
            {
                categoriaAurora.calcularPontos(valoresDoDado),
                categoriaUns.calcularPontos(valoresDoDado),
                categoriaDois.calcularPontos(valoresDoDado),
                categoriaTres.calcularPontos(valoresDoDado),
                categoriaQuatro.calcularPontos(valoresDoDado),
                categoriaCinco.calcularPontos(valoresDoDado),
                categoriaSeis.calcularPontos(valoresDoDado),
                categoriaPar.calcularPontos(valoresDoDado),
                categoriaDoisPares.calcularPontos(valoresDoDado, categoriaPar.calcularPontos(valoresDoDado)),
                categoriaTrio.calcularPontos(valoresDoDado),
                categoriaQuadra.calcularPontos(valoresDoDado),
                categoriaFullHouse.calcularPontos(valoresDoDado),
                categoriaSequenciaMaior.calcularPontos(valoresDoDado),
                categoriaSequenciaMenor.calcularPontos(valoresDoDado)
            };            

            Array.Sort(pontos);                     

            pontosTotal = pontos[13];

            if (pontos[13] == categoriaAurora.calcularPontos(valoresDoDado))
            {
                return "Aurora";
            }

            else if (pontos[13] == categoriaFullHouse.calcularPontos(valoresDoDado))
            {
                return "Full House";
            }

            else if (pontos[13] == categoriaSequenciaMaior.calcularPontos(valoresDoDado))
            {
                return "Sequência maior";
            }

            else if (pontos[13] == categoriaSequenciaMenor.calcularPontos(valoresDoDado))
            {
                return "Sequência menor";
            }

            else if (pontos[13] == categoriaQuadra.calcularPontos(valoresDoDado))
            {
                return "quadra";
            }

            else if (pontos[13] == categoriaTrio.calcularPontos(valoresDoDado))
            {
                return "trio";
            }

            else if (pontos[13] == categoriaDoisPares.calcularPontos(valoresDoDado, categoriaPar.calcularPontos(valoresDoDado)))
            {
                return "dois pares";
            }

            else if (pontos[13] == categoriaPar.calcularPontos(valoresDoDado))
            {
                return "par";
            }

            else if (pontos[13] == categoriaSeis.calcularPontos(valoresDoDado))
            {
                return "seis";
            }

            else if (pontos[13] == categoriaCinco.calcularPontos(valoresDoDado))
            {
                return "cinco";
            }

            else if (pontos[13] == categoriaQuatro.calcularPontos(valoresDoDado))
            {
                return "quatro";
            }

            else if (pontos[13] == categoriaTres.calcularPontos(valoresDoDado))
            {
                return "três";
            }

            else if (pontos[13] == categoriaDois.calcularPontos(valoresDoDado))
            {
                return "dois";
            }

            else if (pontos[13] == categoriaUns.calcularPontos(valoresDoDado))
            {
                return "uns";
            }
            return null;
        }
    }
}