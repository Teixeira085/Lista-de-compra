using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_compra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string item = txtItem.Text.Trim();

            if (string.IsNullOrEmpty(item))
            {
                MessageBox.Show("Digite um item para adicionar.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstCompras.Items.Add(item);
            txtItem.Clear();
            txtItem.Focus();
        }


        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            if (lstCompras.SelectedIndex != -1)
            {
                lstCompras.Items.RemoveAt(lstCompras.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecione um item para remover.", "Aviso");
            }

        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            if (lstCompras.Items.Count == 0)
            {
                MessageBox.Show("A lista já está vazia.", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Deseja realmente limpar a lista?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lstCompras.Items.Clear();
            }

        }
    }
}





