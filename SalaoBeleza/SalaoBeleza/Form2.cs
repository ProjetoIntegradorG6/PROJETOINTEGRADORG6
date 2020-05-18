using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaoBeleza
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuPessoa_Click(object sender, EventArgs e)
        {
            Clientes form = new Clientes();
            form.Show();
        }

        private void mnuProdutos_Click(object sender, EventArgs e)
        {
            Produtos form = new Produtos();
            form.Show();
        }
    }
}
