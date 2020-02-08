using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace bd_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btncadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar(txtnome.Text, txttelefone.Text);
            MessageBox.Show(cad.mensagem);
        }
    }
}
