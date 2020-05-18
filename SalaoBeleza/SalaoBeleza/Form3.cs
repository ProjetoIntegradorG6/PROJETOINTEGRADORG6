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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void rbtDinheiro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String nome = txtNome.Text;
            String endereco = txtEnd.Text;
            String telefone = mtbTel.Text;
            String servico = gbxPag.Text;
            String horario = dtpHora.Text;

            MessageBox.Show("Salvo com Sucesso");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEnd.Text = "";
            mtbTel.Text = "";
            gbxPag.Text = "";
            dtpHora.Text = "";
        }
    }
}
