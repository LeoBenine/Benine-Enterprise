using System;
using System.Windows.Forms;

namespace Benine_Enterprise
{
    public partial class Menu : Form
    {
        private string nomeUsuario;

        public Menu(string usuario)
        {
            InitializeComponent();
            nomeUsuario = usuario;

            // Impede que o usuário maximize a janela
            this.MaximizeBox = false;

            // (Opcional) Impede redimensionamento manual
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            label2.Text = $"Bem-vindo, {nomeUsuario}!";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Método vazio apenas para evitar erro por clique no rótulo
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Funcionarios telaFuncionarios = new Funcionarios();
            telaFuncionarios.ShowDialog();
        }
    }
}
