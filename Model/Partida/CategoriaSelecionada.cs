using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramaAurora.Model;

namespace ProgramaAurora.Model
{
    class CategoriaSelecionada
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


        public int categoriaSelecionada(int comboBox1, ValoresDoDado valoresDoDado)
        {
            if (comboBox1 == 1)
            {
                categoriaAurora.calcularPontos(valoresDoDado);
                return categoriaAurora.Pontos;
            }

            if (comboBox1 == 2)
            {
                categoriaFullHouse.calcularPontos(valoresDoDado);
                return categoriaFullHouse.Pontos;
            }

            if (comboBox1 == 3)
            {
                categoriaSequenciaMaior.calcularPontos(valoresDoDado);
                return categoriaSequenciaMaior.Pontos;
            }

            if (comboBox1 == 4)
            {
                categoriaSequenciaMenor.calcularPontos(valoresDoDado);
                return categoriaSequenciaMenor.Pontos;
            }


            if (comboBox1 == 5)
            {
                categoriaQuadra.calcularPontos(valoresDoDado);
                return categoriaQuadra.Pontos;
            }


            if (comboBox1 == 6)
            {
                categoriaTrio.calcularPontos(valoresDoDado);
                return categoriaTrio.Pontos;
            }


            if (comboBox1 == 7)
            {
                categoriaDoisPares.calcularPontos(valoresDoDado, categoriaPar.calcularPontos(valoresDoDado));
                return categoriaDoisPares.Pontos;
            }


            if (comboBox1 == 8)
            {
                categoriaPar.calcularPontos(valoresDoDado);
                return categoriaPar.Pontos;
            }


            if (comboBox1 == 9)
            {
                categoriaSeis.calcularPontos(valoresDoDado);
                return categoriaSeis.Pontos;
            }


            if (comboBox1 == 10)
            {
                categoriaCinco.calcularPontos(valoresDoDado);
                return categoriaCinco.Pontos;
            }


            if (comboBox1 == 11)
            {
                categoriaQuatro.calcularPontos(valoresDoDado);
                return categoriaQuatro.Pontos;
            }


            if (comboBox1 == 12)
            {
                categoriaTres.calcularPontos(valoresDoDado);
                return categoriaTres.Pontos;
            }


            if (comboBox1 == 13)
            {
                categoriaDois.calcularPontos(valoresDoDado);
                return categoriaDois.Pontos;
            }


            if (comboBox1 == 14)
            {
                categoriaUns.calcularPontos(valoresDoDado);
                return categoriaUns.Pontos;
            }

            return 0;
        }
    }
}
