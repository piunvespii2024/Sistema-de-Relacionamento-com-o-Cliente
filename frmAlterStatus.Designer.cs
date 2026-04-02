namespace Sistema_de_Relacionamento_com_o_Cliente
{
    partial class frmAlteraStatus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btAtivar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.mskCodigo = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbnome = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lbstatus = new System.Windows.Forms.Label();
            this.btDesativar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código do Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btAtivar
            // 
            this.btAtivar.Enabled = false;
            this.btAtivar.Location = new System.Drawing.Point(201, 118);
            this.btAtivar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAtivar.Name = "btAtivar";
            this.btAtivar.Size = new System.Drawing.Size(115, 28);
            this.btAtivar.TabIndex = 2;
            this.btAtivar.Text = "Ativar";
            this.btAtivar.UseVisualStyleBackColor = true;
            this.btAtivar.Click += new System.EventHandler(this.btAtivar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(201, 37);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(115, 34);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // mskCodigo
            // 
            this.mskCodigo.Location = new System.Drawing.Point(14, 37);
            this.mskCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskCodigo.Mask = "00000";
            this.mskCodigo.Name = "mskCodigo";
            this.mskCodigo.PromptChar = ' ';
            this.mskCodigo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mskCodigo.Size = new System.Drawing.Size(66, 22);
            this.mskCodigo.TabIndex = 0;
            this.mskCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskCodigo.ValidatingType = typeof(int);
            this.mskCodigo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCodigo_MaskInputRejected);
            this.mskCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskCodigo_KeyDown);
            this.mskCodigo.Leave += new System.EventHandler(this.mskCodigo_Leave);
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(14, 90);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(302, 22);
            this.txtNome.TabIndex = 7;
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Location = new System.Drawing.Point(11, 71);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(45, 17);
            this.lbnome.TabIndex = 8;
            this.lbnome.Text = "Nome";
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(14, 131);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(128, 22);
            this.txtStatus.TabIndex = 9;
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.Location = new System.Drawing.Point(11, 113);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(63, 17);
            this.lbstatus.TabIndex = 10;
            this.lbstatus.Text = "Situação";
            // 
            // btDesativar
            // 
            this.btDesativar.Enabled = false;
            this.btDesativar.Location = new System.Drawing.Point(200, 151);
            this.btDesativar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDesativar.Name = "btDesativar";
            this.btDesativar.Size = new System.Drawing.Size(115, 27);
            this.btDesativar.TabIndex = 3;
            this.btDesativar.Text = "Desativar";
            this.btDesativar.UseVisualStyleBackColor = true;
            this.btDesativar.Click += new System.EventHandler(this.btDesativar_Click);
            // 
            // frmAlteraStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 183);
            this.Controls.Add(this.btDesativar);
            this.Controls.Add(this.lbstatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.mskCodigo);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btAtivar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlteraStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alterar Status";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAtivar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.MaskedTextBox mskCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lbstatus;
        private System.Windows.Forms.Button btDesativar;
    }
}