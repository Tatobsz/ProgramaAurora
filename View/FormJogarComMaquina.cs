using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramaAurora.Model;


namespace ProgramaAurora
{
    public partial class FormJogarComMaquina : Form
    {
        public FormJogarComMaquina()
        {
            InitializeComponent();
        }

        Jogador jogador1 = new Jogador();
        Jogador jogador2 = new Jogador();
        ErrorProvider erro = new ErrorProvider();
        Dado Dado1 = new Dado();
        Dado Dado2 = new Dado();
        Dado Dado3 = new Dado();
        Dado Dado4 = new Dado();
        Dado Dado5 = new Dado();
        ValoresDoDado valoresDoDado = new ValoresDoDado();
        MostrarFaceImg mostrarFaceImg = new MostrarFaceImg();
        MelhorJogada melhorJogada = new MelhorJogada();
        CategoriaSelecionada categoriaSelecionada = new CategoriaSelecionada();


        public bool ValidarNomeSePreenchido()
        {
            bool valido = true;

            if (txtJogador1.Text == "" && txtJogador2.Text == "")
            {
                valido = false;
                erro.SetError(txtJogador1, "Um dos nomes deve ser preenchido");
            }
            return valido;
        }

        public void LimparMenssagemErro()
        {
            erro.SetError(txtJogador1, "");
        }

        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {
            LimparMenssagemErro();

            if (ValidarNomeSePreenchido())
            {
                jogador1.Nome = txtJogador1.Text;
                jogador2.Nome = txtJogador2.Text;

                lblJogador1.Text = jogador1.Nome;
                lblJogador2.Text = jogador2.Nome;

                lblPontosJogador2.Text = "Pontos: " + jogador1.Pontos.ToString();
                lblPontosJogador1.Text = "Pontos: " + jogador2.Pontos.ToString();

                lblPontosJogador2.Visible = true;
                lblPontosJogador1.Visible = true;

                txtJogador1.Visible = false;
                txtJogador2.Visible = false;
                btnIniciarJogo.Visible = false;
                splitContainer2.Visible = true;
            }
        }        

        private void btnVerificar_Click_1(object sender, EventArgs e)
        {
            /*
            var Dado1 = new Dado();
            var Dado2 = new Dado();
            var Dado3 = new Dado();
            var Dado4 = new Dado();
            var Dado5 = new Dado();         
            var valoresDoDado = new ValoresDoDado();
            var mostrarFaceImg = new MostrarFaceImg();
            var melhorJogada = new MelhorJogada();*/

            valoresDoDado.atribuiValores(Dado1, Dado2, Dado3, Dado4, Dado5);

            pictureBox1.Image = Image.FromFile(mostrarFaceImg.ImagemDoDado(valoresDoDado.ValorDados[0], Dado1));
            pictureBox2.Image = Image.FromFile(mostrarFaceImg.ImagemDoDado(valoresDoDado.ValorDados[1], Dado2));
            pictureBox3.Image = Image.FromFile(mostrarFaceImg.ImagemDoDado(valoresDoDado.ValorDados[2], Dado3));
            pictureBox4.Image = Image.FromFile(mostrarFaceImg.ImagemDoDado(valoresDoDado.ValorDados[3], Dado4));
            pictureBox5.Image = Image.FromFile(mostrarFaceImg.ImagemDoDado(valoresDoDado.ValorDados[4], Dado5));

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
        }

        private void btnSalvarCategoria_Click(object sender, EventArgs e)
        {            
            if (rbAurora.Checked)
            {
                int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(1, valoresDoDado);
                jogador1.Pontos += pontosDaRodada;
                string pontuou = "Você marcou {0} pontos nesta rodada";
                pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                MessageBox.Show(pontuou);
                lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
            }

            else if (rbFullHouse.Checked)
            {
                int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(2, valoresDoDado);
                jogador1.Pontos += pontosDaRodada;
                string pontuou = "Você marcou {0} pontos nesta rodada";
                pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                MessageBox.Show(pontuou);
                lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
            }

            else if (rbSequenciaMaior.Checked)
            {
                int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(3, valoresDoDado);
                jogador1.Pontos += pontosDaRodada;
                string pontuou = "Você marcou {0} pontos nesta rodada";
                pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                MessageBox.Show(pontuou);
                lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
            }

            else if (rbSequenciaMenor.Checked)
            {
                int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(4, valoresDoDado);
                jogador1.Pontos += pontosDaRodada;
                string pontuou = "Você marcou {0} pontos nesta rodada";
                pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                MessageBox.Show(pontuou);
                lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
            }

            else if (rbQuadra.Checked)
            {
                int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(5, valoresDoDado);
                jogador1.Pontos += pontosDaRodada;
                string pontuou = "Você marcou {0} pontos nesta rodada";
                pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                MessageBox.Show(pontuou);
                lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
            }

            else if (rbTrio.Checked)
            {
                int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(6, valoresDoDado);
                jogador1.Pontos += pontosDaRodada;
                string pontuou = "Você marcou {0} pontos nesta rodada";
                pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                MessageBox.Show(pontuou);
                lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
            }

            else if (rbDoisPares.Checked)
            {
                int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(7, valoresDoDado);
                jogador1.Pontos += pontosDaRodada;
                string pontuou = "Você marcou {0} pontos nesta rodada";
                pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                MessageBox.Show(pontuou);
                lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
            }

            else if (rbPar.Checked)
            {
                int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(8, valoresDoDado);
                jogador1.Pontos += pontosDaRodada;
                string pontuou = "Você marcou {0} pontos nesta rodada";
                pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                MessageBox.Show(pontuou);
                lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
            }

            else if (rbSeis.Checked)
            {
                int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(9, valoresDoDado);
                jogador1.Pontos += pontosDaRodada;
                string pontuou = "Você marcou {0} pontos nesta rodada";
                pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                MessageBox.Show(pontuou);
                lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
            }

            else if (rbCinco.Checked)
            {
                int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(10, valoresDoDado);
                jogador1.Pontos += pontosDaRodada;
                string pontuou = "Você marcou {0} pontos nesta rodada";
                pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                MessageBox.Show(pontuou);
                lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
            }

            else if (rbQuatro.Checked)
            {
                int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(11, valoresDoDado);
                jogador1.Pontos += pontosDaRodada;
                string pontuou = "Você marcou {0} pontos nesta rodada";
                pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                MessageBox.Show(pontuou);
                lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
            }

            else if (rbTres.Checked)
            {
                int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(12, valoresDoDado);
                jogador1.Pontos += pontosDaRodada;
                string pontuou = "Você marcou {0} pontos nesta rodada";
                pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                MessageBox.Show(pontuou);
                lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
            }

            else if (rbDois.Checked)
            {
                int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(13, valoresDoDado);
                jogador1.Pontos += pontosDaRodada;
                string pontuou = "Você marcou {0} pontos nesta rodada";
                pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                MessageBox.Show(pontuou);
                lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
            }

            else if (rbUns.Checked)
            {
                int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(14, valoresDoDado);
                jogador1.Pontos += pontosDaRodada;
                string pontuou = "Você marcou {0} pontos nesta rodada";
                pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                MessageBox.Show(pontuou);
                lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
            }
        }
    }
}


