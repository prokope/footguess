namespace footguess_fecip
{
    public partial class restam11_psg_completo : Form
    {
        public restam11_psg_completo()
        {
            InitializeComponent();
            label1.Text = VariaveisGlobais.NomeUsuario.ToString();
            VariaveisGlobais.BotaoPSGAtivo = false;
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
