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
    public partial class champions5 : Form
    {
        public champions5()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += .1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.QntdAcertosChampions += 1;
            champions6 FormChampions6 = new champions6();
            FormChampions6.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            champions6 FormChampions6 = new champions6();
            FormChampions6.ShowDialog();
            this.Close();
        }
    }
}
