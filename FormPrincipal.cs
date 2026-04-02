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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
           
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult res = MessageBox.Show("Tem certeza que deseja sair da aplicação?","Controle de Tarefas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes) Application.Exit();

        }

        protected void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmCadastro frmcad  = new frmCadastro();
            frmcad.MdiParent = (FormPrincipal)this;
            frmcad.Tag = "CADASTRAR";
            frmcad.Show();
            

        }

        private void alterarStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlteraStatus frm = new frmAlteraStatus();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSobre frm = new frmSobre();
            
            frm.ShowDialog();
        }

        private void FormPrincipal_Load_1(object sender, EventArgs e)
        {

        }

        private void BarraProgresso_Click(object sender, EventArgs e)
        {

        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void porCodigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) 
            { 
                if ( this.ActiveMdiChild.Name == "frmConsultaCli") this.ActiveMdiChild.Close();
            }
            frmConsultaCli frm = new frmConsultaCli();
            frm.MdiParent = this;
            frm.Tag = "CODIGO";
            frm.Text = "Consultar Pelo CÓDIGO do Cliente";
            frm.Show();
            
        }

        private void porNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild.Name == "frmConsultaCli") this.ActiveMdiChild.Close();
            }
            frmConsultaCli frm = new frmConsultaCli();
            frm.MdiParent = this;
            frm.Tag = "NOME";
            frm.Text = "Consultar Pelo NOME do Cliente";
            frm.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastro frmAlt = new frmCadastro();
            frmAlt.MdiParent = this;
            frmAlt.Text = "ALTERAR CADASTRO";
            frmAlt.Tag = "ALTERAR";
            frmAlt.Show();
        }

        private void porCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelCodigo frmRel = new frmRelCodigo();
            frmRel.MdiParent = this;
            frmRel.Show();
      
        }

        private void porNomeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelNome frmRel = new frmRelNome();
            frmRel.MdiParent = this;
            frmRel.Show();
        }

        private void aniverssarianteDoMêsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelAniversario frmRel = new frmRelAniversario();
            frmRel.MdiParent = this;
            frmRel.Show();
        }
    }
}
