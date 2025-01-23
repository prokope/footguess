using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace footguess_fecip
{
    public partial class _1_Restam11 : Form
    {
        public _1_Restam11()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {  
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += .1;
        }

        private void buttonvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.BotaoRealMadridAtivo == true)
            {
                VariaveisGlobais.IdQuizSelecionado = 4;
                restam11_rma formRestam11_Rma = new restam11_rma();
                formRestam11_Rma.ShowDialog();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.BotaoBarcelonaAtivo == true)
            {
                VariaveisGlobais.IdQuizSelecionado = 5;
                restam11_barca formRestam11_barca = new restam11_barca();
                formRestam11_barca.ShowDialog();
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.BotaoPSGAtivo == true)
            {
                VariaveisGlobais.IdQuizSelecionado = 6;
                restam11_psg formRestam11_psg = new restam11_psg();
                formRestam11_psg.ShowDialog();
                this.Close();
            }
        }

        private void buttonvoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.BotaoFlamengoAtivo == true)
            {
                VariaveisGlobais.IdQuizSelecionado = 7;
                restam11_fla formRestam11_fla = new restam11_fla();
                formRestam11_fla.ShowDialog();
                this.Close();
            }
        }
    }
}
