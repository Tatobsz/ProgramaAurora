using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgramaAurora.Model
{
    public class Jogador
    {        
        public string Nome { get; set; }
        public int Pontos { get; set; }

        public Jogador()
        {
            Pontos = 0;
        }

        public int fazerJogada(int escolhaCategoria)
        {
            if(escolhaCategoria == 1)
            {
                var categoria = new CategoriaUns();
                Pontos += categoria.Pontos;
                return Pontos;
            }

            else if (escolhaCategoria == 2)
            {
                var categoria = new CategoriaDois();
                Pontos += categoria.Pontos;
                return Pontos;
            }

            else if (escolhaCategoria == 3)
            {
                var categoria = new CategoriaTres();
                Pontos += categoria.Pontos;
                return Pontos;
            }

            else if (escolhaCategoria == 4)
            {
                var categoria = new CategoriaQuatro();
                Pontos += categoria.Pontos;
                return Pontos;
            }

            else if (escolhaCategoria == 5)
            {
                var categoria = new CategoriaCinco();
                Pontos += categoria.Pontos;
                return Pontos;
            }

            else if (escolhaCategoria == 6)
            {
                var categoria = new CategoriaSeis();
                Pontos += categoria.Pontos;
                return Pontos;
            }

            else if (escolhaCategoria == 7)
            {
                var categoria = new CategoriaPar();
                Pontos += categoria.Pontos;
                return Pontos;
            }
            else if (escolhaCategoria == 8)
            {
                var categoria = new CategoriaDoisPares();
                Pontos += categoria.Pontos;
                return Pontos;
            }

            else if (escolhaCategoria == 9)
            {
                var categoria = new CategoriaTrio();
                Pontos += categoria.Pontos;
                return Pontos;
            }

            else if (escolhaCategoria == 10)
            {
                var categoria = new CategoriaQuadra();
                Pontos += categoria.Pontos;
                return Pontos;
            }

            else if (escolhaCategoria == 11)
            {
                var categoria = new CategoriaFullHouse();
                Pontos += categoria.Pontos;
                return Pontos;
            }

            else if (escolhaCategoria == 12)
            {
                var categoria = new CategoriaAurora();
                Pontos += categoria.Pontos;
                return Pontos;
            }

            else if (escolhaCategoria == 13)
            {
                var categoria = new CategoriaSequenciaMenor();
                Pontos += categoria.Pontos;
                return Pontos;
            }

            else if (escolhaCategoria == 14)
            {
                var categoria = new CategoriaSequenciaMaior();
                Pontos += categoria.Pontos;
                return Pontos;
            }
            return Pontos;
        }
    }
}