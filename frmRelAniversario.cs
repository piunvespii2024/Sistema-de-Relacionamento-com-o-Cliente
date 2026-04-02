using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Relacionamento_com_o_Cliente
{
    public partial class frmRelAniversario : Form
    {
        public frmRelAniversario()
        {
            InitializeComponent();
        }

        private void frmRelAniversario_Load(object sender, EventArgs e)
        {

            dataGrid.DataSource = Banco.buscarAniversariante();

            if(dataGrid.DataSource != null)
            {

                dataGrid.Columns[0].HeaderText = "Cód.";
                dataGrid.Columns[1].HeaderText = "Nome";
                dataGrid.Columns[2].HeaderText = "Endereço";
                dataGrid.Columns[3].HeaderText = "Nascimento";
                dataGrid.Columns[4].HeaderText = "Telefone";
                dataGrid.Columns[5].HeaderText = "Limite Crédito";
                dataGrid.Columns[6].HeaderText = "Ativo";
                            
                dataGrid.Columns[0].Width = 40;
                dataGrid.Columns[1].Width = 160;
                dataGrid.Columns[2].Width = 200;
                dataGrid.Columns[3].Width = 90;
                dataGrid.Columns[4].Width = 120;
                dataGrid.Columns[5].Width = 90;
                dataGrid.Columns[6].Width = 50;
                
                dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGrid.AllowUserToAddRows = false;
                dataGrid.AllowUserToDeleteRows = false;
                dataGrid.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Não foram encontradas Aniversariantes para este mês", "Aniversariantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }
    }
}
