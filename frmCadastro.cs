using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sistema_de_Relacionamento_com_o_Cliente
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }
        
        private void frmCadastro_Load(object sender, EventArgs e)
        {
           
            if (this.Tag.ToString() == "ALTERAR")
            {
                progresso(10);
                btBuscar.Enabled = false;
                progresso(30);
                txtCodigo.Enabled = true;
                progresso(60);
                btNovo.Visible = false;
                progresso(80);
                btAlterar.Visible = true;
                progresso(90);
                btBuscar.Visible = true;
                progresso(100);
               
            }
        }


        private void ativarbotao(bool var)
        {
            
            txtNome.Enabled = var;
            txtEnd.Enabled = var;
            mskTxtFone.Enabled = var;
            txtCredito.Enabled = var;
            dateTimePicker1.Enabled = var;
            checkBox1.Enabled = var;
            btSalvar.Enabled = var;
        }
        private void limparcampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEnd.Clear();
            mskTxtFone.Clear();
            txtCredito.Clear();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            checkBox1.Checked = false;

        }


        private void btSalvar_Click(object sender, EventArgs e)
        {
           
            DialogResult res = MessageBox.Show("Tem certeza que deseja Adicionar Este Cliente?", "Cadastro de Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                
                Paciente cli = new Paciente();

                cli.Codigo = Convert.ToInt32(txtCodigo.Text);
                cli.Nome = txtNome.Text;
                cli.Profissao = txtEnd.Text;
               /* cli.DataNascimento = dateTimePicker1.Value;
                cli.Telefone = mskTxtFone.Text;
                cli.LimiteCredito = (txtCredito.Text =="") ? 0 : Convert.ToDecimal(txtCredito.Text) ;
                cli.Status = checkBox1.Checked;*/
                bool op = (this.Tag == "CADASTRAR") ? Banco.cadPaciente(cli) :  Banco.atualizaCliente(cli);
              
                btBuscar.Enabled = false;
                btSalvar.Enabled = false;
                txtCodigo.Enabled = true;
                btNovo.Enabled = true;
                
                txtCodigo.Focus();
                limparcampos();
                ativarbotao(false);
                
            }
            else
            {
                Banco.Conexao(false);
                // this.Close(); 
            }
        }
          
        private void btNovo_Click_2(object sender, EventArgs e)
        {

            DataTable cli;
            cli = Banco.buscarlastcli();
            
            //DialogResult res = MessageBox.Show(registro["CodCli"].ToString());
            
            DataRow registro = cli.Rows.Count.Equals(0)? null  : (cli.Rows[0]);

            ativarbotao(true);
            limparcampos();
            txtCodigo.Text = (cli.Rows.Count.Equals(0)) ? "1" : (int.Parse(registro["Codigo"].ToString()) + 1).ToString();
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            btNovo.Enabled = false;
            
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Gostaria de Fechar ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Banco.Conexao(false);
                this.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Gostaria de Fechar ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Banco.Conexao(false);
                this.Close();
            }

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
           
            Paciente cli = Banco.BuscaCodigo(Convert.ToInt32(txtCodigo.Text.Trim()));
            if (cli != null)
            {

                dateTimePicker1.Format = DateTimePickerFormat.Short;
                progresso(10);
                btAlterar.Enabled = true;
                progresso(20);
                txtNome.Text = cli.Nome;
                progresso(40);
                txtEnd.Text = cli.Profissao;
                progresso(50);
               /* dateTimePicker1.Value = cli.DataNascimento;
                progresso(70);
                mskTxtFone.Text = cli.Telefone;
                progresso(80);             
                txtCredito.Text = cli.LimiteCredito.ToString();
                txtCredito.Text = txtCredito.Text = "R$ "+txtCredito.Text;
                progresso(90);
                checkBox1.Checked = cli.Status;
                progresso(100);*/
            }
            else
            {
                MessageBox.Show("Cliente não Cadastrado ou Inativo!", "Aviso",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limparcampos();
                btBuscar.Enabled = false;
            }

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            
            btAlterar.Enabled = false;
            txtCodigo.Enabled = false;
            btSalvar.Enabled = true;
            ativarbotao(true);
            txtCredito.Text = txtCredito.Text.Remove(0,2);
        }

        private void txtCodigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim().Length > 0)
            {
                btBuscar.Enabled = true;
            }
            else
            {
                btBuscar.Enabled = false;
            }

        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) e.SuppressKeyPress = true;
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCodigo.Text.Trim().Length > 0)
                {
                    btBuscar.Enabled = true;
                    btBuscar.Focus();
                }
            }
        }
        public void progresso(int contador) 
        {
                   
            FormPrincipal frm = (FormPrincipal)this.MdiParent;
            frm.BarraProgresso.Value = contador;
        }

        private void txtCredito_KeyDown(object sender, KeyEventArgs e)
        {
          
            if (e.KeyCode == Keys.Space) e.SuppressKeyPress = true;
        }

        private void txtCredito_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void txtCredito_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCredito_KeyPress(object sender, KeyPressEventArgs e)
       {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }

}