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
    public partial class restam11_barca : Form
    {
        public restam11_barca()
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
            this.Close();
            VariaveisGlobais.BotaoBarcelonaAtivo = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.QntdAcertosBAR = 0;
            if (textBox1.Text.ToLower() == "suarez")
            {
                label1.Text = "✓";
                label1.ForeColor = Color.Lime;
                textBox1.Enabled = false;
                VariaveisGlobais.QntdAcertosBAR += 1;
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
                VariaveisGlobais.QntdAcertosBAR += 1;

            }
            else if (textBox2.Text.ToLower() == "neymar jr")
            {
                label2.Text = "✓";
                label2.ForeColor = Color.Lime;
                textBox2.Enabled = false;
                VariaveisGlobais.QntdAcertosBAR += 1;

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
                VariaveisGlobais.QntdAcertosBAR += 1;

            }
            else
            {
                label3.Text = "X";
                label3.ForeColor = Color.Red;
            }
            if (textBox4.Text.ToLower() == "iniesta")
            {
                label4.Text = "✓";
                label4.ForeColor = Color.Lime;
                textBox4.Enabled = false;
                VariaveisGlobais.QntdAcertosBAR += 1;

            }
            else
            {
                label4.Text = "X";
                label4.ForeColor = Color.Red;
            }
            if (textBox5.Text.ToLower() == "busquets")
            {
                label5.Text = "✓";
                label5.ForeColor = Color.Lime;
                textBox5.Enabled = false;
                VariaveisGlobais.QntdAcertosBAR += 1;

            }
            else if (textBox5.Text.ToLower() == "sergio busquets")
            {
                label5.Text = "✓";
                label5.ForeColor = Color.Lime;
                textBox5.Enabled = false;
                VariaveisGlobais.QntdAcertosBAR += 1;
            }
            else
            {
                label5.Text = "X";
                label5.ForeColor = Color.Red;
            }
            if (textBox6.Text.ToLower() == "rakitic")
            {
                label6.Text = "✓";
                label6.ForeColor = Color.Lime;
                textBox6.Enabled = false;
                VariaveisGlobais.QntdAcertosBAR += 1;

            }
            else if (textBox6.Text.ToLower() == "rakitíc")
            {
                label6.Text = "✓";
                label6.ForeColor = Color.Lime;
                textBox6.Enabled = false;
                VariaveisGlobais.QntdAcertosBAR += 1;
            }
            else
            {
                label6.Text = "X";
                label6.ForeColor = Color.Red;
            }
            if (textBox7.Text.ToLower() == "pique")
            {
                label7.Text = "✓";
                label7.ForeColor = Color.Lime;
                textBox7.Enabled = false;
                VariaveisGlobais.QntdAcertosBAR += 1;

            }
            else if (textBox7.Text.ToLower() == "piqué")
            {
                label7.Text = "✓";
                label7.ForeColor = Color.Lime;
                textBox7.Enabled = false;
                VariaveisGlobais.QntdAcertosBAR += 1;

            }
            else
            {
                label7.Text = "X";
                label7.ForeColor = Color.Red;
            }
            if (textBox8.Text.ToLower() == "mascherano")
            {
                label8.Text = "✓";
                label8.ForeColor = Color.Lime;
                textBox8.Enabled = false;
                VariaveisGlobais.QntdAcertosBAR += 1;

            }
            else
            {
                label8.Text = "X";
                label8.ForeColor = Color.Red;
            }
            if (textBox9.Text.ToLower() == "alba")
            {
                label9.Text = "✓";
                label9.ForeColor = Color.Lime;
                textBox9.Enabled = false;
                VariaveisGlobais.QntdAcertosBAR += 1;

            }
            else if (textBox9.Text.ToLower() == "jordi alba")
            {
                label9.Text = "✓";
                label9.ForeColor = Color.Lime;
                textBox9.Enabled = false;
                VariaveisGlobais.QntdAcertosBAR += 1;

            }
            else
            {
                label9.Text = "X";
                label9.ForeColor = Color.Red;
            }
            if (textBox10.Text.ToLower() == "alves")
            {
                label10.Text = "✓";
                label10.ForeColor = Color.Lime;
                textBox10.Enabled = false;
                VariaveisGlobais.QntdAcertosBAR += 1;

            }
            else if (textBox10.Text.ToLower() == "dani alves")
            {
                label10.Text = "✓";
                label10.ForeColor = Color.Lime;
                textBox10.Enabled = false;
                VariaveisGlobais.QntdAcertosBAR += 1;

            }
            else if (textBox10.Text.ToLower() == "daniel alves")
            {
                label10.Text = "✓";
                label10.ForeColor = Color.Lime;
                textBox10.Enabled = false;
                VariaveisGlobais.QntdAcertosBAR += 1;

            }
            else
            {
                label10.Text = "X";
                label10.ForeColor = Color.Red;
            }
            if (textBox11.Text.ToLower() == "ter stegen")
            {
                label11.Text = "✓";
                label11.ForeColor = Color.Lime;
                textBox11.Enabled = false;
                VariaveisGlobais.QntdAcertosBAR += 1;

            }
            else if (textBox11.Text.ToLower() == "stegen")
            {
                label11.Text = "✓";
                label11.ForeColor = Color.Lime;
                textBox11.Enabled = false;
                VariaveisGlobais.QntdAcertosBAR += 1;

            }
            else
            {
                label11.Text = "X";
                label11.ForeColor = Color.Red;
            }
        }
    }
}