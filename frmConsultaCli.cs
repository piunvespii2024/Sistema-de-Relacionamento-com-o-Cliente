using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Relacionamento_com_o_Cliente
{
    public partial class frmConsultaCli : Form
    {
        public frmConsultaCli()
        {
            InitializeComponent();
        }

        private void btPesquisar_Click_1(object sender, EventArgs e)
        {
            
            if (this.Tag=="NOME")
            {
                DataTable cli = Banco.ListaClientes(0, txtNome.Text.Trim(), false);
                procurar(cli);
            }
            else
            {
                DataTable cli = Banco.ListaClientes(Convert.ToInt32(mskCodigo.Text.Trim()), "", true);
                procurar(cli);
            }
            
            this.mskCodigo.Clear();
            this.txtNome.Clear();
        }
        private void procurar(DataTable cli)
        {
            ArrayList clientArray = new ArrayList();
            if (cli.Rows.Count > 0)
            {
                
                DataRow registro = cli.Rows[0];

                clientArray.AddRange(registro.ItemArray);
                //clientArray.RemoveAt(0);
                
                if (Convert.ToBoolean(clientArray[6].ToString()))
                {
                    clientArray.RemoveAt(6);
                    clientArray.Insert(6, "Cliente Ativo");

                }
                else
                {
                    clientArray.RemoveAt(6);
                    clientArray.Insert(6, "Cliente Inativo");
                }
                lbDados.DataSource = clientArray;
            }
     
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mskCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            //e.SuppressKeyPress = !(e.KeyValue >= 48 && e.KeyValue <= 57);
            if (!char.IsDigit((char)e.KeyValue) && !char.IsControl((char)e.KeyValue))
            {
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (mskCodigo.Text.Trim().Length > 0)
                {
                    btPesquisar.Enabled = true;
                    btPesquisar.Focus();
                }
            }
            
            if (e.KeyCode == Keys.Space) e.SuppressKeyPress = true;
            
        }

        private void mskCodigo_Leave(object sender, EventArgs e)
        {
            if (mskCodigo.Text.Trim().Length > 0)
            {
                btPesquisar.Enabled = true;
            }
            else
            {
                btPesquisar.Enabled = false;
            }
        }

        private void mskCodigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmConsultaCli_Load(object sender, EventArgs e)
        {
            if (this.Tag == "CODIGO")
            {
                lbDigite.Text = "Digite o Código:";
                txtNome.Visible = false;
                mskCodigo.Visible = true;
            }
            else {
                lbDigite.Text = "Digite o Nome:";
                txtNome.Visible = true;
                mskCodigo.Visible = false;
            }


        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            {
                if (txtNome.Text.Trim().Length > 0)
                {
                    btPesquisar.Enabled = true;
                    btPesquisar.Focus();
                }
            }

        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim().Length > 0)
            {
                btPesquisar.Enabled = true;
            }
            else
            {
                btPesquisar.Enabled = false;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

           
    }
}
