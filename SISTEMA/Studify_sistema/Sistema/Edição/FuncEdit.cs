using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//bibliotecas adicionadas
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;
using Microsoft.VisualBasic;

namespace Sistema
{
    public partial class FuncEdit : Form
    {
        int x, y;
        Point Point = new Point();

        public bool Valcpf = false;
        public string arquivo, diretorio, caminhoBanco;
        SqlConnection con = new SqlConnection(FrmLogin.strCn);
        public FuncEdit()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnDadosImp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string sexo;
            if (rdbFeminino.Checked == true)
            {
                sexo = "Feminino";
            }
            else
            {
                sexo = "Masculino";
            }

            string atualizaSQL = "update Tb_Funcionario set Nome_Funcionario='" + txtNome.Text + "', Foto_Funcionario='" + caminhoBanco + "', Sexo_Funcionario='" + sexo + "', Email_Funcionario='" + txtEmail.Text + "', Telefone_Funcionario='" + txtTelefone.Text + "', Celular_Funcionario='" + txtCelular.Text + "', CPF_Funcionario='" + txtCPF.Text + "', RG_Funcionario='" + txtRG.Text + "', DataNascimento_Funcionario='" + txtDataNasc.Text + "', CEP_Funcionario='" + txtCEP.Text + "', Endereco_Funcionario='" + txtEndereco.Text + "', NumeroEnd_Funcionario='" + txtNum.Text + "', ComplementoEnd_Funcionario='" + txtComp.Text + "', Bairro_Funcionario='" + txtBairro.Text + "', Cidade_Funcionario='" + txtCidade.Text + "', Estado_Funcionario='" + txtEstado.Text + "', Cargo_Funcionario='" + cbCargo.SelectedItem + "', Salario_Funcionario=" + txtSalario.Text.Replace(",", ".") + ", Login_Funcionario='" + txtLogin.Text + "', Senha_Funcionario='" + txtSenha.Text + "' where Id_Funcionario=" + lblID.Text;

            SqlCommand cmd = new SqlCommand(atualizaSQL, con);

