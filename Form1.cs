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
        public Form1()
        {
            InitializeComponent();
            NewMethod();
            this.Icon = Properties.Resources.icone;//new Icon(@"\\Benine Enterprise\Benine Enterprise\Resources\icone.ico"); // Define o ícone personalizado
        }

        private void NewMethod()
        {
            this.FormBorderStyle = FormBorderStyle.None; // Remove as bordas
            this.StartPosition = FormStartPosition.CenterScreen; // Centraliza o Form na tela
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Value = 0;
            label1.Text = "0%";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 2;
                label1.Text = progressBar1.Value.ToString() + "%";
            }

            if (progressBar1.Value >= 100)
            {
                timer1.Stop();
                this.Hide();

                Login login = new Login();
                login.ShowDialog();

                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}