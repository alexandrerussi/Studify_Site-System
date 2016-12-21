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
    public partial class FrmProf : Form
    {
        int x, y;
        Point Point = new Point();

        static string myStr;
        //Adicionando as conexões
        SqlConnection con = new SqlConnection(FrmLogin.strCn);
        public FrmProf()
        {
            InitializeComponent();
        }

        private void FrmProf_Load(object sender, EventArgs e)
        {

            cbBusca.SelectedIndex = 0;
            //define a instrução SQL
            string strSql = "SELECT * FROM Tb_Professor";
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
                        strSql = "SELECT * FROM Tb_Professor WHERE Id_Professor LIKE '%" + txtBusca.Text + "%'";
                        break;
                    case 2:
                        strSql = "SELECT * FROM Tb_Professor WHERE Nome_Professor LIKE '%" + txtBusca.Text + "%'";
                        break;
                    case 3:
                        strSql = "SELECT * FROM Tb_Professor WHERE Email_Professor LIKE '%" + txtBusca.Text + "%'";
                        break;
                    case 4:
                        strSql = "SELECT * FROM Tb_Professor WHERE RG_Professor LIKE '%" + txtBusca.Text + "%'";
                        break;
                    case 5:
                        strSql = "SELECT * FROM Tb_Professor WHERE CPF_Professor LIKE '%" + txtBusca.Text + "%'";
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string strSql = "SELECT * FROM Tb_Professor";
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
        public void Limpar()
        {
            ProfEdit editProf = new ProfEdit();
            editProf.lblID.Text = "";
            editProf.txtNome.Clear();
            editProf.img.Image = Sistema.Properties.Resources.picture;
            editProf.txtVideoApresentacao.Clear();
            editProf.cbSexo.SelectedIndex = 0;
            editProf.txtEmail.Clear();
            editProf.txtSenha.Clear();
            editProf.txtContato1.Clear();
            editProf.txtContato2.Clear();
            editProf.txtCPF.Clear();
            editProf.txtData.Clear();
            editProf.txtCEP.Clear();
            editProf.txtEndereco.Clear();
            editProf.txtNum.Clear();
            editProf.txtComp.Clear();
            editProf.txtBairro.Clear();
            editProf.txtCidade.Clear();
            editProf.txtEstado.Clear();
            editProf.cbSegmento.SelectedIndex = 0;
            editProf.cbMateria.SelectedIndex = 0;
            editProf.txtFormacao.Clear();
            editProf.txtValor.Clear();
            editProf.txtDescricao.Clear();
            //avaliação
            editProf.txtSkp.Clear();
            editProf.txtFace.Clear();
            editProf.txtLink.Clear();
            editProf.txtYout.Clear();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProfEdit editProf = new ProfEdit();
            //Recuperando a coluna e o funcionário selecionado
            if (e.RowIndex != -1)
            {
                int idProfessor = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                //SELECIONANDO COLUNA -- Iniciando a busca pelo valor selecionado
                string verificaLoginSQL = "select * from Tb_Professor where Id_Professor=" + idProfessor;
                SqlCommand cmd = new SqlCommand(verificaLoginSQL, con);
                SqlDataReader DR;
                try
                {
                    con.Open();
                    DR = cmd.ExecuteReader();
                    if (DR.Read())
                    {
                        editProf.cbDias.ClearSelected();
                        editProf.cbManha.ClearSelected();
                        editProf.cbTarde.ClearSelected();
                        editProf.cbNoite.ClearSelected();
                        Limpar();
                        editProf.Text = "Perfil do professor";
                        editProf.lblTitle.Text = "Perfil do professor";
                        editProf.btnAction.Text = "ATUALIZAR";
                        editProf.btnRemover.Visible = true;
                        editProf.lblID.Visible = true;
                        editProf.lblMostraId.Visible = true;
                        editProf.btnPreencher.Visible = false;

                        //EM ORDEM DO BANCO DE DADOS
                        editProf.lblID.Text = DR.GetValue(0).ToString();
                        editProf.txtNome.Text = DR.GetValue(1).ToString();
                        editProf.img.ImageLocation = @"..\..\..\..\..\SITE\" + DR.GetValue(2).ToString().Replace("/", @"\");
                        editProf.lblCaminho.Text = DR.GetValue(2).ToString();
                        editProf.txtVideoApresentacao.Text = DR.GetValue(3).ToString();
                        editProf.cbSexo.Text = DR.GetValue(4).ToString();
                        editProf.txtEmail.Text = DR.GetValue(5).ToString();
                        editProf.txtSenha.Text = DR.GetValue(6).ToString();
                        editProf.txtContato1.Text = DR.GetValue(7).ToString();
                        editProf.txtContato2.Text = DR.GetValue(8).ToString();
                        editProf.txtCPF.Text = DR.GetValue(9).ToString().Replace(".", "").Replace("-", "");
                        editProf.txtData.Text = DR.GetValue(10).ToString();
                        editProf.txtCEP.Text = DR.GetValue(11).ToString().Replace("-", "");
                        editProf.txtEndereco.Text = DR.GetValue(12).ToString();
                        editProf.txtNum.Text = DR.GetValue(13).ToString();
                        editProf.txtComp.Text = DR.GetValue(14).ToString();
                        editProf.txtBairro.Text = DR.GetValue(15).ToString();
                        editProf.txtCidade.Text = DR.GetValue(16).ToString();
                        editProf.txtEstado.Text = DR.GetValue(17).ToString();
                        editProf.cbSegmento.Text = DR.GetValue(18).ToString();
                        editProf.cbMateria.Text = DR.GetValue(19).ToString();
                        //horario
                        editProf.txtFormacao.Text = DR.GetValue(21).ToString();
                        editProf.txtValor.Text = DR.GetValue(22).ToString();
                        editProf.txtDescricao.Text = DR.GetValue(23).ToString();
                        //avaliação
                        editProf.txtSkp.Text = DR.GetValue(25).ToString();
                        editProf.txtFace.Text = DR.GetValue(26).ToString();
                        editProf.txtLink.Text = DR.GetValue(27).ToString();
                        editProf.txtYout.Text = DR.GetValue(28).ToString();
                        DR.Close();

                        SqlCommand cmdAgenda = new SqlCommand("SELECT * FROM Agenda where Id_Professor=" + idProfessor, con);

                        DR = cmdAgenda.ExecuteReader();
                        if (DR.Read())
                        {
                            
                            string dias = DR.GetValue(2).ToString();

                            for (int i = 0; i < editProf.cbDias.Items.Count; i++)
                            {
                                if (dias.IndexOf(editProf.cbDias.Items[i].ToString()) != -1)
                                {
                                    editProf.cbDias.SetItemChecked(i, true);
                                }
                                else
                                {
                                    editProf.cbDias.SetItemChecked(i, false);
                                }

                            }

                            string manha = DR.GetValue(3).ToString();

                            for (int i = 0; i < editProf.cbManha.Items.Count; i++)
                            {
                                if (manha.IndexOf(editProf.cbManha.Items[i].ToString()) != -1)
                                {
                                    editProf.cbManha.SetItemChecked(i, true);
                                }
                                else
                                {
                                    editProf.cbManha.SetItemChecked(i, false);
                                }

                            }

                            string tarde = DR.GetValue(4).ToString();

                            for (int i = 0; i < editProf.cbTarde.Items.Count; i++)
                            {
                                if (tarde.IndexOf(editProf.cbTarde.Items[i].ToString()) != -1)
                                {
                                    editProf.cbTarde.SetItemChecked(i, true);
                                }
                                else
                                {
                                    editProf.cbTarde.SetItemChecked(i, false);
                                }

                            }

                            string noite = DR.GetValue(5).ToString();

                            for (int i = 0; i < editProf.cbNoite.Items.Count; i++)
                            {
                                if (noite.IndexOf(editProf.cbNoite.Items[i].ToString()) != -1)
                                {
                                    editProf.cbNoite.SetItemChecked(i, true);
                                }
                                else
                                {
                                    editProf.cbNoite.SetItemChecked(i, false);
                                }

                            }

                        }

                        editProf.ShowDialog();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProfEdit editProf = new ProfEdit();
            Limpar();
            editProf.btnVisualiza.Visible = false;
            editProf.btnAction.Text = "ADICIONAR";
            editProf.Text = "Cadastro de professor";
            editProf.lblTitle.Text = "Cadastro de professor";
            editProf.cbSexo.SelectedIndex = 0;
            editProf.cbSegmento.SelectedIndex = 0;
            editProf.cbMateria.SelectedIndex = 0;
            editProf.lblID.Visible = false;
            editProf.lblMostraId.Visible = false;
            editProf.btnRemover.Visible = false;
            editProf.ShowDialog();
        }
    }
}
