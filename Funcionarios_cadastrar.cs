using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Benine_Enterprise
{
    public partial class Funcionarios_cadastrar : Form
    {
        public Funcionarios_cadastrar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Funcionarios_cadastrar_Load(object sender, EventArgs e)
        {
            EstilizarBotoes();
        }

        private void EstilizarBotoes()
        {
            Color azul = Color.FromArgb(0, 122, 204);
            Color vermelho = Color.FromArgb(192, 57, 43);
            Color cinza = Color.FromArgb(108, 117, 125);

            btCadastrar.BackColor = azul;
            btCadastrar.ForeColor = Color.White;
            btCadastrar.FlatStyle = FlatStyle.Flat;
            btCadastrar.FlatAppearance.BorderSize = 0;
            btCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btCadastrar.Cursor = Cursors.Hand;

            button1.BackColor = vermelho;
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 9F);
            button1.Cursor = Cursors.Hand;

            btVoltar.BackColor = cinza;
            btVoltar.ForeColor = Color.White;
            btVoltar.FlatStyle = FlatStyle.Flat;
            btVoltar.FlatAppearance.BorderSize = 0;
            btVoltar.Font = new Font("Segoe UI", 9F);
            btVoltar.Cursor = Cursors.Hand;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string cpf = textBox1.Text.Trim();         // CPF
            string login = txtLogin.Text.Trim();       // Login
            string cargo = txtCargo.Text.Trim();       // Cargo
            string celular = txtCelular.Text.Trim();   // Celular
            string salarioTexto = txtSalario.Text.Trim();
            DateTime nascimento = dateaNascimento.Value;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cpf) ||
                string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(salarioTexto))
            {
                MessageBox.Show("Preencha os campos obrigatórios: Nome, CPF, Salário e Login.");
                return;
            }

            if (!decimal.TryParse(salarioTexto, out decimal salario))
            {
                MessageBox.Show("Salário inválido. Digite um valor numérico.");
                return;
            }

            using (MySqlConnection conn = Conexao.ObterConexao())
            {
                try
                {
                    conn.Open();
                    string sql = @"INSERT INTO Funcionarios 
                                  (Nome, CPF, DataNascimento, Cargo, Celular, Salario, Login)
                                  VALUES (@nome, @cpf, @nasc, @cargo, @cel, @salario, @login)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@cpf", cpf);
                        cmd.Parameters.AddWithValue("@nasc", nascimento);
                        cmd.Parameters.AddWithValue("@cargo", cargo);
                        cmd.Parameters.AddWithValue("@cel", celular);
                        cmd.Parameters.AddWithValue("@salario", salario);
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Funcionário cadastrado com sucesso!");
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar: " + ex.Message);
                }
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Funcionarios form = new Funcionarios(); // Troque pelo nome correto do seu form principal
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            textBox1.Clear();       // CPF
            txtLogin.Clear();
            txtCargo.Clear();
            txtCelular.Clear();
            txtSalario.Clear();
            dateaNascimento.Value = DateTime.Today;
        }

        private void txtNome_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void txtLogin_TextChanged(object sender, EventArgs e) { }
        private void txtCargo_TextChanged(object sender, EventArgs e) { }
        private void txtCelular_TextChanged(object sender, EventArgs e) { }
        private void txtSalario_TextChanged(object sender, EventArgs e) { }
        private void dateaNascimento_ValueChanged(object sender, EventArgs e) { }
        private void lbNome_Click(object sender, EventArgs e) { }
        private void lbLogin_Click(object sender, EventArgs e) { }
        private void lbCPF_Click(object sender, EventArgs e) { }
        private void lbData_Click(object sender, EventArgs e) { }
        private void lbCargo_Click(object sender, EventArgs e) { }
        private void lb_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}
