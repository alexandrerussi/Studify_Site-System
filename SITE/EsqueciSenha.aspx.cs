using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;

public partial class EsqueciSenha : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StudifyConnectionString3"].ConnectionString);
    static int id, codigo, categoria;
    static string atualizaSenha;
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

    protected void Page_Load(object sender, EventArgs e)
    {
        txtEnsinoFundamental.Attributes["type"] = "hidden";
        txtEnsinoMedio.Attributes["type"] = "hidden";
        txtEnsinoTecnico.Attributes["type"] = "hidden";
        txtPreVestibular.Attributes["type"] = "hidden";
        txtGraduacao.Attributes["type"] = "hidden";

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

    protected void btnEsqueci1_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtEmailEsqueci.Text))
        {
            return;
        }
        else
        {
            string verficaEmail = "Select ((Select count(Email_Aluno) From Tb_Aluno where Email_Aluno='" + txtEmailEsqueci.Text + "')+(Select count(Email_Professor) From Tb_Professor WHERE Email_Professor='" + txtEmailEsqueci.Text + "')) as total_area";
            SqlCommand verificando = new SqlCommand(verficaEmail, con);

            try
            {
                con.Open();
                int resultado = Convert.ToInt32(verificando.ExecuteScalar());

                if (resultado != 0)
                {
                    string verificaCategoria = "SELECT Id_Professor, Nome_Professor, Categoria FROM Tb_Professor WHERE Email_Professor='" + txtEmailEsqueci.Text + "' UNION ALL SELECT Id_Aluno, Nome_Aluno, Categoria FROM Tb_Aluno WHERE Email_Aluno='" + txtEmailEsqueci.Text + "'";
                    SqlCommand VerificaLogin = new SqlCommand(verificaCategoria, con);
                    SqlDataReader DR;
                    try
                    {

                        DR = VerificaLogin.ExecuteReader();
                        if (DR.Read())
                        {
                            id = Convert.ToInt32(DR.GetValue(0));
                            if (Convert.ToInt32(DR.GetValue(2)) == 1)
                            {
                                categoria = 1;
                            }
                            else
                            {
                                categoria = 2;
                            }
                            Random random = new Random();
                            codigo = Convert.ToInt32(random.Next(1, 9999999).ToString());
                            try
                            {

                                MailMessage mail = new MailMessage();
                                mail.To.Add(txtEmailEsqueci.Text);
                                mail.From = new MailAddress("studifyeducacao@gmail.com");
                                mail.Subject = "Studify - Código de Verificação";

                                mail.Body = "<html><link href=\"https://fonts.googleapis.com/css?family=Roboto:100,300,400,500,700,900\" rel=\"stylesheet\"><table style=\"width:538px;background-color:#393836\" align=\"center\" cellspacing=\"0\" cellpadding=\"0\"><tbody><tr><td style=\"height:65px;background-color:#009688;border-bottom:1px solid #4db6ac\"><img src=\"http://studify.com.br/images/headerEmail.jpg\" width=\"538\" height=\"65\" alt=\"Studify\" class=\"CToWUd\"></td></tr><tr><td bgcolor=\"#17212e\" style=\"background-image:url(http://studify.com.br/images/fundoRetrato.jpg);background-repeat:no-repeat;\"><table width=\"470\" border=\"0\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\" style=\"padding-left:5px;padding-right:5px\"><tbody><tr><td style=\"padding-top:32px;text-align: center;\"><br/><span style=\"font-size:30px;color:#f5f5f5;font-family:'Roboto', sans-serif; font-weight: 300;\">SEU CÓDIGO DE VERIFICAÇÃO É:</span><br/><br/><span style=\"font-size:35px;color:#ff7043;font-family:'Roboto', sans-serif; font-weight: 300;\" >" + codigo + "</span><br/><br/><span style=\"font-size:22px;color:#f5f5f5;font-family:'Roboto', sans-serif; font-weight: 300;\" >COPIE O CÓDIGO ACIMA E COLE NO CAMPO INDICADO NO SITE</span><br/><br/><br/><br/><br/><span style=\"font-size:26px;color:#f5f5f5;font-family:'Roboto', sans-serif; font-weight: 300;\" >SIGA-NOS EM NOSSAS REDES SOCIAIS!</span><br/><br/><br/><span style=\"font-size:26px;color:#f5f5f5;font-family:'Roboto', sans-serif; font-weight: 300;\" ><a href=\"https://www.facebook.com/studifyeducacao/\"><img src=\"http://studify.com.br/imagens/fb.jpg\" width=\"200\" height=\"auto\"></a></span><span style=\"font-size:26px;color:#f5f5f5;font-family:'Roboto', sans-serif; font-weight: 300;\" ><a href=\"https://www.youtube.com/channel/UCTCIAlYf7QcHdaoCiCj3Gnw\"><img src=\"http://studify.com.br/imagens/yt.jpg\" width=\"200\" height=\"auto\"></a></span><br/><br/><br/><br/><br/></td></tr></tbody></table></td></tr></tbody></table></td></tbody></table></html>";

                                mail.IsBodyHtml = true;
                                SmtpClient smtp = new SmtpClient();
                                smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
                                smtp.Credentials = new System.Net.NetworkCredential("studifyeducacao@gmail.com", "Studify10"); // ***use valid credentials***
                                smtp.Port = 587;
                                //Or your Smtp Email ID and Password
                                smtp.EnableSsl = true;
                                smtp.Send(mail);
                                MultiView1.ActiveViewIndex = 1;
                            }
                            catch (Exception ex)
                            {
                                Response.Write("<script>alert('Email não enviado22!')</script>");
                                txtEmailEsqueci.Text = ex.Message;
                            }
                        }
                        else
                        {
                            Response.Write("<script>alert('Email não enviado33!')</script>");
                        }



                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script>alert('Email não enviado11!')</script>");
                        txtEmailEsqueci.Text = ex.Message;
                    }


                }
                else
                {
                    Response.Write("<script>alert('Email não cadastrado!')</script>");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Erro de conexão')</script>");
                txtEmailEsqueci.Text = ex.Message;
            }
        }



    }

    protected void btnEsqueci2_Click(object sender, EventArgs e)
    {
        if (codigo.ToString() == txtIdEsqueci.Text)
        {
            MultiView1.ActiveViewIndex = 2;
            codigo = 0;
        }
        else if (codigo == 0)
        {
            Response.Redirect("index.aspx");
        }
        else
        {
            Response.Write("<script>alert('Id incorreto')</script>");
            return;
        }
    }

    protected void btnEsqueci3_Click(object sender, EventArgs e)
    {
        if (categoria == 0)
        {
            Response.Redirect("index.aspx");
            return;
        }
        else if (categoria == 1)
        {
            atualizaSenha = "update Tb_Professor set Senha_Professor='" + txtSenhaEsqueci.Text + "' where Id_Professor=" + id;
        }
        else if (categoria == 2)
        {
            atualizaSenha = "update Tb_Aluno set Senha_Aluno='" + txtSenhaEsqueci.Text + "' where Id_Aluno=" + id;
        }
        SqlCommand cmd = new SqlCommand(atualizaSenha, con);
        try
        {
            con.Open();
            int resultado = cmd.ExecuteNonQuery();
            if (resultado == 1)
            {
                Response.Write("<script>alert('Senha alterada com sucesso!')</script>");
                Response.Redirect("index.aspx");
            }
        }
        catch (Exception)
        {
            Response.Write("<script>alert('Erro de conexão!')</script>");
        }
        finally
        {
            con.Close();
        }
    }
}