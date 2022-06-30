using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Configuration;
using WindowsFormsCrudAluno.Controles;
using WindowsFormsCrudAluno.Domimio;

namespace WindowsFormsCrudAluno
{
    public partial class FrmAluno : Form
    {
        public FrmAluno()
        {
            InitializeComponent();
        }

        public void AcessoBd()
        {
            using (FbConnection Conexao = BD.UsarInstacia().UsarConexao())
            {
                try
                {
                    Conexao.Open();

                    string meuSql = "SELECT MATRICULA, NOME, SEXO, NASCIMENTO, CPF FROM TBALUNO";

                    FbCommand comando = new FbCommand(meuSql, Conexao);

                    var leitura = comando.ExecuteReader();

                    var listaAlunos = new List<Aluno>();

                    while (leitura.Read())
                    {
                        var aluno = new Aluno();

                        aluno.Matricula = leitura.GetInt32(0);
                        aluno.Nome = leitura.GetString(1);
                        if (leitura.GetInt32(2) == 0)
                        {
                            aluno.SexoAluno = "Feminino";
                        }
                        else
                            aluno.SexoAluno = "Masculino";
                        aluno.DataNascimento = leitura.GetString(3);
                        aluno.Cpf = leitura.GetString(4);


                        listaAlunos.Add(aluno);
                    }

                    this.dataGridView1.DataSource = listaAlunos;


                }
                catch (FbException ErrBd)
                {

                    MessageBox.Show("Erro de Acesso:" + ErrBd.Message, "Erro");

                }
                finally
                {
                    Conexao.Close();
                }
            }
        }

        public void PesquisaBd(string chaveConsulta)
        {
            using (FbConnection Conexao = BD.UsarInstacia().UsarConexao())
            {
                try
                {
                    Conexao.Open();

                    string meuSql = $"SELECT MATRICULA, NOME, SEXO, NASCIMENTO, CPF FROM TBALUNO WHERE MATRICULA ={chaveConsulta} OR NOME LIKE '{chaveConsulta}'";

                    FbCommand comando = new FbCommand(meuSql, Conexao);

                    var leitura = comando.ExecuteReader();

                    var listaAlunos = new List<Aluno>();

                    while (leitura.Read())
                    {
                        var aluno = new Aluno();

                        aluno.Matricula = leitura.GetInt32(0);
                        aluno.Nome = leitura.GetString(1);
                        if (leitura.GetInt32(2) == 0)
                        {
                            aluno.SexoAluno = "Feminino";
                        }
                        else
                            aluno.SexoAluno = "Masculino";
                        aluno.DataNascimento = leitura.GetString(3);
                        aluno.Cpf = leitura.GetString(4);


                        listaAlunos.Add(aluno);
                    }

                    this.dataGridView1.DataSource = listaAlunos;


                }
                catch (FbException ErrBd)
                {

                    MessageBox.Show("Erro de Acesso:" + ErrBd.Message, "Erro");

                }
                finally
                {
                    Conexao.Close();
                }
            }
        }

        private void LimparCampos()
        {
            txtMatricula.LimparMatricula();
            txtData.LimparData();
            txtNome.LimparTxt();
            txtNumCpf.LimparCpf();
            boxSexo1.LimparSexo();
        }

        private void FrmAluno_Load(object sender, EventArgs e)
        {
            if (!BD.TesteConexao())
                MessageBox.Show("Erro Banco de Dados");


            AcessoBd();
        }

        private void FrmAluno_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void Limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        public void txtNome_TextChanged(object sender, EventArgs e)
        {
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {

            var aluno = new Aluno();

            aluno.Nome = txtNome.Text;
            aluno.Matricula = txtMatricula.NumMat();

            if (boxSexo1.SelecionadoSexoAluno())
            {
                aluno.SexoAluno = "1";
            }
            else
                aluno.SexoAluno = "0";

            aluno.DataNascimento = txtData.DtNascimento();
            aluno.Cpf = txtNumCpf.NumCpf();

            var bd = BD.UsarInstacia();

            if (bd.Create(aluno))
            {
                
                MessageBox.Show("Salvo Com Sucesso");
                LimparCampos();
                AcessoBd();
            }
            else
                MessageBox.Show("Houve um erro ao tentar salvar o aluno, verifique as informações e tente novamente");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Editar_Click(object sender, EventArgs e)
        {
            int linha = dataGridView1.CurrentRow.Index;
            string selecionado = dataGridView1.Rows[linha].Cells[0].Value.ToString();

        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            int linha = dataGridView1.CurrentRow.Index;
            string selecionado = dataGridView1.Rows[linha].Cells[0].Value.ToString();

            var bd = BD.UsarInstacia();

            DialogResult Apagar = MessageBox.Show("Deseja mesmo excluir esse aluno?","Excluir",
                                                  MessageBoxButtons.YesNo, 
                                                  MessageBoxIcon.Question);

            if (Apagar == DialogResult.Yes)
            {
                if (bd.Delete(selecionado))
                {
                    AcessoBd();
                    MessageBox.Show("Excluido Com Sucesso");
                }
                else
                    MessageBox.Show("Houve um erro ao tentar excluir o aluno, verifique as informações e tente novamente");

            }
            else
            {
                MessageBox.Show("Ação Cancelada", "Excluir",MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisar.Text;

            if (pesquisa == "")
            {
                MessageBox.Show("Digite a matricula ou o nome do aluno na barra de pesquisa", "Pesquisa",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);
            }
            else
                PesquisaBd(pesquisa);

        }
    }
}
