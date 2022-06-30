using FirebirdSql.Data.FirebirdClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using WindowsFormsCrudAluno.Domimio;

public class BD
{
    private static readonly BD Instancia = new BD();

    private BD(){    }

    public static BD UsarInstacia ()
    {
        return Instancia;
    }
    
    public FbConnection UsarConexao()
    {
        string conf = ConfigurationManager.ConnectionStrings["StringConexao"].ToString();
        return new FbConnection(conf);
    }

    public static bool TesteConexao()
    {
        bool conecte = true;
        using (FbConnection Conexao = BD.UsarInstacia().UsarConexao())
        {
            try
            {
                Conexao.Open();
            }
            catch
            {
                conecte = false;
            }
            finally
            {
                Conexao.Close();
            }
        }
        return conecte;
    }

    public bool Create(Aluno aluno)
    {

        string sqlConecte = $"INSERT INTO TBALUNO(MATRICULA, NOME, SEXO, NASCIMENTO, CPF) VALUES('{aluno.Matricula}', '{aluno.Nome}', '{aluno.SexoAluno}', '{aluno.DataNascimento}', '{aluno.Cpf}')";

        bool conecte = true;
        using (FbConnection Conexao = BD.UsarInstacia().UsarConexao())
        {
            try
            {
                Conexao.Open();
                using (FbCommand comando = new FbCommand(sqlConecte, Conexao)) { comando.ExecuteNonQuery(); }
                //FbDataAdapter da = new FbDataAdapter(comando);
            }
            catch
            {
                conecte = false;
            }
            finally
            {
                Conexao.Close();
            }
        }
        return conecte;
    } 

    public bool Delete(string item)
    {
        

        string sqlConecte = "DELETE FROM TBALUNO WHERE MATRICULA = " + item;

        bool conecte = true;
        
        using (FbConnection Conexao = BD.UsarInstacia().UsarConexao())
        

        try
        {
           Conexao.Open();
           using (FbCommand comando = new FbCommand(sqlConecte, Conexao)) { comando.ExecuteNonQuery(); }


        }catch
        {

            conecte = false;
        }

        return conecte;
    }

    public bool Update(Aluno aluno)
    {

        string sqlConecte = $"UPDATE TBALUNO SET TBALUNO.NOME = '{aluno.Nome}', TBALUNO.SEXO = '{aluno.SexoAluno}', TBALUNO.NASCIMENTO = '{aluno.DataNascimento}', TBALUNO.CPF = '{aluno.Cpf}' WHERE TBALUNO.MATRICULA = '{aluno.Matricula}'";

        bool conecte = true;
        using (FbConnection Conexao = BD.UsarInstacia().UsarConexao())
        {
            try
            {
                Conexao.Open();
                using (FbCommand comando = new FbCommand(sqlConecte, Conexao)) { comando.ExecuteNonQuery(); }
                //FbDataAdapter da = new FbDataAdapter(comando);
            }
            catch
            {
                conecte = false;
            }
            finally
            {
                Conexao.Close();
            }
        }
        return conecte;
    }


}