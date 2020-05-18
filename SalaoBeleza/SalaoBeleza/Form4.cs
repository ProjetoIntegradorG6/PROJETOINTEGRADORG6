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
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalve_Click(object sender, EventArgs e)
        {
            String nome = txtNomee.Text;
            String endereco = txtEndereco.Text;
            String telefone = mtkTel.Text;
            String horario = mtkCNPJ.Text;

            MessageBox.Show("Salvo com Sucesso");
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            txtNomee.Text = "";
            txtEndereco.Text = "";
            mtkTel.Text = "";
            mtkCNPJ.Text = "";
            
        }
    }
}
