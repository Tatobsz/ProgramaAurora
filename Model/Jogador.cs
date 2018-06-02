using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaAurora
{
    class Jogador
    {
        public string Nome { get; set; }
        public int Pontos { get; set; }

        public Jogador()
        {
            Nome = "Jogador*";
            Pontos = 0;
        }

        public void somarPontos(int pontos)
        {
            Pontos += pontos;            
        }
    }
}
