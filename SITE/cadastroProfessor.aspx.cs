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

public partial class cadastroProfessor : System.Web.UI.Page
{
    StringBuilder dia = new StringBuilder();
    StringBuilder manha = new StringBuilder();
    StringBuilder tarde = new StringBuilder();
    StringBuilder noite = new StringBuilder();

    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StudifyConnectionString3"].ConnectionString);

    ////Passo1
    //string nome, sexo, contato1, contato2, cpf, diaNascimento, mesNascimento, anoNascimento, CEP, endereco, numero, complemento, bairro, estado, cidade;

    ////Passo2
    //string email, senha, formacao, segmento, tipoAula, horario, disciplina, localAula, valorAula, descricao;

    ////Passo3
    //string skype, facebook, linkedin, youtube;

    protected void Page_Load(object sender, EventArgs e)
    {
        txtEnsinoFundamental.Attributes["type"] = "hidden";
        txtEnsinoMedio.Attributes["type"] = "hidden";
        txtEnsinoTecnico.Attributes["type"] = "hidden";
        txtPreVestibular.Attributes["type"] = "hidden";
        txtGraduacao.Attributes["type"] = "hidden";

        ddlAnoNascimento.Items.Add("Ano*");
        for (int i = 2000; i >= 1920; i--)
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
            Response.Redirect("EditarPerfil.aspx");

        }
    }

    protected void btnLogar_Click(object sender, EventArgs e)
    {
        string strSQLBuscaLogin = "SELECT Id_Professor, Nome_Professor, Email_Professor,Senha_Professor FROM Tb_Professor WHERE Email_Professor='" + txtEmail.Text + "' and Senha_Professor='" + txtSenha.Text + "' UNION ALL SELECT Id_Aluno, Nome_Aluno, Email_Aluno,Senha_Aluno FROM Tb_Aluno WHERE Email_Aluno='" + txtEmail.Text + "' and Senha_Aluno='" + txtSenha.Text + "'";

        SqlCommand VerificaLogin = new SqlCommand(strSQLBuscaLogin, con);

        SqlDataReader DR;

        try
        {
            con.Open();
            DR = VerificaLogin.ExecuteReader();

            if (DR.Read())
            {
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

    protected void btnVideoCadastro_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
    }

    protected void btnInfoPessoalProf_Click(object sender, EventArgs e)
    {
        //nome = txtNomeCompleto.Text;
        //sexo = ddlSexo.SelectedItem.ToString();
        //contato1 = txtContato1.Text;
        //contato2 = txtContato2.Text;
        //cpf = txtCPF.Text;
        //diaNascimento = ddlDiaNascimento.SelectedItem.ToString();
        //mesNascimento = ddlMesNascimento.SelectedItem.ToString();
        //anoNascimento = ddlAnoNascimento.SelectedItem.ToString();
        //CEP = txtCEP.Text;
        //endereco = txtEndereco.Text;
        //numero = txtNumero.Text;
        //complemento = txtComplemento.Text;
        //bairro = txtBairro.Text;
        //estado = ddlEstado.SelectedItem.ToString();
        //cidade = txtCidade.Text;

        MultiView1.ActiveViewIndex = 2;
    }

    protected void btnInfoTecnico_Click(object sender, EventArgs e)
    {
        //email = txtEmailCadastro.Text;
        //senha = txtSenhaCadastro.Text;
        //formacao = txtFormacao.Text;
        //segmento = ddlSegmento.SelectedItem.ToString();
        //tipoAula = ddlTipoAula.SelectedItem.ToString();
        //horario = txtHorario.Text;
        //disciplina = txtDisciplina.Text;
        //localAula = ddlLocalAula.SelectedItem.ToString();
        //valorAula = txtValorAula.Text;
        //descricao = txtDescricao.Text;

        MultiView1.ActiveViewIndex = 3;
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

    protected void btnInfoSociais_Click(object sender, EventArgs e)
    {
        //skype = txtSkype.Text;
        //facebook = txtFacebook.Text;
        //linkedin = txtLinkedin.Text;
        //youtube = txtYoutube.Text;

        //criar objeto de conexao
        
        con.Open();
        string strSQLContaUsuario = "Select count(*) from Tb_Professor, Tb_Aluno where Tb_Professor.Email_Professor='" + txtEmailCadastro.Text + "' or Tb_Aluno.Email_Aluno='" + txtEmailCadastro.Text + "'";

        //criar o objeto que executa o comando SQL
        SqlCommand UsuarioExiste = new SqlCommand(strSQLContaUsuario, con);
        int total = Convert.ToInt32(UsuarioExiste.ExecuteScalar());

        txtSenhaCadastro.Attributes["value"] = txtSenhaCadastro.Text;

        if (total != 0)
        {
            Response.Write("<script>alert('Email já existente... Verifique o campo')</script>");
            MultiView1.ActiveViewIndex = 2;
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
                    lblMensagem.Text = "Só pode enviar arquivso png, jpg ou jpeg!!!";
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

                        if (rdbTermos.Checked == true)
                        {
                            string url = txtVideoApresentacao.Text;
                            string ytFormattedUrl = GetYouTubeID(url);
                            fileUploadImagem.SaveAs(Server.MapPath("/upload/professor/" + fileUploadImagem.FileName));
                            lblMensagem.Text = "Arquivo Enviado com Sucesso!!!";
                            lblMensagem.ForeColor = System.Drawing.Color.Green;

                            string strSQLInserirUsuario = "Insert into Tb_Professor (Nome_Professor, Foto_Professor, Video_Professor, Sexo_Professor, Email_Professor, Senha_Professor, Contato1_Professor, Contato2_Professor, CPF_Professor, DataNascimento_Professor, CEP_Professor, Endereco_Professor, NumeroEnd_Professor, ComplementoEnd_Professor, Bairro_Professor, Cidade_Professor, Estado_Professor, Segmento_Professor, Disciplina_Professor, Formacao_Professor, Valor_Aula_Professor, Descricao_Professor, Skype_Professor, Facebook_Professor, Linkedin_Professor, Youtube_Professor, Categoria) values (@Nome_Professor, @Foto_Professor, '" + ytFormattedUrl + "', @Sexo_Professor, @Email_Professor, @Senha_Professor, @Contato1_Professor, @Contato2_Professor, @CPF_Professor, @DataNascimento_Professor, @CEP_Professor, @Endereco_Professor, @NumeroEnd_Professor, @ComplementoEnd_Professor, @Bairro_Professor, @Cidade_Professor, @Estado_Professor, @Segmento_Professor, @Disciplina_Professor, @Formacao_Professor, @Valor_Aula_Professor, @Descricao_Professor, @Skype_Professor, @Facebook_Professor, @Linkedin_Professor, @Youtube_Professor, 1)";
                            SqlCommand inserirUsuario = new SqlCommand(strSQLInserirUsuario, con);
                            inserirUsuario.Parameters.AddWithValue("@Nome_Professor", txtNomeCompleto.Text);
                            string caminho = "upload/professor/" + fileUploadImagem.FileName;
                            inserirUsuario.Parameters.AddWithValue("@Foto_Professor", caminho);
                            inserirUsuario.Parameters.AddWithValue("@Sexo_Professor", ddlSexo.SelectedItem.ToString());
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
                            inserirUsuario.Parameters.AddWithValue("@Segmento_Professor", ddlSegmento.SelectedItem.ToString());
                            inserirUsuario.Parameters.AddWithValue("@Disciplina_Professor", txtDisciplina.Text);
                            inserirUsuario.Parameters.AddWithValue("@Formacao_Professor", txtQualificacao.Text);
                            inserirUsuario.Parameters.AddWithValue("@Valor_Aula_Professor", Convert.ToDecimal(txtValorAula.Text));
                            inserirUsuario.Parameters.AddWithValue("@Descricao_Professor", txtDescricao.Text);
                            inserirUsuario.Parameters.AddWithValue("@Skype_Professor", txtSkype.Text);
                            inserirUsuario.Parameters.AddWithValue("@Facebook_Professor", txtFacebook.Text);
                            inserirUsuario.Parameters.AddWithValue("@Linkedin_Professor", txtLinkedin.Text);
                            inserirUsuario.Parameters.AddWithValue("@Youtube_Professor", txtCanalYoutube.Text);



                            try
                            {
                                inserirUsuario.ExecuteNonQuery();
                                con.Close();
                                con.Open();
                                string StrId = "Select Id_Professor from Tb_Professor order by Id_Professor desc";
                                SqlCommand verificaId = new SqlCommand(StrId, con);
                                int id = Convert.ToInt32(verificaId.ExecuteScalar());

                                if (id >= 1)
                                {
                                    id = Convert.ToInt32(verificaId.ExecuteScalar());
                                }


                                con.Close();
                                con.Open();
                                string StrCadastra = "Insert into Agenda (Id_Professor, Dia, Manha, Tarde, Noite) values (@Id_Professor, @Dia, @Manha, @Tarde, @Noite)";
                                foreach (ListItem item in chbDias.Items)
                                {
                                    if (item.Selected)
                                    {
                                        dia.Append(item.Text + ", ");
                                    }
                                }

                                foreach (ListItem item in chbManha.Items)
                                {
                                    if (item.Selected)
                                    {
                                        manha.Append(item.Text + ", ");
                                    }
                                }

                                foreach (ListItem item in chbTarde.Items)
                                {
                                    if (item.Selected)
                                    {
                                        tarde.Append(item.Text + ", ");
                                    }
                                }

                                foreach (ListItem item in chbNoite.Items)
                                {
                                    if (item.Selected)
                                    {
                                        noite.Append(item.Text + ", ");
                                    }
                                }

                                SqlCommand Cadastra = new SqlCommand(StrCadastra, con);
                                Cadastra.Parameters.AddWithValue("@Id_Professor", id);
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
                                catch (Exception ex)
                                {
                                    Response.Write("<script>alert('ERRO...tente novamente')</script>");
                                }
                                Response.Write("<script>alert('Cadastro realizado com sucesso!')</script>");
                                //txtSkype.Text = dia.ToString() + horario.ToString();
                                Response.Redirect("login.aspx");

                            }
                            catch (Exception ex)
                            {
                                Response.Write("<script>alert('ERRO...tente novamente')</script>");
                                txtSkype.Text = ex.ToString();
                                //txtSkype.Text = dia.ToString() + horario.ToString();
                            }
                        }
                        else
                        {
                            Response.Write("<script>alert('Favor aceitar a nossa política de segurança para cadastrar.')</script>");
                        }
                    }
                }
            }
            else
            {
                if (rdbTermos.Checked == true)
                {
                    string url = txtVideoApresentacao.Text;
                    string ytFormattedUrl = GetYouTubeID(url);
                    string strSQLInserirUsuario = "Insert into Tb_Professor (Nome_Professor, Video_Professor, Sexo_Professor, Email_Professor, Senha_Professor, Contato1_Professor, Contato2_Professor, CPF_Professor, DataNascimento_Professor, CEP_Professor, Endereco_Professor, NumeroEnd_Professor, ComplementoEnd_Professor, Bairro_Professor, Cidade_Professor, Estado_Professor, Segmento_Professor, Disciplina_Professor, Formacao_Professor, Valor_Aula_Professor, Descricao_Professor, Skype_Professor, Facebook_Professor, Linkedin_Professor, Youtube_Professor, Categoria) values (@Nome_Professor,'" + ytFormattedUrl + "', @Sexo_Professor, @Email_Professor, @Senha_Professor, @Contato1_Professor, @Contato2_Professor, @CPF_Professor, @DataNascimento_Professor, @CEP_Professor, @Endereco_Professor, @NumeroEnd_Professor, @ComplementoEnd_Professor, @Bairro_Professor, @Cidade_Professor, @Estado_Professor, @Segmento_Professor, @Disciplina_Professor, @Formacao_Professor, @Valor_Aula_Professor, @Descricao_Professor, @Skype_Professor, @Facebook_Professor, @Linkedin_Professor, @Youtube_Professor, 1)";
                    SqlCommand inserirUsuario = new SqlCommand(strSQLInserirUsuario, con);
                    inserirUsuario.Parameters.AddWithValue("@Nome_Professor", txtNomeCompleto.Text);
                    inserirUsuario.Parameters.AddWithValue("@Sexo_Professor", ddlSexo.SelectedItem.ToString());
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
                    inserirUsuario.Parameters.AddWithValue("@Segmento_Professor", ddlSegmento.SelectedItem.ToString());
                    inserirUsuario.Parameters.AddWithValue("@Disciplina_Professor", txtDisciplina.Text);
                    inserirUsuario.Parameters.AddWithValue("@Formacao_Professor", txtQualificacao.Text);
                    inserirUsuario.Parameters.AddWithValue("@Valor_Aula_Professor", Convert.ToDecimal(txtValorAula.Text));
                    inserirUsuario.Parameters.AddWithValue("@Descricao_Professor", txtDescricao.Text);
                    inserirUsuario.Parameters.AddWithValue("@Skype_Professor", txtSkype.Text);
                    inserirUsuario.Parameters.AddWithValue("@Facebook_Professor", txtFacebook.Text);
                    inserirUsuario.Parameters.AddWithValue("@Linkedin_Professor", txtLinkedin.Text);
                    inserirUsuario.Parameters.AddWithValue("@Youtube_Professor", txtCanalYoutube.Text);



                    try
                    {
                        inserirUsuario.ExecuteNonQuery();
                        con.Close();
                        con.Open();
                        string StrId = "Select Id_Professor from Tb_Professor order by Id_Professor desc";
                        SqlCommand verificaId = new SqlCommand(StrId, con);
                        int id = Convert.ToInt32(verificaId.ExecuteScalar());
                        txtSkype.Text = id.ToString();
                        if (id >= 1)
                        {
                            id = Convert.ToInt32(verificaId.ExecuteScalar());
                        }


                        con.Close();
                        con.Open();
                        string StrCadastra = "Insert into Agenda (Id_Professor, Dia, Manha, Tarde, Noite) values (@Id_Professor, @Dia, @Manha, @Tarde, @Noite)";
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
                        Cadastra.Parameters.AddWithValue("@Id_Professor", id);
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
                        Response.Write("<script>alert('Cadastro realizado com sucesso!')</script>");
                        //txtSkype.Text = dia.ToString() + horario.ToString();
                        Response.Redirect("login.aspx");

                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script>alert('ERRO...tente novamente')</script>");
                        txtSkype.Text = ex.ToString();
                        //txtSkype.Text = dia.ToString() + horario.ToString();
                    }
                }
                else
                {
                    Response.Write("<script>alert('Favor aceitar a nossa política de segurança para cadastrar.')</script>");
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
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StudifyConnectionString3"].ConnectionString);
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

    protected void btnAgenda_Click(object sender, EventArgs e)
    {
        

        

        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StudifyConnectionString3"].ConnectionString);
        //con.Open();

        

        //txtSkype.Text = dia.ToString() + horario.ToString();

        MultiView1.ActiveViewIndex = 4;
    }

    //protected void btnPreencherProf1_Click(object sender, EventArgs e)
    //{
    //    txtNomeCompleto.Text = "Martim Santos";
    //    ddlSexo.SelectedIndex = 1;
    //    txtContato1.Text = "(11) 99599-5283";
    //    txtContato2.Text = "(11) 97541-4865";
    //    txtCPF.Text = "413.970.403-94";
    //    ddlDiaNascimento.SelectedIndex = 7;
    //    ddlMesNascimento.SelectedIndex = 5;
    //    ddlAnoNascimento.SelectedIndex = 12;
    //    txtCEP.Text = "08121-001";
    //    txtEndereco.Text = "Rua Antônio de Souza Amorim";
    //    txtNumero.Text = "1122";
    //    txtBairro.Text = "Jardim São Luís (Zona Leste)";
    //    ddlEstado.SelectedValue = "SP";
    //    txtCidade.Text = "São Paulo";
    //    txtEmailCadastro.Text = "martim@gmail.com";
    //    txtValorAula.Text = "100,00";
    //    txtSenhaCadastro.Text = "123";
    //    txtConfirmarSenha.Text = "123";
    //    txtQualificacao.Text = "Sou formado em física pela USP; Pós-graduação em astrofísica, também pela USP; Licenciatura em física.";
    //    txtDescricao.Text = "Adoro dar aula, sou muito bom com crianças e adolescentes. Tenho uma didática diferenciada, utilizo livros certificados pelo inep, explico a matéria de uma forma dinâmica, onde uso o material didático junto com conteúdos da internet. Dou aula a 5 anos e ministrei aula em grades escolas de São Paulo, como o COPI, Objetivo e Etapa.";
    //    ddlSegmento.SelectedItem.Text = "Ensino Médio";
    //    txtDisciplina.Text = "Física";

    //    txtSkype.Text = "martin-santos";
    //    txtVideoApresentacao.Text = "https://www.youtube.com/watch?v=9l6zsGh1Nto";


    //}
}