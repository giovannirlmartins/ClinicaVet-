using ClinicaVeterinariaForms.Classes;

namespace ClinicaVeterinariaForms
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void linkLblCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmCadastroUsuario telaCadastroUsuario = new FrmCadastroUsuario();
            telaCadastroUsuario.ShowDialog();
            this.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            bool logado = false;

            string usuarioDigitado = txtUsuario.Text;
            string senhaDigitada = txtSenha.Text;

            Usuario usuario = new Usuario();
            List<Usuario> listaUsuarioCadastrado = usuario.ListaUsuarios;

            if (logado == true)
            {
                //se o usuário e a senha conferem
                this.Hide();
                FrmPaginaInicial telaInicial = new FrmPaginaInicial();
                telaInicial.ShowDialog();
            }

        }
    }
}
