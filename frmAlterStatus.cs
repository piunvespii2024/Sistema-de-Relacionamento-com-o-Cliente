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
    public partial class frmAlteraStatus : Form
    {
        
        public frmAlteraStatus()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            DataTable cli = Banco.clientesInativo(Convert.ToInt32(mskCodigo.Text.Trim()));
            if (cli.Rows.Count > 0)
            {
                DataRow registro = cli.Rows[0];
                    
                txtNome.Text =  registro ["Nome"].ToString();
                if (Convert.ToBoolean(registro["Ativo"].ToString()))
                {
                    txtStatus.Text = "* ATIVO *";
                    btAtivar.Enabled= false;
                    btDesativar.Enabled = true;
                }
                else {
                    txtStatus.Text = " INATIVO ";
                    btAtivar.Enabled = true;
                    btDesativar.Enabled = false;
                    
                }
            }
            else
            {
                MessageBox.Show("Cliente NÃO Cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //btBuscar.Enabled = false;
            }  
                
        }

        private void mskCodigo_Leave(object sender, EventArgs e)
        {
            if (mskCodigo.Text.Trim().Length > 0)
            {
                btBuscar.Enabled = true;
            }
            else
            {
                btBuscar.Enabled = false;
            }
        }

        private void mskCodigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) e.SuppressKeyPress = true;
            if (e.KeyCode == Keys.Enter)
            {
                if (mskCodigo.Text.Trim().Length > 0)
                {
                    btBuscar.Enabled = true;
                    btBuscar.Focus();
                }
            }
        }

        private void btAtivar_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Quer Reativar o Cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( msg == DialogResult.Yes) 
            {
                       
                Banco.atualizaStatus( Convert.ToInt32(mskCodigo.Text),true);
                btAtivar.Enabled = false;
                txtNome.Clear();
                txtStatus.Clear();
                btBuscar.Focus();
                MessageBox.Show("Cliente Ativado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }

        private void btDesativar_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Gostaria de Desativar o Cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {

                Banco.atualizaStatus(Convert.ToInt32(mskCodigo.Text), false);
                btDesativar.Enabled = false;
                txtNome.Clear();
                txtStatus.Clear();
                MessageBox.Show("Cliente DESATIVADO!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
            }
        }
    }
}
