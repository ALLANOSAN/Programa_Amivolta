using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Cadastro_Amivolta
{
    public partial class Cadastro_2 : Form
    {
        public readonly string _nomeSelecionado;

        public Cadastro_2(string nomeSelecionado)
        {
            InitializeComponent();
            _nomeSelecionado = nomeSelecionado;

            // Carrega os detalhes da criança selecionada nos campos correspondentes
            CarregarDetalhesCrianca();

        }

        public void MoverFocoParaTxtNome()
        {
            // Move o foco para a TextBox Txt_Nome
            Txt_Nome.Focus();
        }

        public void CarregarDetalhesCrianca()
        {
            try
            {
                AmivoltaDbConnection dbConnection = new AmivoltaDbConnection();
                using (MySqlConnection connection = dbConnection.Connect())
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM criancas WHERE Nome = @nome", connection))
                    {
                        cmd.Parameters.AddWithValue("@nome", _nomeSelecionado);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Carrega os detalhes nos campos correspondentes
                                Txt_Nome.Text = reader["Nome"].ToString();
                                Txt_Telefone.Text = reader["Telefone"].ToString();
                                Txt_Endereço.Text = reader["Endereco"].ToString();
                                Txt_Responsavel.Text = reader["Responsavel"].ToString();
                            }
                        }
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
        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            CadastrarCrianca();
            Close();
        }

        private void Btn_Atualizar_Click(object sender, EventArgs e)
        {
            AtualizarCrianca();
        }

        private void CadastrarCrianca()
        {
            try
            {
                AmivoltaDbConnection dbConnection = new AmivoltaDbConnection();
                using (MySqlConnection connection = dbConnection.Connect())
                {
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO criancas (Nome, Telefone, Endereco, Responsavel) VALUES (@nome, @telefone, @endereco, @responsavel)", connection))
                    {
                        cmd.Parameters.AddWithValue("@nome", Txt_Nome.Text);
                        cmd.Parameters.AddWithValue("@telefone", Txt_Telefone.Text);
                        cmd.Parameters.AddWithValue("@endereco", Txt_Endereço.Text);
                        cmd.Parameters.AddWithValue("@responsavel", Txt_Responsavel.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Criança cadastrada com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void AtualizarCrianca()
        {
            try
            {
                AmivoltaDbConnection dbConnection = new AmivoltaDbConnection();
                using (MySqlConnection connection = dbConnection.Connect())
                {
                    using (MySqlCommand cmd = new MySqlCommand("UPDATE criancas SET Telefone = @telefone, Endereco = @endereco, Responsavel = @responsavel WHERE Nome = @nome", connection))
                    {
                        cmd.Parameters.AddWithValue("@nome", Txt_Nome.Text);
                        cmd.Parameters.AddWithValue("@telefone", Txt_Telefone.Text);
                        cmd.Parameters.AddWithValue("@endereco", Txt_Endereço.Text);
                        cmd.Parameters.AddWithValue("@responsavel", Txt_Responsavel.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cadastro atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                Close();
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
    }
}