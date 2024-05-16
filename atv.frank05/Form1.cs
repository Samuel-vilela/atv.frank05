using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv.frank05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChamar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string texto = ("Olá meu nome é:");
            string mensagem = (texto + nome);
            MessageBox.Show(mensagem); 
        }
    }
}
