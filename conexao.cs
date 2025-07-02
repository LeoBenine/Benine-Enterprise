using MySql.Data.MySqlClient;

public class Conexao
{
    public static string StringConexao = "Server=localhost;Database=benine_enterprise;Uid=root;Pwd=;";

    public static MySqlConnection ObterConexao()
    {
        return new MySqlConnection(StringConexao);
    }
}
