using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using FirebirdSql.Data.FirebirdClient;
using System.Configuration;
using System.Data;

namespace WindowsFormsCrudAluno.Controles
{ 
    public class GridDados : DataGridView
    {
        private DataGridView gridDados;
        public void AcessoBd()
        {
            using (FbConnection Conexao = BD.UsarInstacia().UsarConexao())
            {
                try
                {
                    Conexao.Open();

                    string meuSql = "SELECT * FROM TBALUNO";

                    FbCommand comando = new FbCommand(meuSql, Conexao);
                    FbDataAdapter da = new FbDataAdapter(comando);

                    DataTable bdProjeto = new DataTable();
                    da.Fill(bdProjeto);

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

        public void InicializeGridDados(DataTable bdProjeto)
        {
            gridDados = new DataGridView();
            Controls.Add(gridDados);
            //gridDados.Size = new Size();

            gridDados.DataSource = bdProjeto;

            gridDados.ColumnHeadersVisible = true;

            DataGridViewCellStyle columnHeaderStyle =
                new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Aqua;
            columnHeaderStyle.Font =
                new Font("Verdana", 10, FontStyle.Bold);
            gridDados.ColumnHeadersDefaultCellStyle =
                columnHeaderStyle;

            gridDados.Columns[0].Name = "Matrícula";
            gridDados.Columns[1].Name = "Nome";
            gridDados.Columns[2].Name = "Sexo";
            gridDados.Columns[3].Name = "Nascimento";
            gridDados.Columns[4].Name = "CPF";

            string[] row1 = new string[] { "SELECT MATRICULA FROM TBALUNO" };
            string[] row2 = new string[] { "SELECT NOME FROM TBALUNO" };
            string[] row3 = new string[] { "SELECT SEXO FROM TBALUNO" };
            string[] row4 = new string[] { "SELECT DTNASCIMENTO FROM TBALUNO" };
            string[] row5 = new string[] { "SELECT CPF FROM TBALUNO" };
        }
    }

}
