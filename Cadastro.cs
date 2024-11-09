using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Cadastro_Amivolta
{
    public partial class Pesquisa : Form
    {
        public readonly AmivoltaDbAutocomplete Autocomplete;
        // Adicione um campo para armazenar o nome da criança selecionada
        public string NomeSelecionado;
        public Pesquisa()
        {
            InitializeComponent();
            AmivoltaDbConnection dbConnection = new AmivoltaDbConnection();
            Autocomplete = new AmivoltaDbAutocomplete(dbConnection.Connect().ConnectionString);
            // Adiciona um manipulador de evento para o evento CellDoubleClick na DataGridView
            Dgv_Pesquisa.CellDoubleClick += Dgv_Pesquisa_CellDoubleClick;
        }

        public void Txt_Pesquisar_TextChanged(object sender, EventArgs e)
        {
            var searchTerm = Txt_Pesquisar.Text;
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                Dgv_Pesquisa.DataSource = null;
                return;
            }

            try
            {
                DataTable dt = Autocomplete.AutoCompleteChildren(searchTerm);
                Dgv_Pesquisa.DataSource = dt;
            }
            catch (MySqlException ex) when (ex.Number == 0)
            {
                MessageBox.Show("Não foi possível conectar ao servidor. Entre em contato com o administrador", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException ex) when (ex.Number == 1045)
            {
                MessageBox.Show("Usuário e/ou senha inválidos, por favor tente novamente", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro ao acessar banco de dados MySQL: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class AmivoltaDbAutocomplete
        {
            private readonly MySqlConnection _connection;

            public AmivoltaDbAutocomplete(string connectionString)
            {
                _connection = new MySqlConnection(connectionString);
            }

            public DataTable AutoCompleteChildren(string searchTerm)
            {
                DataTable dt = new DataTable();

                try
                {
                    _connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand("SELECT Nome FROM criancas WHERE Nome LIKE @searchTerm", _connection))
                    {
                        cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                finally
                {
                    _connection.Close();
                }

                return dt;
            }

        }
        public void Dgv_Pesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a célula clicada é a de 'Nome'
            if (e.RowIndex >= 0 && e.ColumnIndex == Dgv_Pesquisa.Columns["Nome"].Index)
            {
                // Obtém o valor do 'Nome' da célula clicada
                string nomeSelecionado = Dgv_Pesquisa.Rows[e.RowIndex].Cells["Nome"].Value.ToString();

                // Abre o formulário Cadastro_2 passando o nome como parâmetro
                Cadastro_2 cadastro2 = new Cadastro_2(nomeSelecionado);
                cadastro2.ShowDialog();
            }
        }

        private void Btn_Cadastro_Click(object sender, EventArgs e)
        {
            // Abre o formulário Cadastro_2
            Cadastro_2 cadastro2 = new Cadastro_2(NomeSelecionado);
            cadastro2.ShowDialog();
            // Move o foco para a TextBox Txt_Nome no Cadastro_2
            cadastro2.MoverFocoParaTxtNome();
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            // Adicione lógica para remover a criança do banco de dados usando o nomeSelecionado
            try
            {
                AmivoltaDbConnection dbConnection = new AmivoltaDbConnection();
                using (MySqlConnection connection = dbConnection.Connect())
                {
                    using (MySqlCommand cmd = new MySqlCommand("DELETE FROM criancas WHERE Nome = @nome", connection))
                    {
                        cmd.Parameters.AddWithValue("@nome", NomeSelecionado);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Criança removida com sucesso!", "Remoção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro ao acessar banco de dados MySQL: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Atualize a DataGridView após a remoção, se necessário
            Txt_Pesquisar_TextChanged(sender, e);
        }
    }
}