using ClinicaVeterinariaForms.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicaVeterinariaForms
{
    public partial class FrmCadastroUsuario : Form
    {
        public FrmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.cpf = mTxtCpf.Text;
            usuario.nome = txtNome.Text;
            usuario.telefone = mTxtTelefone.Text;
            usuario.estado = cbBoxListaEstados.Text;
            usuario.senha = txtSenha.Text;
            usuario.CadastrarUsuario(usuario);

            Conexao banco = new Conexao();

            try
            {
                string dataSource = "datasource=localhost;username=root;password=;database=dbVetMais";
                
                Conexao conexao = new Conexao();
                string sql =
                    "INSERT INTO tutores (nome, telefone) " +
                    $"VALUES ({txtNome.Text}, {mTxtTelefone.Text}";
            }
            catch
            {

            }
            finally
            {

            }
                

                //MySqlCommand comando = new MySqlCommand(sql, conexao);

                //comando.Parameters.AddWithValue("@nome", txtNome.Text);
                //comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                //comando.Parameters.AddWithValue("@email", txtEmail.Text);

                
                //comando.ExecuteReader();
            }

        }
    }
}
