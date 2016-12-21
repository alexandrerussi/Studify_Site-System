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
    public partial class frmVisualizaSup : Form
    {
        int x, y;
        Point Point = new Point();
        //Adicionando as conexões
        SqlConnection con = new SqlConnection(FrmLogin.strCn);
        public frmVisualizaSup()
        {
            InitializeComponent();
        }

        private void pnMove_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPreencher_Click(object sender, EventArgs e)
        {
            if (cbMarcar.Checked == true)
            {
                string atualizaSQL = "update TbContato set vitrine='s' where id=" + lblID.Text;
                SqlCommand cmd = new SqlCommand(atualizaSQL, con);
                try
                {
                    con.Open();
                    int resultado = cmd.ExecuteNonQuery();
                    if (resultado == 1)
                    {
                        MessageBox.Show("Atualizado!");
                        this.Close();
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
            else if (cbMarcar.Checked == false)
            {
                string atualizaSQL = "update TbContato set vitrine=null where id=" + lblID.Text;
                SqlCommand cmd = new SqlCommand(atualizaSQL, con);
                try
                {
                    con.Open();
                    int resultado = cmd.ExecuteNonQuery();
                    if (resultado == 1)
                    {
                        MessageBox.Show("Atualizado!");
                        this.Close();
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
    }
}
