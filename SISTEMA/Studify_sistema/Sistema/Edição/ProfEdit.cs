using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Data.SqlClient;

namespace Sistema
{
    public partial class ProfEdit : Form
    {
        int x, y;
        Point Point = new Point();

        StringBuilder dia = new StringBuilder();
        StringBuilder manha = new StringBuilder();
        StringBuilder tarde = new StringBuilder();
        StringBuilder noite = new StringBuilder();


        public string diretorio, arquivo, caminhoBanco = null;
        public bool valCPF = false;
        public bool preenche;
        public string url;
        public string ytFormattedUrl;
        SqlConnection con = new SqlConnection(FrmLogin.strCn);
        public ProfEdit()
        {
            InitializeComponent();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (btnAction.Text == "ADICIONAR")
            {
                url = txtVideoApresentacao.Text;
                ytFormattedUrl = GetYouTubeID(url);
                string adicionaSQL = "insert into Tb_Professor(Nome_Professor, Foto_Professor, Video_Professor, Sexo_Professor, Email_Professor, Senha_Professor, Contato1_Professor, Contato2_Professor, CPF_Professor, DataNascimento_Professor, CEP_Professor, Endereco_Professor, NumeroEnd_Professor, ComplementoEnd_Professor, Bairro_Professor, Cidade_Professor, Estado_Professor, Segmento_Professor, Disciplina_Professor, Formacao_Professor, Valor_Aula_Professor, Descricao_Professor, Skype_Professor, Facebook_Professor, Linkedin_Professor, Youtube_Professor, Categoria) values('" + txtNome.Text + "','" + caminhoBanco + "','" + ytFormattedUrl + "','" + cbSexo.Text + "','" + txtEmail.Text + "','" + txtSenha.Text + "','" + txtContato1.Text + "','" + txtContato2.Text + "','" + txtCPF.Text + "','" + txtData.Text + "','" + txtCEP.Text + "','" + txtEndereco.Text + "','" + txtNum.Text + "','" + txtComp.Text + "','" + txtBairro.Text + "','" + txtCidade.Text + "','" + txtEstado.Text + "','" + cbSegmento.Text + "','" + cbMateria.Text + "','" + txtFormacao.Text + "','" + txtValor.Text + "','" + txtDescricao.Text + "','" + txtSkp.Text + "','" + txtFace.Text + "','" + txtLink.Text + "','" + txtYout.Text + "', 1)";
                SqlCommand cmd = new SqlCommand(adicionaSQL, con);
                try
                {
                    if (txtNome.Text != "" || txtEmail.Text != "" || txtSenha.Text != "" || txtContato1.Text != "" || txtCPF.Text != "" || txtData.Text != "" || txtCEP.Text != "" || txtEndereco.Text != "" || txtNum.Text != "" || txtBairro.Text != "" || txtCidade.Text != "" || txtEstado.Text != "" || cbMateria.SelectedIndex != 0 || txtFormacao.Text != "" || txtValor.Text != "")
                    {
                        VerificaCampos();
                        VerificaCampos2();
                        if (preenche == true)
                        {
                            ValidaCPF();
                            if (valCPF == true)
                            {
                                con.Open();
                                int resultado = cmd.ExecuteNonQuery();
                                con.Close();
                                if (resultado == 1)
                                {


                                    string StrId = "Select Id_Professor from Tb_Professor order by Id_Professor desc";
                                    SqlCommand verificaId = new SqlCommand(StrId, con);
                                    con.Open();
                                    int id = Convert.ToInt32(verificaId.ExecuteScalar());

                                    if (id >= 1)
                                    {
                                        id = Convert.ToInt32(verificaId.ExecuteScalar());
                                    }


                                    con.Close();
                                    for (int i = 0; i < cbDias.Items.Count; i++)
                                    {
                                        if (cbDias.GetItemChecked(i))
                                        {
                                            string str = (string)cbDias.Items[i];
                                            dia.Append(" " + str);
                                        }
                                    }

                                    for (int i = 0; i < cbManha.Items.Count; i++)
                                    {
                                        if (cbManha.GetItemChecked(i))
                                        {
                                            string str = (string)cbManha.Items[i];
                                            manha.Append(" " + str);
                                        }
                                    }

                                    for (int i = 0; i < cbTarde.Items.Count; i++)
                                    {
                                        if (cbTarde.GetItemChecked(i))
                                        {
                                            string str = (string)cbTarde.Items[i];
                                            tarde.Append(" " + str);
                                        }
                                    }

                                    for (int i = 0; i < cbNoite.Items.Count; i++)
                                    {
                                        if (cbNoite.GetItemChecked(i))
                                        {
                                            string str = (string)cbNoite.Items[i];
                                            noite.Append(" " + str);
                                        }
                                    }

                                    string StrCadastra = "Insert into Agenda (Id_Professor, Dia, Manha, Tarde, Noite) values (" + id + ", '" + dia + "', '" + manha + "', '" + tarde + "', '" + noite + "')";


                                    SqlCommand Cadastra = new SqlCommand(StrCadastra, con);


                                    con.Open();
                                    Cadastra.ExecuteNonQuery();
                                    con.Close();
                                    if (diretorio == null || arquivo == null)
                                    {
                                        Clipboard.SetText(adicionaSQL + Environment.NewLine + StrCadastra);
                                        MessageBox.Show("Adicionado");
                                        this.Close();
                                    }
                                    else
                                    {
                                        System.IO.File.Copy(diretorio, @"..\..\..\..\..\SITE\upload\professor\" + arquivo, true);
                                        Clipboard.SetText(adicionaSQL + Environment.NewLine + StrCadastra);
                                        MessageBox.Show("Adicionado");
                                        this.Close();

                                    }
                                }
                            }
                            else
                            {
                                //tabControl1.SelectedTab = info1;
                                lblCPF.Visible = true;
                                lblCPF.Text = "CPF inválido";
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
                url = txtVideoApresentacao.Text;
                ytFormattedUrl = GetYouTubeID(url);
                string atualizaSQL = "update Tb_Professor set Nome_Professor='" + txtNome.Text + "', Foto_Professor='" + caminhoBanco + "', Video_Professor='" + ytFormattedUrl + "', Sexo_Professor='" + cbSexo.Text + "', Email_Professor='" + txtEmail.Text + "', Senha_Professor='" + txtSenha.Text + "', Contato1_Professor='" + txtContato1.Text + "', Contato2_Professor='" + txtContato2.Text + "', CPF_Professor='" + txtCPF.Text + "', DataNascimento_Professor='" + txtData.Text + "', CEP_Professor='" + txtCEP.Text + "', Endereco_Professor='" + txtEndereco.Text + "', NumeroEnd_Professor='" + txtNum.Text + "', ComplementoEnd_Professor='" + txtComp.Text + "', Bairro_Professor='" + txtBairro.Text + "', Cidade_Professor='" + txtCidade.Text + "', Estado_Professor='" + txtEstado.Text + "', Segmento_Professor='" + cbSegmento.Text + "', Disciplina_Professor='" + cbMateria.Text + "', Formacao_Professor='" + txtFormacao.Text + "', Valor_Aula_Professor='" + txtValor.Text.Replace(",", ".") + "', Descricao_Professor='" + txtDescricao.Text + "', Skype_Professor='" + txtSkp.Text + "', Facebook_Professor='" + txtFace.Text + "', Linkedin_Professor='" + txtLink.Text + "', Youtube_Professor='" + txtYout.Text + "' where Id_Professor= " + lblID.Text;
                SqlCommand cmd = new SqlCommand(atualizaSQL, con);
                try
                {
                    VerificaCampos();
                    VerificaCampos2();
                    if (txtNome.Text != "" || txtEmail.Text != "" || txtSenha.Text != "" || txtContato1.Text != "" || txtCPF.Text != "" || txtData.Text != "" || txtCEP.Text != "" || txtEndereco.Text != "" || txtNum.Text != "" || txtBairro.Text != "" || txtCidade.Text != "" || txtEstado.Text != "" || cbMateria.SelectedIndex != 0 || txtFormacao.Text != "" || txtValor.Text != "")
                    {
                        VerificaCampos();
                        VerificaCampos2();
                        ValidaCPF();
                        if (valCPF == true)
                        {
                            con.Open();
                            int resultado = cmd.ExecuteNonQuery();
                            if (resultado == 1)
                            {

                                string StrCadastra = "update Agenda set Dia = @Dia, Manha = @Manha, Tarde = @Tarde, Noite = @Noite where Id_Professor = " + lblID.Text;
                                for (int i = 0; i < cbDias.Items.Count; i++)
                                {
                                    if (cbDias.GetItemChecked(i))
                                    {
                                        string str = (string)cbDias.Items[i];
                                        dia.Append(" " + str);
                                    }
                                }

                                for (int i = 0; i < cbManha.Items.Count; i++)
                                {
                                    if (cbManha.GetItemChecked(i))
                                    {
                                        string str = (string)cbManha.Items[i];
                                        manha.Append(" " + str);
                                    }
                                }

                                for (int i = 0; i < cbTarde.Items.Count; i++)
                                {
                                    if (cbTarde.GetItemChecked(i))
                                    {
                                        string str = (string)cbTarde.Items[i];
                                        tarde.Append(" "+ str);
                                    }
                                }

                                for (int i = 0; i < cbNoite.Items.Count; i++)
                                {
                                    if (cbNoite.GetItemChecked(i))
                                    {
                                        string str = (string)cbNoite.Items[i];
                                        noite.Append(" " + str);
                                    }
                                }

                                SqlCommand Cadastra = new SqlCommand(StrCadastra, con);
                                Cadastra.Parameters.AddWithValue("@Dia", dia.ToString());
                                Cadastra.Parameters.AddWithValue("@Manha", manha.ToString());
                                Cadastra.Parameters.AddWithValue("@Tarde", tarde.ToString());
                                Cadastra.Parameters.AddWithValue("@Noite", noite.ToString());
                                Cadastra.ExecuteNonQuery();
                                con.Close();
                                if (diretorio == null || arquivo == null)
                                {
                                    MessageBox.Show("Atualizado");
                                    
                                    
                                    
                                    this.Close();
                                }
                                else {
                                    System.IO.File.Copy(diretorio, @"..\..\..\..\..\SITE\upload\professor\" + arquivo, true);
                                    MessageBox.Show("Atualizado");
                                    
                                    
                                    
                                    this.Close();
                                }
                            }
                        }
                        else
                        {
                            //tabControl1.SelectedTab = info1;
                            lblCPF.Visible = true;
                            lblCPF.Text = "CPF inválido";
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
                valCPF = false;
            }
            else
            {
                valCPF = true;
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

        private void ProfEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studifyPCDataSet.Tb_Comentario' table. You can move, or remove it, as needed.
            this.tb_ComentarioTableAdapter.Fill(this.studifyPCDataSet.Tb_Comentario);
            VerificaMenu();
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
                    lblCEP.Text = "Serviço indisponível";
                }
            }
        }

        private void btnPasso_Click(object sender, EventArgs e)
        {

            if (txtNome.Text == "" || txtContato1.Text == "" || txtCPF.Text == "" || txtData.Text == "" || txtCEP.Text == "" || txtEndereco.Text == "" || txtNum.Text == "" || txtBairro.Text == "" || txtCidade.Text == "" || txtEstado.Text == "")
            {
                VerificaCampos();
            }
            else
            {
                ValidaCPF();
                if (valCPF == false)
                {
                    //tabControl1.SelectedTab = info1;
                    pnInfo1.Visible = true;
                    pnInfo2.Visible = false;
                    pnInfo3.Visible = false;
                    lblCPF.Visible = true;
                    lblCPF.Text = "CPF inválido";
                    valCPF = false;
                }
                else
                {
                    VerificaCampos();
                    
                    pnInfo1.Visible = false;
                    pnInfo2.Visible = true;
                    pnInfo3.Visible = false;
                    rdbMenu2.Checked=true;
                    VerificaMenu();
                }

            }

        }
        //INFO 1
        public void VerificaCampos()
        {
            //NOME
            if (txtNome.Text == "")
            {
                lblNome.Visible = true;
                txtNome.Focus();
                pnInfo1.Visible = true;
                //tabControl1.SelectedTab = info1;
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
                pnInfo1.Visible = true;
                //tabControl1.SelectedTab = info1;
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
                pnInfo1.Visible = true;
                //tabControl1.SelectedTab = info1;
                preenche = false;

            }
            else
            {
                preenche = true;
                lblData.Visible = false;
            }

            //CPF
            if (txtCPF.Text == "   .   .   -")
            {
                lblCPF.Text = "*Campo obrigatório";
                lblCPF.Visible = true;
                txtCPF.Focus();
                preenche = false;
                pnInfo1.Visible = true;
                //tabControl1.SelectedTab = info1;
            }
            else
            {
                preenche = true;
                lblCPF.Visible = false;
            }

            //Contato 1
            if (txtContato1.Text == "")
            {
                preenche = false;
                lblContato.Visible = true;
                txtContato1.Focus();
                pnInfo1.Visible = true;
                //tabControl1.SelectedTab = info1;
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
                pnInfo1.Visible = true;
                // tabControl1.SelectedTab = info1;
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
                pnInfo1.Visible = true;
                //tabControl1.SelectedTab = info1;
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
                pnInfo1.Visible = true;
                //tabControl1.SelectedTab = info1;
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
                pnInfo1.Visible = true;
                //tabControl1.SelectedTab = info1;
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
                pnInfo1.Visible = true;
                //tabControl1.SelectedTab = info1;
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
                pnInfo1.Visible = true;
                //tabControl1.SelectedTab = info1;
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
            if (txtEmail.Text == "")
            {
                lblEmail.Visible = true;
                txtEmail.Focus();
                preenche = false;
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
            //Formação
            if (txtFormacao.Text == "")
            {
                preenche = false;
                lblForma.Visible = true;
                txtFormacao.Focus();
            }
            else
            {
                preenche = true;
                lblForma.Visible = false;
            }

            //Materia
            if (cbMateria.SelectedIndex == 0)
            {
                preenche = false;
                lblDisc.Visible = true;
            }
            else
            {
                preenche = true;
                lblDisc.Visible = false;
            }

            //Valor
            if (txtValor.Text == "")
            {
                preenche = false;
                lblValor.Visible = true;
                txtValor.Focus();
            }
            else
            {
                preenche = true;
                lblValor.Visible = false;
            }

            //Descrição
            if (txtDescricao.Text == "")
            {
                preenche = false;
                lblDescricao.Visible = true;
                txtDescricao.Focus();
            }
            else
            {
                preenche = true;
                lblDescricao.Visible = false;
            }

        }

        private void btnPreencher_Click(object sender, EventArgs e)
        {
            txtNome.Text = "Vitor Cunha Souza";
            cbSexo.SelectedIndex = 1;
            cbSegmento.SelectedIndex = 4;
            cbMateria.SelectedIndex = 7;
            txtData.Text = "24061985";
            txtCPF.Text = "45545696679";
            txtContato1.Text = "(81) 3590-7293";
            txtCEP.Text = "54780370";
            txtNum.Text = "1158";
            txtEmail.Text = "vitor.cunha@studify.com";
            txtSenha.Text = "123";
            txtFormacao.Text = "Bacharelado";
            txtValor.Text = "350";
            txtDescricao.Text = "Tenho vontade de ensinar a todos que queiram aprender Tecnologia da Informação, para que aumente o número de pessoas para o mercado de trabalho. Qualquer dúvida, email: vitor.cunha@studiy.com";
            //tabControl1.SelectedTab = info2;
        }

        private void cbSegmento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valor;
            valor = cbSegmento.SelectedIndex;

            switch (valor)
            {
                case 0:
                    cbMateria.Items.Clear();
                    cbMateria.Items.Add("Selecione a matéria");
                    cbMateria.Items.Add("Matemática");
                    cbMateria.Items.Add("Português");
                    cbMateria.Items.Add("Ciências");
                    cbMateria.Items.Add("Inglês");
                    cbMateria.Items.Add("História");
                    cbMateria.Items.Add("Geografia");
                    cbMateria.Items.Add("Espanhol");
                    cbMateria.Items.Add("Arte");
                    cbMateria.Items.Add("Outros");
                    break;
                case 1:
                    cbMateria.Items.Clear();
                    cbMateria.Items.Add("Selecione a matéria");
                    cbMateria.Items.Add("Matemática");
                    cbMateria.Items.Add("Português");
                    cbMateria.Items.Add("Física");
                    cbMateria.Items.Add("Química");
                    cbMateria.Items.Add("Biologia");
                    cbMateria.Items.Add("Inglês");
                    cbMateria.Items.Add("História");
                    cbMateria.Items.Add("Geografia");
                    cbMateria.Items.Add("Filosofia");
                    cbMateria.Items.Add("Sociologia");
                    cbMateria.Items.Add("Outros");
                    break;
                case 2:
                    cbMateria.Items.Clear();
                    cbMateria.Items.Add("Selecione a matéria");
                    cbMateria.Items.Add("Matemática");
                    cbMateria.Items.Add("Português");
                    cbMateria.Items.Add("Física");
                    cbMateria.Items.Add("Química");
                    cbMateria.Items.Add("Biologia");
                    cbMateria.Items.Add("Inglês");
                    cbMateria.Items.Add("História");
                    cbMateria.Items.Add("Geografia");
                    cbMateria.Items.Add("Filosofia");
                    cbMateria.Items.Add("Sociologia");
                    cbMateria.Items.Add("Outros");
                    break;
                case 3:
                    cbMateria.Items.Clear();
                    cbMateria.Items.Add("Selecione o curso");
                    cbMateria.Items.Add("Informática");
                    cbMateria.Items.Add("Administração");
                    cbMateria.Items.Add("Marketing");
                    cbMateria.Items.Add("Eventos");
                    cbMateria.Items.Add("Enfermagem");
                    cbMateria.Items.Add("Meteorologia");
                    cbMateria.Items.Add("Edificações");
                    cbMateria.Items.Add("Alimentos");
                    cbMateria.Items.Add("Artes Visuais");
                    cbMateria.Items.Add("Biocombustíveis");
                    cbMateria.Items.Add("Segurança do Trabalho");
                    break;
                case 4:
                    cbMateria.Items.Clear();
                    cbMateria.Items.Add("Selecione a matéria");
                    cbMateria.Items.Add("Engenharias");
                    cbMateria.Items.Add("Medicina");
                    cbMateria.Items.Add("Letras");
                    cbMateria.Items.Add("Direito");
                    cbMateria.Items.Add("Biologia");
                    cbMateria.Items.Add("Ciências Sociais");
                    cbMateria.Items.Add("Tecnologia da informação");
                    cbMateria.Items.Add("Economia");
                    cbMateria.Items.Add("Administração");
                    cbMateria.Items.Add("Arquitetura e urbanismo");
                    cbMateria.Items.Add("Artes");
                    cbMateria.Items.Add("Matemática");
                    cbMateria.Items.Add("Física");
                    cbMateria.Items.Add("Química");
                    cbMateria.Items.Add("Publicidade e marketing");
                    cbMateria.Items.Add("Turismo");
                    cbMateria.Items.Add("Outros");
                    break;
            }
            return;
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
            string remove = "delete from Tb_Professor where Id_Professor= " + lblID.Text;

            SqlCommand cmd = new SqlCommand(remove, con);

            try
            {
                // Abrindo a conexão com o banco
                con.Open();
                // Criando uma variável para adicionar e armazenar o resultado
                int resultado;
                if (MessageBox.Show("Tem certeza que deseja remover este professor?",
               "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    resultado = cmd.ExecuteNonQuery();
                    if (resultado == 1)
                    {
                        MessageBox.Show("Professor removido com sucesso!");
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
            pnInfo2.Visible = false;
            pnInfo3.Visible = false;
            rdbMenu1.Checked = true;
            VerificaMenu();
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

        private void btnInfo2_Click_1(object sender, EventArgs e)
        {
            pnInfo1.Visible = false;
            pnInfo2.Visible = true;
            pnInfo3.Visible = false;
            rdbMenu2.Checked = true;
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

        private void cbDias_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cbDias.Items.Count; i++)
            {


                if (cbDias.GetItemRectangle(i).Contains(cbDias.PointToClient(MousePosition)))
                {
                    switch (cbDias.GetItemCheckState(i))
                    {
                        case CheckState.Checked:
                            cbDias.SetItemCheckState(i, CheckState.Unchecked);
                            break;
                        case CheckState.Indeterminate:
                        case CheckState.Unchecked:
                            cbDias.SetItemCheckState(i, CheckState.Checked);
                            break;
                    }

                }
            }
        }

        private void cbManha_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cbManha.Items.Count; i++)
            {


                if (cbManha.GetItemRectangle(i).Contains(cbManha.PointToClient(MousePosition)))
                {
                    switch (cbManha.GetItemCheckState(i))
                    {
                        case CheckState.Checked:
                            cbManha.SetItemCheckState(i, CheckState.Unchecked);
                            break;
                        case CheckState.Indeterminate:
                        case CheckState.Unchecked:
                            cbManha.SetItemCheckState(i, CheckState.Checked);
                            break;
                    }

                }
            }
        }

        private void cbTarde_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cbTarde.Items.Count; i++)
            {


                if (cbTarde.GetItemRectangle(i).Contains(cbTarde.PointToClient(MousePosition)))
                {
                    switch (cbTarde.GetItemCheckState(i))
                    {
                        case CheckState.Checked:
                            cbTarde.SetItemCheckState(i, CheckState.Unchecked);
                            break;
                        case CheckState.Indeterminate:
                        case CheckState.Unchecked:
                            cbTarde.SetItemCheckState(i, CheckState.Checked);
                            break;
                    }

                }

            }
        }

        private void cbNoite_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cbNoite.Items.Count; i++)
            {


                if (cbNoite.GetItemRectangle(i).Contains(cbNoite.PointToClient(MousePosition)))
                {
                    switch (cbNoite.GetItemCheckState(i))
                    {
                        case CheckState.Checked:
                            cbNoite.SetItemCheckState(i, CheckState.Unchecked);
                            break;
                        case CheckState.Indeterminate:
                        case CheckState.Unchecked:
                            cbNoite.SetItemCheckState(i, CheckState.Checked);
                            break;
                    }

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnInfo1.Visible = false;
            pnInfo2.Visible = false;
            pnInfo3.Visible = true;
            rdbMenu3.Checked = true;
            VerificaMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmComentarios com = new frmComentarios();
            string strSql = "SELECT * FROM Tb_Comentario where Id_Professor=" + lblID.Text;
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

        void VerificaMenu()
        {
            if (rdbMenu1.Checked == true)
            {
                btnInfo1.BackColor = Color.FromArgb(41, 41, 41);
                btnInfo2.BackColor = Color.FromArgb(35, 35, 35);
                btnInfo3.BackColor = Color.FromArgb(35, 35, 35);
            }
            if (rdbMenu2.Checked == true)
            {
                btnInfo1.BackColor = Color.FromArgb(35, 35, 35);
                btnInfo2.BackColor = Color.FromArgb(41, 41, 41);
                btnInfo3.BackColor = Color.FromArgb(35, 35, 35);
            }
            if (rdbMenu3.Checked == true)
            {
                btnInfo1.BackColor = Color.FromArgb(35, 35, 35);
                btnInfo2.BackColor = Color.FromArgb(35, 35, 35);
                btnInfo3.BackColor = Color.FromArgb(41, 41, 41);
            }
        }
        private void btnInfo2_Click(object sender, EventArgs e)
        {
            pnInfo1.Visible = false;
            pnInfo2.Visible = false;
            pnInfo3.Visible = true;
            rdbMenu3.Checked = true;
            VerificaMenu();
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
                            caminhoBanco = "upload/professor/" + arquivo;
                            lblCaminho.Text = caminhoBanco;

                        }
                    }
                }
            }
        }
    }
}
