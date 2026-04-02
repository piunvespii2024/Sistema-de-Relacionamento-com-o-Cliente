namespace Sistema_de_Relacionamento_com_o_Cliente
{
    partial class frmConsultaCli
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
            this.lbDados = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mskCodigo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDigite = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDados
            // 
            this.lbDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDados.Enabled = false;
            this.lbDados.FormattingEnabled = true;
            this.lbDados.ItemHeight = 16;
            this.lbDados.Location = new System.Drawing.Point(134, 58);
            this.lbDados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbDados.Name = "lbDados";
            this.lbDados.Size = new System.Drawing.Size(460, 114);
            this.lbDados.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Crédito           R$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Telefone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "STATUS";
            // 
            // mskCodigo
            // 
            this.mskCodigo.AllowPromptAsInput = false;
            this.mskCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mskCodigo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mskCodigo.Location = new System.Drawing.Point(134, 26);
            this.mskCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskCodigo.Mask = "00000";
            this.mskCodigo.Name = "mskCodigo";
            this.mskCodigo.PromptChar = ' ';
            this.mskCodigo.Size = new System.Drawing.Size(90, 26);
            this.mskCodigo.TabIndex = 0;
            this.mskCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskCodigo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCodigo.Visible = false;
            this.mskCodigo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCodigo_MaskInputRejected);
            this.mskCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskCodigo_KeyDown);
            this.mskCodigo.Leave += new System.EventHandler(this.mskCodigo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código";
            // 
            // lbDigite
            // 
            this.lbDigite.AutoSize = true;
            this.lbDigite.Location = new System.Drawing.Point(131, 7);
            this.lbDigite.Name = "lbDigite";
            this.lbDigite.Size = new System.Drawing.Size(169, 17);
            this.lbDigite.TabIndex = 11;
            this.lbDigite.Text = "Digite o Código do cliente";
            // 
            // txtNome
            // 
            this.txtNome.AcceptsReturn = true;
            this.txtNome.AcceptsTab = true;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNome.Location = new System.Drawing.Point(134, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(259, 24);
            this.txtNome.TabIndex = 1;
            this.txtNome.Visible = false;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(517, 26);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 12;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click_1);
            // 
            // frmConsultaCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 185);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbDigite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbDados);
            this.Controls.Add(this.mskCodigo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaCli";
            this.Text = "Consulta Clientes";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmConsultaCli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDigite;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btPesquisar;
    }
}