using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgramaAurora.Model
{
    public class ValoresDoDado
    {
        public int[] ValorDados { get; set; } = new int[5];
        public int[] ValorDadosFrequencia { get; set; } = new int[5];

        public void atribuiValores(Dado Dado1, Dado Dado2, Dado Dado3, Dado Dado4, Dado Dado5)
        {
            int[] aux = new int[5];
            
            aux[0] = Dado1.JogarDados();
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(0.2));
            aux[1] = Dado2.JogarDados();
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(0.2));
            aux[2] = Dado3.JogarDados();
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(0.2));
            aux[3] = Dado4.JogarDados();
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(0.2));
            aux[4] = Dado5.JogarDados();

            ValorDados[0] = aux[0];
            ValorDados[1] = aux[1];
            ValorDados[2] = aux[2];
            ValorDados[3] = aux[3];
            ValorDados[4] = aux[4];

            ValorDadosFrequencia[0] = aux[0];
            ValorDadosFrequencia[1] = aux[1];
            ValorDadosFrequencia[2] = aux[2];
            ValorDadosFrequencia[3] = aux[3];
            ValorDadosFrequencia[4] = aux[4];
        }
    }
}