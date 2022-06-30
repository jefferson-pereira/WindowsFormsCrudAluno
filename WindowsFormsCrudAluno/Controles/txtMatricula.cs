using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCrudAluno.Controles
{
    public class txtMatricula : TextBox
    {
        protected override void OnGotFocus(EventArgs caixaTexto)
        {
            base.OnGotFocus(caixaTexto);
            this.SelectAll();
            this.BackColor = Color.SkyBlue;
            
        }

        protected override void OnLostFocus(EventArgs cxTexto)
        {
            base.OnLostFocus(cxTexto);
            this.BackColor = Color.White;
            
            if (this.Text == "")
                return;

            string numer;

            numer = Convert.ToString(this.Text);

            if (numer.Length > 9)
            {
                MessageBox.Show("digite um numero entre 1 ate 999999999");
                this.Text = "";
            }

            try
            {
                Convert.ToInt32(this.Text);
            }
            catch
            {
                this.Text = "";

                MessageBox.Show("Digite apenas números na matrícula");
            }
        }

        protected override void OnCreateControl()
        {
            this.TextAlign = HorizontalAlignment.Right;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            
            if (e.KeyChar == 8)
                return;

            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        public void LimparMatricula()
        {
            this.Text = "";
        }

        public int NumMat()
        {

            if (this.Text != "")
            {
                return Convert.ToInt32(this.Text);
            }
            else
            {
                return 0;
            }
        
        }
    }

}