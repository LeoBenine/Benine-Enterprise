using System;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Benine_Enterprise
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            if (Application.OpenForms.Count > 0)
                this.Icon = Application.OpenForms[0].Icon;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Aplicando estilo visual nos botões
            EstilizarBotao(btEntrar, Color.FromArgb(0, 120, 215), Color.White);
            EstilizarBotao(btCadastrar, Color.Gray, Color.White);
            EstilizarBotao(button2, Color.DarkRed, Color.White);

            CenterControlsVertically(
                label1, textBox1,
                label2, textBox2,
                btEntrar,
                btCadastrar,
                button2
            );
        }

        private void EstilizarBotao(Button botao, Color fundo, Color texto)
        {
            botao.BackColor = fundo;
            botao.ForeColor = texto;
            botao.FlatStyle = FlatStyle.Flat;
            botao.FlatAppearance.BorderSize = 0;
            botao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            botao.Cursor = Cursors.Hand;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Cadastrar cadastrarForm = new Cadastrar())
            {
                cadastrarForm.ShowDialog();
            }
            this.Show();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text.Trim();
            string senhaOriginal = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senhaOriginal))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            string senhaHash = GerarHashSHA256(senhaOriginal);

            using (MySqlConnection conn = Conexao.ObterConexao())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Login = @usuario AND Senha = @senha";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@senha", senhaHash);

                        long resultado = Convert.ToInt64(cmd.ExecuteScalar());

                        if (resultado > 0)
                        {
                            MessageBox.Show($"Bem-vindo, {usuario}!");
                            this.Hide();
                            using (Menu menuForm = new Menu(usuario))
                            {
                                menuForm.ShowDialog();
                            }
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha inválidos.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco: " + ex.Message);
                }
            }
        }

        private string GerarHashSHA256(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(senha);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CenterControlsVertically(params Control[] controls)
        {
            int spacing = 10;
            int totalHeight = controls.Sum(c => c.Height) + (controls.Length - 1) * spacing;
            int startY = (this.ClientSize.Height - totalHeight) / 2;

            foreach (Control control in controls)
            {
                control.Left = (this.ClientSize.Width - control.Width) / 2;
                control.Top = startY;
                startY += control.Height + spacing;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void pictureBox2_Click(object sender, EventArgs e) { }
    }
}
