using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//bibliotecas importadas
using System.Data.SqlClient;
using System.IO;

namespace Sistema
{
    public partial class AlunoEdit : Form
    {
        public string arquivo, diretorio, caminhoBanco;
        public bool preenche;
        public int idade;
        public bool menu = true;
        public bool valCPF = false;

        int x, y;
        Point Point = new Point();


        //SQl de conexão
        SqlConnection con = new SqlConnection(FrmLogin.strCn);
        public AlunoEdit()
        {
            InitializeComponent();
        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
            if (txtCEP.Text.Length > 8)
            {
                try
                {
                    //a linha abaixo cria um objeto de nome ds usando a classe DataSet
                    DataSet ds = new DataSet();
                    // a linha abaixo cria uma variável de nome xml do tipo string
                    // esta variável armazena a Strind de conexão com o web service
                    // .Replace @cep -> substitui o que foi digitado no campo txtCEP pelo campo cep do servidor web
                    // .replace ("-", "") -> substitui o - por nulo, se o cliente digitar - no campo CEP 
                    String xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", txtCEP.Text.Replace("-", ""));
                    //a linha abaixo abre a conexão com o banco de dados e faz a leitura
                    //dos campos da tabela do servidor
                    ds.ReadXml(xml);
                    // as linhas abaixo preenchem os campos do form de acordo com os
                    // dados recebidos do servidor web (banco de dados CEP)
                    txtEndereco.Text = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString() + " " + ds.Tables[0].Rows[0]["logradouro"].ToString();

                    txtBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                    txtCidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                    txtEstado.Text = ds.Tables[0].Rows[0]["uf"].ToString();
                    txtNum.Focus();
                }
                catch (Exception)
                {
                    lblCEP.Text = "Serviço indisponível";
                }
            }
        }
        public void VerificaMenu()
        {
            if (menu == true)
            {
                btnInfo1.BackColor = Color.FromArgb(41,41,41);
                btnInfo2.BackColor = Color.FromArgb(35, 35, 35);
            }
            else if (menu == false)
            {
                btnInfo2.BackColor = Color.FromArgb(41, 41, 41);
                btnInfo1.BackColor = Color.FromArgb(35, 35, 35);
            }
        }
        public void VerificaCampos()
        {
            //NOME
            if (txtNome.Text == "")
            {
                lblNome.Visible = true;
                txtNome.Focus();
                
                preenche = false;
            }
            else
            {
                lblNome.Visible = false;
                preenche = true;
            }

            //SEXO
            if (cbSexo.SelectedIndex == 0)
            {
                lblSexo.Visible = true;
                
                preenche = false;
            }
            else
            {
                preenche = true;
                lblSexo.Visible = false;
            }

            //DATA DE NASCIMENTO
            if (txtData.Text == "  /  /")
            {
                lblData.Visible = true;
                txtNome.Focus();
                
                preenche = false;

            }
            else
            {
                preenche = true;
                lblData.Visible = false;
            }

            //RG
            if (txtRG.Text == "  .   .   -")
            {
                preenche = false;
                lblRG.Visible = true;
                txtRG.Focus();
                

            }
            else
            {
                preenche = true;
                lblRG.Visible = false;
            }

            //Contato 1
            if (txtContato1.Text == "")
            {
                preenche = false;
                lblContato.Visible = true;
                txtContato1.Focus();
                
            }
            else
            {
                preenche = true;
                lblContato.Visible = false;
            }

            //CEP
            if (txtCEP.Text == "     -")
            {
                preenche = false;
                lblCEP.Text = "*Campo obrigatório";
                lblCEP.Visible = true;
                txtCEP.Focus();
                
            }
            else
            {
                preenche = true;
                lblCEP.Visible = false;
            }

            //Endereço
            if (txtEndereco.Text == "")
            {
                preenche = false;
                lblEndereco.Visible = true;
                txtEndereco.Focus();
                
            }
            else
            {
                preenche = true;
                lblEndereco.Visible = false;
            }

            //Estado 
            if (txtEstado.Text == "")
            {
                preenche = false;
                lblEstado.Visible = true;
                txtEstado.Focus();
                
            }
            else
            {
                preenche = true;
                lblEstado.Visible = false;
            }

            //Numero
            if (txtNum.Text == "")
            {
                preenche = false;
                lblNum.Visible = true;
                txtNum.Focus();
                
            }
            else
            {
                preenche = true;
                lblNum.Visible = false;
            }

            //Bairro
            if (txtBairro.Text == "")
            {
                preenche = false;
                lblBairro.Visible = true;
                txtBairro.Focus();
                
            }
            else
            {
                preenche = true;
                lblBairro.Visible = false;
            }

            //Cidade
            if (txtCidade.Text == "")
            {
                preenche = false;
                lblCidade.Visible = true;
                txtCidade.Focus();
                
            }
            else
            {
                preenche = true;
                lblCidade.Visible = false;
            }
        }
        public void VerificaCampos2()
        {
            //Email
            if (txtCidade.Text == "")
            {
                preenche = false;
                lblEmail.Visible = true;
                txtEmail.Focus();
            }
            else
            {
                preenche = true;
                lblEmail.Visible = false;
            }

            //Senha
            if (txtSenha.Text == "")
            {
                preenche = false;
                lblSenha.Visible = true;
                txtSenha.Focus();
            }
            else
            {
                preenche = true;
                lblSenha.Visible = false;
            }

            //Nome Responsável
            if (idade < 18)
            {
                pnRespons.Visible = true;
                if (txtNomeResp.Text == "")
                {
                    preenche = false;
                    lblNomeResp.Visible = true;
                    txtNomeResp.Focus();
                }
                else
                {
                    preenche = true;
                    lblNomeResp.Visible = false;
                }
            }

            //Email Responsável
            if (idade < 18)
            {
                pnRespons.Visible = true;
                if (txtEmailResp.Text == "")
                {
                    preenche = false;
                    lblEmailResp.Visible = true;
                    txtEmailResp.Focus();
                }
                else
                {
                    preenche = true;
                    lblEmailResp.Visible = false;
                }
            }

            //Sexo Responsável
            if (idade < 18)
            {
                pnRespons.Visible = true;
                if (cbSexo.SelectedIndex == 0)
                {
                    preenche = false;
                    lblSexoResp.Visible = true;

                }
                else
                {
                    preenche = true;
                    lblSexoResp.Visible = false;
                }
            }

            //RG Responsável
            if (idade < 18)
            {
                pnRespons.Visible = true;
                if (txtRGResp.Text == "  .   .   -")
                {
                    preenche = false;
                    lblRGResp.Visible = true;
                    txtRGResp.Focus();

                }
                else
                {
                    preenche = true;
                    lblRGResp.Visible = false;
                }
            }

            //CPF Responsável
            if (idade < 18)
            {
                pnRespons.Visible = true;
                if (txtCPFResp.Text == "   .   .   -")
                {
                    lblCPFResp.Text = "*Campo obrigatório";
                    preenche = false;
                    lblCPFResp.Visible = true;
                    txtCPFResp.Focus();

                }
                else
                {
                    preenche = true;
                    lblCPFResp.Visible = false;
                }
            }

            //Contato Responsável
            if (idade < 18)
            {
                pnRespons.Visible = true;
                if (txtContatoResp.Text == "")
                {
                    preenche = false;
                    lblContatoResp.Visible = true;
                    txtContatoResp.Focus();

                }
                else
                {
                    preenche = true;
                    lblContatoResp.Visible = false;
                }
            }



        }
        private void ValidaCPF(string txt)
        {
            int d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11;
            int soma1, soma2, resto1, resto2, dv1, dv2;
            string cpf = txt.Replace(".", "").Replace("-", "");
            //Substring(0,1) // (1o digito, só um número)
            d1 = Convert.ToInt32(cpf.Substring(0, 1));
            d2 = Convert.ToInt32(cpf.Substring(1, 1));
            d3 = Convert.ToInt32(cpf.Substring(2, 1));
            d4 = Convert.ToInt32(cpf.Substring(3, 1));
            d5 = Convert.ToInt32(cpf.Substring(4, 1));
            d6 = Convert.ToInt32(cpf.Substring(5, 1));
            d7 = Convert.ToInt32(cpf.Substring(6, 1));
            d8 = Convert.ToInt32(cpf.Substring(7, 1));
            d9 = Convert.ToInt32(cpf.Substring(8, 1));
            d10 = Convert.ToInt32(cpf.Substring(9, 1));
            d11 = Convert.ToInt32(cpf.Substring(10, 1));


            //cálculo do 1o dígito verificador

            soma1 = ((d1 * 10) + (d2 * 9) + (d3 * 8) + (d4 * 7) + (d5 * 6) + (d6 * 5) + (d7 * 4) + (d8 * 3) + (d9 * 2));

            resto1 = (soma1 % 11);
            if (resto1 < 2)
            {
                dv1 = 0;
            }
            else
            {
                dv1 = 11 - resto1;
            }
            //cálculo do 2o dígito verificador

            soma2 = ((d1 * 11) + (d2 * 10) + (d3 * 9) + (d4 * 8) + (d5 * 7) + (d6 * 6) + (d7 * 5) + (d8 * 4) + (d9 * 3) + (dv1 * 2));

            resto2 = (soma2 % 11);
            if (resto2 < 2)
            {
                dv2 = 0;
            }
            else
            {
                dv2 = 11 - resto2;
            }
            if (dv1 != d10 || dv2 != d11)
            {
                valCPF = false;
            }
            else
            {
                valCPF = true;
            }
        }
        public void btnMenu()
        {

        }
        private void btnPasso_Click(object sender, EventArgs e)
        {

            if (txtNome.Text == "" || txtContato1.Text == "" || txtRG.Text == "  .   .   -" || txtData.Text == "" || txtCEP.Text == "" || txtEndereco.Text == "" || txtNum.Text == "" || txtBairro.Text == "" || txtCidade.Text == "" || txtEstado.Text == "")
            {
                VerificaCampos();
            }
            else {

                VerificaCampos();
                VerificaIdade(txtData.Text);
                if (idade >= 18)
                {
                    pnRespons.Visible = false;
                    //tabControl1.SelectedTab = info2;
                }
                else
                {
                    pnRespons.Visible = true;
                    //tabControl1.SelectedTab = info2;
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
        private void AlunoEdit_Load(object sender, EventArgs e)
        {
            
        }
      
        private void btnEscolher_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {


                if (openFileDialog1.CheckFileExists)
                {
                    //verificar a extensao
                    string extensao = System.IO.Path.GetExtension(openFileDialog1.FileName);

                    if (extensao.ToLower() != ".png" && extensao.ToLower() != ".jpg" && extensao.ToLower() != ".jpeg")
                    {
                        MessageBox.Show("Extensão inválida");
                    }
                    else
                    {
                        //verificar o tamannho do arquivo
                        FileInfo finfo = new FileInfo(openFileDialog1.FileName);
                        long tamanho = finfo.Length;

                        if (tamanho > 2097152)
                        {
                            MessageBox.Show("Só pode enviar arquivos de até 2 Megas");
                        }

                        else
                        {
                            diretorio = System.IO.Path.GetFullPath(openFileDialog1.FileName).Replace("\\", "/");
                            arquivo = System.IO.Path.GetFileName(openFileDialog1.FileName);
                            
                            img.ImageLocation = diretorio;
                            caminhoBanco = "upload/aluno/" + System.IO.Path.GetFileName(openFileDialog1.FileName);
                            lblCaminho.Text = caminhoBanco;

                        }
                    }
                }
            }
        }

        private void btnPreencher_Click(object sender, EventArgs e)
        {
            txtNome.Text = "Giovanna Lima Costa";
            cbSexo.SelectedIndex = 2;
            txtEmail.Text = "giovanna.lima@studify.com.br";
            txtSenha.Text = "123";
            txtContato1.Text = "(11) 2977-6468";
            txtRG.Text = "219095565";
            txtData.Text = "16062001";
            txtCEP.Text = "06810430";
            txtNum.Text = "1495";
            txtNomeResp.Text = "Rafaela Lima";
            cbSexoResp.SelectedIndex = 2;
            txtEmailResp.Text = "rafa.lima@studify.com.br";
            txtContatoResp.Text = "(11) 7145-3533";
            txtCPFResp.Text = "56350346599";
            txtRGResp.Text = "401858741";
            //tabControl1.SelectedTab = info2;
        }

        private void cbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrar.Checked == true)
            {
                txtSenha.PasswordChar = '\u0000';
            }
            else if (cbMostrar.Checked == false)
            {
                txtSenha.PasswordChar = '•';
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string remove = "delete from Tb_Aluno where Id_Aluno=" + lblID.Text;

            SqlCommand cmd = new SqlCommand(remove, con);

            try
            {
                // Abrindo a conexão com o banco
                con.Open();
                // Criando uma variável para adicionar e armazenar o resultado
                int resultado;
                if (MessageBox.Show("Tem certeza que deseja remover este aluno?",
               "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    resultado = cmd.ExecuteNonQuery();
                    if (resultado == 1)
                    {
                        MessageBox.Show("Aluno removido com sucesso!");
                        this.Close();
                    }
                    // Encerrando o uso do cmd
                    cmd.Dispose();
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

        private void btnInfo1_Click(object sender, EventArgs e)
        {
            pnInfo1.Visible = true;
            menu = true;
            VerificaMenu();
        }

        private void btnInfo2_Click(object sender, EventArgs e)
        {
            pnInfo1.Visible = false;
            menu = false;
            VerificaMenu();
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmComentarios com = new frmComentarios();
            string strSql = "SELECT * FROM Tb_Comentario where Id_Aluno="+lblID.Text;
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
            com.dataGridView1.DataSource = clientes;

            con.Close();
            com.ShowDialog();
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

        private void btnAction_Click(object sender, EventArgs e)
        {
            //ADICIONAR ALUNO
            if (btnAction.Text == "ADICIONAR")
            {
                string adicionaSQL = "insert into Tb_Aluno(Nome_Aluno, Foto_Aluno, Sexo_Aluno, Email_Aluno, Senha_Aluno, Contato1_Aluno, Contato2_Aluno, RG_Aluno, DataNascimento_Aluno, CEP_Aluno, Endereco_Aluno, NumeroEnd_Aluno, ComplementoEnd_Aluno, Bairro_Aluno, Cidade_Aluno, Estado_Aluno, Nome_Responsavel, Sexo_Responsavel, Email_Responsavel, Contato_Responsavel, CPF_Responsavel, RG_Responsavel,Categoria) values('" + txtNome.Text + "', '" + caminhoBanco + "', '" + cbSexo.SelectedItem + "','" + txtEmail.Text + "','" + txtSenha.Text + "','" + txtContato1.Text + "','" + txtContato2.Text + "','" + txtRG.Text + "','" + txtData.Text + "','" + txtCEP.Text + "','" + txtEndereco.Text + "', '" + txtNum.Text + "','" + txtComp.Text + "','" + txtBairro.Text + "','" + txtCidade.Text + "','" + txtEstado.Text + "','" + txtNomeResp.Text + "','" + cbSexoResp.SelectedItem + "','" + txtEmailResp.Text + "','" + txtContatoResp.Text + "','" + txtCPFResp.Text + "','" + txtRGResp.Text + "', 2)";
                SqlCommand cmd = new SqlCommand(adicionaSQL, con);
                try
                {
                    if (txtNome.Text != "" || txtEmail.Text != "" || txtSenha.Text != "" || txtContato1.Text != "" || txtRG.Text != "" || txtData.Text != "" || txtCEP.Text != "" || txtEndereco.Text != "" || txtNum.Text != "" || txtBairro.Text != "" || txtCidade.Text != "" || txtEstado.Text != "" )
                    {
                        VerificaCampos();
                        VerificaCampos2();
                        if (preenche == true)
                        {
                            VerificaIdade(txtData.Text);
                            if (idade >= 18)
                            {
                                con.Open();
                                int resultado = cmd.ExecuteNonQuery();
                                if (resultado == 1)
                                {
                                    if (diretorio==null || arquivo==null)
                                    {
                                        Clipboard.SetText(adicionaSQL);
                                        MessageBox.Show("Adicionado");
                                        this.Close();
                                    }
                                    else
                                    {
                                        System.IO.File.Copy(diretorio, @"..\..\..\..\..\SITE\upload\aluno\" + arquivo, true);
                                        Clipboard.SetText(adicionaSQL);
                                        MessageBox.Show("Adicionado");
                                        this.Close();
                                    }
                                    
                                }

                            }
                            else
                            {
                                ValidaCPF(txtCPFResp.Text);
                                if (valCPF == true)
                                {
                                    con.Open();
                                    int resultado = cmd.ExecuteNonQuery();
                                    if (resultado == 1)
                                    {
                                        if (diretorio == null || arquivo == null)
                                        {
                                            Clipboard.SetText(adicionaSQL);
                                            MessageBox.Show("Adicionado");
                                            this.Close();
                                        }
                                        else
                                        {
                                            System.IO.File.Copy(diretorio, @"..\..\..\..\..\SITE\upload\aluno\" + arquivo, true);
                                            Clipboard.SetText(adicionaSQL);
                                            MessageBox.Show("Adicionado");
                                            this.Close();
                                        }
                                    }
                                }
                                else
                                {
                                    lblCPFResp.Visible = true;
                                    lblCPFResp.Text = "CPF inválido";
                                }
                            }


                        }
                        else
                        {
                            VerificaCampos();
                            VerificaCampos2();
                        }

                    }
                    else
                    {
                        VerificaCampos();
                        VerificaCampos2();
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
            else if (btnAction.Text == "ATUALIZAR")
            {
                string atualizaSQL = "update Tb_Aluno set Nome_Aluno='" + txtNome.Text + "', Foto_Aluno='" + caminhoBanco + "', Sexo_Aluno='" + cbSexo.SelectedItem + "', Email_Aluno='" + txtEmail.Text + "', Senha_Aluno='" + txtSenha.Text + "', Contato1_Aluno='" + txtContato1.Text + "', Contato2_Aluno='" + txtContato2.Text + "', RG_Aluno='" + txtRG.Text + "', DataNascimento_Aluno='" + txtData.Text + "', CEP_Aluno='" + txtCEP.Text + "', Endereco_Aluno='" + txtEndereco.Text + "', NumeroEnd_Aluno='" + txtNum.Text + "', ComplementoEnd_Aluno='" + txtComp.Text + "', Bairro_Aluno='" + txtBairro.Text + "', Cidade_Aluno='" + txtCidade.Text + "', Estado_Aluno='" + txtEstado.Text + "', Nome_Responsavel='" + txtNomeResp.Text + "', Sexo_Responsavel='" + cbSexoResp.SelectedItem + "', Email_Responsavel='" + txtEmailResp.Text + "', Contato_Responsavel='" + txtContatoResp.Text + "', CPF_Responsavel='" + txtCPFResp.Text + "', RG_Responsavel='" + txtRGResp.Text + "' where Id_Aluno=" + lblID.Text;
                SqlCommand cmd = new SqlCommand(atualizaSQL, con);
                try
                {
                    if (txtNome.Text != "" || txtEmail.Text != "" || txtSenha.Text != "" || txtContato1.Text != "" || txtRG.Text != "" || txtData.Text != "" || txtCEP.Text != "" || txtEndereco.Text != "" || txtNum.Text != "" || txtBairro.Text != "" || txtCidade.Text != "" || txtEstado.Text != "")
                    {
                        VerificaCampos();
                        VerificaCampos2();
                        if (preenche == true)
                        {
                            VerificaIdade(txtData.Text);
                            if (idade >= 18)
                            {


                                con.Open();
                                int resultado = cmd.ExecuteNonQuery();
                                if (resultado == 1)
                                {
                                    if (diretorio == null || arquivo == null)
                                    {
                                        
                                        MessageBox.Show("Atualizado");
                                        this.Close();
                                    }
                                    else
                                    {
                                        System.IO.File.Copy(diretorio, @"..\..\..\..\..\SITE\upload\aluno\" + arquivo, true);
                                        
                                        MessageBox.Show("Atualizado");
                                        this.Close();
                                    }
                                }
                            }
                            else
                            {
                                ValidaCPF(txtCPFResp.Text);
                                if (valCPF == true)
                                {
                                    con.Open();
                                    int resultado = cmd.ExecuteNonQuery();
                                    if (resultado == 1)
                                    {
                                        if (diretorio == null || arquivo == null)
                                        {

                                            MessageBox.Show("Atualizado");
                                            this.Close();
                                            
                                            
                                        }
                                        else
                                        {
                                            System.IO.File.Copy(diretorio, @"..\..\..\..\..\SITE\upload\aluno\" + arquivo, true);

                                            MessageBox.Show("Atualizado");
                                            this.Close();
                                        }
                                    }
                                }
                                else
                                {
                                    lblCPFResp.Visible = true;
                                    lblCPFResp.Text = "CPF inválido";
                                }
                            }


                        }
                        else
                        {
                            VerificaCampos();
                            VerificaCampos2();
                        }

                    }
                    else
                    {
                        VerificaCampos();
                        VerificaCampos2();
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
        
    }
}
