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
    public partial class champions8 : Form
    {
        public champions8()
        {
            InitializeComponent();
            label2.Text = VariaveisGlobais.NomeUsuario.ToString() + ",";
            label3.Text = VariaveisGlobais.QntdAcertosChampions.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += .1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.BotaoChampionsLeagueAtivo = false;
            Modos FormModos = new Modos();
            FormModos.ShowDialog();
            this.Close();
        }
    }
}
