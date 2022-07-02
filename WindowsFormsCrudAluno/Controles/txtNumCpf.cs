using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using WindowsFormsCrudAluno.Regras;

namespace WindowsFormsCrudAluno.Controles
{
    public class txtNumCpf : TextBox
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

            if (this.Text == "")
                return;

            string numer;

            numer = Convert.ToString(this.Text);

            if (!Regras.ValidaCPF.IsCpf(numer))
            {
                MessageBox.Show("CPF Inválido");
                this.Text = "";
            }

        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (e.KeyChar == 8)
                return;
            
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        public void LimparCpf()
        {
            this.Text = "";
        }

       public string NumCpf()
        {
            return this.Text;
        }

        public void EditarCPFSelecinonado(string cpf)
        {
            this.Text = cpf;
        }
    
    }
}
