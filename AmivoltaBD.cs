using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cadastro_Amivolta
{
    public class AmivoltaDbConnection
    {
        private readonly string _connStr;

        public AmivoltaDbConnection()
        {
            _connStr = "server=localhost;user=root;database=amivolta;port=3307;password=;charset=utf8";
        }

        public MySqlConnection Connect()
        {
            try
            {
                var conn = new MySqlConnection(_connStr);
                conn.Open();
                return conn;
            }
            catch (MySqlException ex)
            {
                // Trata exceções específicas do MySQL
                if (ex.Number == 0)
                {
                    MessageBox.Show("Não foi possível conectar ao servidor. Entre em contato com o administrador", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Number == 1045)
                {
                    MessageBox.Show("Usuário e/ou senha inválidos, por favor tente novamente", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Trata outras exceções não relacionadas diretamente com o MySQL
                    MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                throw; // Re-lançar a exceção para que o erro possa ser tratado em outro lugar, se necessário
                
            }
        }
    }
}