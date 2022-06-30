using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCrudAluno.Regras
{
    public class Regras
    {
        public bool MatriculaVazia(Control controle)
        {
            if (controle.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
