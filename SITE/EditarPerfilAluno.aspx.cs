using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class EditarPerfilAluno : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StudifyConnectionString3"].ConnectionString);
    public int idade;
    protected void Page_Init(object sender, EventArgs e)
    {
        if (Session["Login"] != null)
        {
            lblUsuario.Text = Session["Login"].ToString();
            Cadastro.Visible = false;
            CadastroMobile.Visible = false;
            ddlPerfil.Visible = true;
            ddlPerfilMobile.Visible = true;
            ddlPerfil.Items.Insert(0, new ListItem("Olá, " + lblUsuario.Text, "1"));
            ddlPerfilMobile.Items.Insert(0, new ListItem("Olá, " + lblUsuario.Text, "1"));
            lblUsuario.Visible = false;
        }
        else
        {
            Cadastro.Visible = true;
            CadastroMobile.Visible = true;
            lblUsuario.Visible = false;
            ddlPerfil.Visible = false;
            ddlPerfilMobile.Visible = false;
            //Response.Redirect("PerfilProfessor.aspx");
        }
    }

    protected void Page_LoadComplete(object sender, EventArgs e)
    {
        
        string insereAluno = "select * from Tb_Aluno where Id_Aluno=" + Session["idLogin"];
        SqlCommand cmd = new SqlCommand(insereAluno, con);
        SqlDataReader DR;
        try
        {
            con.Open();
            DR = cmd.ExecuteReader();
            if (DR.Read())
            {
                txtNomeCompleto.Text = DR.GetValue(1).ToString();
                //lblCaminho.Text = DR.GetValue(2).ToString();
                //img.ImageLocation = DR.GetValue(2).ToString();
                ddlSexo.SelectedItem.Text = DR.GetValue(3).ToString();
                txtEmailCadastro.Text = DR.GetValue(4).ToString();
                txtSenhaCadastro.Text = DR.GetValue(5).ToString();
                txtConfirmarSenha.Text = DR.GetValue(5).ToString();
                txtContato1.Text = DR.GetValue(6).ToString();
                txtContato2.Text = DR.GetValue(7).ToString();
                txtRG.Text = DR.GetValue(8).ToString().Replace(".", "").Replace("-", "");
                DateTime dt = Convert.ToDateTime(DR.GetValue(9).ToString());
                ddlDiaNascimento.SelectedValue = dt.Day.ToString();
                ddlMesNascimento.SelectedValue = "0" + dt.Month.ToString();
                ddlAnoNascimento.SelectedValue = dt.Year.ToString();
                txtCEP.Text = DR.GetValue(10).ToString().Replace("-", "");
                txtEndereco.Text = DR.GetValue(11).ToString();
                txtNumero.Text = DR.GetValue(12).ToString();
                txtComplemento.Text = DR.GetValue(13).ToString();
                txtBairro.Text = DR.GetValue(14).ToString();
                txtCidade.Text = DR.GetValue(15).ToString();
                ddlEstado.SelectedValue = DR.GetValue(16).ToString();
                txtNomeCompletoResponsavel.Text = DR.GetValue(17).ToString();
                ddlSexoResponsavel.SelectedItem.Text = DR.GetValue(18).ToString();
                txtEmailCadastroResponsavel.Text = DR.GetValue(19).ToString();
                txtContatoResponsavel.Text = DR.GetValue(20).ToString();
                txtCpfCadastroResponsavel.Text = DR.GetValue(21).ToString().Replace(".", "").Replace("-", "");
                txtRgCadastroResponsavel.Text = DR.GetValue(22).ToString().Replace(".", "").Replace("-", "");
            }
        }
        catch (Exception)
        {
            Response.Write("<script>alert('ERRO DE CONEXÃO!')</script>");
        }
        finally
        {
            con.Close();
        }
    }
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

    protected void ddlPerfil_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlPerfil.SelectedValue == "Sair")
        {
            ddlPerfil.Visible = false;
            ddlPerfilMobile.Visible = false;
            Cadastro.Visible = true;
            CadastroMobile.Visible = true;
            Session.Clear();
            ListItem removeItem = ddlPerfil.Items.FindByValue("1");
            ddlPerfil.Items.Remove(removeItem);

            ListItem removeItemMobile = ddlPerfilMobile.Items.FindByValue("1");
            ddlPerfilMobile.Items.Remove(removeItem);
        }

        if (ddlPerfilMobile.SelectedValue == "Sair")
        {
            ddlPerfil.Visible = false;
            ddlPerfilMobile.Visible = false;
            Cadastro.Visible = true;
            CadastroMobile.Visible = true;
            Session.Clear();
            ListItem removeItem = ddlPerfil.Items.FindByValue("1");
            ddlPerfil.Items.Remove(removeItem);

            ListItem removeItemMobile = ddlPerfilMobile.Items.FindByValue("1");
            ddlPerfilMobile.Items.Remove(removeItem);
        }

        if (ddlPerfil.SelectedValue == "Perfil")
        {
            int categoria = Convert.ToInt32(Session["Categoria"]);
            if (categoria == 1)
            {
                Response.Redirect("EditarPerfilProfessor.aspx");
            }
            else if (categoria == 2)
            {
                Response.Redirect("EditarPerfilAluno.aspx");
            }
        }
    }




    protected void btnLogar_Click(object sender, EventArgs e)
    {
        string strSQLBuscaLogin = "SELECT Id_Professor, Nome_Professor, Email_Professor,Senha_Professor,Categoria FROM Tb_Professor WHERE Email_Professor='" + txtEmail.Text + "' and Senha_Professor='" + txtSenha.Text + "' UNION ALL SELECT Id_Aluno, Nome_Aluno, Email_Aluno,Senha_Aluno, Categoria FROM Tb_Aluno WHERE Email_Aluno='" + txtEmail.Text + "' and Senha_Aluno='" + txtSenha.Text + "'";

        SqlCommand VerificaLogin = new SqlCommand(strSQLBuscaLogin, con);

        SqlDataReader DR;

        try
        {
            con.Open();
            DR = VerificaLogin.ExecuteReader();

            if (DR.Read())
            {
                Session["Categoria"] = DR.GetValue(4);
                Session["Login"] = DR.GetValue(1).ToString();
                Session["idLogin"] = DR.GetValue(0).ToString();
                Response.Write("<script>alert('Login feito com sucesso!')</script>");
                Response.Redirect("index.aspx");
            }
            else
            {

                Response.Write("<script>alert('Dados inválidos!')</script>");

            }
        }
        catch (Exception)
        {

            Response.Write("<script>alert('Erro de conexão')</script>");
        }
        finally
        {
            con.Close();
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

    protected void FinalizarAluno_Click(object sender, EventArgs e)
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
                    fileUploadImagem.SaveAs(Server.MapPath("/upload/aluno/" + fileUploadImagem.FileName));
                    lblMensagem.Text = "Arquivo Enviado com Sucesso!!!";
                    string data = ddlDiaNascimento.SelectedItem.ToString() + "/" + ddlMesNascimento.SelectedValue.ToString() + "/" + ddlAnoNascimento.SelectedItem.ToString();
                    string atualizaSQL = "update Tb_Aluno set Nome_Aluno= @Nome_Aluno, Foto_Aluno= @Foto_Aluno, Sexo_Aluno= @Sexo_Aluno, Email_Aluno= @Email_Aluno, Senha_Aluno= @Senha_Aluno, Contato1_Aluno= @Contato1_Aluno, Contato2_Aluno= @Contato2_Aluno, RG_Aluno= @RG_Aluno, DataNascimento_Aluno= @DataNascimento_Aluno, CEP_Aluno= @CEP_Aluno, Endereco_Aluno= @Endereco_Aluno, NumeroEnd_Aluno= @NumeroEnd_Aluno, ComplementoEnd_Aluno= @ComplementoEnd_Aluno, Bairro_Aluno= @Bairro_Aluno, Cidade_Aluno= @Cidade_Aluno, Estado_Aluno= @Estado_Aluno, Nome_Responsavel= @Nome_Responsavel, Sexo_Responsavel= @Sexo_Responsavel, Email_Responsavel= @Email_Responsavel, Contato_Responsavel= @Contato_Responsavel, CPF_Responsavel= @CPF_Responsavel, RG_Responsavel= @RG_Responsavel where Id_Aluno=" + Session["idLogin"];

                    SqlCommand cmd = new SqlCommand(atualizaSQL, con);
                    cmd.Parameters.AddWithValue("@Nome_Aluno", txtNomeCompleto.Text);
                    string caminho = "upload/aluno/" + fileUploadImagem.FileName;
                    cmd.Parameters.AddWithValue("@Foto_Aluno", caminho);
                    cmd.Parameters.AddWithValue("@Sexo_Aluno", ddlSexo.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Email_Aluno", txtEmailCadastro.Text);
                    cmd.Parameters.AddWithValue("@Senha_Aluno", txtSenhaCadastro.Text);
                    cmd.Parameters.AddWithValue("@Contato1_Aluno", txtContato1.Text);
                    cmd.Parameters.AddWithValue("@Contato2_Aluno", txtContato2.Text); //Tem que deixar esse campo NULL - alterar lá no BANCO - NÃO ESQUECER
                    cmd.Parameters.AddWithValue("@RG_Aluno", txtRG.Text);
                    cmd.Parameters.AddWithValue("@DataNascimento_Aluno", ddlDiaNascimento.SelectedItem.ToString() + "/" + ddlMesNascimento.SelectedValue.ToString() + "/" + ddlAnoNascimento.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CEP_Aluno", txtCEP.Text);
                    cmd.Parameters.AddWithValue("@Endereco_Aluno", txtEndereco.Text);
                    cmd.Parameters.AddWithValue("@NumeroEnd_Aluno", txtNumero.Text);
                    cmd.Parameters.AddWithValue("@ComplementoEnd_Aluno", txtComplemento.Text);
                    cmd.Parameters.AddWithValue("@Bairro_Aluno", txtBairro.Text);
                    cmd.Parameters.AddWithValue("@Cidade_Aluno", txtCidade.Text);
                    cmd.Parameters.AddWithValue("@Estado_Aluno", ddlEstado.SelectedValue);
                    cmd.Parameters.AddWithValue("@Nome_Responsavel", txtNomeCompletoResponsavel.Text);
                    cmd.Parameters.AddWithValue("@Sexo_Responsavel", ddlSexoResponsavel.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Email_Responsavel", txtEmailCadastroResponsavel.Text);
                    cmd.Parameters.AddWithValue("@Contato_Responsavel", txtContatoResponsavel.Text);
                    cmd.Parameters.AddWithValue("@CPF_Responsavel", txtCpfCadastroResponsavel.Text);
                    cmd.Parameters.AddWithValue("@RG_Responsavel", txtRgCadastroResponsavel.Text);

                    try
                    {
                        con.Open();
                        VerificaIdade(data);

                        int resultado = cmd.ExecuteNonQuery();
                        if (resultado == 1)
                        {
                            
                            Response.Write("<script>alert('Atualizado com sucesso!')</script>");
                            Response.Redirect("index.aspx");
                        }

                    }
                    catch (Exception)
                    {
                        Response.Write("<script>alert('Erro de conexão')</script>");
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }
        else
        {
            string data = ddlDiaNascimento.SelectedItem.ToString() + "/" + ddlMesNascimento.SelectedValue.ToString() + "/" + ddlAnoNascimento.SelectedItem.ToString();
            string atualizaSQL = "update Tb_Aluno set Nome_Aluno= @Nome_Aluno, Sexo_Aluno= @Sexo_Aluno, Email_Aluno= @Email_Aluno, Senha_Aluno= @Senha_Aluno, Contato1_Aluno= @Contato1_Aluno, Contato2_Aluno= @Contato2_Aluno, RG_Aluno= @RG_Aluno, DataNascimento_Aluno= @DataNascimento_Aluno, CEP_Aluno= @CEP_Aluno, Endereco_Aluno= @Endereco_Aluno, NumeroEnd_Aluno= @NumeroEnd_Aluno, ComplementoEnd_Aluno= @ComplementoEnd_Aluno, Bairro_Aluno= @Bairro_Aluno, Cidade_Aluno= @Cidade_Aluno, Estado_Aluno= @Estado_Aluno, Nome_Responsavel= @Nome_Responsavel, Sexo_Responsavel= @Sexo_Responsavel, Email_Responsavel= @Email_Responsavel, Contato_Responsavel= @Contato_Responsavel, CPF_Responsavel= @CPF_Responsavel, RG_Responsavel= @RG_Responsavel where Id_Aluno=" + Session["idLogin"];

            SqlCommand cmd = new SqlCommand(atualizaSQL, con);
            cmd.Parameters.AddWithValue("@Nome_Aluno", txtNomeCompleto.Text);
            cmd.Parameters.AddWithValue("@Sexo_Aluno", ddlSexo.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Email_Aluno", txtEmailCadastro.Text);
            cmd.Parameters.AddWithValue("@Senha_Aluno", txtSenhaCadastro.Text);
            cmd.Parameters.AddWithValue("@Contato1_Aluno", txtContato1.Text);
            cmd.Parameters.AddWithValue("@Contato2_Aluno", txtContato2.Text); //Tem que deixar esse campo NULL - alterar lá no BANCO - NÃO ESQUECER
            cmd.Parameters.AddWithValue("@RG_Aluno", txtRG.Text);
            cmd.Parameters.AddWithValue("@DataNascimento_Aluno", ddlDiaNascimento.SelectedItem.ToString() + "/" + ddlMesNascimento.SelectedValue.ToString() + "/" + ddlAnoNascimento.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@CEP_Aluno", txtCEP.Text);
            cmd.Parameters.AddWithValue("@Endereco_Aluno", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@NumeroEnd_Aluno", txtNumero.Text);
            cmd.Parameters.AddWithValue("@ComplementoEnd_Aluno", txtComplemento.Text);
            cmd.Parameters.AddWithValue("@Bairro_Aluno", txtBairro.Text);
            cmd.Parameters.AddWithValue("@Cidade_Aluno", txtCidade.Text);
            cmd.Parameters.AddWithValue("@Estado_Aluno", ddlEstado.SelectedValue);
            cmd.Parameters.AddWithValue("@Nome_Responsavel", txtNomeCompletoResponsavel.Text);
            cmd.Parameters.AddWithValue("@Sexo_Responsavel", ddlSexoResponsavel.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Email_Responsavel", txtEmailCadastroResponsavel.Text);
            cmd.Parameters.AddWithValue("@Contato_Responsavel", txtContatoResponsavel.Text);
            cmd.Parameters.AddWithValue("@CPF_Responsavel", txtCpfCadastroResponsavel.Text);
            cmd.Parameters.AddWithValue("@RG_Responsavel", txtRgCadastroResponsavel.Text);

            try
            {
                con.Open();
                VerificaIdade(data);

                int resultado = cmd.ExecuteNonQuery();
                if (resultado == 1)
                {
                    //Response.Redirect("index.aspx");
                    Response.Write("<script>alert('Atualizado com sucesso!')</script>");
                    Response.Redirect("index.aspx");
                }

            }
            catch (Exception)
            {
                Response.Write("<script>alert('Erro de conexão')</script>");
            }
            finally
            {
                con.Close();
            }
        }
    }

    protected void btnEditarPerfilAluno_Click(object sender, EventArgs e)
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
                    fileUploadImagem.SaveAs(Server.MapPath("/upload/aluno/" + fileUploadImagem.FileName));
                    lblMensagem.Text = "Arquivo Enviado com Sucesso!!!";
                    string data = ddlDiaNascimento.SelectedItem.ToString() + "/" + ddlMesNascimento.SelectedValue.ToString() + "/" + ddlAnoNascimento.SelectedItem.ToString();
                    string atualizaSQL = "update Tb_Aluno set Nome_Aluno= @Nome_Aluno, Foto_Aluno= @Foto_Aluno, Sexo_Aluno= @Sexo_Aluno, Email_Aluno= @Email_Aluno, Senha_Aluno= @Senha_Aluno, Contato1_Aluno= @Contato1_Aluno, Contato2_Aluno= @Contato2_Aluno, RG_Aluno= @RG_Aluno, DataNascimento_Aluno= @DataNascimento_Aluno, CEP_Aluno= @CEP_Aluno, Endereco_Aluno= @Endereco_Aluno, NumeroEnd_Aluno= @NumeroEnd_Aluno, ComplementoEnd_Aluno= @ComplementoEnd_Aluno, Bairro_Aluno= @Bairro_Aluno, Cidade_Aluno= @Cidade_Aluno, Estado_Aluno= @Estado_Aluno where Id_Aluno=" + Session["idLogin"];

                    SqlCommand cmd = new SqlCommand(atualizaSQL, con);
                    cmd.Parameters.AddWithValue("@Nome_Aluno", txtNomeCompleto.Text);
                    string caminho = "upload/aluno/" + fileUploadImagem.FileName;
                    cmd.Parameters.AddWithValue("@Foto_Aluno", caminho);
                    cmd.Parameters.AddWithValue("@Sexo_Aluno", ddlSexo.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Email_Aluno", txtEmailCadastro.Text);
                    cmd.Parameters.AddWithValue("@Senha_Aluno", txtSenhaCadastro.Text);
                    cmd.Parameters.AddWithValue("@Contato1_Aluno", txtContato1.Text);
                    cmd.Parameters.AddWithValue("@Contato2_Aluno", txtContato2.Text); //Tem que deixar esse campo NULL - alterar lá no BANCO - NÃO ESQUECER
                    cmd.Parameters.AddWithValue("@RG_Aluno", txtRG.Text);
                    cmd.Parameters.AddWithValue("@DataNascimento_Aluno", ddlDiaNascimento.SelectedItem.ToString() + "/" + ddlMesNascimento.SelectedValue.ToString() + "/" + ddlAnoNascimento.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CEP_Aluno", txtCEP.Text);
                    cmd.Parameters.AddWithValue("@Endereco_Aluno", txtEndereco.Text);
                    cmd.Parameters.AddWithValue("@NumeroEnd_Aluno", txtNumero.Text);
                    cmd.Parameters.AddWithValue("@ComplementoEnd_Aluno", txtComplemento.Text);
                    cmd.Parameters.AddWithValue("@Bairro_Aluno", txtBairro.Text);
                    cmd.Parameters.AddWithValue("@Cidade_Aluno", txtCidade.Text);
                    cmd.Parameters.AddWithValue("@Estado_Aluno", ddlEstado.SelectedValue);



                    try
                    {
                        con.Open();
                        VerificaIdade(data);

                        if (idade < 18)
                        {
                            MultiView1.ActiveViewIndex = 1;
                        }
                        else
                        {
                            int resultado = cmd.ExecuteNonQuery();
                            if (resultado == 1)
                            {
                                Response.Write("<script>alert('Atualizado com sucesso!')</script>");
                                Response.Redirect("index.aspx");
                            }
                        }

                    }
                    catch (Exception)
                    {
                        Response.Write("<script>alert('Erro de conexão')</script>");
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }
        else
        {
            string data = ddlDiaNascimento.SelectedItem.ToString() + "/" + ddlMesNascimento.SelectedValue.ToString() + "/" + ddlAnoNascimento.SelectedItem.ToString();
            string atualizaSQL = "update Tb_Aluno set Nome_Aluno= @Nome_Aluno, Sexo_Aluno= @Sexo_Aluno, Email_Aluno= @Email_Aluno, Senha_Aluno= @Senha_Aluno, Contato1_Aluno= @Contato1_Aluno, Contato2_Aluno= @Contato2_Aluno, RG_Aluno= @RG_Aluno, DataNascimento_Aluno= @DataNascimento_Aluno, CEP_Aluno= @CEP_Aluno, Endereco_Aluno= @Endereco_Aluno, NumeroEnd_Aluno= @NumeroEnd_Aluno, ComplementoEnd_Aluno= @ComplementoEnd_Aluno, Bairro_Aluno= @Bairro_Aluno, Cidade_Aluno= @Cidade_Aluno, Estado_Aluno= @Estado_Aluno where Id_Aluno=" + Session["idLogin"];

            SqlCommand cmd = new SqlCommand(atualizaSQL, con);
            cmd.Parameters.AddWithValue("@Nome_Aluno", txtNomeCompleto.Text);
            cmd.Parameters.AddWithValue("@Sexo_Aluno", ddlSexo.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Email_Aluno", txtEmailCadastro.Text);
            cmd.Parameters.AddWithValue("@Senha_Aluno", txtSenhaCadastro.Text);
            cmd.Parameters.AddWithValue("@Contato1_Aluno", txtContato1.Text);
            cmd.Parameters.AddWithValue("@Contato2_Aluno", txtContato2.Text); //Tem que deixar esse campo NULL - alterar lá no BANCO - NÃO ESQUECER
            cmd.Parameters.AddWithValue("@RG_Aluno", txtRG.Text);
            cmd.Parameters.AddWithValue("@DataNascimento_Aluno", ddlDiaNascimento.SelectedItem.ToString() + "/" + ddlMesNascimento.SelectedValue.ToString() + "/" + ddlAnoNascimento.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@CEP_Aluno", txtCEP.Text);
            cmd.Parameters.AddWithValue("@Endereco_Aluno", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@NumeroEnd_Aluno", txtNumero.Text);
            cmd.Parameters.AddWithValue("@ComplementoEnd_Aluno", txtComplemento.Text);
            cmd.Parameters.AddWithValue("@Bairro_Aluno", txtBairro.Text);
            cmd.Parameters.AddWithValue("@Cidade_Aluno", txtCidade.Text);
            cmd.Parameters.AddWithValue("@Estado_Aluno", ddlEstado.SelectedValue);
            try
            {
                con.Open();
                VerificaIdade(data);

                if (idade < 18)
                {
                    MultiView1.ActiveViewIndex = 1;
                }
                else
                {
                    int resultado = cmd.ExecuteNonQuery();
                    if (resultado == 1)
                    {
                        Response.Write("<script>alert('Atualizado com sucesso!')</script>");
                        Response.Redirect("index.aspx");
                    }
                }

            }
            catch (Exception)
            {
                Response.Write("<script>alert('Erro de conexão')</script>");
            }
            finally
            {
                con.Close();
            }
        }
    }
}