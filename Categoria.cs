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

        private Dado ordenarDado(Dado dado)
        {
            Array.Sort(dado.Faces);
            return dado;
        }

	    public int uns(Dado dado)
        {
            ordenarDado(dado);
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
            ordenarDado(dado);
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
            ordenarDado(dado);
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
            ordenarDado(dado);
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
            ordenarDado(dado);
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
            ordenarDado(dado);
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
            ordenarDado(dado);

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
            ordenarDado(dado);
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
            ordenarDado(dado);
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
            ordenarDado(dado);
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
            ordenarDado(dado);
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
            ordenarDado(dado);
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
            ordenarDado(dado);
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
            ordenarDado(dado);
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
