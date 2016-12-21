using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class PerfilProfessor : System.Web.UI.Page
{
    public string recuperaImagemSQL, img;
    public static decimal soma, total, media;
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StudifyConnectionString3"].ConnectionString);

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
            lblUsuario.Visible = false;

            int categoria = Convert.ToInt32(Session["Categoria"]);
            if (categoria == 1)
            {
                pnEnviarCom.Visible = false;
                pnFacaLogin.Visible = true;
                recuperaImagemSQL = "SELECT Foto_Professor FROM Tb_Professor WHERE Id_Professor=" + Session["idLogin"];
            }
            else if (categoria == 2)
            {
                pnEnviarCom.Visible = true;
                pnFacaLogin.Visible = false;
                recuperaImagemSQL = "SELECT Foto_Aluno FROM Tb_Aluno WHERE Id_Aluno=" + Session["idLogin"];
            }

            SqlCommand recuperaImagem = new SqlCommand(recuperaImagemSQL, con);
            SqlDataReader DR;
            try
            {
                con.Open();
                DR = recuperaImagem.ExecuteReader();
                if (DR.Read())
                {
                    img = DR.GetValue(0).ToString();
                    ImgPerfil.ImageUrl = DR.GetValue(0).ToString();
                    //txtComentario.Text = DR.GetValue(0).ToString();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }

        }
        else
        {
            Cadastro.Visible = true;
            CadastroMobile.Visible = true;
            lblUsuario.Visible = false;
            ddlPerfil.Visible = false;
            ddlPerfilMobile.Visible = false;
        }
        try
        {

            SqlCommand somaAvaliacao = new SqlCommand("select SUM(Avaliacao) OVER () AS SumTotal from Tb_Comentario where Id_Professor=" + Request.QueryString["codigo"], con);

            con.Open();

            soma = Convert.ToDecimal(somaAvaliacao.ExecuteScalar());




            SqlCommand totalAvaliacao = new SqlCommand("Select count(*) from Tb_Comentario where Id_Professor=" + Request.QueryString["codigo"], con);
            total = Convert.ToDecimal(totalAvaliacao.ExecuteScalar());
            con.Close();
            media = soma / total;
            Repeater1.DataBind();
            RepeaterComentario.DataBind();
        }
        catch (Exception)
        {

        }
        con.Close();
    }
    protected void Page_LoadComplete(object sender, EventArgs e)
    {


    }
    protected void Page_Load(object sender, EventArgs e)
    {
        txtEnsinoFundamental.Attributes["type"] = "hidden";
        txtEnsinoMedio.Attributes["type"] = "hidden";
        txtEnsinoTecnico.Attributes["type"] = "hidden";
        txtPreVestibular.Attributes["type"] = "hidden";
        txtGraduacao.Attributes["type"] = "hidden";



        if (Session["idLogin"] == null)
        {
            pnEnviarCom.Visible = false;
            pnFacaLogin.Visible = true;
        }
        else
        {
            pnEnviarCom.Visible = true;
            pnFacaLogin.Visible = false;
        }
        
        int categoria = Convert.ToInt32(Session["Categoria"]);
        if (categoria == 1)
        {
            txtComentario.Enabled = false;
            txtComentario.Text = "É necessário ser um aluno para comentar";
            ddlAvaliarComentario.Enabled = false;
            ButtonEnviarComentario.Enabled = false;
        }
        else if (categoria == 2)
        {

            pnEnviarCom.Visible = true;
            pnFacaLogin.Visible = false;
        }


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

    protected void ButtonEnviarComentario_Click(object sender, EventArgs e)
    {
        con.Open();

        string IdAluno = Session["idLogin"].ToString();
        string NomeAluno = Session["Login"].ToString();

        //Session.Remove("idLogin");

        string strInserirComentario = "Insert into Tb_Comentario (Id_Professor, Id_Aluno, Comentario, Avaliacao, Nome_Aluno, Img_Perfil) values (" + Request.QueryString["codigo"] + ", " + IdAluno + ", @Comentario, @Avaliacao,'" + NomeAluno + "',@Img_Perfil)";
        SqlCommand InserirComentario = new SqlCommand(strInserirComentario, con);
        InserirComentario.Parameters.AddWithValue("@Comentario", txtComentario.Text);
        InserirComentario.Parameters.AddWithValue("@Avaliacao", ddlAvaliarComentario.SelectedValue.ToString());
        InserirComentario.Parameters.AddWithValue("@Img_Perfil", img);


        try
        {
            InserirComentario.ExecuteNonQuery();
            con.Close();
            SqlCommand somaAvaliacao = new SqlCommand("select SUM(Avaliacao) OVER () AS SumTotal from Tb_Comentario where Id_Professor=" + Request.QueryString["codigo"], con);

            con.Open();

            soma = Convert.ToDecimal(somaAvaliacao.ExecuteScalar());
            con.Close();


            SqlCommand totalAvaliacao = new SqlCommand("Select count(*) from Tb_Comentario where Id_Professor=" + Request.QueryString["codigo"], con);
            con.Open();
            total = Convert.ToDecimal(totalAvaliacao.ExecuteScalar());
            con.Close();
            media = soma / total;
            string mediaAtual = media.ToString().Replace(",", ".");
            SqlCommand insereAvaliacao = new SqlCommand("update Tb_Professor set Avaliacao_Professor=" + mediaAtual + " where Id_Professor=" + Request.QueryString["codigo"], con);
            con.Open();
            insereAvaliacao.ExecuteNonQuery();
            con.Close();
            txtComentario.Text = "";
            Repeater1.DataBind();
            RepeaterComentario.DataBind();
            Response.Write("<script>alert('Cadastro realizado com sucesso!')</script>");
            //Response.Redirect("login.aspx");
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('ERRO...tente novamente')</script>");
            txtComentario.Text = ex.ToString();
        }
    }

    protected void Repeater1_DataBinding(object sender, EventArgs e)
    {

    }

    protected void RepeaterComentario_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        Image img = (Image)e.Item.FindControl("imgAvaliacaoCom");

        int avaliacao = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "Avaliacao"));


        if (avaliacao == 0.00)
        {
            img.ImageUrl = "images/starsrating/0.png";
        }
        else if (avaliacao == 1.00)
        {
            img.ImageUrl = "images/starsrating/1.png";
        }
        else if (avaliacao == 2.00)
        {
            img.ImageUrl = "images/starsrating/2.png";
        }
        else if (avaliacao == 3.00)
        {
            img.ImageUrl = "images/starsrating/3.png";
        }
        else if (avaliacao == 4.00)
        {
            img.ImageUrl = "images/starsrating/4.png";
        }
        else if (avaliacao == 5.00)
        {
            img.ImageUrl = "images/starsrating/5.png";
        }
    }

    protected void Repeater1_ItemDataBound1(object sender, RepeaterItemEventArgs e)
    {
        string visualizaCom = "select * from Tb_Comentario where Id_Professor="+ Request.QueryString["codigo"];
        SqlCommand cmd = new SqlCommand(visualizaCom, con);
        con.Open();
        int resultado = Convert.ToInt32(cmd.ExecuteScalar());

        if (resultado == 0)
        {
            Image img = (Image)e.Item.FindControl("Image1");

            img.ImageUrl = "images/starsrating/0.png";
        }
        else
        {
            
            Image img = (Image)e.Item.FindControl("Image1");

            double mediaExibe = Convert.ToDouble(media);

            if (mediaExibe >= 5.00)
            {
                img.ImageUrl = "images/starsrating/5.png";
            }
            else if (mediaExibe >= 4.50)
            {
                img.ImageUrl = "images/starsrating/4,5.png";
            }
            else if (mediaExibe >= 4.00)
            {
                img.ImageUrl = "images/starsrating/4.png";
            }
            else if (mediaExibe >= 3.50)
            {
                img.ImageUrl = "images/starsrating/3,5.png";
            }
            else if (mediaExibe >= 3.00)
            {
                img.ImageUrl = "images/starsrating/3.png";
            }
            else if (mediaExibe >= 2.50)
            {
                img.ImageUrl = "images/starsrating/2,5.png";
            }
            else if (mediaExibe >= 2.00)
            {
                img.ImageUrl = "images/starsrating/2.png";
            }
            else if (mediaExibe >= 1.50)
            {
                img.ImageUrl = "images/starsrating/1,5.png";
            }
            else if (mediaExibe >= 1.00)
            {
                img.ImageUrl = "images/starsrating/1.png";
            }
            else if (mediaExibe >= 0.50)
            {
                img.ImageUrl = "images/starsrating/0,5.png";
            }
            else if (mediaExibe >= 0.00)
            {
                img.ImageUrl = "images/starsrating/0.png";
            }
            

        }
        
    }
}