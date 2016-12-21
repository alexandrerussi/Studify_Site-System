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
using System.IO;

namespace Sistema
{
    public partial class FrmFunc : Form
    {
        FuncEdit editFunc = new FuncEdit();

        int x, y;
        Point Point = new Point();

        //Adicionando as conexões
        SqlConnection con = new SqlConnection(FrmLogin.strCn);
        public FrmFunc()
        {
            InitializeComponent();
        }

        private void FrmFunc_Load(object sender, EventArgs e)
        {
            cbBusca.SelectedIndex = 0;
            //define a instrução SQL
            string strSql = "SELECT * FROM Tb_Funcionario";
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
                switch (cbBusca.SelectedIndex)
                {
                    case 1:
                        strSql = "SELECT * FROM Tb_Funcionario WHERE Id_Funcionario LIKE '%" + txtBusca.Text + "%'";
                        break;
                    case 2:
                        strSql = "SELECT * FROM Tb_Funcionario WHERE Nome_Funcionario LIKE '%" + txtBusca.Text + "%'";
                        break;
                    case 3:
                        strSql = "SELECT * FROM Tb_Funcionario WHERE Email_Funcionario LIKE '%" + txtBusca.Text + "%'";
                        break;
                    case 4:
                        strSql = "SELECT * FROM Tb_Funcionario WHERE RG_Funcionario LIKE '%" + txtBusca.Text + "%'";
                        break;
                    case 5:
                        strSql = "SELECT * FROM Tb_Funcionario WHERE CPF_Funcionario LIKE '%" + txtBusca.Text + "%'";
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
        public void PermissFunc()
        {
            editFunc.txtNome.ReadOnly = false;
            editFunc.txtEmail.ReadOnly = false;
            editFunc.txtTelefone.ReadOnly = false;
            editFunc.txtCelular.ReadOnly = false;
            editFunc.txtCPF.ReadOnly = false;
            editFunc.txtRG.ReadOnly = false;
            editFunc.txtDataNasc.ReadOnly = false;
            editFunc.txtCEP.ReadOnly = false;
            editFunc.txtCidade.ReadOnly = false;
            editFunc.txtEstado.ReadOnly = false;
            editFunc.txtEndereco.ReadOnly = false;
            editFunc.txtNum.ReadOnly = false;
            editFunc.txtComp.ReadOnly = false;
            editFunc.txtBairro.ReadOnly = false;
            editFunc.cbCargo.Enabled = false;
            editFunc.txtSalario.ReadOnly = false;
            editFunc.txtLogin.ReadOnly = false;
            editFunc.txtSenha.ReadOnly = false;
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
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Recuperando a coluna e o funcionário selecionado
            if (e.RowIndex != -1)
            {
                int idFuncionario = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                //Iniciando a busca pelo valor selecionado
                string verificaLoginSQL = "select * from Tb_Funcionario where Id_Funcionario=" + idFuncionario;
                SqlCommand cmd = new SqlCommand(verificaLoginSQL, con);
                SqlDataReader DR;
                try
                {
                    con.Open();
                    DR = cmd.ExecuteReader();

                    if (DR.Read())
                    {
                        PermissFunc();
                        //TRATANDO AS INICIALIZAÇÕES
                        editFunc.lblID.Visible = true;
                        editFunc.label17.Visible = true;
                        editFunc.btnAdicionar.Visible = true;
                        editFunc.btnAlterar.Visible = true;
                        editFunc.btnAtualizar.Visible = true;
                        editFunc.btnDeletar.Visible = true;
                        editFunc.btnAlterar.Text = "Alterar imagem";

                        //EM ORDEM DO BANCO DE DADOS
                        editFunc.lblID.Text = DR.GetValue(0).ToString();
                        editFunc.txtNome.Text = DR.GetValue(1).ToString();
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
                        editFunc.pctFoto.ImageLocation = @"..\..\..\..\..\SITE\" + DR.GetValue(2).ToString().Replace("/", @"\");

                        //CONDIÇÕES
                        switch (FrmTelaInicial.cargo)
                        {
                            case "CEO":

                                editFunc.pnDadosImp.Visible = true;
                                editFunc.lblPermissão.Visible = false;
                                editFunc.btnAlterar.Visible = true;
                                editFunc.rdbFeminino.Enabled = true;
                                editFunc.rdbMasculino.Enabled = true;
                                editFunc.txtSenha.ReadOnly = false;
                                editFunc.cbExibir.Visible = true;
                                break;
                            //final do CEO
                            case "CIO":
                                if (DR.GetValue(17).ToString() == "CEO")
                                {

                                    editFunc.btnDeletar.Visible = false;
                                    editFunc.pnDadosImp.Visible = false;
                                    editFunc.lblPermissão.Visible = true;
                                    editFunc.txtSenha.ReadOnly = true;
                                    editFunc.cbExibir.Visible = false;
                                }
                                else
                                {

                                    editFunc.pnDadosImp.Visible = true;
                                    editFunc.lblPermissão.Visible = false;
                                    editFunc.btnAlterar.Visible = true;
                                    editFunc.txtSenha.ReadOnly = false;
                                    editFunc.cbExibir.Visible = true;
                                }


                                break;
                            //final do CIO
                            case "CFO":
                                if (DR.GetValue(17).ToString() == "CEO" || DR.GetValue(17).ToString() == "CIO")
                                {

                                    editFunc.btnDeletar.Visible = false;
                                    editFunc.pnDadosImp.Visible = false;
                                    editFunc.lblPermissão.Visible = true;
                                    editFunc.txtSenha.ReadOnly = true;
                                    editFunc.cbExibir.Visible = false;
                                }
                                else
                                {

                                    editFunc.pnDadosImp.Visible = true;
                                    editFunc.lblPermissão.Visible = false;
                                    editFunc.btnAlterar.Visible = true;
                                    editFunc.txtSenha.ReadOnly = false;
                                    editFunc.cbExibir.Visible = true;
                                }
                                break;
                            //final do CFO
                            case "RH":
                                if (DR.GetValue(17).ToString() == "CEO" || DR.GetValue(17).ToString() == "CIO" || DR.GetValue(17).ToString() == "CFO")
                                {

                                    editFunc.btnDeletar.Visible = false;
                                    editFunc.pnDadosImp.Visible = false;
                                    editFunc.lblPermissão.Visible = true;
                                    editFunc.txtSenha.ReadOnly = true;
                                    editFunc.cbExibir.Visible = false;
                                }
                                else
                                {

                                    editFunc.pnDadosImp.Visible = true;
                                    editFunc.lblPermissão.Visible = false;
                                    editFunc.btnAlterar.Visible = true;
                                    editFunc.txtSenha.ReadOnly = false;
                                    editFunc.cbExibir.Visible=true;
                                }
                                break;
                                //final do RH
                        }

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
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            editFunc.pnDadosImp.Visible = true;
            editFunc.lblPermissão.Visible = false;
            editFunc.lblID.Visible = false;
            editFunc.label17.Visible = false;
            editFunc.btnDeletar.Visible = false;
            editFunc.btnAtualizar.Visible = false;
            editFunc.btnAdicionar.Visible = true;
            editFunc.btnAlterar.Visible = false;
            editFunc.txtSenha.PasswordChar = '•';

            Limpar();
            editFunc.txtNome.Focus();
            editFunc.ShowDialog();
            //editFunc.txtSenha.PasswordChar = '\u0000';
        }
        public void Limpar()
        {
            editFunc.txtNome.Clear();
            editFunc.pctFoto.ImageLocation = "";
            editFunc.txtEmail.Clear();
            editFunc.txtTelefone.Clear();
            editFunc.txtCelular.Clear();
            editFunc.txtCPF.Clear();
            editFunc.txtRG.Clear();
            editFunc.txtDataNasc.Clear();
            editFunc.txtCEP.Clear();
            editFunc.txtEndereco.Clear();
            editFunc.txtNum.Clear();
            editFunc.txtComp.Clear();
            editFunc.txtBairro.Clear();
            editFunc.txtCidade.Clear();
            editFunc.txtEstado.Clear();
            editFunc.cbCargo.SelectedIndex = 0;
            editFunc.txtSalario.Clear();
            editFunc.txtLogin.Clear();
            editFunc.txtSenha.Clear();
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string strSql = "SELECT * FROM Tb_Funcionario";
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmdSelect = new SqlCommand("select Foto_Funcionario from Tb_Funcionario where ID=1", con);

                con.Open();
                byte[] barrImg = (byte[])cmdSelect.ExecuteScalar();
                string strfn = Convert.ToString(DateTime.Now.ToFileTime());
                FileStream fs = new FileStream(strfn,
                                  FileMode.CreateNew, FileAccess.Write);
                fs.Write(barrImg, 0, barrImg.Length);
                fs.Flush();
                fs.Close();
                editFunc.pctFoto.Image = Image.FromFile(strfn);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void pnMove_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
