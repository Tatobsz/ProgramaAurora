using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgramaAurora.Model
{
    public class MostrarFaceImg
    {
        public string ImagemDoDado(int FaceDado, Dado dado)
        {
            if (FaceDado == 1)
            {
                return dado.FotoFace[0];
            }

            else if (FaceDado == 2)
            {
                return dado.FotoFace[1];
            }

            else if (FaceDado == 3)
            {
                return dado.FotoFace[2];
            }

            else if (FaceDado == 4)
            {
                return dado.FotoFace[3];
            }

            else if (FaceDado == 5)
            {
                return dado.FotoFace[4];
            }

            else if (FaceDado == 6)
            {
                return dado.FotoFace[5];
            }
            return null;
        }
    }
}