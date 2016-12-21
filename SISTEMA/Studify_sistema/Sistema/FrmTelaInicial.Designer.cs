namespace Sistema
{
    partial class FrmTelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaInicial));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnMeuPerfil = new System.Windows.Forms.Button();
            this.pctFoto = new System.Windows.Forms.PictureBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnSuporte = new System.Windows.Forms.Button();
            this.btnAlun = new System.Windows.Forms.Button();
            this.btnProf = new System.Windows.Forms.Button();
            this.btnFunc = new System.Windows.Forms.Button();
            this.studifyPCDataSet = new Sistema.StudifyPCDataSet();
            this.tbListaEmailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ListaEmailsTableAdapter = new Sistema.StudifyPCDataSetTableAdapters.Tb_ListaEmailsTableAdapter();
            this.pnMsg = new System.Windows.Forms.Panel();
            this.btnPreencher = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.studifyDataSet = new Sistema.StudifyDataSet();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studifyPCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbListaEmailsBindingSource)).BeginInit();
            this.pnMsg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studifyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.btnLog);
            this.panel1.Controls.Add(this.btnMeuPerfil);
            this.panel1.Controls.Add(this.pctFoto);
            this.panel1.Controls.Add(this.lblCargo);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 768);
            this.panel1.TabIndex = 3;
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnLog.FlatAppearance.BorderSize = 0;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.btnLog.ForeColor = System.Drawing.Color.White;
            this.btnLog.Location = new System.Drawing.Point(12, 379);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(230, 42);
            this.btnLog.TabIndex = 6;
            this.btnLog.Text = "LOG OUT";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnMeuPerfil
            // 
            this.btnMeuPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnMeuPerfil.FlatAppearance.BorderSize = 0;
            this.btnMeuPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeuPerfil.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.btnMeuPerfil.ForeColor = System.Drawing.Color.White;
            this.btnMeuPerfil.Location = new System.Drawing.Point(12, 331);
            this.btnMeuPerfil.Name = "btnMeuPerfil";
            this.btnMeuPerfil.Size = new System.Drawing.Size(230, 42);
            this.btnMeuPerfil.TabIndex = 5;
            this.btnMeuPerfil.Text = "MEU PERFIL";
            this.btnMeuPerfil.UseVisualStyleBackColor = false;
            this.btnMeuPerfil.Click += new System.EventHandler(this.btnMeuPerfil_Click);
            // 
            // pctFoto
            // 
            this.pctFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctFoto.ImageLocation = "";
            this.pctFoto.Location = new System.Drawing.Point(14, 12);
            this.pctFoto.Name = "pctFoto";
            this.pctFoto.Size = new System.Drawing.Size(230, 230);
            this.pctFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFoto.TabIndex = 2;
            this.pctFoto.TabStop = false;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.White;
            this.lblCargo.Location = new System.Drawing.Point(11, 292);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(52, 19);
            this.lblCargo.TabIndex = 1;
            this.lblCargo.Tag = "";
            this.lblCargo.Text = "Cargo";
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(11, 245);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(234, 47);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome completo";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold);
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(1255, 718);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(86, 23);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "00:00:00";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold);
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(1234, 741);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(132, 27);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "00/00/0000";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnMin);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnSobre);
            this.panel2.Controls.Add(this.btnSuporte);
            this.panel2.Controls.Add(this.btnAlun);
            this.panel2.Controls.Add(this.btnProf);
            this.panel2.Controls.Add(this.btnFunc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(259, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1107, 35);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Sistema.Properties.Resources.close_envelope__1_;
            this.button1.Location = new System.Drawing.Point(882, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 35);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(957, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(75, 35);
            this.btnMin.TabIndex = 6;
            this.btnMin.Text = "_";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1032, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSobre.FlatAppearance.BorderSize = 0;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ForeColor = System.Drawing.Color.White;
            this.btnSobre.Location = new System.Drawing.Point(668, 0);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(167, 35);
            this.btnSobre.TabIndex = 4;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnSuporte
            // 
            this.btnSuporte.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSuporte.FlatAppearance.BorderSize = 0;
            this.btnSuporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuporte.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuporte.ForeColor = System.Drawing.Color.White;
            this.btnSuporte.Location = new System.Drawing.Point(501, 0);
            this.btnSuporte.Name = "btnSuporte";
            this.btnSuporte.Size = new System.Drawing.Size(167, 35);
            this.btnSuporte.TabIndex = 3;
            this.btnSuporte.Text = "Suporte";
            this.btnSuporte.UseVisualStyleBackColor = true;
            this.btnSuporte.Visible = false;
            this.btnSuporte.Click += new System.EventHandler(this.btnSuporte_Click);
            // 
            // btnAlun
            // 
            this.btnAlun.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAlun.FlatAppearance.BorderSize = 0;
            this.btnAlun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlun.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlun.ForeColor = System.Drawing.Color.White;
            this.btnAlun.Location = new System.Drawing.Point(334, 0);
            this.btnAlun.Name = "btnAlun";
            this.btnAlun.Size = new System.Drawing.Size(167, 35);
            this.btnAlun.TabIndex = 2;
            this.btnAlun.Text = "Alunos";
            this.btnAlun.UseVisualStyleBackColor = true;
            this.btnAlun.Visible = false;
            this.btnAlun.Click += new System.EventHandler(this.btnAlun_Click);
            // 
            // btnProf
            // 
            this.btnProf.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProf.FlatAppearance.BorderSize = 0;
            this.btnProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf.ForeColor = System.Drawing.Color.White;
            this.btnProf.Location = new System.Drawing.Point(167, 0);
            this.btnProf.Name = "btnProf";
            this.btnProf.Size = new System.Drawing.Size(167, 35);
            this.btnProf.TabIndex = 1;
            this.btnProf.Text = "Professores";
            this.btnProf.UseVisualStyleBackColor = true;
            this.btnProf.Visible = false;
            this.btnProf.Click += new System.EventHandler(this.btnProf_Click);
            // 
            // btnFunc
            // 
            this.btnFunc.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFunc.FlatAppearance.BorderSize = 0;
            this.btnFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunc.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunc.ForeColor = System.Drawing.Color.White;
            this.btnFunc.Location = new System.Drawing.Point(0, 0);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(167, 35);
            this.btnFunc.TabIndex = 0;
            this.btnFunc.Text = "Funcionários";
            this.btnFunc.UseVisualStyleBackColor = true;
            this.btnFunc.Visible = false;
            this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // studifyPCDataSet
            // 
            this.studifyPCDataSet.DataSetName = "StudifyPCDataSet";
            this.studifyPCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbListaEmailsBindingSource
            // 
            this.tbListaEmailsBindingSource.DataMember = "Tb_ListaEmails";
            this.tbListaEmailsBindingSource.DataSource = this.studifyPCDataSet;
            // 
            // tb_ListaEmailsTableAdapter
            // 
            this.tb_ListaEmailsTableAdapter.ClearBeforeFill = true;
            // 
            // pnMsg
            // 
            this.pnMsg.BackColor = System.Drawing.Color.Transparent;
            this.pnMsg.BackgroundImage = global::Sistema.Properties.Resources.msg;
            this.pnMsg.Controls.Add(this.btnPreencher);
            this.pnMsg.Controls.Add(this.dataGridView1);
            this.pnMsg.Controls.Add(this.btnAtualizar);
            this.pnMsg.Location = new System.Drawing.Point(791, 41);
            this.pnMsg.Name = "pnMsg";
            this.pnMsg.Size = new System.Drawing.Size(431, 441);
            this.pnMsg.TabIndex = 7;
            this.pnMsg.Visible = false;
            // 
            // btnPreencher
            // 
            this.btnPreencher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnPreencher.FlatAppearance.BorderSize = 0;
            this.btnPreencher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreencher.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreencher.ForeColor = System.Drawing.Color.White;
            this.btnPreencher.Location = new System.Drawing.Point(268, 46);
            this.btnPreencher.Name = "btnPreencher";
            this.btnPreencher.Size = new System.Drawing.Size(148, 29);
            this.btnPreencher.TabIndex = 63;
            this.btnPreencher.Text = "COPIAR";
            this.btnPreencher.UseVisualStyleBackColor = false;
            this.btnPreencher.Click += new System.EventHandler(this.btnPreencher_Click);
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
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbListaEmailsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.FloralWhite;
            this.dataGridView1.Location = new System.Drawing.Point(17, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(399, 345);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(19)))));
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Image = global::Sistema.Properties.Resources.reload;
            this.btnAtualizar.Location = new System.Drawing.Point(17, 46);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(142, 28);
            this.btnAtualizar.TabIndex = 10;
            this.btnAtualizar.Text = "   ATUALIZAR";
            this.btnAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // studifyDataSet
            // 
            this.studifyDataSet.DataSetName = "StudifyDataSet";
            this.studifyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 350;
            // 
            // FrmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnMsg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmTelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studify";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTelaInicial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studifyPCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbListaEmailsBindingSource)).EndInit();
            this.pnMsg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studifyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblNome;
        public System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.PictureBox pctFoto;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnMeuPerfil;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button btnSobre;
        public System.Windows.Forms.Button btnSuporte;
        public System.Windows.Forms.Button btnAlun;
        public System.Windows.Forms.Button btnProf;
        public System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.Panel pnMsg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAtualizar;
        private StudifyPCDataSet studifyPCDataSet;
        private System.Windows.Forms.BindingSource tbListaEmailsBindingSource;
        private StudifyPCDataSetTableAdapters.Tb_ListaEmailsTableAdapter tb_ListaEmailsTableAdapter;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnPreencher;
        private StudifyDataSet studifyDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}