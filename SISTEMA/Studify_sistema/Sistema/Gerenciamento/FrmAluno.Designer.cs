namespace Sistema
{
    partial class FrmAluno
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAluno));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contato1AlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeResponsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoResponsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailResponsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatoResponsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFResponsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGResponsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbAlunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studifyPCDataSet = new Sistema.StudifyPCDataSet();
            this.tb_AlunoTableAdapter = new Sistema.StudifyPCDataSetTableAdapters.Tb_AlunoTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.cbBusca = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnMove = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studifyPCDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlunoDataGridViewTextBoxColumn,
            this.nomeAlunoDataGridViewTextBoxColumn,
            this.sexoAlunoDataGridViewTextBoxColumn,
            this.emailAlunoDataGridViewTextBoxColumn,
            this.contato1AlunoDataGridViewTextBoxColumn,
            this.rGAlunoDataGridViewTextBoxColumn,
            this.nomeResponsavelDataGridViewTextBoxColumn,
            this.sexoResponsavelDataGridViewTextBoxColumn,
            this.emailResponsavelDataGridViewTextBoxColumn,
            this.contatoResponsavelDataGridViewTextBoxColumn,
            this.cPFResponsavelDataGridViewTextBoxColumn,
            this.rGResponsavelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbAlunoBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(12, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(775, 474);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idAlunoDataGridViewTextBoxColumn
            // 
            this.idAlunoDataGridViewTextBoxColumn.DataPropertyName = "Id_Aluno";
            this.idAlunoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idAlunoDataGridViewTextBoxColumn.Name = "idAlunoDataGridViewTextBoxColumn";
            this.idAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAlunoDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeAlunoDataGridViewTextBoxColumn
            // 
            this.nomeAlunoDataGridViewTextBoxColumn.DataPropertyName = "Nome_Aluno";
            this.nomeAlunoDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeAlunoDataGridViewTextBoxColumn.Name = "nomeAlunoDataGridViewTextBoxColumn";
            this.nomeAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeAlunoDataGridViewTextBoxColumn.Width = 300;
            // 
            // sexoAlunoDataGridViewTextBoxColumn
            // 
            this.sexoAlunoDataGridViewTextBoxColumn.DataPropertyName = "Sexo_Aluno";
            this.sexoAlunoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoAlunoDataGridViewTextBoxColumn.Name = "sexoAlunoDataGridViewTextBoxColumn";
            this.sexoAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailAlunoDataGridViewTextBoxColumn
            // 
            this.emailAlunoDataGridViewTextBoxColumn.DataPropertyName = "Email_Aluno";
            this.emailAlunoDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailAlunoDataGridViewTextBoxColumn.Name = "emailAlunoDataGridViewTextBoxColumn";
            this.emailAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailAlunoDataGridViewTextBoxColumn.Width = 300;
            // 
            // contato1AlunoDataGridViewTextBoxColumn
            // 
            this.contato1AlunoDataGridViewTextBoxColumn.DataPropertyName = "Contato1_Aluno";
            this.contato1AlunoDataGridViewTextBoxColumn.HeaderText = "Contato";
            this.contato1AlunoDataGridViewTextBoxColumn.Name = "contato1AlunoDataGridViewTextBoxColumn";
            this.contato1AlunoDataGridViewTextBoxColumn.ReadOnly = true;
            this.contato1AlunoDataGridViewTextBoxColumn.Width = 150;
            // 
            // rGAlunoDataGridViewTextBoxColumn
            // 
            this.rGAlunoDataGridViewTextBoxColumn.DataPropertyName = "RG_Aluno";
            this.rGAlunoDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rGAlunoDataGridViewTextBoxColumn.Name = "rGAlunoDataGridViewTextBoxColumn";
            this.rGAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            this.rGAlunoDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomeResponsavelDataGridViewTextBoxColumn
            // 
            this.nomeResponsavelDataGridViewTextBoxColumn.DataPropertyName = "Nome_Responsavel";
            this.nomeResponsavelDataGridViewTextBoxColumn.HeaderText = "Nome Responsavel";
            this.nomeResponsavelDataGridViewTextBoxColumn.Name = "nomeResponsavelDataGridViewTextBoxColumn";
            this.nomeResponsavelDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeResponsavelDataGridViewTextBoxColumn.Width = 300;
            // 
            // sexoResponsavelDataGridViewTextBoxColumn
            // 
            this.sexoResponsavelDataGridViewTextBoxColumn.DataPropertyName = "Sexo_Responsavel";
            this.sexoResponsavelDataGridViewTextBoxColumn.HeaderText = "Sexo Responsavel";
            this.sexoResponsavelDataGridViewTextBoxColumn.Name = "sexoResponsavelDataGridViewTextBoxColumn";
            this.sexoResponsavelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailResponsavelDataGridViewTextBoxColumn
            // 
            this.emailResponsavelDataGridViewTextBoxColumn.DataPropertyName = "Email_Responsavel";
            this.emailResponsavelDataGridViewTextBoxColumn.HeaderText = "Email Responsavel";
            this.emailResponsavelDataGridViewTextBoxColumn.Name = "emailResponsavelDataGridViewTextBoxColumn";
            this.emailResponsavelDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailResponsavelDataGridViewTextBoxColumn.Width = 300;
            // 
            // contatoResponsavelDataGridViewTextBoxColumn
            // 
            this.contatoResponsavelDataGridViewTextBoxColumn.DataPropertyName = "Contato_Responsavel";
            this.contatoResponsavelDataGridViewTextBoxColumn.HeaderText = "Contato Responsavel";
            this.contatoResponsavelDataGridViewTextBoxColumn.Name = "contatoResponsavelDataGridViewTextBoxColumn";
            this.contatoResponsavelDataGridViewTextBoxColumn.ReadOnly = true;
            this.contatoResponsavelDataGridViewTextBoxColumn.Width = 150;
            // 
            // cPFResponsavelDataGridViewTextBoxColumn
            // 
            this.cPFResponsavelDataGridViewTextBoxColumn.DataPropertyName = "CPF_Responsavel";
            this.cPFResponsavelDataGridViewTextBoxColumn.HeaderText = "CPF Responsavel";
            this.cPFResponsavelDataGridViewTextBoxColumn.Name = "cPFResponsavelDataGridViewTextBoxColumn";
            this.cPFResponsavelDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPFResponsavelDataGridViewTextBoxColumn.Width = 150;
            // 
            // rGResponsavelDataGridViewTextBoxColumn
            // 
            this.rGResponsavelDataGridViewTextBoxColumn.DataPropertyName = "RG_Responsavel";
            this.rGResponsavelDataGridViewTextBoxColumn.HeaderText = "RG Responsavel";
            this.rGResponsavelDataGridViewTextBoxColumn.Name = "rGResponsavelDataGridViewTextBoxColumn";
            this.rGResponsavelDataGridViewTextBoxColumn.ReadOnly = true;
            this.rGResponsavelDataGridViewTextBoxColumn.Width = 150;
            // 
            // tbAlunoBindingSource
            // 
            this.tbAlunoBindingSource.DataMember = "Tb_Aluno";
            this.tbAlunoBindingSource.DataSource = this.studifyPCDataSet;
            // 
            // studifyPCDataSet
            // 
            this.studifyPCDataSet.DataSetName = "StudifyPCDataSet";
            this.studifyPCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_AlunoTableAdapter
            // 
            this.tb_AlunoTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.txtBusca);
            this.panel1.Controls.Add(this.cbBusca);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 45);
            this.panel1.TabIndex = 12;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Image = global::Sistema.Properties.Resources.add_button_inside_black_circle;
            this.btnAdicionar.Location = new System.Drawing.Point(12, 9);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(229, 29);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "     ADICIONAR ALUNO";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusca.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.ForeColor = System.Drawing.Color.White;
            this.txtBusca.Location = new System.Drawing.Point(247, 10);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(193, 27);
            this.txtBusca.TabIndex = 1;
            // 
            // cbBusca
            // 
            this.cbBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.cbBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBusca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbBusca.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBusca.ForeColor = System.Drawing.Color.White;
            this.cbBusca.FormattingEnabled = true;
            this.cbBusca.Items.AddRange(new object[] {
            "Selecione um item",
            "ID",
            "Nome",
            "Email",
            "RG",
            "CPF",
            "Nome Responsável",
            "Email Responsável",
            "RG Responsável",
            "CPF Responsável"});
            this.cbBusca.Location = new System.Drawing.Point(446, 10);
            this.cbBusca.Name = "cbBusca";
            this.cbBusca.Size = new System.Drawing.Size(212, 27);
            this.cbBusca.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::Sistema.Properties.Resources.busca;
            this.btnBuscar.Location = new System.Drawing.Point(664, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(123, 29);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "    BUSCAR";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pnMove
            // 
            this.pnMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnMove.Controls.Add(this.btnMin);
            this.pnMove.Controls.Add(this.btnClose);
            this.pnMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMove.Location = new System.Drawing.Point(0, 0);
            this.pnMove.Name = "pnMove";
            this.pnMove.Size = new System.Drawing.Size(800, 30);
            this.pnMove.TabIndex = 14;
            this.pnMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnMove_MouseDown);
            this.pnMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnMove_MouseMove);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(612, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(94, 30);
            this.btnMin.TabIndex = 1;
            this.btnMin.Text = "_";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(706, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(19)))));
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.Location = new System.Drawing.Point(12, 80);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(142, 28);
            this.btnAtualizar.TabIndex = 13;
            this.btnAtualizar.Text = "   ATUALIZAR";
            this.btnAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // FrmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnMove);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento dos Alunos";
            this.Load += new System.EventHandler(this.FrmAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studifyPCDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnMove.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private StudifyPCDataSet studifyPCDataSet;
        private System.Windows.Forms.BindingSource tbAlunoBindingSource;
        private StudifyPCDataSetTableAdapters.Tb_AlunoTableAdapter tb_AlunoTableAdapter;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.ComboBox cbBusca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel pnMove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contato1AlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeResponsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoResponsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailResponsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatoResponsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFResponsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGResponsavelDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}