namespace Sistema
{
    partial class FrmFunc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFunc));
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.cbBusca = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studifyPCDataSet = new Sistema.StudifyPCDataSet();
            this.tb_FuncionarioTableAdapter = new Sistema.StudifyPCDataSetTableAdapters.Tb_FuncionarioTableAdapter();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnMove = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studifyPCDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnMove.SuspendLayout();
            this.SuspendLayout();
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
            "CPF"});
            this.cbBusca.Location = new System.Drawing.Point(446, 10);
            this.cbBusca.Name = "cbBusca";
            this.cbBusca.Size = new System.Drawing.Size(212, 27);
            this.cbBusca.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFuncionarioDataGridViewTextBoxColumn,
            this.nomeFuncionarioDataGridViewTextBoxColumn,
            this.sexoFuncionarioDataGridViewTextBoxColumn,
            this.emailFuncionarioDataGridViewTextBoxColumn,
            this.telefoneFuncionarioDataGridViewTextBoxColumn,
            this.celularFuncionarioDataGridViewTextBoxColumn,
            this.cPFFuncionarioDataGridViewTextBoxColumn,
            this.rGFuncionarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbFuncionarioBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Light", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(13, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(775, 474);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idFuncionarioDataGridViewTextBoxColumn
            // 
            this.idFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Id_Funcionario";
            this.idFuncionarioDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idFuncionarioDataGridViewTextBoxColumn.Name = "idFuncionarioDataGridViewTextBoxColumn";
            this.idFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idFuncionarioDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeFuncionarioDataGridViewTextBoxColumn
            // 
            this.nomeFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Nome_Funcionario";
            this.nomeFuncionarioDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeFuncionarioDataGridViewTextBoxColumn.Name = "nomeFuncionarioDataGridViewTextBoxColumn";
            this.nomeFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeFuncionarioDataGridViewTextBoxColumn.Width = 300;
            // 
            // sexoFuncionarioDataGridViewTextBoxColumn
            // 
            this.sexoFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Sexo_Funcionario";
            this.sexoFuncionarioDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoFuncionarioDataGridViewTextBoxColumn.Name = "sexoFuncionarioDataGridViewTextBoxColumn";
            this.sexoFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexoFuncionarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailFuncionarioDataGridViewTextBoxColumn
            // 
            this.emailFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Email_Funcionario";
            this.emailFuncionarioDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailFuncionarioDataGridViewTextBoxColumn.Name = "emailFuncionarioDataGridViewTextBoxColumn";
            this.emailFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailFuncionarioDataGridViewTextBoxColumn.Width = 300;
            // 
            // telefoneFuncionarioDataGridViewTextBoxColumn
            // 
            this.telefoneFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Telefone_Funcionario";
            this.telefoneFuncionarioDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneFuncionarioDataGridViewTextBoxColumn.Name = "telefoneFuncionarioDataGridViewTextBoxColumn";
            this.telefoneFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneFuncionarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // celularFuncionarioDataGridViewTextBoxColumn
            // 
            this.celularFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Celular_Funcionario";
            this.celularFuncionarioDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularFuncionarioDataGridViewTextBoxColumn.Name = "celularFuncionarioDataGridViewTextBoxColumn";
            this.celularFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.celularFuncionarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // cPFFuncionarioDataGridViewTextBoxColumn
            // 
            this.cPFFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "CPF_Funcionario";
            this.cPFFuncionarioDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFFuncionarioDataGridViewTextBoxColumn.Name = "cPFFuncionarioDataGridViewTextBoxColumn";
            this.cPFFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPFFuncionarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // rGFuncionarioDataGridViewTextBoxColumn
            // 
            this.rGFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "RG_Funcionario";
            this.rGFuncionarioDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rGFuncionarioDataGridViewTextBoxColumn.Name = "rGFuncionarioDataGridViewTextBoxColumn";
            this.rGFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.rGFuncionarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // tbFuncionarioBindingSource
            // 
            this.tbFuncionarioBindingSource.DataMember = "Tb_Funcionario";
            this.tbFuncionarioBindingSource.DataSource = this.studifyPCDataSet;
            // 
            // studifyPCDataSet
            // 
            this.studifyPCDataSet.DataSetName = "StudifyPCDataSet";
            this.studifyPCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_FuncionarioTableAdapter
            // 
            this.tb_FuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Image = global::Sistema.Properties.Resources.add_button_inside_black_circle;
            this.btnAdicionar.Location = new System.Drawing.Point(13, 9);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(229, 29);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "     ADICIONAR FUNCIONÁRIO";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.txtBusca);
            this.panel1.Controls.Add(this.cbBusca);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 45);
            this.panel1.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::Sistema.Properties.Resources.busca;
            this.btnBuscar.Location = new System.Drawing.Point(665, 9);
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
            this.pnMove.TabIndex = 10;
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
            this.btnMin.TabIndex = 3;
            this.btnMin.Text = "_";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
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
            this.btnClose.TabIndex = 2;
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
            this.btnAtualizar.Image = global::Sistema.Properties.Resources.reload;
            this.btnAtualizar.Location = new System.Drawing.Point(13, 80);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(142, 28);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.Text = "   ATUALIZAR";
            this.btnAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // FrmFunc
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
            this.Name = "FrmFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento dos Funcionários";
            this.Load += new System.EventHandler(this.FrmFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studifyPCDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnMove.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.ComboBox cbBusca;
        private System.Windows.Forms.Button btnBuscar;
        private StudifyPCDataSet studifyPCDataSet;
        private System.Windows.Forms.BindingSource tbFuncionarioBindingSource;
        private StudifyPCDataSetTableAdapters.Tb_FuncionarioTableAdapter tb_FuncionarioTableAdapter;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Panel pnMove;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGFuncionarioDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}