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
    public partial class champions6 : Form
    {
        public champions6()
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
            champions7 FormChampions4 = new champions7();
            FormChampions4.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            champions7 FormChampions7 = new champions7();
            FormChampions7.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            champions7 FormChampions7 = new champions7();
            FormChampions7.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            champions7 FormChampions7 = new champions7();
            FormChampions7.ShowDialog();
            this.Close();
        }
    }
}
