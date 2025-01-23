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
    public partial class restam11_fla : Form
    {
        public restam11_fla()
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
            VariaveisGlobais.BotaoFlamengoAtivo = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.QntdAcertosFLA == 11)
            {
                restam11_fla_completo FormFlaCheck = new restam11_fla_completo();
                FormFlaCheck.ShowDialog();
            }

            VariaveisGlobais.QntdAcertosFLA = 0;
            if (textBox1.Text.ToLower() == "gabigol")
            {
                label1.Text = "✓";
                label1.ForeColor = Color.Lime;
                textBox1.Enabled = false;
                VariaveisGlobais.QntdAcertosFLA += 1;
            }
            else if (textBox1.Text.ToLower() == "gabi")
            {
                label1.Text = "✓";
                label1.ForeColor = Color.Lime;
                textBox1.Enabled = false;
                VariaveisGlobais.QntdAcertosFLA += 1;
            }
            else
            {
                label1.Text = "X";
                label1.ForeColor = Color.Red;
            }
            if (textBox2.Text.ToLower() == "bruno henrique")
            {
                label2.Text = "✓";
                label2.ForeColor = Color.Lime;
                textBox2.Enabled = false;
                VariaveisGlobais.QntdAcertosFLA += 1;
            }
            else if (textBox2.Text.ToLower() == "henrique")
            {
                label2.Text = "✓";
                label2.ForeColor = Color.Lime;
                textBox2.Enabled = false;
                VariaveisGlobais.QntdAcertosFLA += 1;
            }
            else if (textBox2.Text.ToLower() == "b henrique")
            {
                label2.Text = "✓";
                label2.ForeColor = Color.Lime;
                textBox2.Enabled = false;
                VariaveisGlobais.QntdAcertosFLA += 1;
            }
            else
            {
                label2.Text = "X";
                label2.ForeColor = Color.Red;
            }
            if (textBox3.Text.ToLower() == "everton ribeiro")
            {
                label3.Text = "✓";
                label3.ForeColor = Color.Lime;
                textBox3.Enabled = false;
                VariaveisGlobais.QntdAcertosFLA += 1;
            }
            else if (textBox3.Text.ToLower() == "ribeiro")
            {
                label3.Text = "✓";
                label3.ForeColor = Color.Lime;
                textBox3.Enabled = false;
                VariaveisGlobais.QntdAcertosFLA += 1;
            }
            else
            {
                label3.Text = "X";
                label3.ForeColor = Color.Red;
            }
            if (textBox4.Text.ToLower() == "arrascaeta")
            {
                label4.Text = "✓";
                label4.ForeColor = Color.Lime;
                textBox4.Enabled = false;
                VariaveisGlobais.QntdAcertosFLA += 1;
            }
            else if (textBox4.Text.ToLower() == "de arrascaeta")
            {
                label4.Text = "✓";
                label4.ForeColor = Color.Lime;
                textBox4.Enabled = false;
                VariaveisGlobais.QntdAcertosFLA += 1;
            }
            else
            {
                label4.Text = "X";
                label4.ForeColor = Color.Red;
            }
            if (textBox5.Text.ToLower() == "gerson")
            {
                label5.Text = "✓";
                label5.ForeColor = Color.Lime;
                textBox5.Enabled = false;
                VariaveisGlobais.QntdAcertosFLA += 1;
            }
            else
            {
                label5.Text = "X";
                label5.ForeColor = Color.Red;
            }
            if (textBox6.Text.ToLower() == "arao")
            {
                label6.Text = "✓";
                label6.ForeColor = Color.Lime;
                textBox6.Enabled = false;
                VariaveisGlobais.QntdAcertosFLA += 1;
            }
            else if (textBox6.Text.ToLower() == "arão")
            {
                label6.Text = "✓";
                label6.ForeColor = Color.Lime;
                textBox6.Enabled = false;
                VariaveisGlobais.QntdAcertosFLA += 1;
            }
            else if (textBox6.Text.ToLower() == "willian arão")
            {
                label6.Text = "✓";
                label6.ForeColor = Color.Lime;
                textBox6.Enabled = false;
                VariaveisGlobais.QntdAcertosFLA += 1;
            }
            else if (textBox6.Text.ToLower() == "willian arao")
            {
                label6.Text = "✓";
                label6.ForeColor = Color.Lime;
                textBox6.Enabled = false;
                VariaveisGlobais.QntdAcertosFLA += 1;
            }
            else
            {
                label6.Text = "X";
                label6.ForeColor = Color.Red;
            }
            if (textBox7.Text.ToLower() == "pablo mari")
            {
                label7.Text = "✓";
                label7.ForeColor = Color.Lime;
                textBox7.Enabled = false;
                VariaveisGlobais.QntdAcertosFLA += 1;
            }
            else if (textBox7.Text.ToLower() == "pablo marí")
            {
                label7.Text = "✓";
                label7.ForeColor = Color.Lime;
                textBox7.Enabled = false;
            }
            else if (textBox7.Text.ToLower() == "marí")
            {
                label7.Text = "✓";
                label7.ForeColor = Color.Lime;
                textBox7.Enabled = false;
            }
            else if (textBox6.Text.ToLower() == "mari")
            {
                label7.Text = "✓";
                label7.ForeColor = Color.Lime;
                textBox7.Enabled = false;
            }
            else
            {
                label7.Text = "X";
                label7.ForeColor = Color.Red;
            }
            if (textBox8.Text.ToLower() == "rodrigo caio")
            {
                label8.Text = "✓";
                label8.ForeColor = Color.Lime;
                textBox8.Enabled = false;
                VariaveisGlobais.QntdAcertosFLA += 1;
            }
            else if (textBox8.Text.ToLower() == "caio")
            {
                label8.Text = "✓";
                label8.ForeColor = Color.Lime;
                textBox8.Enabled = false;
                VariaveisGlobais.QntdAcertosFLA += 1;
            }
            else
            {
                label8.Text = "X";
                label8.ForeColor = Color.Red;
            }
            if (textBox9.Text.ToLower() == "filipe luis")
            {
                label9.Text = "✓";
                label9.ForeColor = Color.Lime;
                textBox9.Enabled = false;
                VariaveisGlobais.QntdAcertosFLA += 1;
            }
            else if (textBox9.Text.ToLower() == "filipe luís")
            {
                label9.Text = "✓";
                label9.ForeColor = Color.Lime;
                textBox9.Enabled = false;
            }
            else if (textBox9.Text.ToLower() == "luís")
            {
                label9.Text = "✓";
                label9.ForeColor = Color.Lime;
                textBox9.Enabled = false;
                VariaveisGlobais.QntdAcertosFLA += 1;
            }
            else if (textBox9.Text.ToLower() == "luis")
            {
                label9.Text = "✓";
                label9.ForeColor = Color.Lime;
                textBox9.Enabled = false;
                VariaveisGlobais.QntdAcertosFLA += 1;
            }
            else
            {
                label9.Text = "X";
                label9.ForeColor = Color.Red;
            }
            if (textBox10.Text.ToLower() == "rafinha")
            {
                label10.Text = "✓";
                label10.ForeColor = Color.Lime;
                textBox10.Enabled = false;
                VariaveisGlobais.QntdAcertosFLA += 1;
            }
            else
            {
                label10.Text = "X";
                label10.ForeColor = Color.Red;
            }
            if (textBox11.Text.ToLower() == "diego alves")
            {
                label11.Text = "✓";
                label11.ForeColor = Color.Lime;
                textBox11.Enabled = false;
                VariaveisGlobais.QntdAcertosFLA += 1;
            }
            else if (textBox11.Text.ToLower() == "alves")
            {
                label11.Text = "✓";
                label11.ForeColor = Color.Lime;
                textBox11.Enabled = false;
                VariaveisGlobais.QntdAcertosFLA += 1;
            }
            else
            {
                label11.Text = "X";
                label11.ForeColor = Color.Red;
            }
        }
    }
}
