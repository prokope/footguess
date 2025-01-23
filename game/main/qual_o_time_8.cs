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
    public partial class qual_o_time_8 : Form
    {
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
            VariaveisGlobais.BotaoQualOTimeAtivo = false;
            Modos FormModos = new Modos();
            FormModos.ShowDialog();
            this.Close();
        }
    }
}
