namespace Sistema
{
    partial class FrmProf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProf));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProfessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProfessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoProfessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailProfessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaProfessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contato1ProfessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFProfessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segmentoProfessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplinaProfessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorAulaProfessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avaliacaoProfessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skypeProfessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facebookProfessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkedinProfessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.youtubeProfessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbProfessorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studifyPCDataSet = new Sistema.StudifyPCDataSet();
            this.cbBusca = new System.Windows.Forms.ComboBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.tb_ProfessorTableAdapter = new Sistema.StudifyPCDataSetTableAdapters.Tb_ProfessorTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnMove = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProfessorBindingSource)).BeginInit();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProfessorDataGridViewTextBoxColumn,
            this.nomeProfessorDataGridViewTextBoxColumn,
            this.sexoProfessorDataGridViewTextBoxColumn,
            this.emailProfessorDataGridViewTextBoxColumn,
            this.senhaProfessorDataGridViewTextBoxColumn,
            this.contato1ProfessorDataGridViewTextBoxColumn,
            this.cPFProfessorDataGridViewTextBoxColumn,
            this.segmentoProfessorDataGridViewTextBoxColumn,
            this.disciplinaProfessorDataGridViewTextBoxColumn,
            this.valorAulaProfessorDataGridViewTextBoxColumn,
            this.avaliacaoProfessorDataGridViewTextBoxColumn,
            this.skypeProfessorDataGridViewTextBoxColumn,
            this.facebookProfessorDataGridViewTextBoxColumn,
            this.linkedinProfessorDataGridViewTextBoxColumn,
            this.youtubeProfessorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbProfessorBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Light", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(776, 474);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idProfessorDataGridViewTextBoxColumn
            // 
            this.idProfessorDataGridViewTextBoxColumn.DataPropertyName = "Id_Professor";
            this.idProfessorDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idProfessorDataGridViewTextBoxColumn.Name = "idProfessorDataGridViewTextBoxColumn";
            this.idProfessorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProfessorDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeProfessorDataGridViewTextBoxColumn
            // 
            this.nomeProfessorDataGridViewTextBoxColumn.DataPropertyName = "Nome_Professor";
            this.nomeProfessorDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeProfessorDataGridViewTextBoxColumn.Name = "nomeProfessorDataGridViewTextBoxColumn";
            this.nomeProfessorDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeProfessorDataGridViewTextBoxColumn.Width = 300;
            // 
            // sexoProfessorDataGridViewTextBoxColumn
            // 
            this.sexoProfessorDataGridViewTextBoxColumn.DataPropertyName = "Sexo_Professor";
            this.sexoProfessorDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoProfessorDataGridViewTextBoxColumn.Name = "sexoProfessorDataGridViewTextBoxColumn";
            this.sexoProfessorDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexoProfessorDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailProfessorDataGridViewTextBoxColumn
            // 
            this.emailProfessorDataGridViewTextBoxColumn.DataPropertyName = "Email_Professor";
            this.emailProfessorDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailProfessorDataGridViewTextBoxColumn.Name = "emailProfessorDataGridViewTextBoxColumn";
            this.emailProfessorDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailProfessorDataGridViewTextBoxColumn.Width = 300;
            // 
            // senhaProfessorDataGridViewTextBoxColumn
            // 
            this.senhaProfessorDataGridViewTextBoxColumn.DataPropertyName = "Senha_Professor";
            this.senhaProfessorDataGridViewTextBoxColumn.HeaderText = "Senha";
            this.senhaProfessorDataGridViewTextBoxColumn.Name = "senhaProfessorDataGridViewTextBoxColumn";
            this.senhaProfessorDataGridViewTextBoxColumn.ReadOnly = true;
            this.senhaProfessorDataGridViewTextBoxColumn.Width = 150;
            // 
            // contato1ProfessorDataGridViewTextBoxColumn
            // 
            this.contato1ProfessorDataGridViewTextBoxColumn.DataPropertyName = "Contato1_Professor";
            this.contato1ProfessorDataGridViewTextBoxColumn.HeaderText = "Contato";
            this.contato1ProfessorDataGridViewTextBoxColumn.Name = "contato1ProfessorDataGridViewTextBoxColumn";
            this.contato1ProfessorDataGridViewTextBoxColumn.ReadOnly = true;
            this.contato1ProfessorDataGridViewTextBoxColumn.Width = 150;
            // 
            // cPFProfessorDataGridViewTextBoxColumn
            // 
            this.cPFProfessorDataGridViewTextBoxColumn.DataPropertyName = "CPF_Professor";
            this.cPFProfessorDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFProfessorDataGridViewTextBoxColumn.Name = "cPFProfessorDataGridViewTextBoxColumn";
            this.cPFProfessorDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPFProfessorDataGridViewTextBoxColumn.Width = 150;
            // 
            // segmentoProfessorDataGridViewTextBoxColumn
            // 
            this.segmentoProfessorDataGridViewTextBoxColumn.DataPropertyName = "Segmento_Professor";
            this.segmentoProfessorDataGridViewTextBoxColumn.HeaderText = "Segmento";
            this.segmentoProfessorDataGridViewTextBoxColumn.Name = "segmentoProfessorDataGridViewTextBoxColumn";
            this.segmentoProfessorDataGridViewTextBoxColumn.ReadOnly = true;
            this.segmentoProfessorDataGridViewTextBoxColumn.Width = 250;
            // 
            // disciplinaProfessorDataGridViewTextBoxColumn
            // 
            this.disciplinaProfessorDataGridViewTextBoxColumn.DataPropertyName = "Disciplina_Professor";
            this.disciplinaProfessorDataGridViewTextBoxColumn.HeaderText = "Disciplina";
            this.disciplinaProfessorDataGridViewTextBoxColumn.Name = "disciplinaProfessorDataGridViewTextBoxColumn";
            this.disciplinaProfessorDataGridViewTextBoxColumn.ReadOnly = true;
            this.disciplinaProfessorDataGridViewTextBoxColumn.Width = 250;
            // 
            // valorAulaProfessorDataGridViewTextBoxColumn
            // 
            this.valorAulaProfessorDataGridViewTextBoxColumn.DataPropertyName = "Valor_Aula_Professor";
            this.valorAulaProfessorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorAulaProfessorDataGridViewTextBoxColumn.Name = "valorAulaProfessorDataGridViewTextBoxColumn";
            this.valorAulaProfessorDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorAulaProfessorDataGridViewTextBoxColumn.Width = 50;
            // 
            // avaliacaoProfessorDataGridViewTextBoxColumn
            // 
            this.avaliacaoProfessorDataGridViewTextBoxColumn.DataPropertyName = "Avaliacao_Professor";
            this.avaliacaoProfessorDataGridViewTextBoxColumn.HeaderText = "Avaliacao";
            this.avaliacaoProfessorDataGridViewTextBoxColumn.Name = "avaliacaoProfessorDataGridViewTextBoxColumn";
            this.avaliacaoProfessorDataGridViewTextBoxColumn.ReadOnly = true;
            this.avaliacaoProfessorDataGridViewTextBoxColumn.Width = 50;
            // 
            // skypeProfessorDataGridViewTextBoxColumn
            // 
            this.skypeProfessorDataGridViewTextBoxColumn.DataPropertyName = "Skype_Professor";
            this.skypeProfessorDataGridViewTextBoxColumn.HeaderText = "Skype";
            this.skypeProfessorDataGridViewTextBoxColumn.Name = "skypeProfessorDataGridViewTextBoxColumn";
            this.skypeProfessorDataGridViewTextBoxColumn.ReadOnly = true;
            this.skypeProfessorDataGridViewTextBoxColumn.Width = 150;
            // 
            // facebookProfessorDataGridViewTextBoxColumn
            // 
            this.facebookProfessorDataGridViewTextBoxColumn.DataPropertyName = "Facebook_Professor";
            this.facebookProfessorDataGridViewTextBoxColumn.HeaderText = "Facebook";
            this.facebookProfessorDataGridViewTextBoxColumn.Name = "facebookProfessorDataGridViewTextBoxColumn";
            this.facebookProfessorDataGridViewTextBoxColumn.ReadOnly = true;
            this.facebookProfessorDataGridViewTextBoxColumn.Width = 150;
            // 
            // linkedinProfessorDataGridViewTextBoxColumn
            // 
            this.linkedinProfessorDataGridViewTextBoxColumn.DataPropertyName = "Linkedin_Professor";
            this.linkedinProfessorDataGridViewTextBoxColumn.HeaderText = "Linkedin";
            this.linkedinProfessorDataGridViewTextBoxColumn.Name = "linkedinProfessorDataGridViewTextBoxColumn";
            this.linkedinProfessorDataGridViewTextBoxColumn.ReadOnly = true;
            this.linkedinProfessorDataGridViewTextBoxColumn.Width = 150;
            // 
            // youtubeProfessorDataGridViewTextBoxColumn
            // 
            this.youtubeProfessorDataGridViewTextBoxColumn.DataPropertyName = "Youtube_Professor";
            this.youtubeProfessorDataGridViewTextBoxColumn.HeaderText = "Youtube";
            this.youtubeProfessorDataGridViewTextBoxColumn.Name = "youtubeProfessorDataGridViewTextBoxColumn";
            this.youtubeProfessorDataGridViewTextBoxColumn.ReadOnly = true;
            this.youtubeProfessorDataGridViewTextBoxColumn.Width = 150;
            // 
            // tbProfessorBindingSource
            // 
            this.tbProfessorBindingSource.DataMember = "Tb_Professor";
            this.tbProfessorBindingSource.DataSource = this.studifyPCDataSet;
            // 
            // studifyPCDataSet
            // 
            this.studifyPCDataSet.DataSetName = "StudifyPCDataSet";
            this.studifyPCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.cbBusca.Location = new System.Drawing.Point(447, 10);
            this.cbBusca.Name = "cbBusca";
            this.cbBusca.Size = new System.Drawing.Size(212, 27);
            this.cbBusca.TabIndex = 9;
            // 
            // txtBusca
            // 
            this.txtBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusca.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.ForeColor = System.Drawing.Color.White;
            this.txtBusca.Location = new System.Drawing.Point(248, 10);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(193, 27);
            this.txtBusca.TabIndex = 8;
            // 
            // tb_ProfessorTableAdapter
            // 
            this.tb_ProfessorTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::Sistema.Properties.Resources.add_button_inside_black_circle;
            this.btnAdd.Location = new System.Drawing.Point(13, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(229, 29);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "     ADICIONAR PROFESSOR";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtBusca);
            this.panel1.Controls.Add(this.cbBusca);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 45);
            this.panel1.TabIndex = 14;
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
            this.btnBuscar.TabIndex = 10;
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
            this.pnMove.TabIndex = 16;
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
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.Location = new System.Drawing.Point(12, 80);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(142, 28);
            this.btnAtualizar.TabIndex = 15;
            this.btnAtualizar.Text = "    ATUALIZAR";
            this.btnAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // FrmProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnMove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmProf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento dos Professores";
            this.Load += new System.EventHandler(this.FrmProf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProfessorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studifyPCDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnMove.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbBusca;
        private System.Windows.Forms.TextBox txtBusca;
        private StudifyPCDataSet studifyPCDataSet;
        private System.Windows.Forms.BindingSource tbProfessorBindingSource;
        private StudifyPCDataSetTableAdapters.Tb_ProfessorTableAdapter tb_ProfessorTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Panel pnMove;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProfessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProfessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoProfessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailProfessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaProfessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contato1ProfessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFProfessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segmentoProfessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplinaProfessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorAulaProfessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avaliacaoProfessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skypeProfessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facebookProfessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkedinProfessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn youtubeProfessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}