            try
            {
                con.Open();
                if (txtNome.Text == "" || txtEmail.Text == "" || txtTelefone.Text == "" || txtCelular.Text == "" || txtCPF.Text == "" || txtRG.Text == "" || txtDataNasc.Text == "" || txtCEP.Text == "" || txtEndereco.Text == "" || txtNum.Text == "" || txtBairro.Text == "" || txtCidade.Text == "" || txtEstado.Text == "" || txtSalario.Text == "" || txtLogin.Text == "" || txtSenha.Text == "")
                {
                    txtNome.Focus();
                    MessageBox.Show("Campos vazios... Preencha corretamente");
                }
                else
                {
                    ValidaCPF();
                    if (Valcpf == false)
                    {
                        txtCPF.Clear();
                        txtCPF.Focus();
                        MessageBox.Show("CPF inválido!");
                    }
                    else if (Valcpf == true)
                    {
                        if (MessageBox.Show("Tem certeza que deseja atualizar?",
               "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int resultado;
                            resultado = cmd.ExecuteNonQuery();
                            if (resultado == 1)
                            {
                                if (diretorio == null || arquivo == null)
                                {
                                    MessageBox.Show("Atualizado com sucesso!");
                                    this.Close();
                                }
                                else
                                {
                                    System.IO.File.Copy(diretorio, @"..\..\..\..\..\SITE\upload\funcionario\" + arquivo, true);
                                    MessageBox.Show("Atualizado com sucesso!");
                                    this.Close();
                                }
                            }
                        }
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
        private void btnAlterar_Click(object sender, EventArgs e)
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

                            pctFoto.ImageLocation = diretorio;
                            caminhoBanco = "upload/funcionario/" + System.IO.Path.GetFileName(openFileDialog1.FileName);
                            
                        }
                    }
                }
            }
        }
        private void ValidaCPF()
        {
            int d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11;
            int soma1, soma2, resto1, resto2, dv1, dv2;
            string cpf = txtCPF.Text.Replace(".", "").Replace("-", "");
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
                Valcpf = false;
            }
            else
            {
                Valcpf = true;
            }
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {

            string remove = "delete from Tb_Funcionario where Id_Funcionario= " + lblID.Text;

            SqlCommand cmd = new SqlCommand(remove, con);

            try
            {
                // Abrindo a conexão com o banco
                con.Open();
                // Criando uma variável para adicionar e armazenar o resultado
                int resultado;
                if (MessageBox.Show("Tem certeza que deseja remover este funcionário?",
               "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    resultado = cmd.ExecuteNonQuery();
                    if (resultado == 1)
                    {
                        MessageBox.Show("Registro removido com sucesso");
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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string sexo;
            if (rdbFeminino.Checked == true)
            {
                sexo = "Feminino";
            }
            else
            {
                sexo = "Masculino";
            }
            string adicionaSQL = "insert into Tb_Funcionario(Nome_Funcionario, Foto_Funcionario, Sexo_Funcionario, Email_Funcionario, Telefone_Funcionario, Celular_Funcionario, CPF_Funcionario, RG_Funcionario, DataNascimento_Funcionario, CEP_Funcionario, Cidade_Funcionario, Estado_Funcionario, Endereco_Funcionario, NumeroEnd_Funcionario, Bairro_Funcionario, Cargo_Funcionario, Salario_Funcionario, Login_Funcionario, Senha_Funcionario) values('" + txtNome.Text + "', '" + caminhoBanco + "', '" + sexo + "', '" + txtEmail.Text + "', '" + txtTelefone.Text + "', '" + txtCelular.Text + "', '" + txtCPF.Text + "', '" + txtRG.Text + "', '" + txtDataNasc.Text + "', '" + txtCEP.Text + "', '" + txtCidade.Text + "', '" + txtEstado.Text + "', '" + txtEndereco.Text + "', '" + txtNum.Text + "', '" + txtBairro.Text + "', '" + cbCargo.SelectedItem + "', " + txtSalario.Text.Replace(",", ".") + ", '" + txtLogin.Text + "', '" + txtSenha.Text + "'); ";
            SqlCommand cmd = new SqlCommand(adicionaSQL, con);
            try
            {
                con.Open();
                if (txtNome.Text == "" || txtEmail.Text == "" || txtTelefone.Text == "" || txtCelular.Text == "" || txtCPF.Text == "" || txtRG.Text == "" || txtDataNasc.Text == "" || txtCEP.Text == "" || txtEndereco.Text == "" || txtNum.Text == "" || txtBairro.Text == "" || txtCidade.Text == "" || txtEstado.Text == "" || txtSalario.Text == "" || txtLogin.Text == "" || txtSenha.Text == "")
                {
                    txtNome.Focus();
                    MessageBox.Show("Campos vazios... Preencha corretamente");
                }
                else
                {
                    ValidaCPF();
                    if (Valcpf == false)
                    {
                        txtCPF.Clear();
                        txtCPF.Focus();
                        MessageBox.Show("CPF inválido!");
                    }
                    else if (Valcpf == true)
                    {
                        int resultado;
                        resultado = cmd.ExecuteNonQuery();
                        if (resultado == 1)
                        {
                            if (diretorio == null || arquivo == null)
                            {
                                MessageBox.Show("Adicionado com sucesso!");
                                this.Close();
                            }
                            else
                            {
                                System.IO.File.Copy(diretorio, @"..\..\..\..\..\SITE\upload\funcionario\" + arquivo, true);
                                MessageBox.Show("Adicionado com sucesso!");
                                this.Close();
                            }
                        }
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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void txtCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnPreencher_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
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

        private void cbExibir_CheckedChanged(object sender, EventArgs e)
        {
            if (cbExibir.Checked == true)
            {
                txtSenha.PasswordChar = '\u0000';
            }
            else if (cbExibir.Checked == false)
            {
                txtSenha.PasswordChar = '•';
            }
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
                }
                catch (Exception)
                {
                    MessageBox.Show("Serviço indisponível");
                }
            }
        }
    }
}
