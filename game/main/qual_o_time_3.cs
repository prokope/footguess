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
    public partial class qual_o_time_3 : Form
    {
        public qual_o_time_3()
        {
            InitializeComponent();
            VariaveisGlobais.Tempo = 10;
            label1.Text = VariaveisGlobais.Tempo.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += .1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (VariaveisGlobais.Tempo == 0)
            {
                timer2.Stop();
                qual_o_time_4 FormQualOTime4 = new qual_o_time_4();
                FormQualOTime4.ShowDialog();
                this.Close();
            }
            else
            {
                VariaveisGlobais.Tempo -= 1;
                label1.Text = VariaveisGlobais.Tempo.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            qual_o_time_4 FormQualOTime4 = new qual_o_time_4();
            FormQualOTime4.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            qual_o_time_4 FormQualOTime4 = new qual_o_time_4();
            FormQualOTime4.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.QntdAcertosQualOTime += 1;
            timer2.Stop();
            qual_o_time_4 FormQualOTime4 = new qual_o_time_4();
            FormQualOTime4.ShowDialog();
            this.Close();
        }
    }
}
