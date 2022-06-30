using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCrudAluno.Domimio
{
    public class Aluno
    {
       
        public int Matricula { get; set; }
        public string Nome { get; set; } 
        public string SexoAluno { get; set; }
        public string DataNascimento { get; set; }
        public string Cpf { get; set; }
    }
}
