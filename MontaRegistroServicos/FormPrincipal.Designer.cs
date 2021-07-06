
namespace MontaRegistroServicos
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.TBTextoOriginal = new System.Windows.Forms.TextBox();
            this.TBTextoNovo = new System.Windows.Forms.TextBox();
            this.BtnProcessar = new System.Windows.Forms.Button();
            this.PBProgresso = new System.Windows.Forms.ProgressBar();
            this.TBStatus = new System.Windows.Forms.TextBox();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.TCPrincipal = new System.Windows.Forms.TabControl();
            this.tabQuery = new System.Windows.Forms.TabPage();
            this.tabParametros = new System.Windows.Forms.TabPage();
            this.DGVSchemas = new System.Windows.Forms.DataGridView();
            this.OFDArquivoJson = new System.Windows.Forms.OpenFileDialog();
            this.TBSiglaPadrao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBLocalPadrao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBAmbientePadrao = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ambiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.TBServicoPadrao = new System.Windows.Forms.TextBox();
            this.TCPrincipal.SuspendLayout();
            this.tabQuery.SuspendLayout();
            this.tabParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSchemas)).BeginInit();
            this.SuspendLayout();
            // 
            // TBTextoOriginal
            // 
            this.TBTextoOriginal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBTextoOriginal.Location = new System.Drawing.Point(6, 6);
            this.TBTextoOriginal.Multiline = true;
            this.TBTextoOriginal.Name = "TBTextoOriginal";
            this.TBTextoOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBTextoOriginal.Size = new System.Drawing.Size(846, 243);
            this.TBTextoOriginal.TabIndex = 0;
            // 
            // TBTextoNovo
            // 
            this.TBTextoNovo.Location = new System.Drawing.Point(6, 255);
            this.TBTextoNovo.Multiline = true;
            this.TBTextoNovo.Name = "TBTextoNovo";
            this.TBTextoNovo.ReadOnly = true;
            this.TBTextoNovo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBTextoNovo.Size = new System.Drawing.Size(846, 243);
            this.TBTextoNovo.TabIndex = 1;
            this.TBTextoNovo.DoubleClick += new System.EventHandler(this.TBTextoNovo_DoubleClick);
            this.TBTextoNovo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBTextoNovo_KeyDown);
            // 
            // BtnProcessar
            // 
            this.BtnProcessar.Location = new System.Drawing.Point(355, 542);
            this.BtnProcessar.Name = "BtnProcessar";
            this.BtnProcessar.Size = new System.Drawing.Size(75, 23);
            this.BtnProcessar.TabIndex = 2;
            this.BtnProcessar.Text = "Processar";
            this.BtnProcessar.UseVisualStyleBackColor = true;
            this.BtnProcessar.Click += new System.EventHandler(this.BtnProcessar_Click);
            // 
            // PBProgresso
            // 
            this.PBProgresso.Location = new System.Drawing.Point(546, 574);
            this.PBProgresso.Name = "PBProgresso";
            this.PBProgresso.Size = new System.Drawing.Size(318, 16);
            this.PBProgresso.Step = 1;
            this.PBProgresso.TabIndex = 0;
            this.PBProgresso.Visible = false;
            // 
            // TBStatus
            // 
            this.TBStatus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TBStatus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TBStatus.Location = new System.Drawing.Point(-1, 572);
            this.TBStatus.Name = "TBStatus";
            this.TBStatus.ReadOnly = true;
            this.TBStatus.Size = new System.Drawing.Size(867, 20);
            this.TBStatus.TabIndex = 0;
            this.TBStatus.TabStop = false;
            this.TBStatus.Text = "Pronto!";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnLimpar.Location = new System.Drawing.Point(436, 542);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpar.TabIndex = 3;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // TCPrincipal
            // 
            this.TCPrincipal.Controls.Add(this.tabQuery);
            this.TCPrincipal.Controls.Add(this.tabParametros);
            this.TCPrincipal.Location = new System.Drawing.Point(1, 6);
            this.TCPrincipal.Name = "TCPrincipal";
            this.TCPrincipal.SelectedIndex = 0;
            this.TCPrincipal.Size = new System.Drawing.Size(865, 530);
            this.TCPrincipal.TabIndex = 1;
            // 
            // tabQuery
            // 
            this.tabQuery.BackColor = System.Drawing.SystemColors.Control;
            this.tabQuery.Controls.Add(this.TBTextoOriginal);
            this.tabQuery.Controls.Add(this.TBTextoNovo);
            this.tabQuery.Location = new System.Drawing.Point(4, 22);
            this.tabQuery.Name = "tabQuery";
            this.tabQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuery.Size = new System.Drawing.Size(857, 504);
            this.tabQuery.TabIndex = 0;
            this.tabQuery.Text = "Principal";
            // 
            // tabParametros
            // 
            this.tabParametros.BackColor = System.Drawing.SystemColors.Control;
            this.tabParametros.Controls.Add(this.label4);
            this.tabParametros.Controls.Add(this.TBServicoPadrao);
            this.tabParametros.Controls.Add(this.label3);
            this.tabParametros.Controls.Add(this.TBAmbientePadrao);
            this.tabParametros.Controls.Add(this.label2);
            this.tabParametros.Controls.Add(this.TBLocalPadrao);
            this.tabParametros.Controls.Add(this.label1);
            this.tabParametros.Controls.Add(this.TBSiglaPadrao);
            this.tabParametros.Controls.Add(this.DGVSchemas);
            this.tabParametros.Location = new System.Drawing.Point(4, 22);
            this.tabParametros.Name = "tabParametros";
            this.tabParametros.Padding = new System.Windows.Forms.Padding(3);
            this.tabParametros.Size = new System.Drawing.Size(857, 504);
            this.tabParametros.TabIndex = 1;
            this.tabParametros.Text = "Parametrizações";
            // 
            // DGVSchemas
            // 
            this.DGVSchemas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVSchemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSchemas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.sigla,
            this.servico,
            this.ambiente,
            this.local});
            this.DGVSchemas.Location = new System.Drawing.Point(4, 37);
            this.DGVSchemas.Name = "DGVSchemas";
            this.DGVSchemas.Size = new System.Drawing.Size(848, 461);
            this.DGVSchemas.TabIndex = 3;
            this.DGVSchemas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGVSchemas_KeyDown);
            // 
            // OFDArquivoJson
            // 
            this.OFDArquivoJson.FileName = "Schemas.json";
            // 
            // TBSiglaPadrao
            // 
            this.TBSiglaPadrao.Location = new System.Drawing.Point(76, 9);
            this.TBSiglaPadrao.Name = "TBSiglaPadrao";
            this.TBSiglaPadrao.Size = new System.Drawing.Size(86, 20);
            this.TBSiglaPadrao.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sigla padrão:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Local padrão:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TBLocalPadrao
            // 
            this.TBLocalPadrao.Location = new System.Drawing.Point(249, 9);
            this.TBLocalPadrao.Name = "TBLocalPadrao";
            this.TBLocalPadrao.Size = new System.Drawing.Size(86, 20);
            this.TBLocalPadrao.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ambiente padrão:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TBAmbientePadrao
            // 
            this.TBAmbientePadrao.Location = new System.Drawing.Point(443, 9);
            this.TBAmbientePadrao.Name = "TBAmbientePadrao";
            this.TBAmbientePadrao.Size = new System.Drawing.Size(86, 20);
            this.TBAmbientePadrao.TabIndex = 8;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // sigla
            // 
            this.sigla.HeaderText = "Sigla";
            this.sigla.Name = "sigla";
            // 
            // servico
            // 
            this.servico.HeaderText = "Serviço";
            this.servico.Name = "servico";
            // 
            // ambiente
            // 
            this.ambiente.HeaderText = "Ambiente";
            this.ambiente.Name = "ambiente";
            // 
            // local
            // 
            this.local.HeaderText = "Local";
            this.local.Name = "local";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(544, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Serviço padrão:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TBServicoPadrao
            // 
            this.TBServicoPadrao.Location = new System.Drawing.Point(630, 9);
            this.TBServicoPadrao.Name = "TBServicoPadrao";
            this.TBServicoPadrao.Size = new System.Drawing.Size(86, 20);
            this.TBServicoPadrao.TabIndex = 10;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 594);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.PBProgresso);
            this.Controls.Add(this.TCPrincipal);
            this.Controls.Add(this.TBStatus);
            this.Controls.Add(this.BtnProcessar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gera Registros de Serviços";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.TCPrincipal.ResumeLayout(false);
            this.tabQuery.ResumeLayout(false);
            this.tabQuery.PerformLayout();
            this.tabParametros.ResumeLayout(false);
            this.tabParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSchemas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBTextoOriginal;
        private System.Windows.Forms.TextBox TBTextoNovo;
        private System.Windows.Forms.Button BtnProcessar;
        private System.Windows.Forms.ProgressBar PBProgresso;
        private System.Windows.Forms.TextBox TBStatus;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.TabControl TCPrincipal;
        private System.Windows.Forms.TabPage tabParametros;
        private System.Windows.Forms.TabPage tabQuery;
        private System.Windows.Forms.DataGridView DGVSchemas;
        private System.Windows.Forms.OpenFileDialog OFDArquivoJson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBSiglaPadrao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBLocalPadrao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBAmbientePadrao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigla;
        private System.Windows.Forms.DataGridViewTextBoxColumn servico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ambiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn local;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBServicoPadrao;
    }
}