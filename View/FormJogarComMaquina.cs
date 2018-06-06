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
        Boolean vezDoJogador = true;
        int rodadas;

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

                lblVezDoJogador.Text = "Vez do jogador 1";
            }
        }        

        private void btnVerificar_Click_1(object sender, EventArgs e)
        {
            var melhorJogada = new MelhorJogada();
            var valoresDoDado1 = new ValoresDoDado();
            var mostrarFaceImg = new MostrarFaceImg();            

            valoresDoDado1 = valoresDoDado;                       

            valoresDoDado1.atribuiValores(Dado1, Dado2, Dado3, Dado4, Dado5);

            pictureBox1.Image = Image.FromFile(mostrarFaceImg.ImagemDoDado(valoresDoDado1.ValorDados[0], Dado1));
            pictureBox2.Image = Image.FromFile(mostrarFaceImg.ImagemDoDado(valoresDoDado1.ValorDados[1], Dado2));
            pictureBox3.Image = Image.FromFile(mostrarFaceImg.ImagemDoDado(valoresDoDado1.ValorDados[2], Dado3));
            pictureBox4.Image = Image.FromFile(mostrarFaceImg.ImagemDoDado(valoresDoDado1.ValorDados[3], Dado4));
            pictureBox5.Image = Image.FromFile(mostrarFaceImg.ImagemDoDado(valoresDoDado1.ValorDados[4], Dado5));

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;

            pnlSelecao.Visible = true;
            btnVerificar.Visible = false;
        }



        private void btnSalvarCategoria_Click_1(object sender, EventArgs e)
        {
            if (rodadas < 9)
            {
                var categoriaSelecionada = new CategoriaSelecionada();
                var valoresDoDado1 = new ValoresDoDado();

                valoresDoDado1 = valoresDoDado;

                if (vezDoJogador == true)
                {
                    if (rbAurora.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(1, valoresDoDado1);
                        jogador1.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
                    }

                    else if (rbFullHouse.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(2, valoresDoDado1);
                        jogador1.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
                    }

                    else if (rbSequenciaMaior.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(3, valoresDoDado1);
                        jogador1.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
                    }

                    else if (rbSequenciaMenor.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(4, valoresDoDado1);
                        jogador1.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
                    }

                    else if (rbQuadra.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(5, valoresDoDado1);
                        jogador1.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
                    }

                    else if (rbTrio.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(6, valoresDoDado1);
                        jogador1.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
                    }

                    else if (rbDoisPares.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(7, valoresDoDado1);
                        jogador1.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
                    }

                    else if (rbPar.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(8, valoresDoDado1);
                        jogador1.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
                    }

                    else if (rbSeis.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(9, valoresDoDado1);
                        jogador1.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
                    }

                    else if (rbCinco.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(10, valoresDoDado1);
                        jogador1.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
                    }

                    else if (rbQuatro.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(11, valoresDoDado1);
                        jogador1.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
                    }

                    else if (rbTres.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(12, valoresDoDado1);
                        jogador1.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
                    }

                    else if (rbDois.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(13, valoresDoDado1);
                        jogador1.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
                    }

                    else if (rbUns.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(14, valoresDoDado1);
                        jogador1.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador1.Text = "Pontos: " + jogador1.Pontos.ToString();
                    }
                    lblVezDoJogador.Text = "Vez do jogador 2";
                    vezDoJogador = false;
                }


                else if (vezDoJogador == false)
                {
                    if (rbAurora.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(1, valoresDoDado1);
                        jogador2.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador2.Text = "Pontos: " + jogador2.Pontos.ToString();
                    }

                    else if (rbFullHouse.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(2, valoresDoDado1);
                        jogador2.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador2.Text = "Pontos: " + jogador2.Pontos.ToString();
                    }

                    else if (rbSequenciaMaior.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(3, valoresDoDado1);
                        jogador2.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador2.Text = "Pontos: " + jogador2.Pontos.ToString();
                    }

                    else if (rbSequenciaMenor.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(4, valoresDoDado1);
                        jogador2.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador2.Text = "Pontos: " + jogador2.Pontos.ToString();
                    }

                    else if (rbQuadra.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(5, valoresDoDado1);
                        jogador2.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador2.Text = "Pontos: " + jogador2.Pontos.ToString();
                    }

                    else if (rbTrio.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(6, valoresDoDado1);
                        jogador2.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador2.Text = "Pontos: " + jogador2.Pontos.ToString();
                    }

                    else if (rbDoisPares.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(7, valoresDoDado1);
                        jogador2.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador2.Text = "Pontos: " + jogador2.Pontos.ToString();
                    }

                    else if (rbPar.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(8, valoresDoDado1);
                        jogador2.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador2.Text = "Pontos: " + jogador2.Pontos.ToString();
                    }

                    else if (rbSeis.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(9, valoresDoDado1);
                        jogador2.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador2.Text = "Pontos: " + jogador2.Pontos.ToString();
                    }

                    else if (rbCinco.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(10, valoresDoDado1);
                        jogador2.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador2.Text = "Pontos: " + jogador2.Pontos.ToString();
                    }

                    else if (rbQuatro.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(11, valoresDoDado1);
                        jogador2.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador2.Text = "Pontos: " + jogador2.Pontos.ToString();
                    }

                    else if (rbTres.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(12, valoresDoDado1);
                        jogador2.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador2.Text = "Pontos: " + jogador2.Pontos.ToString();
                    }

                    else if (rbDois.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(13, valoresDoDado1);
                        jogador2.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador2.Text = "Pontos: " + jogador2.Pontos.ToString();
                    }

                    else if (rbUns.Checked)
                    {
                        int pontosDaRodada = categoriaSelecionada.categoriaSelecionada(14, valoresDoDado1);
                        jogador2.Pontos += pontosDaRodada;
                        string pontuou = "Você marcou {0} pontos nesta rodada";
                        pontuou = string.Format(pontuou, pontosDaRodada.ToString());
                        MessageBox.Show(pontuou);
                        lblPontosJogador2.Text = "Pontos: " + jogador2.Pontos.ToString();
                    }
                    vezDoJogador = true;
                    lblVezDoJogador.Text = "Vez do jogador 1";
                }

                pnlSelecao.Visible = false;
                btnVerificar.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
            }

            else
            {
                string fimDeJogo = "Fim do jogo \n O vencedor é {0}";

                if (jogador1.Pontos > jogador2.Pontos)
                {
                    fimDeJogo = string.Format(fimDeJogo, "Jogador 1");
                    MessageBox.Show(fimDeJogo);                    
                }

                else if (jogador1.Pontos < jogador2.Pontos)
                {
                    fimDeJogo = string.Format(fimDeJogo, "Jogador 2");
                    MessageBox.Show(fimDeJogo);
                }

                else
                    MessageBox.Show("Fim do jogo \n Deu empate");                
            }

            rodadas++;
        }
    }
}


