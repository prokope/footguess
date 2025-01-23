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
    public partial class champions1 : Form
    {
        public champions1()
        {
            InitializeComponent();
            VariaveisGlobais.QntdAcertosChampions = 0;
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
            VariaveisGlobais.QntdAcertosChampions = 0;
            VariaveisGlobais.QntdAcertosChampions += 1;
            champions2 FormChampions2 = new champions2();
            FormChampions2.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            champions2 FormChampions2 = new champions2();
            FormChampions2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            champions2 FormChampions2 = new champions2();
            FormChampions2.ShowDialog();
            this.Close();
        }
    }
}
