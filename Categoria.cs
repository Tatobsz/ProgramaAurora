using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaAurora
{
    class Categoria
    {
        Dado dado = new Dado();

        private void ordenarDado()
        {
            Array.Sort(dado.Faces);
        }

	    public int uns(Dado dado)
        {
            ordenarDado();
            int unsPontos = 0;            

            foreach (var face in dado.Faces)
            {
                if (face == 1)
                {
                    unsPontos += face;
                }
            }
            return unsPontos;
        }


        public int dois(Dado dado)
        {
            ordenarDado();
            int doisPontos = 0;

            foreach (var face in dado.Faces)
            {
                if (face == 2)
                {
                    doisPontos += face;
                }
            }
            return doisPontos;
        }


        public int três(Dado dado)
        {
            ordenarDado();
            int tresPontos = 0;

            foreach (var face in dado.Faces)
            {
                if (face == 3)
                {
                    tresPontos += face;
                }
            }
            return tresPontos;
        }


        public int quatro(Dado dado)
        {
            ordenarDado();
            int quatroPontos = 0;

            foreach (var face in dado.Faces)
            {
                if (face == 4)
                {
                    quatroPontos += face;
                }
            }
            return quatroPontos;
        }


        public int cinco(Dado dado)
        {
            ordenarDado();
            int cincoPontos = 0;

            foreach (var face in dado.Faces)
            {
                if (face == 5)
                {
                    cincoPontos += face;
                }
            }
            return cincoPontos;
        }


        public int seis(Dado dado)
        {
            ordenarDado();
            int seisPontos = 0;

            foreach (var face in dado.Faces)
            {
                if (face == 6)
                {
                    seisPontos += face;
                }
            }
            return seisPontos;
        }


        public int par(Dado dado)
        {
            ordenarDado();

            int parPontos = 0;

            for (int i = 0; i < 5; i++)
            {
                if (dado.Faces[i] == dado.Faces[i + 1])
                {
                    parPontos += dado.Faces[i];
                }
            }
            
            return parPontos;
        }


        public int doisPares(Dado dado)
        {
            ordenarDado();
            int doisParesPontos = 0;

            var contandoOsPares = dado.Faces
             .GroupBy(x => x)
             .Select(a => new
             {
                 Item = a.Key,
                 Quant = a.Count()
             })
             .ToArray();

            return doisParesPontos;
        }


        public int trio(Dado dado)
        {
            ordenarDado();
            int trioPontos = 0;
            foreach (var face in dado.Faces)
            {
                if (face == 1)
                {
                    trioPontos += face;
                }
            }
            return trioPontos;
        }


        public int quadra(Dado dado)
        {
            ordenarDado();
            int quadraPontos = 0;
            foreach (var face in dado.Faces)
            {
                if (face == 1)
                {
                    quadraPontos += face;
                }
            }
            return quadraPontos;
        }


        public int sequenciaMenor(Dado dado)
        {
            ordenarDado();
            int sequenciaMenorPontos = 0;
            foreach (var face in dado.Faces)
            {
                if (face == 1)
                {
                    sequenciaMenorPontos  += face;
                }
            }
            return sequenciaMenorPontos;
        }


        public int sequenciaMaior(Dado dado)
        {
            ordenarDado();
            int sequenciaMaiorPontos = 0;
            foreach (var face in dado.Faces)
            {
                if (face == 1)
                {
                    sequenciaMaiorPontos += face;
                }
            }
            return sequenciaMaiorPontos;
        }


        public int fullHouse(Dado dado)
        {
            ordenarDado();
            int fullHousePontos = 0;
            foreach (var face in dado.Faces)
            {
                if (face == 1)
                {
                    fullHousePontos += face;
                }
            }
            return fullHousePontos;
        }


        public int aurora(Dado dado)
        {
            ordenarDado();
            int auroraPontos = 0;
            Boolean iguais = false;

            for (int i = 0; i < 4; i++)
            {
                if (dado.Faces[i] == dado.Faces[i + 1])
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
                auroraPontos = 50;
                return auroraPontos;
            }

            else
            {
                return auroraPontos;
            }
        }
    }
}
