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
    public partial class FrmAluno : Form
    {
        public int idade;
        int x, y;
        Point Point = new Point();
        //Adicionando as conexões
        SqlConnection con = new SqlConnection(FrmLogin.strCn);
        public FrmAluno()
        {
            InitializeComponent();
        }

        private void FrmAluno_Load(object sender, EventArgs e)
        {
            cbBusca.SelectedIndex = 0;
            //define a instrução SQL
            string strSql = "SELECT * FROM Tb_Aluno";
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string strSql = "SELECT * FROM Tb_Aluno";
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbBusca.SelectedIndex != 0)
            {
                string strSql = null;
                con.Open();
                //atribuindo um caso para a categoria da busca
                /*
                ID
                Nome
                Email
                RG
                CPF
                Nome Responsável
                Email Responsável
                RG Responsável
                CPF Responsável
                
                */
                switch (cbBusca.SelectedIndex)
                {
                    case 1:
                        strSql = "SELECT * FROM Tb_Aluno WHERE Id_Aluno LIKE '%" + txtBusca.Text + "%'";
                        break;
                    case 2:
                        strSql = "SELECT * FROM Tb_Aluno WHERE Nome_Aluno LIKE '%" + txtBusca.Text + "%'";
                        break;
                    case 3:
                        strSql = "SELECT * FROM Tb_Aluno WHERE Email_Aluno LIKE '%" + txtBusca.Text + "%'";
                        break;
                    case 4:
                        strSql = "SELECT * FROM Tb_Aluno WHERE RG_Aluno LIKE '%" + txtBusca.Text + "%'";
                        break;
                    case 5:
                        strSql = "SELECT * FROM Tb_Aluno WHERE CPF_Aluno LIKE '%" + txtBusca.Text + "%'";
                        break;
                    case 6:
                        strSql = "SELECT * FROM Tb_Aluno WHERE Nome_Responsavel LIKE '%" + txtBusca.Text + "%'";
                        break;
                    case 7:
                        strSql = "SELECT * FROM Tb_Aluno WHERE Email_Responsavel LIKE '%" + txtBusca.Text + "%'";
                        break;
                    case 8:
                        strSql = "SELECT * FROM Tb_Aluno WHERE RG_Responsavel LIKE '%" + txtBusca.Text + "%'";
                        break;
                    case 9:
                        strSql = "SELECT * FROM Tb_Aluno WHERE CPF_Responsavel LIKE '%" + txtBusca.Text + "%'";
                        break;
                }
                SqlCommand cmd = new SqlCommand(strSql, con);

                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable clientes = new DataTable();

                da.Fill(clientes);

                dataGridView1.DataSource = clientes;

                con.Close();
            }
            else
            {
                MessageBox.Show("Selecione uma categoria para realizar a busca!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AlunoEdit editAluno = new AlunoEdit();
            editAluno.img.Image = Sistema.Properties.Resources.picture;
            editAluno.btnAction.Text="ADICIONAR";
            editAluno.Text= "Cadastro do Aluno";
            editAluno.lblTitle.Text = "Cadastro do Aluno";
            editAluno.btnRemover.Visible = false;
            editAluno.lblMostraId.Visible = false;
            editAluno.lblID.Visible = false;
            editAluno.btnVisualiza.Visible = false;
            Limpar();
            
            editAluno.cbSexo.SelectedIndex = 0;
            editAluno.cbSexoResp.SelectedIndex = 0;
            editAluno.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AlunoEdit editAluno = new AlunoEdit();
            //Recuperando a coluna e o funcionário selecionado
            if (e.RowIndex != -1)
            {
                int idAluno = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                //SELECIONANDO COLUNA -- Iniciando a busca pelo valor selecionado
                string verificaLoginSQL = "select * from Tb_Aluno where Id_Aluno=" + idAluno;
                SqlCommand cmd = new SqlCommand(verificaLoginSQL, con);
                SqlDataReader DR;
                try
                {
                    con.Open();
                    DR = cmd.ExecuteReader();
                    if (DR.Read())
                    {
                        Limpar();
                        string data = DR.GetValue(9).ToString();
                        editAluno.Text = "Perfil do aluno";
                        editAluno.lblTitle.Text = "Perfil do aluno";
                        editAluno.btnAction.Text = "ATUALIZAR";
                        editAluno.btnRemover.Visible = true;
                        editAluno.lblID.Visible = true;
                        editAluno.lblMostraId.Visible = true;
                        editAluno.btnPreencher.Visible = false;

                        //EM ORDEM DO BANCO DE DADOS
                        editAluno.lblID.Text = DR.GetValue(0).ToString();
                        editAluno.txtNome.Text = DR.GetValue(1).ToString();
                        editAluno.lblCaminho.Text = DR.GetValue(2).ToString();
                        editAluno.img.ImageLocation = @"..\..\..\..\..\SITE\" + DR.GetValue(2).ToString().Replace("/", @"\");
                        editAluno.cbSexo.Text = DR.GetValue(3).ToString();
                        editAluno.txtEmail.Text = DR.GetValue(4).ToString();
                        editAluno.txtSenha.Text = DR.GetValue(5).ToString();
                        editAluno.txtContato1.Text = DR.GetValue(6).ToString();
                        editAluno.txtContato2.Text = DR.GetValue(7).ToString();
                        editAluno.txtRG.Text = DR.GetValue(8).ToString().Replace(".", "").Replace("-", "");
                        editAluno.txtData.Text = DR.GetValue(9).ToString().Replace("/", "");
                        editAluno.txtCEP.Text = DR.GetValue(10).ToString().Replace("-", "");
                        editAluno.txtEndereco.Text = DR.GetValue(11).ToString();
                        editAluno.txtNum.Text = DR.GetValue(12).ToString();
                        editAluno.txtComp.Text = DR.GetValue(13).ToString();
                        editAluno.txtBairro.Text = DR.GetValue(14).ToString();
                        editAluno.txtCidade.Text = DR.GetValue(15).ToString();
                        editAluno.txtEstado.Text = DR.GetValue(16).ToString();


                        VerificaIdade(data);
                        if (idade >= 18)
                        {
                            editAluno.pnRespons.Visible = false;
                            editAluno.ShowDialog();
                        }
                        else
                        {
                            editAluno.pnRespons.Visible = true;
                            editAluno.txtNomeResp.Text = DR.GetValue(17).ToString();
                            editAluno.cbSexoResp.Text = DR.GetValue(18).ToString();
                            editAluno.txtEmailResp.Text = DR.GetValue(19).ToString();
                            editAluno.txtContatoResp.Text = DR.GetValue(20).ToString();
                            editAluno.txtCPFResp.Text = DR.GetValue(21).ToString().Replace(".", "").Replace("-", "");
                            editAluno.txtRGResp.Text = DR.GetValue(22).ToString().Replace(".", "").Replace("-", "");
                            editAluno.ShowDialog();
                        }

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
        }
        public void VerificaIdade(string data)
        {
            DateTime dt = Convert.ToDateTime(data);
            //TimeSpan com a data atual menos data do niversário
            TimeSpan ts = DateTime.Today - dt;
            //Converter TimeSpan para DateTime
            //Como o new DateTime() retorna 01/01/0001 00:00:00
            //vou ter que remover um ano .AddYears(- 1) e um dia .AddDays(-1) para ter a data exata.
            DateTime idadeValor = (new DateTime() + ts).AddYears(-1).AddDays(-1);
            idade = Convert.ToInt32(idadeValor.ToString("yy"));
        }
        public void Limpar()
        {
            AlunoEdit editAluno = new AlunoEdit();
            editAluno.txtNome.Clear();
            editAluno.cbSexo.SelectedIndex = 0;
            editAluno.txtEmail.Clear(); 
            editAluno.txtSenha.Clear();
            editAluno.txtContato1.Clear();
            editAluno.txtContato2.Clear();
            editAluno.txtRG.Clear();
            editAluno.txtData.Clear();
            editAluno.txtCEP.Clear();
            editAluno.txtEndereco.Clear();
            editAluno.txtEstado.Clear();
            editAluno.txtNum.Clear();
            editAluno.txtComp.Clear();
            editAluno.txtBairro.Clear();
            editAluno.txtCidade.Clear();
            
            editAluno.txtNomeResp.Clear();
            editAluno.cbSexoResp.SelectedIndex = 0;
            editAluno.txtEmailResp.Clear();
            editAluno.txtContatoResp.Clear();
            editAluno.txtCPFResp.Clear();
            editAluno.txtRGResp.Clear();
            editAluno.lblCaminho.Text="";
            editAluno.img.Image = Sistema.Properties.Resources.picture;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnMove_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void pnMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point = Control.MousePosition;
                Point.X -= x;
                Point.Y -= y;
                this.Location = Point;
                Application.DoEvents();
            }
        }
    }
}
