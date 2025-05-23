using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Benine_Enterprise
{
    public partial class Form1 : Form
    {
        private Timer timer1;
        private IContainer components;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label1;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Removendo a borda do formulário
            this.StartPosition = FormStartPosition.CenterScreen; // Abrindo no meio da tela
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar2.Value = 0;
            label1.Text = "0%";

            timer1.Interval = 50; // Define intervalo do Timer
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar2.Value < progressBar2.Maximum)
            {
                progressBar2.Value += 2;
                label1.Text = progressBar2.Value.ToString() + "%";
            }

            if (progressBar2.Value >= 100)
            {
                timer1.Stop();
                this.Hide();

                Login login = new Login();
                login.ShowDialog();

                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void progressBar2_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(12, 588);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(1025, 23);
            this.progressBar2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 572);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "0%";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1056, 623);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar2);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
