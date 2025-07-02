using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Benine_Enterprise
{
    public class Cadastrar : Form
    {
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnCadastrar;
        private Button btnSair;

        public Cadastrar()
        {
            InitializeComponent();

            this.Text = "Cadastro de Usuário";
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(800, 450);
            this.Icon = Properties.Resources.icone;//new Icon(@"D:\Benine Enterprise\Benine Enterprise\Resources\icone.ico");
            this.BackColor = Color.White;

            InicializarControles();
            this.Load += Cadastrar_Load;
        }

        private void InicializarControles()
        {
            label1 = new Label
            {
                Text = "Usuário:",
                AutoSize = true,
                Font = new Font("Segoe UI", 10F)
            };
            this.Controls.Add(label1);

            txtUsuario = new TextBox { Width = 200 };
            this.Controls.Add(txtUsuario);

            label2 = new Label
            {
                Text = "Senha:",
                AutoSize = true,
                Font = new Font("Segoe UI", 10F)
            };
            this.Controls.Add(label2);

            txtSenha = new TextBox
            {
                Width = 200,
                UseSystemPasswordChar = true
            };
            this.Controls.Add(txtSenha);

            btnCadastrar = new Button
            {
                Text = "Cadastrar",
                Width = 120,
                Height = 35,
                BackColor = Color.FromArgb(0, 120, 215),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };
            btnCadastrar.Click += btnCadastrar_Click;
            this.Controls.Add(btnCadastrar);

            btnSair = new Button
            {
                Text = "Sair",
                Width = 120,
                Height = 35,
                BackColor = Color.DarkRed,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F)
            };
            btnSair.Click += (s, e) => Application.Exit();
            this.Controls.Add(btnSair);
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {
            int centerX = this.ClientSize.Width / 2;

            label1.Top = 100;
            label1.Left = centerX - label1.PreferredWidth / 2;

            txtUsuario.Top = label1.Bottom + 5;
            txtUsuario.Left = centerX - txtUsuario.Width / 2;

            label2.Top = txtUsuario.Bottom + 15;
            label2.Left = centerX - label2.PreferredWidth / 2;

            txtSenha.Top = label2.Bottom + 5;
            txtSenha.Left = centerX - txtSenha.Width / 2;

            btnCadastrar.Top = txtSenha.Bottom + 25;
            btnCadastrar.Left = centerX - btnCadastrar.Width / 2;

            btnSair.Top = btnCadastrar.Bottom + 15;
            btnSair.Left = centerX - btnSair.Width / 2;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senhaOriginal = txtSenha.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senhaOriginal))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            string senhaCriptografada = GerarHashSHA256(senhaOriginal);

            using (MySqlConnection conn = Conexao.ObterConexao())
            {
                try
                {
                    conn.Open();

                    string criarTabela = @"
                        CREATE TABLE IF NOT EXISTS Usuarios (
                            Id INT AUTO_INCREMENT PRIMARY KEY,
                            Login VARCHAR(255) NOT NULL UNIQUE,
                            Senha VARCHAR(255) NOT NULL
                        );";
                    using (var cmdCreate = new MySqlCommand(criarTabela, conn))
                        cmdCreate.ExecuteNonQuery();

                    string verificarSql = "SELECT COUNT(*) FROM Usuarios WHERE Login = @usuario";
                    using (var verificarCmd = new MySqlCommand(verificarSql, conn))
                    {
                        verificarCmd.Parameters.AddWithValue("@usuario", usuario);
                        long existe = Convert.ToInt64(verificarCmd.ExecuteScalar());

                        if (existe > 0)
                        {
                            MessageBox.Show("Este nome de usuário já está cadastrado!");
                            return;
                        }
                    }

                    string inserirSql = "INSERT INTO Usuarios (Login, Senha) VALUES (@usuario, @senha)";
                    using (var inserirCmd = new MySqlCommand(inserirSql, conn))
                    {
                        inserirCmd.Parameters.AddWithValue("@usuario", usuario);
                        inserirCmd.Parameters.AddWithValue("@senha", senhaCriptografada);
                        inserirCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    this.Close(); // ou Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar: " + ex.Message);
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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new Size(800, 450);
            this.Name = "Cadastrar";
            this.ResumeLayout(false);
        }
    }
}
