
namespace footguess_fecip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botao_comecar_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.NomeUsuario = textBox1.Text.ToString();

            if (string.IsNullOrWhiteSpace(VariaveisGlobais.NomeUsuario))
            {
                MessageBox.Show("Erro, informe um nome.");
            }

            else
            {
                Modos FormModos = new Modos();
                FormModos.ShowDialog();
            }
        }

        private void botao_comecar_MouseHover(object sender, EventArgs e)
        {
            botao_comecar.BackColor = Color.FromArgb(60, 179, 113);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += .2;
        }
    }
}