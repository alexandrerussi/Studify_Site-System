using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema
{
    public partial class FrmTelaInicial : Form
    {

        //CHAMANDO OS OBJETOS DO FORM
        FuncEdit editFunc = new FuncEdit();

        //ADICIONANDO AS CONEXÕES
        SqlConnection con = new SqlConnection(FrmLogin.strCn);

        //ADICIONANDO AS VARIÁVEIS
        public static string id, cargo;
        static string texto;
        public FrmTelaInicial()
        {
            InitializeComponent();
        }

        public void PermissUser()
        {
            editFunc.txtNome.ReadOnly = true;
            editFunc.txtEmail.ReadOnly = true;
            editFunc.txtTelefone.ReadOnly = true;
            editFunc.txtCelular.ReadOnly = true;
            editFunc.txtCPF.ReadOnly = true;
            editFunc.txtRG.ReadOnly = true;
            editFunc.txtDataNasc.ReadOnly = true;
            editFunc.txtCEP.ReadOnly = true;
            editFunc.txtCidade.ReadOnly = true;
            editFunc.txtEstado.ReadOnly = true;
            editFunc.txtEndereco.ReadOnly = true;
            editFunc.txtNum.ReadOnly = true;
            editFunc.txtComp.ReadOnly = true;
            editFunc.txtBairro.ReadOnly = true;
            editFunc.cbCargo.Enabled = false;
            editFunc.txtSalario.ReadOnly = true;
            editFunc.txtLogin.ReadOnly = true;
            editFunc.txtSenha.ReadOnly = true;
            editFunc.rdbFeminino.Enabled = false;
            editFunc.rdbMasculino.Enabled = false;
        }

        private void FrmTelaInicial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studifyPCDataSet.Tb_ListaEmails' table. You can move, or remove it, as needed.
            this.tb_ListaEmailsTableAdapter.Fill(this.studifyPCDataSet.Tb_ListaEmails);
            //Definindo o tamanho mínimo do form
            int deskHeight = Screen.PrimaryScreen.Bounds.Height;
            int deskWidth = Screen.PrimaryScreen.Bounds.Width;
            this.MinimumSize = new Size(deskWidth, deskHeight);
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = (DateTime.Now.ToString("HH:mm:ss"));
        }

        private void btnMeuPerfil_Click(object sender, EventArgs e)
        {

            string verificaLoginSQL = "select * from Tb_Funcionario where Id_Funcionario=" + id;
            SqlCommand cmd = new SqlCommand(verificaLoginSQL, con);
            SqlDataReader DR;
            try
            {
                con.Open();
                DR = cmd.ExecuteReader();
                if (DR.Read())
                {
                    editFunc.rdbFeminino.Enabled = true;
                    editFunc.rdbMasculino.Enabled = true;
                    editFunc.btnAdicionar.Visible = false;
                    //EM ORDEM DO BANCO DE DADOS
                    editFunc.lblID.Text = DR.GetValue(0).ToString();
                    editFunc.txtNome.Text = DR.GetValue(1).ToString();
                    editFunc.pctFoto.ImageLocation = @"..\..\..\..\..\SITE\" + DR.GetValue(2).ToString().Replace("/", @"\");

                    if (DR.GetValue(3).ToString() == "Masculino")
                    {
                        editFunc.rdbMasculino.Checked = true;
                    }
                    else
                    {
                        editFunc.rdbFeminino.Checked = true;
                    }
                    editFunc.txtEmail.Text = DR.GetValue(4).ToString();
                    editFunc.txtTelefone.Text = DR.GetValue(5).ToString();
                    editFunc.txtCelular.Text = DR.GetValue(6).ToString();
                    editFunc.txtCPF.Text = DR.GetValue(7).ToString();
                    editFunc.txtRG.Text = DR.GetValue(8).ToString();
                    editFunc.txtDataNasc.Text = DR.GetValue(9).ToString();
                    editFunc.txtCEP.Text = DR.GetValue(10).ToString();
                    editFunc.txtEndereco.Text = DR.GetValue(11).ToString();
                    editFunc.txtNum.Text = DR.GetValue(12).ToString();
                    editFunc.txtComp.Text = DR.GetValue(13).ToString();
                    editFunc.txtBairro.Text = DR.GetValue(14).ToString();
                    editFunc.txtCidade.Text = DR.GetValue(15).ToString();
                    editFunc.txtEstado.Text = DR.GetValue(16).ToString();
                    editFunc.cbCargo.Text = DR.GetValue(17).ToString();
                    editFunc.txtSalario.Text = DR.GetValue(18).ToString();
                    editFunc.txtLogin.Text = DR.GetValue(19).ToString();
                    editFunc.txtSenha.Text = DR.GetValue(20).ToString();

                    //Apenas ler
                    PermissUser();

                    //

                    editFunc.pnDadosImp.Visible = true;
                    editFunc.lblPermissão.Visible = false;
                    editFunc.Size = new System.Drawing.Size(763, 560);
                    editFunc.btnAtualizar.Visible = false;
                    editFunc.btnDeletar.Visible = false;
                    editFunc.btnAlterar.Visible = false;
                    editFunc.cbExibir.Visible = true;
                    editFunc.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fazer log out?",
               "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Hide();
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "FrmFunc")
                {
                    i = -1;
                    break;
                }
            }

            if (i != -1)
            {
                FrmFunc func = new FrmFunc();
                func.MdiParent = this;
                func.Show();
            }
        }

        private void btnProf_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "FrmProf")
                {
                    i = -1;
                    break;
                }
            }

            if (i != -1)
            {
                FrmProf prof = new FrmProf();
                prof.MdiParent = this;
                prof.Show();
            }
        }

        private void btnAlun_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "FrmAluno")
                {
                    i = -1;
                    break;
                }
            }

            if (i != -1)
            {
                FrmAluno aluno = new FrmAluno();
                aluno.MdiParent = this;
                aluno.Show();
            }
        }

        private void btnSuporte_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmSuporte")
                {
                    i = -1;
                    break;
                }
            }

            if (i != -1)
            {
                frmSuporte sup = new frmSuporte();
                sup.MdiParent = this;
                sup.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pnMsg.Visible == false)
            {
                pnMsg.Visible = true;
            }
            else if (pnMsg.Visible == true)
            {
                pnMsg.Visible = false;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string strSql = "SELECT * FROM Tb_ListaEmails";
            SqlCommand cmd = new SqlCommand(strSql, con);

            //abre a conexao
            con.Open();

            //define o tipo do comando 
            cmd.CommandType = CommandType.Text;
            //cria um dataadapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //cria um objeto datatable
            DataTable clientes = new DataTable();

            //preenche o datatable via dataadapter
            da.Fill(clientes);

            //atribui o datatable ao datagridview para exibir o resultado
            dataGridView1.DataSource = clientes;

            con.Close();
        }

        private void btnPreencher_Click(object sender, EventArgs e)
        {
            //abre a conexao
            con.Open();
            string strSql = "SELECT Email FROM Tb_ListaEmails";

            string contaSql = "select count(email) from Tb_ListaEmails";
            SqlCommand cmdConta = new SqlCommand(contaSql, con);
            int id = Convert.ToInt32(cmdConta.ExecuteScalar());
            SqlCommand cmd = new SqlCommand(strSql, con);
            SqlDataReader DR;

            DR = cmd.ExecuteReader();
            if (DR.Read())
            {

                for (int i = 0; i < id; i++)
                {
                    texto = texto + " " +dataGridView1.Rows[i].Cells[0].Value.ToString();
                }
                Clipboard.SetText(texto);
                MessageBox.Show("Copiado");
                con.Close();

            }
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.ShowDialog();
        }
    }
}
