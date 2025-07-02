namespace Benine_Enterprise
{
    partial class Funcionarios_cadastrar
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
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbCPF = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateaNascimento = new System.Windows.Forms.DateTimePicker();
            this.lbData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lbCargo = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btVoltar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(283, 9);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome.";
            this.lbNome.Click += new System.EventHandler(this.lbNome_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(286, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(286, 58);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(30, 13);
            this.lbCPF.TabIndex = 2;
            this.lbCPF.Text = "CPF.";
            this.lbCPF.Click += new System.EventHandler(this.lbCPF_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(289, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateaNascimento
            // 
            this.dateaNascimento.Location = new System.Drawing.Point(286, 136);
            this.dateaNascimento.Name = "dateaNascimento";
            this.dateaNascimento.Size = new System.Drawing.Size(200, 20);
            this.dateaNascimento.TabIndex = 4;
            this.dateaNascimento.ValueChanged += new System.EventHandler(this.dateaNascimento_ValueChanged);
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(289, 107);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(105, 13);
            this.lbData.TabIndex = 5;
            this.lbData.Text = "Data de nascimento.";
            this.lbData.Click += new System.EventHandler(this.lbData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Telefone/Celular.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(286, 196);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 7;
            this.txtCelular.TextChanged += new System.EventHandler(this.txtCelular_TextChanged);
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(286, 244);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 20);
            this.txtCargo.TabIndex = 8;
           
            // 
            // lbCargo
            // 
            this.lbCargo.AutoSize = true;
            this.lbCargo.Location = new System.Drawing.Point(286, 228);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(35, 13);
            this.lbCargo.TabIndex = 9;
            this.lbCargo.Text = "Cargo";
            this.lbCargo.Click += new System.EventHandler(this.lbCargo_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(289, 278);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(42, 13);
            this.lb.TabIndex = 10;
            this.lb.Text = "Salario.";
            this.lb.Click += new System.EventHandler(this.lb_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(286, 303);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 11;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(289, 340);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(33, 13);
            this.lbLogin.TabIndex = 12;
            this.lbLogin.Text = "Login";
            this.lbLogin.Click += new System.EventHandler(this.lbLogin_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(286, 356);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 13;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(289, 424);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(75, 23);
            this.btVoltar.TabIndex = 14;
            this.btVoltar.Text = "VOLTAR";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "SAIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(292, 395);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(94, 23);
            this.btCadastrar.TabIndex = 16;
            this.btCadastrar.Text = "CADASTRAR";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // Funcionarios_cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.lbCargo);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.dateaNascimento);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbNome);
            this.Name = "Funcionarios_cadastrar";
            this.Text = "Funcionarios_cadastrar";
            this.Load += new System.EventHandler(this.Funcionarios_cadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateaNascimento;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lbCargo;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btCadastrar;
    }
}