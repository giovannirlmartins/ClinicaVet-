using ClinicaVeterinaria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicaVeterinariaForms
{
    public partial class FrmCadastroTutor : Form
    {
        public FrmCadastroTutor()
        {
            InitializeComponent();
        }

        private void btnCadastrarTutor_Click(object sender, EventArgs e)
        {
            //chamar a função cadastrar tutor no meu banco de dados
            Tutor tutorCadastrar = new Tutor();
            tutorCadastrar.cpf = mTxtCpf.Text;
            tutorCadastrar.telefone = mTxtTelefone.Text;
            tutorCadastrar.email = txtEmail.Text;
            tutorCadastrar.nome = txtNomeTutor.Text;
            tutorCadastrar.CadastrarTutor(tutorCadastrar);
        }
    }
}
