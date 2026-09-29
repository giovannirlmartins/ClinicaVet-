using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicaVeterinariaForms
{
    public partial class FrmPaginaInicial : Form
    {
        public FrmPaginaInicial()
        {
            InitializeComponent();
        }

        private void tutorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // precisa chamar a tela de cadastro de alunos
            FrmCadastroTutor cadastroTutor = new FrmCadastroTutor();
            cadastroTutor.TopLevel = false;
            cadastroTutor.FormBorderStyle = FormBorderStyle.None;
            cadastroTutor.Dock = DockStyle.Fill;
            pnlPaginaInicial.Controls.Clear();
            pnlPaginaInicial.Controls.Add(cadastroTutor);
            cadastroTutor.Show();
        }
    }
}
