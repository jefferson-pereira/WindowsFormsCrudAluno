using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCrudAluno.Controles
{
    public class txtData : MaskedTextBox
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

            if (this.Text == "  /  /")
            {
                return;
            }
            else
            {
                try
                {
                    this.Text = Convert.ToDateTime(this.Text).ToString("dd/MM/yyyy");
                }
                catch
                {
                    this.Text = "";
                    MessageBox.Show("Data de nascimento inválida");
                }
            }
        }

        public void LimparData()
        {
            this.Text = "";
        }

        public string DtNascimento()
        {
            string estaData;

            estaData = this.Text.Trim();
            estaData = estaData.Replace("/", "");

            return estaData;
        }

    }
}
