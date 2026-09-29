namespace ClinicaVeterinariaForms
{
    partial class FrmCadastroUsuario
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
            txtNome = new TextBox();
            lblNome = new Label();
            lblTelefone = new Label();
            mTxtTelefone = new MaskedTextBox();
            lblCpf = new Label();
            mTxtCpf = new MaskedTextBox();
            lblEstado = new Label();
            cbBoxListaEstados = new ComboBox();
            btnCadastrar = new Button();
            btnVoltar = new Button();
            lblSenha = new Label();
            txtSenha = new TextBox();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(22, 52);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(248, 23);
            txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Location = new Point(22, 34);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = Color.Transparent;
            lblTelefone.Location = new Point(22, 102);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(55, 15);
            lblTelefone.TabIndex = 2;
            lblTelefone.Text = "Telefone:";
            // 
            // mTxtTelefone
            // 
            mTxtTelefone.Location = new Point(22, 120);
            mTxtTelefone.Mask = "(00) 00000-0000";
            mTxtTelefone.Name = "mTxtTelefone";
            mTxtTelefone.Size = new Size(215, 23);
            mTxtTelefone.TabIndex = 3;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(22, 161);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(31, 15);
            lblCpf.TabIndex = 4;
            lblCpf.Text = "CPF:";
            // 
            // mTxtCpf
            // 
            mTxtCpf.Location = new Point(22, 179);
            mTxtCpf.Mask = "000.000.000-00";
            mTxtCpf.Name = "mTxtCpf";
            mTxtCpf.Size = new Size(122, 23);
            mTxtCpf.TabIndex = 5;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(22, 220);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado:";
            // 
            // cbBoxListaEstados
            // 
            cbBoxListaEstados.FormattingEnabled = true;
            cbBoxListaEstados.Items.AddRange(new object[] { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espirito Santo", "Goiás", "Maranhão", "Mato Grosso do Sul", "Mato Grosso", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins" });
            cbBoxListaEstados.Location = new Point(23, 238);
            cbBoxListaEstados.Name = "cbBoxListaEstados";
            cbBoxListaEstados.Size = new Size(121, 23);
            cbBoxListaEstados.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(225, 359);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(30, 359);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 9;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(22, 285);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 10;
            lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(22, 303);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(248, 23);
            txtSenha.TabIndex = 11;
            // 
            // FrmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(340, 416);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(btnVoltar);
            Controls.Add(btnCadastrar);
            Controls.Add(cbBoxListaEstados);
            Controls.Add(lblEstado);
            Controls.Add(mTxtCpf);
            Controls.Add(lblCpf);
            Controls.Add(mTxtTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Name = "FrmCadastroUsuario";
            Text = "Cadastro Usuário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label lblNome;
        private Label lblTelefone;
        private MaskedTextBox mTxtTelefone;
        private Label lblCpf;
        private MaskedTextBox mTxtCpf;
        private Label lblEstado;
        private ComboBox cbBoxListaEstados;
        private Button btnCadastrar;
        private Button btnVoltar;
        private Label lblSenha;
        private TextBox txtSenha;
    }
}