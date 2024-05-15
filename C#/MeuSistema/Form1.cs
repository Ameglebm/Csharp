using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace MeuSistema
{
    public partial class form1 : Form
    
    {
        //modificador: public quer dizer que ele pode ser usado em qualquer solução, formulario ou projeto
        //private: quer dizer que so pode ser usado qualquer momento aqui dentro
       public string nomeCliente;//Criando variaveis e seus tipos
       public string meuNome = "Alisson Amegle"; 
       

        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btok_Click(object sender, EventArgs e)
        {
            txtname.Text = meuNome;
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btcancelar2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
