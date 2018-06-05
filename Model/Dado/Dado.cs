using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgramaAurora.Model
{
    public class Dado
    {        
        public int[] Faces { get; set; } = new int[6];        
        
        public string[] FotoFace { get; set; } = new string[6];

        public Dado()
        {
            Faces[0] = 1;
            Faces[1] = 2;
            Faces[2] = 3;
            Faces[3] = 4;
            Faces[4] = 5;
            Faces[5] = 6;            

            FotoFace[0] = "C:\\Users\\welk2\\Desktop\\SoftwareAurora-master\\Resources\\Dado1.jpeg";

            FotoFace[1] = "C:\\Users\\welk2\\Desktop\\SoftwareAurora-master\\Resources\\Dado2.jpeg";

            FotoFace[2] = "C:\\Users\\welk2\\Desktop\\SoftwareAurora-master\\Resources\\Dado3.jpeg";

            FotoFace[3] = "C:\\Users\\welk2\\Desktop\\SoftwareAurora-master\\Resources\\Dado4.jpeg";

            FotoFace[4] = "C:\\Users\\welk2\\Desktop\\SoftwareAurora-master\\Resources\\Dado5.jpeg";

            FotoFace[5] = "C:\\Users\\welk2\\Desktop\\SoftwareAurora-master\\Resources\\Dado6.jpeg";
        }

        public int JogarDados()
        {
            Random random = new Random();
            int aux = random.Next(1, 7);

            switch (aux)
            {
                case 1:
                    return Faces[0];

                case 2:
                    return Faces[1];

                case 3:
                    return Faces[2];

                case 4:
                    return Faces[3];

                case 5:
                    return Faces[4];

                case 6:
                    return Faces[5];
            }

            return aux;
        }
    }
}