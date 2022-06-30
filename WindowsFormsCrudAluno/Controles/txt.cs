using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace WindowsFormsCrudAluno.Controles
{
    public class txt : TextBox
    {
        protected override void OnGotFocus(EventArgs caixaTexto)
        {
            base.OnGotFocus(caixaTexto);
            this.BackColor = Color.SkyBlue;
            this.SelectAll();
        }

        protected override void OnLostFocus(EventArgs cxTexto)
        {
            base.OnLostFocus(cxTexto);
            this.BackColor = Color.White;
        }

        public string RetNome()
        {
            string txtNome = this.Text;
            
            return txtNome;
        }

        public void LimparTxt()
        {
            this.Text = "";
        }

    }
}
