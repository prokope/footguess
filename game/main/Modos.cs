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
    public partial class Modos : Form
    {
        public Modos()
        {
            InitializeComponent();
            label1.Text = VariaveisGlobais.NomeUsuario.ToString();
            timer1.Start();
        }
        private void timerba_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += .1;
        }

        private void botao_escolher_r11_Click(object sender, EventArgs e)
        {
            _1_Restam11 FormRestam11 = new _1_Restam11();
            FormRestam11.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botao_escolher_br_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.BotaoQualOTimeAtivo == true)
            {
                VariaveisGlobais.IdQuizSelecionado = 2;
                _1_Qual_O_Time FormQual_O_Time = new _1_Qual_O_Time();
                FormQual_O_Time.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.BotaoChampionsLeagueAtivo == true)
            {
                VariaveisGlobais.IdQuizSelecionado = 3;
                champions1 FormChampions = new champions1();
                FormChampions.ShowDialog();
            }
        }
    }
}
