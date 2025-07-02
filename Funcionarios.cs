using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Benine_Enterprise
{
    public partial class Funcionarios : Form
    {
        public Funcionarios()
        {
            InitializeComponent();
        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            CarregarFuncionarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionarios_cadastrar cadastro = new Funcionarios_cadastrar();
            cadastro.FormClosed += (s, args) => CarregarFuncionarios();
            cadastro.ShowDialog();
        }

        private void bttDeletar_Click(object sender, EventArgs e)
        {
            string input = txtDeletar.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Digite o código do funcionário a ser excluído.");
                return;
            }

            if (!int.TryParse(input, out int id))
            {
                MessageBox.Show("Código inválido. Digite um número inteiro.");
                return;
            }

            DialogResult confirmacao = MessageBox.Show(
                $"Deseja realmente excluir o funcionário com código {id}?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacao != DialogResult.Yes)
                return;

            using (MySqlConnection conn = Conexao.ObterConexao())
            {
                try
                {
                    conn.Open();

                    string verificarSql = "SELECT COUNT(*) FROM Funcionarios WHERE Id = @id";
                    using (var cmdVerificar = new MySqlCommand(verificarSql, conn))
                    {
                        cmdVerificar.Parameters.AddWithValue("@id", id);
                        long existe = Convert.ToInt64(cmdVerificar.ExecuteScalar());
                        if (existe == 0)
                        {
                            MessageBox.Show("Funcionário não encontrado.");
                            return;
                        }
                    }

                    string deletarSql = "DELETE FROM Funcionarios WHERE Id = @id";
                    using (var cmdExcluir = new MySqlCommand(deletarSql, conn))
                    {
                        cmdExcluir.Parameters.AddWithValue("@id", id);
                        cmdExcluir.ExecuteNonQuery();
                    }

                    MessageBox.Show("Funcionário excluído com sucesso!");
                    txtDeletar.Clear();
                    CarregarFuncionarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir funcionário: " + ex.Message);
                }
            }
        }

        private void CarregarFuncionarios()
        {
            using (MySqlConnection conn = Conexao.ObterConexao())
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT Id, Nome, CPF, DataNascimento, Cargo, Celular, Salario, Login FROM Funcionarios";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable tabela = new DataTable();
                        adapter.Fill(tabela);
                        dataFuncionarios.DataSource = tabela;

                        dataFuncionarios.Columns["Id"].HeaderText = "Código";
                        dataFuncionarios.Columns["DataNascimento"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        dataFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataFuncionarios.ReadOnly = true;
                        dataFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar funcionários: " + ex.Message);
                }
            }
        }

        private void dataFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Implementações futuras
        }

        private void txtDeletar_TextChanged(object sender, EventArgs e)
        {
            // Pode ser usado para buscar automaticamente o nome do funcionário futuramente
        }
    }
}
