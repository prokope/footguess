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
    public partial class restam11_rma_completo : Form
    {
        public restam11_rma_completo()
        {
            InitializeComponent();
            label1.Text = VariaveisGlobais.NomeUsuario.ToString();
            VariaveisGlobais.BotaoRealMadridAtivo = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += .1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
