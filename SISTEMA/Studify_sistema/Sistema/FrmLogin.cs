using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Sistema
{
    public partial class FrmLogin : Form
    {
        int x, y;
        Point Point = new Point();

        //Adicionando as conexões
        public static string strCn = Properties.Settings.Default.strCn;
        SqlConnection con = new SqlConnection(strCn);
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtLogin.GotFocus += new EventHandler(this.TextGotFocus);
            txtLogin.LostFocus += new EventHandler(this.TextLostFocus);
            txtSenha.GotFocus += new EventHandler(this.TextGotFocus);
            txtSenha.LostFocus += new EventHandler(this.TextLostFocus);

            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    toolTip1.SetToolTip(this.pictureBox1, "Conectado");
                    pictureBox1.Image = Properties.Resources.db_success;
                }
            }
            catch (Exception)
            {
                toolTip1.SetToolTip(this.pictureBox1, "Desconectado");
                pictureBox1.Image = Properties.Resources.db_error;
            }
            finally
            {
                con.Close();
            }               
        }
        public void TextGotFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Usuário")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
            if (tb.Text == "Senha")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
                tb.PasswordChar = '•';
            }
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            FrmTelaInicial inicio = new FrmTelaInicial();
            //SQL

            string verificaLoginSQL = "select * from Tb_Funcionario where Login_Funcionario='"+txtLogin.Text+"' and Senha_Funcionario='"+txtSenha.Text+"'";
            SqlCommand cmd = new SqlCommand(verificaLoginSQL, con);
            SqlDataReader DR;
            try
            {
                con.Open();
                DR = cmd.ExecuteReader();
                if (DR.Read())
                {
                    
                    FrmTelaInicial.id = DR.GetValue(0).ToString();
                    FrmTelaInicial.cargo = DR.GetValue(17).ToString();
                    inicio.lblNome.Text = DR.GetValue(1).ToString();
                    inicio.lblCargo.Text = DR.GetValue(17).ToString();
                    inicio.pctFoto.ImageLocation = @"..\..\..\..\..\SITE\" + DR.GetValue(2).ToString().Replace("/",@"\");

                    switch (DR.GetValue(17).ToString())
                    {
                        case "CEO":
                            inicio.btnFunc.Visible = true;
                            inicio.btnProf.Visible = true;
                            inicio.btnAlun.Visible = true;
                            inicio.btnSuporte.Visible = true;
                            break;
                        case "CIO":
                            inicio.btnFunc.Visible = true;
                            inicio.btnProf.Visible = true;
                            inicio.btnAlun.Visible = true;
                            inicio.btnSuporte.Visible = true;
                            break;
                        case "CFO":
                            inicio.btnFunc.Visible = true;
                            inicio.btnProf.Visible = true;
                            inicio.btnAlun.Visible = true;
                            inicio.btnSuporte.Visible = true;
                            break;
                        case "RH":
                            inicio.btnFunc.Visible = true;
                            inicio.btnProf.Visible = true;
                            inicio.btnAlun.Visible = true;
                            inicio.btnSuporte.Visible = true;
                            break;
                        case "TI":
                            inicio.btnFunc.Visible = false;
                            inicio.btnProf.Visible = true;
                            inicio.btnAlun.Visible = true;
                            inicio.btnSuporte.Visible = true;
                            break;
                        case "Marketing":
                            inicio.btnFunc.Visible = false;
                            inicio.btnProf.Visible = true;
                            inicio.btnAlun.Visible = true;
                            inicio.btnSuporte.Visible = true;
                            break;
                        case "Estagiário":
                            inicio.btnFunc.Visible = false;
                            inicio.btnProf.Visible = false;
                            inicio.btnAlun.Visible = false;
                            inicio.btnSuporte.Visible = true;
                            break;

                    }
                    inicio.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Os campos estão inválidos...Tente novamente!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void TextLostFocus(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
            {
                txtLogin.Text = "Usuário";
                txtLogin.ForeColor = Color.Silver;
            }
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Senha";
                txtSenha.ForeColor = Color.Silver;
                txtSenha.PasswordChar = '\u0000';
            }

        }
        public void CheckInstance()
        {
            Process[] thisnameprocesslist;
            string modulename, processname;
            Process p = Process.GetCurrentProcess();
            modulename = p.MainModule.ModuleName.ToString();
            processname = System.IO.Path.GetFileNameWithoutExtension(modulename);
            thisnameprocesslist = Process.GetProcessesByName(processname);
            if (thisnameprocesslist.Length > 1)
            {
                MessageBox.Show("Já possui um sistema Studify aberto.", "ATENÇÃO");
                Application.Exit();
            }
        }
        
        private void reiniciarOSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                toolTip1.SetToolTip(this.pictureBox1, "Conectado");
                pictureBox1.Image = Properties.Resources.db_success;
            }
            else if (con.State == ConnectionState.Closed)
            {
                toolTip1.SetToolTip(this.pictureBox1, "Desconectado");
                pictureBox1.Image = Properties.Resources.db_error;
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
            Application.Exit();
        }
    }
}
