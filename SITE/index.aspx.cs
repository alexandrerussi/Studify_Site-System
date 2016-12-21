using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class index : System.Web.UI.Page
{
    
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

        //Parte 3 texts
        txtFund.Attributes["type"] = "hidden";
        txtMedio.Attributes["type"] = "hidden";
        txtVest.Attributes["type"] = "hidden";
        txtTec.Attributes["type"] = "hidden";
        txtGrad.Attributes["type"] = "hidden";

        txtMat.Attributes["type"] = "hidden";
        txtPort.Attributes["type"] = "hidden";
        txtCienc.Attributes["type"] = "hidden";
        txtIng.Attributes["type"] = "hidden";
        txtHist.Attributes["type"] = "hidden";
        txtGeo.Attributes["type"] = "hidden";
        txtArtes.Attributes["type"] = "hidden";
        txtEsp.Attributes["type"] = "hidden";
        txtFis.Attributes["type"] = "hidden";
        txtQui.Attributes["type"] = "hidden";
        txtBio.Attributes["type"] = "hidden";
        txtFilo.Attributes["type"] = "hidden";
        txtSocio.Attributes["type"] = "hidden";

        txtInfo.Attributes["type"] = "hidden";
        txtMark.Attributes["type"] = "hidden";
        txtEnfermagem.Attributes["type"] = "hidden";
        txtMeca.Attributes["type"] = "hidden";
        txtArtVis.Attributes["type"] = "hidden";
        txtNutri.Attributes["type"] = "hidden";
        txtEven.Attributes["type"] = "hidden";
        txtBioComb.Attributes["type"] = "hidden";

        txtEng.Attributes["type"] = "hidden";
        txtMed.Attributes["type"] = "hidden";
        txtLetras.Attributes["type"] = "hidden";
        txtDir.Attributes["type"] = "hidden";
        txtCiencSoc.Attributes["type"] = "hidden";
        txtEco.Attributes["type"] = "hidden";
        txtArq.Attributes["type"] = "hidden";
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

        if (ddlPerfilMobile.SelectedValue == "Perfil")
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
    protected void ddlNivelAcademico_SelectedIndexChanged(object sender, EventArgs e)
    {
        string nivel, valor;
        nivel = ddlNivelAcademico.SelectedItem.Text;
        valor = ddlNivelAcademico.SelectedValue;

        if (valor == "-1")
        {

            ddlMateria.Items.Clear();
            ddlMateria.Items.Add(new ListItem("Selecione a matéria", "-1"));
        }
        else if (valor == "Ensino Fundamental")
        {
            ddlMateria.Items.Clear();
            ddlMateria.Items.Add(new ListItem("Selecione a matéria", "-1"));
            ddlMateria.Items.Add(new ListItem("Matemática", "Matemática"));
            ddlMateria.Items.Add(new ListItem("Português", "Português"));
            ddlMateria.Items.Add(new ListItem("Ciências", "Ciências"));
            ddlMateria.Items.Add(new ListItem("Inglês", "Inglês"));
            ddlMateria.Items.Add(new ListItem("História", "História"));
            ddlMateria.Items.Add(new ListItem("Geografia", "Geografia"));
            ddlMateria.Items.Add(new ListItem("Espanhol", "Espanhol"));
            ddlMateria.Items.Add(new ListItem("Arte", "Arte"));
        }
        else if (valor == "Ensino Médio")
        {
            ddlMateria.Items.Clear();
            ddlMateria.Items.Add(new ListItem("Selecione a matéria", "-1"));
            ddlMateria.Items.Add(new ListItem("Matemática", "Matemática"));
            ddlMateria.Items.Add(new ListItem("Português", "Português"));
            ddlMateria.Items.Add(new ListItem("Física", "Física"));
            ddlMateria.Items.Add(new ListItem("Química", "Química"));
            ddlMateria.Items.Add(new ListItem("Biologia", "Biologia"));
            ddlMateria.Items.Add(new ListItem("Inglês", "Inglês"));
            ddlMateria.Items.Add(new ListItem("História", "História"));
            ddlMateria.Items.Add(new ListItem("Geografia", "Geografia"));
            ddlMateria.Items.Add(new ListItem("Filosofia", "Filosofia"));
            ddlMateria.Items.Add(new ListItem("Sociologia", "Sociologia"));
        }
        else if (valor == "Pré-Vestibular")
        {
            ddlMateria.Items.Clear();
            ddlMateria.Items.Add(new ListItem("Selecione a matéria", "-1"));
            ddlMateria.Items.Add(new ListItem("Matemática", "Matemática"));
            ddlMateria.Items.Add(new ListItem("Português", "Português"));
            ddlMateria.Items.Add(new ListItem("Física", "Física"));
            ddlMateria.Items.Add(new ListItem("Química", "Química"));
            ddlMateria.Items.Add(new ListItem("Biologia", "Biologia"));
            ddlMateria.Items.Add(new ListItem("Inglês", "Inglês"));
            ddlMateria.Items.Add(new ListItem("História", "História"));
            ddlMateria.Items.Add(new ListItem("Geografia", "Geografia"));
            ddlMateria.Items.Add(new ListItem("Filosofia", "Filosofia"));
            ddlMateria.Items.Add(new ListItem("Sociologia", "Sociologia"));
        }
        else if (valor == "Ensino Técnico")
        {
            ddlMateria.Items.Clear();
            ddlMateria.Items.Add(new ListItem("Selecione o curso", "-1"));
            ddlMateria.Items.Add(new ListItem("Informática", "Informática"));
            ddlMateria.Items.Add(new ListItem("Administração", "Administração"));
            ddlMateria.Items.Add(new ListItem("Marketing", "Marketing"));
            ddlMateria.Items.Add(new ListItem("Eventos", "Eventos"));
            ddlMateria.Items.Add(new ListItem("Enfermagem", "Enfermagem"));
            ddlMateria.Items.Add(new ListItem("Meteorologia", "Meteorologia"));
            ddlMateria.Items.Add(new ListItem("Edificações", "Edificações"));
            ddlMateria.Items.Add(new ListItem("Alimentos", "Alimentos"));
            ddlMateria.Items.Add(new ListItem("Artes Visuais", "Artes Visuais"));
            ddlMateria.Items.Add(new ListItem("Biocombustíveis", "Biocombustíveis"));
            ddlMateria.Items.Add(new ListItem("Segurança do Trabalho", "Segurança do Trabalho"));
        }
        else if (valor == "Graduação")
        {
            ddlMateria.Items.Clear();
            ddlMateria.Items.Add(new ListItem("Selecione a matéria", "-1"));
            ddlMateria.Items.Add(new ListItem("Engenharias", "Engenharias"));
            ddlMateria.Items.Add(new ListItem("Medicina", "Medicina"));
            ddlMateria.Items.Add(new ListItem("Letras", "Letras"));
            ddlMateria.Items.Add(new ListItem("Direito", "Direito"));
            ddlMateria.Items.Add(new ListItem("Biologia", "Biologia"));
            ddlMateria.Items.Add(new ListItem("Ciências Sociais", "Ciências Sociais"));
            ddlMateria.Items.Add(new ListItem("Tecnologia da informação", "Tecnologia da informação"));
            ddlMateria.Items.Add(new ListItem("Economia", "Economia"));
            ddlMateria.Items.Add(new ListItem("Administração", "Administração"));
            ddlMateria.Items.Add(new ListItem("Arquitetura e urbanismo", "Arquitetura e urbanismo"));
            ddlMateria.Items.Add(new ListItem("Artes", "Artes"));
            ddlMateria.Items.Add(new ListItem("Matemática", "Matemática"));
            ddlMateria.Items.Add(new ListItem("Física", "Física"));
            ddlMateria.Items.Add(new ListItem("Química", "Química"));
            ddlMateria.Items.Add(new ListItem("Publicidade e marketing", "Publicidade e marketing"));
            ddlMateria.Items.Add(new ListItem("Turismo", "Turismo"));
        }


        return;
    }


    protected void btnLogar_Click(object sender, EventArgs e)
    {
        string strSQLBuscaLogin = "SELECT Id_Professor, Nome_Professor, Email_Professor,Senha_Professor,Categoria FROM Tb_Professor WHERE Email_Professor='" + txtEmail.Text+ "' and Senha_Professor='" + txtSenha.Text + "' UNION ALL SELECT Id_Aluno, Nome_Aluno, Email_Aluno,Senha_Aluno, Categoria FROM Tb_Aluno WHERE Email_Aluno='" + txtEmail.Text + "' and Senha_Aluno='" + txtSenha.Text + "'";

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

    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        string nivel, valor;
        nivel = DropDownList3.SelectedItem.Text;
        valor = DropDownList3.SelectedValue;

        if (valor == "-1")
        {

            DropDownList4.Items.Clear();
            DropDownList4.Items.Add(new ListItem("Selecione a matéria", "-1"));
        }
        else if (valor == "Ensino Fundamental")
        {
            DropDownList4.Items.Clear();
            DropDownList4.Items.Add(new ListItem("Selecione a matéria", "-1"));
            DropDownList4.Items.Add(new ListItem("Matemática", "Matemática"));
            DropDownList4.Items.Add(new ListItem("Português", "Português"));
            DropDownList4.Items.Add(new ListItem("Ciências", "Ciências"));
            DropDownList4.Items.Add(new ListItem("Inglês", "Inglês"));
            DropDownList4.Items.Add(new ListItem("História", "História"));
            DropDownList4.Items.Add(new ListItem("Geografia", "Geografia"));
            DropDownList4.Items.Add(new ListItem("Espanhol", "Espanhol"));
            DropDownList4.Items.Add(new ListItem("Arte", "Arte"));
        }
        else if (valor == "Ensino Médio")
        {
            DropDownList4.Items.Clear();
            DropDownList4.Items.Add(new ListItem("Selecione a matéria", "-1"));
            DropDownList4.Items.Add(new ListItem("Matemática", "Matemática"));
            DropDownList4.Items.Add(new ListItem("Português", "Português"));
            DropDownList4.Items.Add(new ListItem("Física", "Física"));
            DropDownList4.Items.Add(new ListItem("Química", "Química"));
            DropDownList4.Items.Add(new ListItem("Biologia", "Biologia"));
            DropDownList4.Items.Add(new ListItem("Inglês", "Inglês"));
            DropDownList4.Items.Add(new ListItem("História", "História"));
            DropDownList4.Items.Add(new ListItem("Geografia", "Geografia"));
            DropDownList4.Items.Add(new ListItem("Filosofia", "Filosofia"));
            DropDownList4.Items.Add(new ListItem("Sociologia", "Sociologia"));
        }
        else if (valor == "Pré-Vestibular")
        {
            DropDownList4.Items.Clear();
            DropDownList4.Items.Add(new ListItem("Selecione a matéria", "-1"));
            DropDownList4.Items.Add(new ListItem("Matemática", "Matemática"));
            DropDownList4.Items.Add(new ListItem("Português", "Português"));
            DropDownList4.Items.Add(new ListItem("Física", "Física"));
            DropDownList4.Items.Add(new ListItem("Química", "Química"));
            DropDownList4.Items.Add(new ListItem("Biologia", "Biologia"));
            DropDownList4.Items.Add(new ListItem("Inglês", "Inglês"));
            DropDownList4.Items.Add(new ListItem("História", "História"));
            DropDownList4.Items.Add(new ListItem("Geografia", "Geografia"));
            DropDownList4.Items.Add(new ListItem("Filosofia", "Filosofia"));
            DropDownList4.Items.Add(new ListItem("Sociologia", "Sociologia"));
        }
        else if (valor == "Ensino Técnico")
        {
            DropDownList4.Items.Clear();
            DropDownList4.Items.Add(new ListItem("Selecione o curso", "-1"));
            DropDownList4.Items.Add(new ListItem("Informática", "Informática"));
            DropDownList4.Items.Add(new ListItem("Administração", "Administração"));
            DropDownList4.Items.Add(new ListItem("Marketing", "Marketing"));
            DropDownList4.Items.Add(new ListItem("Eventos", "Eventos"));
            DropDownList4.Items.Add(new ListItem("Enfermagem", "Enfermagem"));
            DropDownList4.Items.Add(new ListItem("Meteorologia", "Meteorologia"));
            DropDownList4.Items.Add(new ListItem("Edificações", "Edificações"));
            DropDownList4.Items.Add(new ListItem("Alimentos", "Alimentos"));
            DropDownList4.Items.Add(new ListItem("Artes Visuais", "Artes Visuais"));
            DropDownList4.Items.Add(new ListItem("Biocombustíveis", "Biocombustíveis"));
            DropDownList4.Items.Add(new ListItem("Segurança do Trabalho", "Segurança do Trabalho"));
        }
        else if (valor == "Graduação")
        {
            DropDownList4.Items.Clear();
            DropDownList4.Items.Add(new ListItem("Selecione a matéria", "-1"));
            DropDownList4.Items.Add(new ListItem("Engenharias", "Engenharias"));
            DropDownList4.Items.Add(new ListItem("Medicina", "Medicina"));
            DropDownList4.Items.Add(new ListItem("Letras", "Letras"));
            DropDownList4.Items.Add(new ListItem("Direito", "Direito"));
            DropDownList4.Items.Add(new ListItem("Biologia", "Biologia"));
            DropDownList4.Items.Add(new ListItem("Ciências Sociais", "Ciências Sociais"));
            DropDownList4.Items.Add(new ListItem("Tecnologia da informação", "Tecnologia da informação"));
            DropDownList4.Items.Add(new ListItem("Economia", "Economia"));
            DropDownList4.Items.Add(new ListItem("Administração", "Administração"));
            DropDownList4.Items.Add(new ListItem("Arquitetura e urbanismo", "Arquitetura e urbanismo"));
            DropDownList4.Items.Add(new ListItem("Artes", "Artes"));
            DropDownList4.Items.Add(new ListItem("Matemática", "Matemática"));
            DropDownList4.Items.Add(new ListItem("Física", "Física"));
            DropDownList4.Items.Add(new ListItem("Química", "Química"));
            DropDownList4.Items.Add(new ListItem("Publicidade e marketing", "Publicidade e marketing"));
            DropDownList4.Items.Add(new ListItem("Turismo", "Turismo"));
        }


        return;
    }
}