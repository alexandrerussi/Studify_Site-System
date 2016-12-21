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
    public partial class frmSuporte : Form
    {
        int x, y;
        Point Point = new Point();
        //Adicionando as conexões
        SqlConnection con = new SqlConnection(FrmLogin.strCn);
        public frmSuporte()
        {
            InitializeComponent();
        }

        private void frmSuporte_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studifyPCDataSet.TbContato' table. You can move, or remove it, as needed.
            this.tbContatoTableAdapter.Fill(this.studifyPCDataSet.TbContato);
            //define a instrução SQL
            string strSql = "SELECT * FROM TbContato where vitrine is null";
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
            cbBusca.SelectedIndex=0;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTudo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTudo.Checked==true)
            {
                string strSql = "SELECT * FROM TbContato";
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
            else if (cbTudo.Checked==false)
            {
                string strSql = "SELECT * FROM TbContato where vitrine is null";
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
        }

        private void pnMove_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (cbTudo.Checked == true)
            {
                string strSql = "SELECT * FROM TbContato";
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
            else if (cbTudo.Checked == false)
            {
                string strSql = "SELECT * FROM TbContato where vitrine is null";
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
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmVisualizaSup visSup = new frmVisualizaSup();
            //Recuperando a coluna e o funcionário selecionado
            if (e.RowIndex != -1)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                //SELECIONANDO COLUNA -- Iniciando a busca pelo valor selecionado
                string verificaLoginSQL = "select * from TbContato where id=" + id;
                SqlCommand cmd = new SqlCommand(verificaLoginSQL, con);
                SqlDataReader DR;
                try
                {
                    con.Open();
                    DR = cmd.ExecuteReader();
                    if (DR.Read())
                    {
                        Limpar();
                        visSup.lblID.Text = DR.GetValue(0).ToString();
                        visSup.txtNome.Text = DR.GetValue(1).ToString();
                        visSup.txtEmail.Text = DR.GetValue(2).ToString();
                        visSup.txtMsg.Text = DR.GetValue(3).ToString();
                        if (DR.GetValue(4).ToString()==null)
                        {
                            visSup.cbMarcar.Checked=false;
                        }
                        else if (DR.GetValue(4).ToString() == "s")
                        {
                            visSup.cbMarcar.Checked = true;
                        }
                        visSup.ShowDialog();
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
        void Limpar()
        {
            frmVisualizaSup visSup = new frmVisualizaSup();
            visSup.lblID.Text="";
            visSup.txtNome.Clear();
            visSup.txtEmail.Clear();
            visSup.txtMsg.Clear();
            visSup.cbMarcar.Checked=false;
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
                */
                switch (cbBusca.SelectedIndex)
                {
                    case 1:
                        strSql = "SELECT * FROM TbContato WHERE id LIKE '%" + txtBusca.Text + "%'";
                        break;
                    case 2:
                        strSql = "SELECT * FROM TbContato WHERE nome LIKE '%" + txtBusca.Text + "%'";
                        break;
                    case 3:
                        strSql = "SELECT * FROM TbContato WHERE email LIKE '%" + txtBusca.Text + "%'";
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
