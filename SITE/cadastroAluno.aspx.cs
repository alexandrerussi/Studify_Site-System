using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data; //classe Data vai gerenciar suas opções para banco de dados

public partial class cadastroAluno : System.Web.UI.Page
{
    public int idade;

    static string caminho;

    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StudifyConnectionString3"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {
        txtEnsinoFundamental.Attributes["type"] = "hidden";
        txtEnsinoMedio.Attributes["type"] = "hidden";
        txtEnsinoTecnico.Attributes["type"] = "hidden";
        txtPreVestibular.Attributes["type"] = "hidden";
        txtGraduacao.Attributes["type"] = "hidden";

        ddlAnoNascimento.Items.Add("Ano*");
        for (int i = 2016; i >= 1920; i--)
        {
            ddlAnoNascimento.Items.Add(i.ToString());
        }

        ddlDiaNascimento.Items.Add("Dia*");
        for (int i = 01; i <= 31; i++)
        {
            ddlDiaNascimento.Items.Add(i.ToString());
        }

        txtSenhaCadastro.Attributes["type"] = "password";
        txtConfirmarSenha.Attributes["type"] = "password";
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
    protected void btnCadastroAluno_Click(object sender, EventArgs e)
    {
        //criar objeto de conexao
        //Alterar a ConnectioString'1

        con.Open();
        string strSQLContaUsuario = "Select count(*) from Tb_Professor, Tb_Aluno where Tb_Professor.Email_Professor='" + txtEmailCadastro.Text + "' or Tb_Aluno.Email_Aluno='" + txtEmailCadastro.Text + "'";
        //criar o objeto que executa o comando SQL
        SqlCommand UsuarioExiste = new SqlCommand(strSQLContaUsuario, con);
        int total = Convert.ToInt32(UsuarioExiste.ExecuteScalar());

        if (total != 0)
        {
            Response.Write("<script>alert('Email já existente... Verifique o campo')</script>");
            txtEmailCadastro.Text = "";
            txtEmailCadastro.Focus();
        }
        else
        {
            //1 - Verificar se existe arquivo
            if (fileUploadImagem.HasFile)
            {
                //verificar a extensao
                string extensao = System.IO.Path.GetExtension(fileUploadImagem.FileName);

                if (extensao.ToLower() != ".png" && extensao.ToLower() != ".jpg" && extensao.ToLower() != ".jpeg")
                {
                    lblMensagem.Text = "Só pode enviar arquivos png, jpg ou jpeg!!!";
                    lblMensagem.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    //verificar o tamannho do arquivo
                    int tamanho = fileUploadImagem.PostedFile.ContentLength;

                    if (tamanho > 2097152)
                    {
                        lblMensagem.Text = "Só pode enviar arquivos de até 2 Megas";
                        lblMensagem.ForeColor = System.Drawing.Color.Red;
                    }

                    else
                    {
                        //Enviando o arquivo
                        fileUploadImagem.SaveAs(Server.MapPath("/upload/aluno/" + fileUploadImagem.FileName));
                        lblMensagem.Text = "Arquivo Enviado com Sucesso!!!";
                        lblMensagem.ForeColor = System.Drawing.Color.Green;
                        string data = ddlDiaNascimento.SelectedItem.ToString() + "/" + ddlMesNascimento.SelectedValue.ToString() + "/" + ddlAnoNascimento.SelectedItem.ToString();
                        //Na string tem que tirar o campo Contato2_Aluno e @Contato2_Aluno
                        string strSQLInserirUsuario = "Insert into Tb_Aluno (Nome_Aluno, Foto_Aluno, Sexo_Aluno, Email_Aluno, Senha_Aluno, Contato1_Aluno, Contato2_Aluno, RG_Aluno, DataNascimento_Aluno, CEP_Aluno, Endereco_Aluno, NumeroEnd_Aluno, Bairro_Aluno, Cidade_Aluno, Estado_Aluno, Categoria) values (@Nome_Aluno, @Foto_Aluno, @Sexo_Aluno, @Email_Aluno, @Senha_Aluno, @Contato1_Aluno, @Contato2_Aluno, @RG_Aluno, @DataNascimento_Aluno, @CEP_Aluno, @Endereco_Aluno, @NumeroEnd_Aluno, @Bairro_Aluno, @Cidade_Aluno, @Estado_Aluno, 2)";
                        SqlCommand inserirUsuario = new SqlCommand(strSQLInserirUsuario, con);
                        inserirUsuario.Parameters.AddWithValue("@Nome_Aluno", txtNomeCompleto.Text);
                        caminho = "upload/aluno/" + fileUploadImagem.FileName;
                        inserirUsuario.Parameters.AddWithValue("@Foto_Aluno", caminho);
                        inserirUsuario.Parameters.AddWithValue("@Sexo_Aluno", ddlSexo.SelectedItem.ToString());
                        inserirUsuario.Parameters.AddWithValue("@Email_Aluno", txtEmailCadastro.Text);
                        inserirUsuario.Parameters.AddWithValue("@Senha_Aluno", txtSenhaCadastro.Text);
                        inserirUsuario.Parameters.AddWithValue("@Contato1_Aluno", txtContato1.Text);
                        inserirUsuario.Parameters.AddWithValue("@Contato2_Aluno", txtContato2.Text); //Tem que deixar esse campo NULL - alterar lá no BANCO - NÃO ESQUECER
                        inserirUsuario.Parameters.AddWithValue("@RG_Aluno", txtRG.Text);
                        inserirUsuario.Parameters.AddWithValue("@DataNascimento_Aluno", ddlDiaNascimento.SelectedItem.ToString() + "/" + ddlMesNascimento.SelectedValue.ToString() + "/" + ddlAnoNascimento.SelectedItem.ToString());
                        inserirUsuario.Parameters.AddWithValue("@CEP_Aluno", txtCEP.Text);
                        inserirUsuario.Parameters.AddWithValue("@Endereco_Aluno", txtEndereco.Text);
                        inserirUsuario.Parameters.AddWithValue("@NumeroEnd_Aluno", txtNumero.Text);
                        inserirUsuario.Parameters.AddWithValue("@Bairro_Aluno", txtBairro.Text);
                        inserirUsuario.Parameters.AddWithValue("@Cidade_Aluno", txtCidade.Text);
                        inserirUsuario.Parameters.AddWithValue("@Estado_Aluno", ddlEstado.SelectedValue);

                        VerificaIdade(data);

                        if (idade < 18)
                        {
                            MultiView1.ActiveViewIndex = 1;
                        }
                        else
                        {
                            if (rdbTermos.Checked == true)
                            {
                                try
                                {
                                    inserirUsuario.ExecuteNonQuery();
                                    con.Close();
                                    Response.Write("<script>alert('Cadastro realizado com sucesso!')</script>");
                                    Response.Redirect("login.aspx");
                                }
                                catch (Exception ex)
                                {
                                    Response.Write("<script>alert('ERRO...tente novamente')</script>");
                                    txtEndereco.Text = ex.ToString();
                                }
                            }
                            else
                            {
                                Response.Write("<script>alert('Favor aceitar a nossa política de segurança para cadastrar.')</script>");
                            }

                        }
                    }
                }
            }
            else
            {
                string data = ddlDiaNascimento.SelectedItem.ToString() + "/" + ddlMesNascimento.SelectedValue.ToString() + "/" + ddlAnoNascimento.SelectedItem.ToString();
                string strSQLInserirUsuario = "Insert into Tb_Aluno (Nome_Aluno, Sexo_Aluno, Email_Aluno, Senha_Aluno, Contato1_Aluno, Contato2_Aluno, RG_Aluno, DataNascimento_Aluno, CEP_Aluno, Endereco_Aluno, NumeroEnd_Aluno, Bairro_Aluno, Cidade_Aluno, Estado_Aluno, Categoria) values (@Nome_Aluno, @Sexo_Aluno, @Email_Aluno, @Senha_Aluno, @Contato1_Aluno, @Contato2_Aluno, @RG_Aluno, @DataNascimento_Aluno, @CEP_Aluno, @Endereco_Aluno, @NumeroEnd_Aluno, @Bairro_Aluno, @Cidade_Aluno, @Estado_Aluno, 2)";
                SqlCommand inserirUsuario = new SqlCommand(strSQLInserirUsuario, con);
                inserirUsuario.Parameters.AddWithValue("@Nome_Aluno", txtNomeCompleto.Text);
                inserirUsuario.Parameters.AddWithValue("@Sexo_Aluno", ddlSexo.SelectedItem.ToString());
                inserirUsuario.Parameters.AddWithValue("@Email_Aluno", txtEmailCadastro.Text);
                inserirUsuario.Parameters.AddWithValue("@Senha_Aluno", txtSenhaCadastro.Text);
                inserirUsuario.Parameters.AddWithValue("@Contato1_Aluno", txtContato1.Text);
                inserirUsuario.Parameters.AddWithValue("@Contato2_Aluno", txtContato2.Text); //Tem que deixar esse campo NULL - alterar lá no BANCO - NÃO ESQUECER
                inserirUsuario.Parameters.AddWithValue("@RG_Aluno", txtRG.Text);
                inserirUsuario.Parameters.AddWithValue("@DataNascimento_Aluno", ddlDiaNascimento.SelectedItem.ToString() + "/" + ddlMesNascimento.SelectedValue.ToString() + "/" + ddlAnoNascimento.SelectedItem.ToString());
                inserirUsuario.Parameters.AddWithValue("@CEP_Aluno", txtCEP.Text);
                inserirUsuario.Parameters.AddWithValue("@Endereco_Aluno", txtEndereco.Text);
                inserirUsuario.Parameters.AddWithValue("@NumeroEnd_Aluno", txtNumero.Text);
                inserirUsuario.Parameters.AddWithValue("@Bairro_Aluno", txtBairro.Text);
                inserirUsuario.Parameters.AddWithValue("@Cidade_Aluno", txtCidade.Text);
                inserirUsuario.Parameters.AddWithValue("@Estado_Aluno", ddlEstado.SelectedValue);
                VerificaIdade(data);

                if (idade < 18)
                {

                    MultiView1.ActiveViewIndex = 1;
                }
                else
                {
                    if (rdbTermos.Checked == true)
                    {
                        try
                        {
                            inserirUsuario.ExecuteNonQuery();
                            con.Close();
                            Response.Write("<script>alert('Cadastro realizado com sucesso!')</script>");
                            Response.Redirect("login.aspx");
                        }
                        catch (Exception ex)
                        {
                            Response.Write("<script>alert('ERRO...tente novamente')</script>");
                            txtEndereco.Text = ex.ToString();
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Favor aceitar a nossa política de segurança para cadastrar.')</script>");
                    }
                }
            }
        }
    }

    protected void btnCadastroEmail_Click(object sender, EventArgs e)
    {
        //criar objeto de conexao
        //Alterar a ConnectioString'1

        con.Open();

        string strSQLCadastroEmail = "Insert into Tb_ListaEmails (Email) values (@Email)";
        SqlCommand cadastroEmail = new SqlCommand(strSQLCadastroEmail, con);
        cadastroEmail.Parameters.AddWithValue("@Email", txtEmailRodape.Text);


        try
        {
            cadastroEmail.ExecuteNonQuery();
            con.Close();
            txtEmailRodape.Text = "";
            Response.Redirect("index.aspx");
            Response.Write("<script>alert('Email Cadastrado')</script>");
        }
        catch (Exception)
        {
            Response.Write("<script>alert('ERRO...tente novamente')</script>");
        }
    }

    protected void btnEnviarContato_Click(object sender, EventArgs e)
    {
        //criar objeto de conexao
        //Alterar a ConnectioString'1

        con.Open();

        string strSQLEnviarMsg = "Insert into TbContato (nome, email, mensagem) values (@nome, @email, @mensagem)";
        SqlCommand enviarMsg = new SqlCommand(strSQLEnviarMsg, con);
        enviarMsg.Parameters.AddWithValue("@nome", txtNomeEntreContato.Text);
        enviarMsg.Parameters.AddWithValue("@email", txtEmailEntreContato.Text);
        enviarMsg.Parameters.AddWithValue("@mensagem", txtMensagemEntreContato.Text);


        try
        {
            enviarMsg.ExecuteNonQuery();
            con.Close();
            txtNomeEntreContato.Text = "";
            txtEmailEntreContato.Text = "";
            txtMensagemEntreContato.Text = "";
            Response.Redirect("index.aspx");
            Response.Write("<script>alert('Mensagem enviada')</script>");
        }
        catch (Exception)
        {
            Response.Write("<script>alert('ERRO...tente novamente')</script>");
        }

    }

    protected void btnLogar_Click(object sender, EventArgs e)
    {

    }

    protected void txtCEP_TextChanged(object sender, EventArgs e)
    {
        try
        {
            string rua;
            //criar um objeto do tipo dataset - 
            DataSet ds = new DataSet();

            //criar uma string que terá o endereço do XML
            string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", txtCEP.Text.Replace("-", ""));

            //ler o endereço
            ds.ReadXml(xml);
            rua = ds.Tables[0].Rows[0]["logradouro"].ToString();
            if (rua == "")
            {
                Response.Write("<script>alert('CEP INVÁLIDO!!!')</script>");
                txtCEP.Focus();
            }
            else
            {
                txtEndereco.Text = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString() + " " + ds.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                ddlEstado.SelectedValue = ds.Tables[0].Rows[0]["uf"].ToString();
                txtNumero.Focus();
            }

        }
        catch (Exception)
        {
            Response.Write("<script>alert('Serviço Indisponível...Tente novamente!!')</script>");
        }
    }

    protected void FinalizarAluno_Click(object sender, EventArgs e)
    {
        //criar objeto de conexao
        //Alterar a ConnectioString'1
        con.Open();
        string strSQLContaUsuario = "Select count(*) from Tb_Professor, Tb_Aluno where Tb_Professor.Email_Professor='" + txtEmailCadastro.Text + "' or Tb_Aluno.Email_Aluno='" + txtEmailCadastro.Text + "'";
        //criar o objeto que executa o comando SQL
        SqlCommand UsuarioExiste = new SqlCommand(strSQLContaUsuario, con);
        int total = Convert.ToInt32(UsuarioExiste.ExecuteScalar());

        if (total != 0)
        {
            Response.Write("<script>alert('Email já existente... Verifique o campo')</script>");
            txtEmailCadastro.Text = "";
            txtEmailCadastro.Focus();
        }
        else
        {
            fileUploadImagem.SaveAs(Server.MapPath("/upload/aluno/" + fileUploadImagem.FileName));
            lblMensagem.Text = "Arquivo Enviado com Sucesso!!!";
            lblMensagem.ForeColor = System.Drawing.Color.Green;

            //Na string tem que tirar o campo Contato2_Aluno e @Contato2_Aluno
            string strSQLInserirUsuario = "Insert into Tb_Aluno (Nome_Aluno, Foto_Aluno, Sexo_Aluno, Email_Aluno, Senha_Aluno, Contato1_Aluno, Contato2_Aluno, RG_Aluno, DataNascimento_Aluno, CEP_Aluno, Endereco_Aluno, NumeroEnd_Aluno, Bairro_Aluno, Cidade_Aluno, Estado_Aluno, Nome_Responsavel, Sexo_Responsavel, Email_Responsavel, Contato_Responsavel, CPF_Responsavel, RG_Responsavel, Categoria) values (@Nome_Aluno, @Foto_Aluno, @Sexo_Aluno, @Email_Aluno, @Senha_Aluno, @Contato1_Aluno, @Contato2_Aluno, @RG_Aluno, @DataNascimento_Aluno, @CEP_Aluno, @Endereco_Aluno, @NumeroEnd_Aluno, @Bairro_Aluno, @Cidade_Aluno, @Estado_Aluno, @Nome_Responsavel, @Sexo_Responsavel, @Email_Responsavel, @Contato_Responsavel, @CPF_Responsavel, @RG_Responsavel, 2)";
            SqlCommand inserirUsuario = new SqlCommand(strSQLInserirUsuario, con);
            inserirUsuario.Parameters.AddWithValue("@Nome_Aluno", txtNomeCompleto.Text);
            
            inserirUsuario.Parameters.AddWithValue("@Foto_Aluno", caminho);
            inserirUsuario.Parameters.AddWithValue("@Sexo_Aluno", ddlSexo.SelectedItem.ToString());
            inserirUsuario.Parameters.AddWithValue("@Email_Aluno", txtEmailCadastro.Text);
            inserirUsuario.Parameters.AddWithValue("@Senha_Aluno", txtSenhaCadastro.Text);
            inserirUsuario.Parameters.AddWithValue("@Contato1_Aluno", txtContato1.Text);
            inserirUsuario.Parameters.AddWithValue("@Contato2_Aluno", txtContato2.Text); //Tem que deixar esse campo NULL - alterar lá no BANCO - NÃO ESQUECER
            inserirUsuario.Parameters.AddWithValue("@RG_Aluno", txtRG.Text);
            inserirUsuario.Parameters.AddWithValue("@DataNascimento_Aluno", ddlDiaNascimento.SelectedItem.ToString() + "/" + ddlMesNascimento.SelectedValue.ToString() + "/" + ddlAnoNascimento.SelectedItem.ToString());
            inserirUsuario.Parameters.AddWithValue("@CEP_Aluno", txtCEP.Text);
            inserirUsuario.Parameters.AddWithValue("@Endereco_Aluno", txtEndereco.Text);
            inserirUsuario.Parameters.AddWithValue("@NumeroEnd_Aluno", txtNumero.Text);
            inserirUsuario.Parameters.AddWithValue("@Bairro_Aluno", txtBairro.Text);
            inserirUsuario.Parameters.AddWithValue("@Cidade_Aluno", txtCidade.Text);
            inserirUsuario.Parameters.AddWithValue("@Estado_Aluno", ddlEstado.SelectedValue);
            inserirUsuario.Parameters.AddWithValue("@Nome_Responsavel", txtNomeCompletoResponsavel.Text);
            inserirUsuario.Parameters.AddWithValue("@Sexo_Responsavel", ddlSexoResponsavel.SelectedItem.ToString());
            inserirUsuario.Parameters.AddWithValue("@Email_Responsavel", txtEmailCadastroResponsavel.Text);
            inserirUsuario.Parameters.AddWithValue("@Contato_Responsavel", txtContatoResponsavel.Text);
            inserirUsuario.Parameters.AddWithValue("@CPF_Responsavel", txtCpfCadastroResponsavel.Text);
            inserirUsuario.Parameters.AddWithValue("@RG_Responsavel", txtRgCadastroResponsavel.Text);



            try
            {
                inserirUsuario.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Cadastro realizado com sucesso!')</script>");
                Response.Redirect("login.aspx");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('ERRO...tente novamente')</script>");
                txtCpfCadastroResponsavel.Text = ex.ToString();
            }
        }
    }

    //protected void btnPreencherProf1_Click(object sender, EventArgs e)
    //{
    //    txtNomeCompleto.Text = "Erick Fernandes";
    //    ddlSexo.SelectedIndex = 1;
    //    txtEmailCadastro.Text = "erick@gmail.com";
    //    txtContato1.Text = "(43) 8590-9913";
    //    txtContato2.Text = "(43) 7549-6967";
    //    txtSenhaCadastro.Text = "123";
    //    txtConfirmarSenha.Text = "123";
    //    ddlDiaNascimento.SelectedIndex = 5;
    //    ddlMesNascimento.SelectedIndex = 3;
    //    ddlAnoNascimento.SelectedIndex = 15;
    //    txtRG.Text = "47.469.569-4";
    //    txtCEP.Text = "86031-050";
    //    txtEndereco.Text = "Rua Dionísio Pereira de Castro";
    //    txtNumero.Text = "142";
    //    txtComplemento.Text = "apto 12";
    //    txtBairro.Text = "Santa Izabel";
    //    ddlEstado.SelectedValue = "PR";
    //    txtCidade.Text = "Londrina";

    //    txtNomeCompletoResponsavel.Text = "Rosana Fernandes";
    //    ddlSexoResponsavel.SelectedIndex = 2;
    //    txtEmailCadastroResponsavel.Text = "rosana@gmail.com";
    //    txtContatoResponsavel.Text = "(71) 9004-7732";
    //    txtRgCadastroResponsavel.Text = "17.107.894-9";
    //    txtCpfCadastroResponsavel.Text = "263.861.423-81";
    //}
}