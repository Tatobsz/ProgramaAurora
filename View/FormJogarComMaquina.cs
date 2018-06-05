using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        Categoria categoria = new Categoria();        

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

        bool rodada = true;

        private void btnVerificar_Click_1(object sender, EventArgs e)
        {            
            Dado Dado = new Dado();

            label1.Text = Convert.ToString(Dado.RodarDados());
            label2.Text = Convert.ToString(Dado.RodarDados());
            label3.Text = Convert.ToString(Dado.RodarDados());
            label4.Text = Convert.ToString(Dado.RodarDados());
            label5.Text = Convert.ToString(Dado.RodarDados());

            Dado.Faces[0] = int.Parse(label1.Text);
            Dado.Faces[1] = int.Parse(label2.Text);
            Dado.Faces[2] = int.Parse(label3.Text);
            Dado.Faces[3] = int.Parse(label4.Text);
            Dado.Faces[4] = int.Parse(label5.Text);

            Dado.FaceSequencia[0] = int.Parse(label1.Text);
            Dado.FaceSequencia[1] = int.Parse(label2.Text);
            Dado.FaceSequencia[2] = int.Parse(label3.Text);
            Dado.FaceSequencia[3] = int.Parse(label4.Text);
            Dado.FaceSequencia[4] = int.Parse(label5.Text);

            pictureBox1.Image = Image.FromFile(categoria.ImagemDoDado(Dado.Faces[0], Dado));
            pictureBox2.Image = Image.FromFile(categoria.ImagemDoDado(Dado.Faces[1], Dado));
            pictureBox3.Image = Image.FromFile(categoria.ImagemDoDado(Dado.Faces[2], Dado));
            pictureBox4.Image = Image.FromFile(categoria.ImagemDoDado(Dado.Faces[3], Dado));
            pictureBox5.Image = Image.FromFile(categoria.ImagemDoDado(Dado.Faces[4], Dado));

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;            
            
            lblResposta.Text = "Indicamos que você use a categoria {0}, com {1} pontos";
            lblResposta.Text = string.Format(lblResposta.Text, categoria.Jogada(Dado), categoria.pontosTotal);
            lblResposta.Visible = true;

            if (rodada)
            {
                jogador1.somarPontos(categoria.pontosTotal);
                lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
                rodada = false;
            }

            else
            {
                jogador2.somarPontos(categoria.pontosTotal);
                lblPontosJogador2.Text = "Pontos: " + jogador2.Pontos.ToString();
                rodada = true;
            }
        }
    }
}


        