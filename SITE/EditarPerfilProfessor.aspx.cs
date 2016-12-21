using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data; //classe Data vai gerenciar suas opções para banco de dados
using System.Text.RegularExpressions;
using System.Text;

public partial class EditarPerfil : System.Web.UI.Page
{
    StringBuilder dia = new StringBuilder();
    StringBuilder manha = new StringBuilder();
    StringBuilder tarde = new StringBuilder();
    StringBuilder noite = new StringBuilder();

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

    protected void Page_LoadComplete(object sender, EventArgs e)
    {
        if (Session["idLogin"]==null)
        {
            Response.Redirect("index.aspx");
        }
        else { 
        string insereProf = "select * from Tb_Professor where Id_Professor=" + Session["idLogin"];
        SqlCommand cmd = new SqlCommand(insereProf, con);
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
                txtVideoApresentacao.Text = DR.GetValue(3).ToString();
                ddlSexo.SelectedItem.Text = DR.GetValue(4).ToString();
                txtEmailCadastro.Text = DR.GetValue(5).ToString();
                txtSenhaCadastro.Text = DR.GetValue(6).ToString();
                txtConfirmarSenha.Text = DR.GetValue(6).ToString();
                txtContato1.Text = DR.GetValue(7).ToString();
                txtContato2.Text = DR.GetValue(8).ToString();
                txtCPF.Text = DR.GetValue(9).ToString().Replace(".", "").Replace("-", "");
                DateTime dt = Convert.ToDateTime(DR.GetValue(10).ToString());
                ddlDiaNascimento.SelectedItem.Text = dt.Day.ToString();
                ddlMesNascimento.SelectedValue = "0" + dt.Month.ToString();
                ddlAnoNascimento.SelectedItem.Text = dt.Year.ToString();
                txtCEP.Text = DR.GetValue(11).ToString().Replace("-", "");
                txtEndereco.Text = DR.GetValue(12).ToString();
                txtNumero.Text = DR.GetValue(13).ToString();
                txtComplemento.Text = DR.GetValue(14).ToString();
                txtBairro.Text = DR.GetValue(15).ToString();
                txtCidade.Text = DR.GetValue(16).ToString();
                ddlEstado.SelectedValue = DR.GetValue(17).ToString();
                ddlSegmento.SelectedItem.Text = DR.GetValue(18).ToString();
                txtDisciplina.Text = DR.GetValue(19).ToString();
                //Horario
                txtQualificacao.Text = DR.GetValue(21).ToString();
                txtValorAula.Text = DR.GetValue(22).ToString();
                txtDescricao.Text = DR.GetValue(23).ToString();
                //Avaliaçao
                txtSkype.Text = DR.GetValue(25).ToString();
                txtFacebook.Text = DR.GetValue(26).ToString();
                txtLinkedin.Text = DR.GetValue(27).ToString();
                txtCanalYoutube.Text = DR.GetValue(28).ToString();
                DR.Close();
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
        
        string insereAgenda = "select * from Agenda where Id_Professor=" + Session["idLogin"];
        SqlCommand cmdAgenda = new SqlCommand(insereAgenda, con);

        try
        {
            con.Open();
            DR = cmdAgenda.ExecuteReader();

            if (DR.Read())
            {
                string dias = DR.GetValue(2).ToString();

                for (int i = 0; i < chbDias.Items.Count; i++)
                {
                    if (dias.IndexOf(chbDias.Items[i].ToString()) != -1)
                    {
                        chbDias.Items[i].Selected = true;
                    }
                    else
                    {
                        chbDias.Items[i].Selected = false;
                    }

                }

                string manha = DR.GetValue(3).ToString();

                for (int i = 0; i < chbManha.Items.Count; i++)
                {
                    if (manha.IndexOf(chbManha.Items[i].ToString()) != -1)
                    {
                        chbManha.Items[i].Selected = true;
                    }
                    else
                    {
                        chbManha.Items[i].Selected = false;
                    }

                }

                string tarde = DR.GetValue(4).ToString();

                for (int i = 0; i < chbTarde.Items.Count; i++)
                {
                    if (tarde.IndexOf(chbTarde.Items[i].ToString()) != -1)
                    {
                        chbTarde.Items[i].Selected = true;
                    }
                    else
                    {
                        chbTarde.Items[i].Selected = false;
                    }

                }

                string noite = DR.GetValue(5).ToString();

                for (int i = 0; i < chbNoite.Items.Count; i++)
                {
                    if (noite.IndexOf(chbNoite.Items[i].ToString()) != -1)
                    {
                        chbNoite.Items[i].Selected = true;
                    }
                    else
                    {
                        chbNoite.Items[i].Selected = false;
                    }

                }

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

    private string GetYouTubeID(string youTubeUrl)
    {
        //RegEx to Find YouTube ID
        Match regexMatch = Regex.Match(youTubeUrl, "^[^v]+v=(.{11}).*",
                           RegexOptions.IgnoreCase);
        if (regexMatch.Success)
        {
            return "http://www.youtube.com/v/" + regexMatch.Groups[1].Value +
                   "&hl=en&fs=1";
        }
        return youTubeUrl;
    }

    public bool CheckDuplicate(string youTubeUrl)
    {
        bool exists = false;
        SqlCommand cmd = new SqlCommand(String.Format("select * from YouTubeVideos where url='{0}'", youTubeUrl), con);

        using (con)
        {
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            exists = (dr.HasRows) ? true : false;
        }

        return exists;
    }

    protected void btnFinalizar_Click(object sender, EventArgs e)
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
                    string url = txtVideoApresentacao.Text;
                    string ytFormattedUrl = GetYouTubeID(url);
                    fileUploadImagem.SaveAs(Server.MapPath("/upload/professor/" + fileUploadImagem.FileName));
                    lblMensagem.Text = "Arquivo Enviado com Sucesso!!!";
                    lblMensagem.ForeColor = System.Drawing.Color.Green;
                    string atualizaSQL = "update Tb_Professor set Nome_Professor = @Nome_Professor, Foto_Professor = @Foto_Professor, Video_Professor = @Video_Professor, Sexo_Professor = @Sexo_Professor, Email_Professor = @Email_Professor, Contato1_Professor = @Contato1_Professor, Contato2_Professor = @Contato2_Professor, CPF_Professor = @CPF_Professor, DataNascimento_Professor = @DataNascimento_Professor, CEP_Professor = @CEP_Professor, Endereco_Professor = @Endereco_Professor, NumeroEnd_Professor = @NumeroEnd_Professor, ComplementoEnd_Professor = @ComplementoEnd_Professor, Bairro_Professor = @Bairro_Professor, Cidade_Professor = @Cidade_Professor, Estado_Professor = @Estado_Professor, Segmento_Professor = @Segmento_Professor, Disciplina_Professor = @Disciplina_Professor, Formacao_Professor = @Formacao_Professor, Valor_Aula_Professor = @Valor_Aula_Professor, Descricao_Professor = @Descricao_Professor, Skype_Professor = @Skype_Professor, Facebook_Professor = @Facebook_Professor, Linkedin_Professor = @Linkedin_Professor, Youtube_Professor = @Youtube_Professor where Id_Professor = " + Session["idLogin"];

                    SqlCommand inserirUsuario = new SqlCommand(atualizaSQL, con);
                    inserirUsuario.Parameters.AddWithValue("@Nome_Professor", txtNomeCompleto.Text);
                    string caminho = "upload/professor/" + fileUploadImagem.FileName;
                    inserirUsuario.Parameters.AddWithValue("@Foto_Professor", caminho);
                    inserirUsuario.Parameters.AddWithValue("@Video_Professor", ytFormattedUrl);
                    inserirUsuario.Parameters.AddWithValue("@Sexo_Professor", ddlSexo.SelectedItem.Text.ToString());
                    inserirUsuario.Parameters.AddWithValue("@Email_Professor", txtEmailCadastro.Text);
                    inserirUsuario.Parameters.AddWithValue("@Senha_Professor", txtSenhaCadastro.Text);
                    inserirUsuario.Parameters.AddWithValue("@Contato1_Professor", txtContato1.Text);
                    inserirUsuario.Parameters.AddWithValue("@Contato2_Professor", txtContato2.Text);
                    inserirUsuario.Parameters.AddWithValue("@CPF_Professor", txtCPF.Text);
                    inserirUsuario.Parameters.AddWithValue("@DataNascimento_Professor", ddlDiaNascimento.SelectedItem.ToString() + "/" + ddlMesNascimento.SelectedValue.ToString() + "/" + ddlAnoNascimento.SelectedItem.ToString());
                    inserirUsuario.Parameters.AddWithValue("@CEP_Professor", txtCEP.Text);
                    inserirUsuario.Parameters.AddWithValue("@Endereco_Professor", txtEndereco.Text);
                    inserirUsuario.Parameters.AddWithValue("@NumeroEnd_Professor", txtNumero.Text);
                    inserirUsuario.Parameters.AddWithValue("@ComplementoEnd_Professor", txtComplemento.Text);
                    inserirUsuario.Parameters.AddWithValue("@Bairro_Professor", txtBairro.Text);
                    inserirUsuario.Parameters.AddWithValue("@Cidade_Professor", txtCidade.Text);
                    inserirUsuario.Parameters.AddWithValue("@Estado_Professor", ddlEstado.SelectedValue);
                    inserirUsuario.Parameters.AddWithValue("@Segmento_Professor", ddlSegmento.SelectedItem.Text.ToString());
                    inserirUsuario.Parameters.AddWithValue("@Disciplina_Professor", txtDisciplina.Text);
                    inserirUsuario.Parameters.AddWithValue("@Formacao_Professor", txtQualificacao.Text);
                    inserirUsuario.Parameters.AddWithValue("@Valor_Aula_Professor", txtValorAula.Text.Replace(",", "."));
                    inserirUsuario.Parameters.AddWithValue("@Descricao_Professor", txtDescricao.Text);
                    inserirUsuario.Parameters.AddWithValue("@Skype_Professor", txtSkype.Text);
                    inserirUsuario.Parameters.AddWithValue("@Facebook_Professor", txtFacebook.Text);
                    inserirUsuario.Parameters.AddWithValue("@Linkedin_Professor", txtLinkedin.Text);
                    inserirUsuario.Parameters.AddWithValue("@Youtube_Professor", txtCanalYoutube.Text);

                    try
                    {
                        con.Open();


                        int resultado = inserirUsuario.ExecuteNonQuery();
                        if (resultado == 1)
                        {
                            
                            
                            string StrCadastra = "update Agenda set Dia = @Dia, Manha = @Manha, Tarde = @Tarde, Noite = @Noite where Id_Professor = "+ Session["idLogin"];
                            foreach (ListItem item in chbDias.Items)
                            {
                                if (item.Selected)
                                {
                                    dia.Append(" " + item.Text);
                                }
                            }

                            foreach (ListItem item in chbManha.Items)
                            {
                                if (item.Selected)
                                {
                                    manha.Append(" " + item.Text);
                                }
                            }

                            foreach (ListItem item in chbTarde.Items)
                            {
                                if (item.Selected)
                                {
                                    tarde.Append(" " + item.Text);
                                }
                            }

                            foreach (ListItem item in chbNoite.Items)
                            {
                                if (item.Selected)
                                {
                                    noite.Append(" " + item.Text);
                                }
                            }

                            SqlCommand Cadastra = new SqlCommand(StrCadastra, con);
                            Cadastra.Parameters.AddWithValue("@Dia", dia.ToString());
                            Cadastra.Parameters.AddWithValue("@Manha", manha.ToString());
                            Cadastra.Parameters.AddWithValue("@Tarde", tarde.ToString());
                            Cadastra.Parameters.AddWithValue("@Noite", noite.ToString());
                            try
                            {
                                Cadastra.ExecuteNonQuery();
                                con.Close();

                                //Response.Redirect("login.aspx");            
                                chbDias.ClearSelection();
                                chbManha.ClearSelection();
                                chbTarde.ClearSelection();
                                chbNoite.ClearSelection();
                            }
                            catch (Exception)
                            {
                                Response.Write("<script>alert('ERRO...tente novamente')</script>");
                            }

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
            string url = txtVideoApresentacao.Text;
            string ytFormattedUrl = GetYouTubeID(url);
            string atualizaSQL = "update Tb_Professor set Nome_Professor = @Nome_Professor, Video_Professor = @Video_Professor, Sexo_Professor = @Sexo_Professor, Email_Professor = @Email_Professor, Contato1_Professor = @Contato1_Professor, Contato2_Professor = @Contato2_Professor, CPF_Professor = @CPF_Professor, DataNascimento_Professor = @DataNascimento_Professor, CEP_Professor = @CEP_Professor, Endereco_Professor = @Endereco_Professor, NumeroEnd_Professor = @NumeroEnd_Professor, ComplementoEnd_Professor = @ComplementoEnd_Professor, Bairro_Professor = @Bairro_Professor, Cidade_Professor = @Cidade_Professor, Estado_Professor = @Estado_Professor, Segmento_Professor = @Segmento_Professor, Disciplina_Professor = @Disciplina_Professor, Formacao_Professor = @Formacao_Professor, Valor_Aula_Professor = @Valor_Aula_Professor, Descricao_Professor = @Descricao_Professor, Skype_Professor = @Skype_Professor, Facebook_Professor = @Facebook_Professor, Linkedin_Professor = @Linkedin_Professor, Youtube_Professor = @Youtube_Professor where Id_Professor = " + Session["idLogin"];

            SqlCommand inserirUsuario = new SqlCommand(atualizaSQL, con);
            inserirUsuario.Parameters.AddWithValue("@Nome_Professor", txtNomeCompleto.Text);
            inserirUsuario.Parameters.AddWithValue("@Video_Professor", ytFormattedUrl);
            inserirUsuario.Parameters.AddWithValue("@Sexo_Professor", ddlSexo.SelectedItem.Text.ToString());
            inserirUsuario.Parameters.AddWithValue("@Email_Professor", txtEmailCadastro.Text);
            inserirUsuario.Parameters.AddWithValue("@Senha_Professor", txtSenhaCadastro.Text);
            inserirUsuario.Parameters.AddWithValue("@Contato1_Professor", txtContato1.Text);
            inserirUsuario.Parameters.AddWithValue("@Contato2_Professor", txtContato2.Text);
            inserirUsuario.Parameters.AddWithValue("@CPF_Professor", txtCPF.Text);
            inserirUsuario.Parameters.AddWithValue("@DataNascimento_Professor", ddlDiaNascimento.SelectedItem.ToString() + "/" + ddlMesNascimento.SelectedValue.ToString() + "/" + ddlAnoNascimento.SelectedItem.ToString());
            inserirUsuario.Parameters.AddWithValue("@CEP_Professor", txtCEP.Text);
            inserirUsuario.Parameters.AddWithValue("@Endereco_Professor", txtEndereco.Text);
            inserirUsuario.Parameters.AddWithValue("@NumeroEnd_Professor", txtNumero.Text);
            inserirUsuario.Parameters.AddWithValue("@ComplementoEnd_Professor", txtComplemento.Text);
            inserirUsuario.Parameters.AddWithValue("@Bairro_Professor", txtBairro.Text);
            inserirUsuario.Parameters.AddWithValue("@Cidade_Professor", txtCidade.Text);
            inserirUsuario.Parameters.AddWithValue("@Estado_Professor", ddlEstado.SelectedValue);
            inserirUsuario.Parameters.AddWithValue("@Segmento_Professor", ddlSegmento.SelectedItem.Text.ToString());
            inserirUsuario.Parameters.AddWithValue("@Disciplina_Professor", txtDisciplina.Text);
            inserirUsuario.Parameters.AddWithValue("@Formacao_Professor", txtQualificacao.Text);
            inserirUsuario.Parameters.AddWithValue("@Valor_Aula_Professor", txtValorAula.Text.Replace(",", "."));
            inserirUsuario.Parameters.AddWithValue("@Descricao_Professor", txtDescricao.Text);
            inserirUsuario.Parameters.AddWithValue("@Skype_Professor", txtSkype.Text);
            inserirUsuario.Parameters.AddWithValue("@Facebook_Professor", txtFacebook.Text);
            inserirUsuario.Parameters.AddWithValue("@Linkedin_Professor", txtLinkedin.Text);
            inserirUsuario.Parameters.AddWithValue("@Youtube_Professor", txtCanalYoutube.Text);

            try
            {
                con.Open();


                int resultado = inserirUsuario.ExecuteNonQuery();
                if (resultado == 1)
                {
                    string StrCadastra = "update Agenda set Dia = @Dia, Manha = @Manha, Tarde = @Tarde, Noite = @Noite where Id_Professor = " + Session["idLogin"];
                    foreach (ListItem item in chbDias.Items)
                    {
                        if (item.Selected)
                        {
                            dia.Append(" " + item.Text);
                        }
                    }

                    foreach (ListItem item in chbManha.Items)
                    {
                        if (item.Selected)
                        {
                            manha.Append(" " + item.Text);
                        }
                    }

                    foreach (ListItem item in chbTarde.Items)
                    {
                        if (item.Selected)
                        {
                            tarde.Append(" " + item.Text);
                        }
                    }

                    foreach (ListItem item in chbNoite.Items)
                    {
                        if (item.Selected)
                        {
                            noite.Append(" " + item.Text);
                        }
                    }

                    SqlCommand Cadastra = new SqlCommand(StrCadastra, con);
                    Cadastra.Parameters.AddWithValue("@Dia", dia.ToString());
                    Cadastra.Parameters.AddWithValue("@Manha", manha.ToString());
                    Cadastra.Parameters.AddWithValue("@Tarde", tarde.ToString());
                    Cadastra.Parameters.AddWithValue("@Noite", noite.ToString());
                    try
                    {
                        Cadastra.ExecuteNonQuery();
                        con.Close();

                        //Response.Redirect("login.aspx");            
                        chbDias.ClearSelection();
                        chbManha.ClearSelection();
                        chbTarde.ClearSelection();
                        chbNoite.ClearSelection();
                    }
                    catch (Exception)
                    {
                        Response.Write("<script>alert('ERRO...tente novamente')</script>");
                    }
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