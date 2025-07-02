namespace Benine_Enterprise
{
    partial class Funcionarios
    {
        private System.ComponentModel.IContainer components = null;

        // Liberação de recursos
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionarios));
            this.button1 = new System.Windows.Forms.Button();
            this.dataFuncionarios = new System.Windows.Forms.DataGridView();
            this.bttDeletar = new System.Windows.Forms.Button();
            this.txtDeletar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(662, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "CADASTRAR FUNCIONÁRIOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataFuncionarios
            // 
            this.dataFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFuncionarios.Location = new System.Drawing.Point(13, 31);
            this.dataFuncionarios.Name = "dataFuncionarios";
            this.dataFuncionarios.Size = new System.Drawing.Size(623, 394);
            this.dataFuncionarios.TabIndex = 1;
            this.dataFuncionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFuncionarios_CellContentClick);
            // 
            // bttDeletar
            // 
            this.bttDeletar.Location = new System.Drawing.Point(662, 112);
            this.bttDeletar.Name = "bttDeletar";
            this.bttDeletar.Size = new System.Drawing.Size(106, 64);
            this.bttDeletar.TabIndex = 2;
            this.bttDeletar.Text = "DELETAR FUNCIONARIO.";
            this.bttDeletar.UseVisualStyleBackColor = true;
            this.bttDeletar.Click += new System.EventHandler(this.bttDeletar_Click);
            // 
            // txtDeletar
            // 
            this.txtDeletar.Location = new System.Drawing.Point(662, 182);
            this.txtDeletar.Name = "txtDeletar";
            this.txtDeletar.Size = new System.Drawing.Size(100, 20);
            this.txtDeletar.TabIndex = 3;
            this.txtDeletar.TextChanged += new System.EventHandler(this.txtDeletar_TextChanged);
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDeletar);
            this.Controls.Add(this.bttDeletar);
            this.Controls.Add(this.dataFuncionarios);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Funcionarios";
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.Funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataFuncionarios;
        private System.Windows.Forms.Button bttDeletar;
        private System.Windows.Forms.TextBox txtDeletar;
    }
}
