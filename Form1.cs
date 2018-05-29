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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dado Dado = new Dado();
        Categoria categoria = new Categoria();

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Dado Dado = new Dado();
            Dado.Faces[0] = int.Parse(txtDado1.Text);
            Dado.Faces[1] = int.Parse(txtDado2.Text);
            Dado.Faces[2] = int.Parse(txtDado3.Text);
            Dado.Faces[3] = int.Parse(txtDado4.Text);
            Dado.Faces[4] = int.Parse(txtDado5.Text);
            
            lblUns.Text = "Na categoria 'Uns' você faz " + categoria.uns(Dado).ToString() + " pontos";
            lblDois.Text = "Na categoria 'Dois' você faz " + categoria.dois(Dado).ToString() + " pontos";
            lblTres.Text = "Na categoria 'Três' você faz " + categoria.três(Dado).ToString() + " pontos";
            lblQuatro.Text = "Na categoria 'Quatro' você faz " + categoria.quatro(Dado).ToString() + " pontos";
            lblCinco.Text = "Na categoria 'Cinco' você faz " + categoria.cinco(Dado).ToString() + " pontos";
            lblSeis.Text = "Na categoria 'Seis' você faz " + categoria.seis(Dado).ToString() + " pontos";
            //lblPar.Text = "Na categoria 'Par' você faz " + categoria.par(Dado).ToString() + " pontos";
            //lblDoisPares.Text = "Na categoria 'DoisPares' você faz " + categoria.doisPares(Dado).ToString() + " pontos";
            //lblTrio.Text = "Na categoria 'Trio' você faz " + categoria.trio(Dado).ToString() + " pontos";
            //lblQuadra.Text = "Na categoria 'Quadra' você faz " + categoria.quadra(Dado).ToString() + " pontos";
            //lblSequenciaMenor.Text = "Na categoria 'Sequência Menor' você faz " + categoria.sequenciaMenor(Dado).ToString() + " pontos";
            //lblSequenciaMaior.Text = "Na categoria 'Sequência Maior' você faz " + categoria.sequenciaMaior(Dado).ToString() + " pontos";
            //lblFullHouse.Text = "Na categoria 'Full House' você faz " + categoria.fullHouse(Dado).ToString() + " pontos";
            lblAurora.Text = "Na categoria 'Aurora' você faz " + categoria.aurora(Dado).ToString() + " pontos";
        }      
    }
}
