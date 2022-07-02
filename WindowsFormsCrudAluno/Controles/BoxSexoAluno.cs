using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsCrudAluno.Controles
{
    public class BoxSexoAluno : ComboBox
    {
        

        protected override void OnGotFocus(EventArgs caixaTexto)
        {
            base.OnGotFocus(caixaTexto);
            this.BackColor = Color.SkyBlue;
            Items.Insert(0, "Feminino");
            Items.Insert(1, "Masculino");
        }

        protected override void OnLostFocus(EventArgs cxTexto)
        {
            base.OnLostFocus(cxTexto);
            this.BackColor = Color.White;
        }
    
        public void LimparSexo()
        {
            SelectedIndex = -1;
        }

        public bool SelecionadoSexoAluno()
        {
            int item = SelectedIndex;

            if (item == 0)
            {
                return false;
            }else 
                return true;
        }

        public void EditarSexoAlunoSelecionar(int sexoAluno)
        {
            SelectedValue = sexoAluno;
        }

    }
}
