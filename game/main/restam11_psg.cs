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
    public partial class restam11_psg : Form
    {
        public restam11_psg()
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            VariaveisGlobais.BotaoPSGAtivo = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.QntdAcertosPSG = 0;
            if (textBox1.Text.ToLower() == "mbappe")
            {
                label1.Text = "✓";
                label1.ForeColor = Color.Lime;
                textBox1.Enabled = false;
                VariaveisGlobais.QntdAcertosPSG += 1;
            }
            else if (textBox1.Text.ToLower() == "mbappé")
            {
                label1.Text = "✓";
                label1.ForeColor = Color.Lime;
                textBox1.Enabled = false;
                VariaveisGlobais.QntdAcertosPSG += 1;
            }
            else
            {
                label1.Text = "X";
                label1.ForeColor = Color.Red;
            }
            if (textBox2.Text.ToLower() == "neymar")
            {
                label2.Text = "✓";
                label2.ForeColor = Color.Lime;
                textBox2.Enabled = false;
                VariaveisGlobais.QntdAcertosPSG += 1;
            }
            else if (textBox1.Text.ToLower() == "neymar jr")
            {
                label2.Text = "✓";
                label2.ForeColor = Color.Lime;
                textBox2.Enabled = false;
                VariaveisGlobais.QntdAcertosPSG += 1;
            }
            else
            {
                label2.Text = "X";
                label2.ForeColor = Color.Red;
            }
            if (textBox3.Text.ToLower() == "messi")
            {
                label3.Text = "✓";
                label3.ForeColor = Color.Lime;
                textBox3.Enabled = false;
                VariaveisGlobais.QntdAcertosPSG += 1;
            }
            else
            {
                label3.Text = "X";
                label3.ForeColor = Color.Red;
            }
            if (textBox4.Text.ToLower() == "verratti")
            {
                label4.Text = "✓";
                label4.ForeColor = Color.Lime;
                textBox4.Enabled = false;
                VariaveisGlobais.QntdAcertosPSG += 1;
            }
            else
            {
                label4.Text = "X";
                label4.ForeColor = Color.Red;
            }
            if (textBox5.Text.ToLower() == "vitinha")
            {
                label5.Text = "✓";
                label5.ForeColor = Color.Lime;
                textBox5.Enabled = false;
                VariaveisGlobais.QntdAcertosPSG += 1;
            }
            else
            {
                label5.Text = "X";
                label5.ForeColor = Color.Red;
            }
            if (textBox6.Text.ToLower() == "renato sanches")
            {
                label6.Text = "✓";
                label6.ForeColor = Color.Lime;
                textBox6.Enabled = false;
                VariaveisGlobais.QntdAcertosPSG += 1;
            }
            else if (textBox6.Text.ToLower() == "sanches")
            {
                label6.Text = "✓";
                label6.ForeColor = Color.Lime;
                textBox6.Enabled = false;
                VariaveisGlobais.QntdAcertosPSG += 1;
            }
            else
            {
                label6.Text = "X";
                label6.ForeColor = Color.Red;
            }
            if (textBox7.Text.ToLower() == "ramos")
            {
                label7.Text = "✓";
                label7.ForeColor = Color.Lime;
                textBox7.Enabled = false;
                VariaveisGlobais.QntdAcertosPSG += 1;
            }
            else if (textBox7.Text.ToLower() == "sergio ramos")
            {
                label7.Text = "✓";
                label7.ForeColor = Color.Lime;
                textBox7.Enabled = false;
                VariaveisGlobais.QntdAcertosPSG += 1;
            }

            else
            {
                label7.Text = "X";
                label7.ForeColor = Color.Red;
            }
            if (textBox8.Text.ToLower() == "marquinhos")
            {
                label8.Text = "✓";
                label8.ForeColor = Color.Lime;
                textBox8.Enabled = false;
                VariaveisGlobais.QntdAcertosPSG += 1;
            }
            else
            {
                label8.Text = "X";
                label8.ForeColor = Color.Red;
            }
            if (textBox9.Text.ToLower() == "nuno mendes")
            {
                label9.Text = "✓";
                label9.ForeColor = Color.Lime;
                textBox9.Enabled = false;
                VariaveisGlobais.QntdAcertosPSG += 1;
            }
            else if (textBox9.Text.ToLower() == "mendes")
            {
                label9.Text = "✓";
                label9.ForeColor = Color.Lime;
                textBox9.Enabled = false;
                VariaveisGlobais.QntdAcertosPSG += 1;
            }

            else
            {
                label9.Text = "X";
                label9.ForeColor = Color.Red;
            }
            if (textBox10.Text.ToLower() == "hakimi")
            {
                label10.Text = "✓";
                label10.ForeColor = Color.Lime;
                textBox10.Enabled = false;
                VariaveisGlobais.QntdAcertosPSG += 1;
            }
            else
            {
                label10.Text = "X";
                label10.ForeColor = Color.Red;
            }
            if (textBox11.Text.ToLower() == "donnarumma")
            {
                label11.Text = "✓";
                label11.ForeColor = Color.Lime;
                textBox11.Enabled = false;
                VariaveisGlobais.QntdAcertosPSG += 1;
            }
            else
            {
                label11.Text = "X";
                label11.ForeColor = Color.Red;
            }
        }
    }
}
