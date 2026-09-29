namespace ClinicaVeterinariaForms
{
    partial class FrmCadastroTutor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNomeTutor = new TextBox();
            lblNomeTutor = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            mTxtTelefone = new MaskedTextBox();
            lblTelefoneTutor = new Label();
            mTxtCpf = new MaskedTextBox();
            lblCpfTutor = new Label();
            btnCadastrarTutor = new Button();
            SuspendLayout();
            // 
            // txtNomeTutor
            // 
            txtNomeTutor.Location = new Point(27, 57);
            txtNomeTutor.Name = "txtNomeTutor";
            txtNomeTutor.Size = new Size(207, 23);
            txtNomeTutor.TabIndex = 0;
            // 
            // lblNomeTutor
            // 
            lblNomeTutor.AutoSize = true;
            lblNomeTutor.Location = new Point(27, 39);
            lblNomeTutor.Name = "lblNomeTutor";
            lblNomeTutor.Size = new Size(99, 15);
            lblNomeTutor.TabIndex = 1;
            lblNomeTutor.Text = "Nome Completo:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(27, 119);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(207, 23);
            txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(27, 101);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // mTxtTelefone
            // 
            mTxtTelefone.Location = new Point(27, 180);
            mTxtTelefone.Mask = "(00) 00000-0000";
            mTxtTelefone.Name = "mTxtTelefone";
            mTxtTelefone.Size = new Size(100, 23);
            mTxtTelefone.TabIndex = 4;
            // 
            // lblTelefoneTutor
            // 
            lblTelefoneTutor.AutoSize = true;
            lblTelefoneTutor.Location = new Point(28, 162);
            lblTelefoneTutor.Name = "lblTelefoneTutor";
            lblTelefoneTutor.Size = new Size(55, 15);
            lblTelefoneTutor.TabIndex = 5;
            lblTelefoneTutor.Text = "Telefone:";
            // 
            // mTxtCpf
            // 
            mTxtCpf.Location = new Point(28, 247);
            mTxtCpf.Mask = "000.000.000-00";
            mTxtCpf.Name = "mTxtCpf";
            mTxtCpf.Size = new Size(100, 23);
            mTxtCpf.TabIndex = 6;
            // 
            // lblCpfTutor
            // 
            lblCpfTutor.AutoSize = true;
            lblCpfTutor.Location = new Point(28, 229);
            lblCpfTutor.Name = "lblCpfTutor";
            lblCpfTutor.Size = new Size(31, 15);
            lblCpfTutor.TabIndex = 7;
            lblCpfTutor.Text = "CPF:";
            // 
            // btnCadastrarTutor
            // 
            btnCadastrarTutor.BackColor = Color.FromArgb(255, 128, 0);
            btnCadastrarTutor.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnCadastrarTutor.FlatAppearance.BorderSize = 0;
            btnCadastrarTutor.ForeColor = Color.White;
            btnCadastrarTutor.Location = new Point(28, 304);
            btnCadastrarTutor.Name = "btnCadastrarTutor";
            btnCadastrarTutor.Size = new Size(206, 25);
            btnCadastrarTutor.TabIndex = 8;
            btnCadastrarTutor.Text = "Cadastrar";
            btnCadastrarTutor.UseVisualStyleBackColor = false;
            btnCadastrarTutor.Click += btnCadastrarTutor_Click;
            // 
            // FrmCadastroTutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrarTutor);
            Controls.Add(lblCpfTutor);
            Controls.Add(mTxtCpf);
            Controls.Add(lblTelefoneTutor);
            Controls.Add(mTxtTelefone);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblNomeTutor);
            Controls.Add(txtNomeTutor);
            Name = "FrmCadastroTutor";
            Text = "Cadastro Tutor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeTutor;
        private Label lblNomeTutor;
        private TextBox txtEmail;
        private Label lblEmail;
        private MaskedTextBox mTxtTelefone;
        private Label lblTelefoneTutor;
        private MaskedTextBox mTxtCpf;
        private Label lblCpfTutor;
        private Button btnCadastrarTutor;
    }
}