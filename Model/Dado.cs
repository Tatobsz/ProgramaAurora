using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaAurora
{
    class Dado
    {
        
        public int[] Faces { get; set; } = new int[5];
        public int[] FaceSequencia { get; set; } = new int[5];
        public string[] FaceDadoImg { get; set; } = new string[6];
        Random random = new Random();

        public Dado()
        {
            FaceDadoImg[0] = "C: \\Users\\wesle\\OneDrive\\Área de Trabalho\\SoftwareAurora\\Resources\\Dado1.jpeg";

            FaceDadoImg[1] = "C:\\Users\\wesle\\OneDrive\\Área de Trabalho\\SoftwareAurora\\Resources\\Dado2.jpeg";

            FaceDadoImg[2] = "C:\\Users\\wesle\\OneDrive\\Área de Trabalho\\SoftwareAurora\\Resources\\Dado3.jpeg";

            FaceDadoImg[3] = "C:\\Users\\wesle\\OneDrive\\Área de Trabalho\\SoftwareAurora\\Resources\\Dado4.jpeg";

            FaceDadoImg[4] = "C:\\Users\\wesle\\OneDrive\\Área de Trabalho\\SoftwareAurora\\Resources\\Dado5.jpeg";

            FaceDadoImg[5] = "C:\\Users\\wesle\\OneDrive\\Área de Trabalho\\SoftwareAurora\\Resources\\Dado6.jpeg";
        }        

        public int RodarDados()
        {
            return random.Next(1, 7);            
        }        
    }
}
