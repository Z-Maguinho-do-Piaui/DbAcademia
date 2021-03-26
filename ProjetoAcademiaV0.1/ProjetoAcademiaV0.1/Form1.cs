using ProjetoAcademiaV0._1.Entidades;
using System;
using System.Windows.Forms;

namespace ProjetoAcademiaV0._1
{
    public partial class Academia : Form
    {
        public Academia()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            Cliente cliente = new Cliente(txbNome.Text, txbSenha.Text);

            Conexao.InserirCliente(cliente);

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Conexao.ListarCliente();
        }
    }
}
