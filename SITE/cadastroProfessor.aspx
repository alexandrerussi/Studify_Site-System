<%@ Page Language="C#" AutoEventWireup="true" CodeFile="cadastroProfessor.aspx.cs" Inherits="cadastroProfessor" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro Professor - Studify</title>
    <!--Import Google Icon Font-->
    <link href="http://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" />


    <!--Import materialize.css-->
    <link href="materialize/css/materialize.min.css" rel="stylesheet" media="screen,projection" />
    <link href="materialize/css/style.css" rel="stylesheet" media="screen,projection" />

    <!--Let browser know website is optimized for mobile-->
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

    <link rel="icon" href="images/logo-min.png" sizes="16x16" />

    <!--Máscaras Form-->
    <script src="Scripts/meujq.js"></script>
    <script src="Scripts/jquery.maskedinput.min.js"></script>
    <script type="text/javascript">
        jQuery(function ($) {
            $("#txtCPF").mask("999.999.999-99");
            $("#txtCEP").mask("99999-999");
        });
    </script>

</head>
<body class="grey lighten-4">
    <form id="form1" runat="server">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudifyConnectionString3 %>" SelectCommand="SELECT * FROM [Tb_Professor]"></asp:SqlDataSource>

        <div>
            <nav class="teal darken-2">
                <div class="nav-wrapper containerColoredMenu row">
                    <div class="col s1 hide-on-med-and-down left-align">
                        <a href="index.aspx">
                            <img class="logo-img-editCadastro" src="images/logo.png" />
                        </a>
                    </div>
                    <a class="right hide-on-med-and-up show-on-medium-and-down marginLogoCadMobile" href="index.aspx">
                        <img class="logo-img" src="images/logo.png" />
                    </a>
                    <div class="col s8 hide-on-med-and-down">
                        <ul>
                            <li class="fontColoredMenu">
                                <a href="#">
                                    <asp:Button ID="btnEnsinoFundamental" CssClass="btnMenu" runat="server" Text="Ensino Fundamental" PostBackUrl="~/paginasPesquisas/pesquisaProfessorFundamental.aspx" CausesValidation="False" />
                                    <asp:TextBox ID="txtEnsinoFundamental" runat="server">Ensino Fundamental</asp:TextBox>
                                </a>
                            </li>

                            <li class="fontColoredMenu">
                                <a href="#">
                                    <asp:Button ID="btnEnsinoMedio" CssClass="btnMenu" runat="server" Text="Ensino Médio" PostBackUrl="~/paginasPesquisas/pesquisaProfessorMedio.aspx" CausesValidation="False" />
                                    <asp:TextBox ID="txtEnsinoMedio" runat="server">Ensino Médio</asp:TextBox>
                                </a>
                            </li>

                            <li class="fontColoredMenu">
                                <a href="#">
                                    <asp:Button ID="btnPreVestibular" runat="server" CssClass="btnMenu" Text="Pré-Vestibular" PostBackUrl="~/paginasPesquisas/pesquisaProfessorVestibular.aspx" CausesValidation="False" />
                                    <asp:TextBox ID="txtPreVestibular" runat="server">Pré-Vestibular</asp:TextBox>
                                </a>
                            </li>

                            <li class="fontColoredMenu">
                                <a href="#">
                                    <asp:Button ID="btnEnsinoTecnico" runat="server" Text="Ensino Técnico" CssClass="btnMenu" PostBackUrl="~/paginasPesquisas/pesquisaProfessorTecnico.aspx" CausesValidation="False" />
                                    <asp:TextBox ID="txtEnsinoTecnico" runat="server">Ensino Técnico</asp:TextBox>
                                </a>
                            </li>

                            <li class="fontColoredMenu">
                                <a href="#">
                                    <asp:Button ID="btnGraduacao" runat="server" Text="Graduação" CssClass="btnMenu" PostBackUrl="~/paginasPesquisas/pesquisaProfessorGraduacao.aspx" CausesValidation="False" />
                                    <asp:TextBox ID="txtGraduacao" runat="server">Graduação</asp:TextBox>
                                </a>
                            </li>
                        </ul>
                    </div>
                    <div class="row hide-on-med-and-down">
                        <div class="col s3 hide-on-med-and-down right-align right">
                            <asp:Label ID="lblUsuario" runat="server"></asp:Label>
                            <div class="col s12">
                                <asp:DropDownList ID="ddlPerfil" CssClass="ddlPerfilHome" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlPerfil_SelectedIndexChanged">
                                    <asp:ListItem Value="Perfil" Class="left circle">Perfil</asp:ListItem>
                                    <asp:ListItem Value="Sair" Class="left circle">Sair</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <asp:Panel ID="Cadastro" runat="server">
                                <a class="btn waves-effect waves-light deep-orange darken-1 modal-trigger btnColoredMenu1" href="#modal1">FAZER LOGIN</a>
                                <a class="btn waves-effect waves-light deep-orange darken-1 modal-trigger btnColoredMenu2" href="#modal1">LOGIN</a>

                                <a class="btn waves-effect waves-light teal modal-trigger btnColoredMenu1" href="#modal2">FAZER CADASTRO</a>
                                <a class="btn waves-effect waves-light teal modal-trigger btnColoredMenu2" href="#modal2">CADASTRO</a>
                            </asp:Panel>
                        </div>
                    </div>

                    <a href="#" data-activates="mobile-demo" class="button-collapse left marginMenu"><i class="material-icons">menu</i></a>
                    <ul class="side-nav" id="mobile-demo">
                        <li class="center-align"><a href="#">
                            <img class="logo-img" src="../images/logo.png" /></a></li>
                        <li class="divider"></li>
                        <li class="deep-orange darken-1">
                            <asp:DropDownList ID="ddlPerfilMobile" CssClass="ddlPerfilHome" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlPerfil_SelectedIndexChanged">
                                <asp:ListItem Value="Perfil" Class="left circle">Perfil</asp:ListItem>
                                <asp:ListItem Value="Sair" Class="left circle">Sair</asp:ListItem>
                            </asp:DropDownList>
                        </li>
                        <asp:Panel ID="CadastroMobile" runat="server">
                            <li><a href="#modal1" class="waves-effect deep-orange darken-1 waves-light modal-trigger hoverEditMenuMobile"><i class="material-icons left">perm_identity</i>Login</a></li>
                            <li><a href="#modal2" class="waves-effect teal waves-ligh modal-trigger hoverEditMenuMobile"><i class="material-icons left">contacts</i>Cadastro</a></li>
                        </asp:Panel>
                        <li class="divider"></li>
                        <li class="divider"></li>
                        <li>
                            <a href="#" class="waves-effect waves-blue">
                                <asp:Button ID="btnEnsinoFundamentalMobile" CssClass="btnMenu" runat="server" Text="Ensino Fundamental" PostBackUrl="~/paginasPesquisas/pesquisaProfessorFundamental.aspx" CausesValidation="False" />
                            </a>
                        </li>

                        <li>
                            <a href="#" class="waves-effect waves-blue">
                                <asp:Button ID="btnEnsinoMediolMobile" CssClass="btnMenu" runat="server" Text="Ensino Médio" PostBackUrl="~/paginasPesquisas/pesquisaProfessorMedio.aspx" CausesValidation="False" />
                            </a>
                        </li>

                        <li>
                            <a href="#" class="waves-effect waves-blue">
                                <asp:Button ID="btnPreVestibularlMobile" CssClass="btnMenu" runat="server" Text="Pré-Vestibular" PostBackUrl="~/paginasPesquisas/pesquisaProfessorVestibular.aspx" CausesValidation="False" />
                            </a>
                        </li>

                        <li>
                            <a href="#" class="waves-effect waves-blue">
                                <asp:Button ID="btnEnsinoTecnicoMobile" CssClass="btnMenu" runat="server" Text="Ensino Técnico" PostBackUrl="~/paginasPesquisas/pesquisaProfessorTecnico.aspx" CausesValidation="False" />
                            </a>
                        </li>

                        <li>
                            <a href="#" class="waves-effect waves-blue">
                                <asp:Button ID="btnGraduacaoMobile" CssClass="btnMenu" runat="server" Text="Graduação" PostBackUrl="~/paginasPesquisas/pesquisaProfessorGraduacao.aspx" CausesValidation="False" />
                            </a>
                        </li>

                    </ul>
                </div>
            </nav>

            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <asp:View ID="VideoCadastro" runat="server">
                    <div class="col s12 container card-panel-cadastro">
                        <h2 class="titulo center-align black-text">Tutorial de cadastro</h2>
                        <h5 class="fonteFina center-align black-text subtituloModal2">Dúvida? Assista o vídeo e elimine todas!</h5>
                        <iframe class="videoPerfil" src="https://www.youtube.com/embed/-I8NDZlDbc8" frameborder="0" allowfullscreen></iframe>
                        <div class="row">
                            <div class="col offset-l9 l3 m12 s12">
                                <asp:Button ID="btnVideoCadastro" runat="server" Text="AVANÇAR" CssClass="right btn teal waves-effect waves-light btnCadastroAluno" OnClick="btnVideoCadastro_Click" />
                            </div>
                        </div>
                    </div>
                </asp:View>
                <asp:View ID="InfoPessoais" runat="server">
                    <div class="col s12 container card-panel-cadastro">
                        <h2 class="titulo center-align black-text">Cadastre-se como professor!</h2>
                        <h5 class="fonteFina center-align black-text subtituloModal2">obtenha resultados rápidos!</h5>
                        <h3 class="titulo center-align black-text">Informações pessoais</h3>
                        <%--<div><asp:Button ID="btnPreencherProf1" runat="server" Text="Button" CssClass="center borderNone white-text white btnProximoPasso2 btnCadastroAluno" CausesValidation="False" OnClick="btnPreencherProf1_Click" /></div>--%>
                        <div class="row">
                            <div class="input-field col l6 m6 s6 paddingEditCadastro">
                                <asp:TextBox ID="txtNomeCompleto" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtNomeCompleto">Nome Completo*</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="red-text" ErrorMessage="Campo obrigatório" ControlToValidate="txtNomeCompleto"></asp:RequiredFieldValidator>
                            </div>
                            <div class="input-field col l6 m6 s6 marginEditCadastro ddlEditDivs">
                                <asp:DropDownList ID="ddlSexo" CssClass="ddlSexo" runat="server">
                                    <asp:ListItem>Sexo*</asp:ListItem>
                                    <asp:ListItem data-icon="images/simbolo_homem.png" Class="left circle">Masculino</asp:ListItem>
                                    <asp:ListItem data-icon="images/simbolo_mulher.png" Class="left circle">Feminino</asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" CssClass="red-text" ErrorMessage="Obrigatório a seleção" ControlToValidate="ddlSexo" InitialValue="Sexo*"></asp:RequiredFieldValidator>
                            </div>

                        </div>
                        <div class="row">
                            <div class="input-field col l3 m6 s6 paddingEditCadastro">
                                <asp:TextBox ID="txtContato1" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtContato1">Contato 1*</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" CssClass="red-text" ErrorMessage="Campo obrigatório" ControlToValidate="txtContato1"></asp:RequiredFieldValidator>
                            </div>
                            <div class="input-field col l3 m6 s6 paddingEditCadastro">
                                <asp:TextBox ID="txtContato2" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtContato2">Contato 2</label>
                            </div>
                            <div class="input-field col l6 m12 s12 paddingEditCadastro">
                                <asp:TextBox ID="txtCPF" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtCPF">CPF*</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" CssClass="red-text" ErrorMessage="Campo obrigatório" ControlToValidate="txtCPF"></asp:RequiredFieldValidator>
                            </div>

                        </div>
                        <div class="row">
                            <div class="input-field col l2 m4 s4 paddingEditCadastro ddlEditDivs">
                                <%--<label class="datepicker handy">Data de nascimento</label>
                                <input type="date" class="datepicker handy" />--%>
                                <asp:DropDownList ID="ddlDiaNascimento" CssClass="ddlDiaNascimento" runat="server">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" CssClass="red-text" ErrorMessage="Obrigatório" ControlToValidate="ddlDiaNascimento" InitialValue="Dia*"></asp:RequiredFieldValidator>
                            </div>
                            <div class="input-field col l2 m4 s4 paddingEditCadastro ddlEditDivs">
                                <%--<label class="datepicker handy">Data de nascimento</label>
                                <input type="date" class="datepicker handy" />--%>
                                <asp:DropDownList ID="ddlMesNascimento" CssClass="ddlMesNascimento" runat="server">
                                    <asp:ListItem Value="-1">Mês*</asp:ListItem>
                                    <asp:ListItem Value="01">Janeiro</asp:ListItem>
                                    <asp:ListItem Value="02">Fevereiro</asp:ListItem>
                                    <asp:ListItem Value="03">Março</asp:ListItem>
                                    <asp:ListItem Value="04">Abril</asp:ListItem>
                                    <asp:ListItem Value="05">Maio</asp:ListItem>
                                    <asp:ListItem Value="06">Junho</asp:ListItem>
                                    <asp:ListItem Value="07">Julho</asp:ListItem>
                                    <asp:ListItem Value="08">Agosto</asp:ListItem>
                                    <asp:ListItem Value="09">Setembro</asp:ListItem>
                                    <asp:ListItem Value="10">Outubro</asp:ListItem>
                                    <asp:ListItem Value="11">Novembro</asp:ListItem>
                                    <asp:ListItem Value="12">Dezembro</asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" CssClass="red-text" ErrorMessage="Obrigatório" ControlToValidate="ddlMesNascimento" InitialValue="-1"></asp:RequiredFieldValidator>
                            </div>
                            <div class="input-field col l2 m4 s4 paddingEditCadastro ddlEditDivs">
                                <%--<label class="datepicker handy">Data de nascimento</label>
                                <input type="date" class="datepicker handy" />--%>
                                <asp:DropDownList ID="ddlAnoNascimento" CssClass="ddlAnoNascimento" runat="server">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" CssClass="red-text" ErrorMessage="Obrigatório" ControlToValidate="ddlAnoNascimento" InitialValue="Ano*"></asp:RequiredFieldValidator>
                            </div>
                            <div class="input-field col l6 m12 s12 paddingEditCadastro">
                                <asp:TextBox ID="txtCEP" CssClass="validate" runat="server" OnTextChanged="txtCEP_TextChanged" AutoPostBack="True"></asp:TextBox>
                                <label for="txtCEP">CEP*</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" CssClass="red-text" ErrorMessage="Campo obrigatório" ControlToValidate="txtCEP"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="row">
                            <div class="input-field col l6 m12 s12 paddingEditCadastro">
                                <asp:TextBox ID="txtEndereco" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtEndereco">Endereço*</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" CssClass="red-text" ErrorMessage="Campo obrigatório" ControlToValidate="txtEndereco"></asp:RequiredFieldValidator>
                            </div>
                            <div class="input-field col l3 m6 s6 paddingEditCadastro">
                                <asp:TextBox ID="txtNumero" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtNumero">Número*</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" CssClass="red-text" ErrorMessage="Campo obrigatório" ControlToValidate="txtNumero"></asp:RequiredFieldValidator>
                            </div>
                            <div class="input-field col l3 m6 s6 paddingEditCadastro">
                                <asp:TextBox ID="txtComplemento" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtComplemento">Complemento</label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="input-field col l3 m6 s6 paddingEditCadastro">
                                <asp:TextBox ID="txtBairro" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtBairro">Bairro*</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" CssClass="red-text" ErrorMessage="Campo obrigatório" ControlToValidate="txtBairro"></asp:RequiredFieldValidator>
                            </div>

                            <div class="input-field col l3 m6 s6 paddingEditCadastro ddlEditDivs">
                                <asp:DropDownList ID="ddlEstado" CssClass="ddlEstado" runat="server">
                                    <asp:ListItem Value="-1">Estado (UF)*</asp:ListItem>
                                    <asp:ListItem Value="AC">Acre</asp:ListItem>
                                    <asp:ListItem Value="AL">Alagoas</asp:ListItem>
                                    <asp:ListItem Value="AP">Amapá</asp:ListItem>
                                    <asp:ListItem Value="AM">Amazonas</asp:ListItem>
                                    <asp:ListItem Value="BA">Bahia</asp:ListItem>
                                    <asp:ListItem Value="CE">Ceará</asp:ListItem>
                                    <asp:ListItem Value="DF">Distrito Federal</asp:ListItem>
                                    <asp:ListItem Value="ES">Espírito Santo</asp:ListItem>
                                    <asp:ListItem Value="GO">Goiás</asp:ListItem>
                                    <asp:ListItem Value="MA">Maranhão</asp:ListItem>
                                    <asp:ListItem Value="MT">Mato Grosso</asp:ListItem>
                                    <asp:ListItem Value="MS">Mato Grosso do Sul</asp:ListItem>
                                    <asp:ListItem Value="MG">Minas Gerais</asp:ListItem>
                                    <asp:ListItem Value="PA">Pará</asp:ListItem>
                                    <asp:ListItem Value="PB">Paraíba</asp:ListItem>
                                    <asp:ListItem Value="PR">Paraná</asp:ListItem>
                                    <asp:ListItem Value="PE">Pernambuco</asp:ListItem>
                                    <asp:ListItem Value="PI">Piauí</asp:ListItem>
                                    <asp:ListItem Value="RJ">Rio de Janeiro</asp:ListItem>
                                    <asp:ListItem Value="RS">Rio Grande do Sul</asp:ListItem>
                                    <asp:ListItem Value="RN">Rio Grande do Norte</asp:ListItem>
                                    <asp:ListItem Value="RO">Rondônia</asp:ListItem>
                                    <asp:ListItem Value="RR">Roraima</asp:ListItem>
                                    <asp:ListItem Value="SC">Santa Catarina</asp:ListItem>
                                    <asp:ListItem Value="SP">São Paulo</asp:ListItem>
                                    <asp:ListItem Value="SE">Sergipe</asp:ListItem>
                                    <asp:ListItem Value="TO">Tocantins</asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" CssClass="red-text" ErrorMessage="Obrigatório" ControlToValidate="ddlEstado" InitialValue="-1"></asp:RequiredFieldValidator>
                            </div>

                            <div class="input-field col l3 m12 s12 paddingEditCadastro">
                                <asp:TextBox ID="txtCidade" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="cidade">Cidade*</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" CssClass="red-text" ErrorMessage="Campo obrigatório" ControlToValidate="txtCidade"></asp:RequiredFieldValidator>
                            </div>

                            <div class="col l3 m12 s12 paddingEditCadastro">
                                <asp:Button ID="btnInfoPessoalProf" runat="server" Text="PRÓXIMO PASSO" CssClass="right btn teal waves-effect waves-light btnCadastroAluno" OnClick="btnInfoPessoalProf_Click" />
                            </div>
                        </div>
                        <div class="row center">
                            <h5 class="fonteFina">Etapa 1 de 4: informações pessoais</h5>
                        </div>
                    </div>
                </asp:View>
                <asp:View ID="InfoTecnicas" runat="server">
                    <div class="col s12 container card-panel-cadastro">
                        <h2 class="titulo center-align black-text">Cadastre-se como professor!</h2>
                        <h5 class="fonteFina center-align black-text subtituloModal2">obtenha resultados rápidos!</h5>
                        <h3 class="titulo center-align black-text">Informações Técnicas</h3>
                        <div class="row">
                            <div class="input-field col l6 m6 s6 paddingEditCadastro">
                                <asp:TextBox ID="txtEmailCadastro" CssClass="validate" TextMode="Email" runat="server"></asp:TextBox>
                                <label for="txtEmailCadastro">Email</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" CssClass="red-text" ErrorMessage="Campo obrigatório" ControlToValidate="txtEmailCadastro"></asp:RequiredFieldValidator>
                            </div>
                            <div class="input-field col l6 m6 s6 paddingEditCadastro">
                                <asp:TextBox ID="txtValorAula" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtValor">Valor da aula por hora</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" CssClass="red-text" ErrorMessage="Campo obrigatório" ControlToValidate="txtValorAula"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="row">
                            <div class="input-field col l6 m12 s12 paddingEditCadastro">
                                <asp:TextBox ID="txtSenhaCadastro" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtSenhaCadastro">Senha*</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" CssClass="red-text" ErrorMessage="Campo obrigatório" ControlToValidate="txtSenhaCadastro"></asp:RequiredFieldValidator>
                            </div>
                            <div class="input-field col l6 m12 s12 paddingEditCadastro">
                                <asp:TextBox ID="txtConfirmarSenha" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="ConfirmarSenha">Confirmar Senha</label>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" CssClass="red-text" ErrorMessage="Campos diferentes" ControlToValidate="txtConfirmarSenha" ControlToCompare="txtSenhaCadastro"></asp:CompareValidator>
                            </div>
                        </div>

                        <div class="row">
                            <div class="input-field col l6 m6 s12">
                                <asp:TextBox ID="txtQualificacao" CssClass="validate materialize-textarea" runat="server" TextMode="MultiLine"></asp:TextBox>
                                <label for="txtQualificacao">Qualificações</label>
                            </div>
                            <div class="input-field col l6 m6 s12">
                                <asp:TextBox ID="txtDescricao" CssClass="validate materialize-textarea" runat="server" TextMode="MultiLine"></asp:TextBox>
                                <label for="txtDescricao">Descricao</label>
                            </div>

                        </div>
                        <div class="row">

                            <div class="input-field col l4 m12 s12 marginEditCadastro ddlEditDivs">
                                <asp:DropDownList ID="ddlSegmento" CssClass="ddlSexo" runat="server">
                                    <asp:ListItem>Segmento</asp:ListItem>
                                    <asp:ListItem>Ensino fundamental</asp:ListItem>
                                    <asp:ListItem>Ensino médio</asp:ListItem>
                                    <asp:ListItem>Pré-Vestibular</asp:ListItem>
                                    <asp:ListItem>Ensino Técnico</asp:ListItem>
                                    <asp:ListItem>Graduação</asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" CssClass="red-text" ErrorMessage="Obrigatório" ControlToValidate="ddlSegmento" InitialValue="Segmento"></asp:RequiredFieldValidator>
                            </div>

                            <div class="input-field col l4 m12 s12 s6paddingEditCadastro">
                                <asp:TextBox ID="txtDisciplina" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtDisciplina">Disciplina(s) lecionada(s)</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" CssClass="red-text" ErrorMessage="Campo obrigatório" ControlToValidate="txtDisciplina"></asp:RequiredFieldValidator>
                            </div>

                            <div class="col l4 m12 s12 paddingEditCadastro">
                                <asp:Button ID="btnInfoTecnico" runat="server" Text="PRÓXIMO PASSO" CssClass="right btn teal waves-effect waves-light btnProximoPasso2 btnCadastroAluno" OnClick="btnInfoTecnico_Click" />
                            </div>
                        </div>
                        <div class="row center">
                            <h5 class="fonteFina">Etapa 2 de 4: informações técnicas</h5>
                        </div>
                    </div>
                </asp:View>
                <asp:View ID="Agenda" runat="server">
                    <div class="col s12 container card-panel-cadastro">
                        <h2 class="titulo center-align black-text">Cadastre-se como professor!</h2>
                        <h5 class="fonteFina center-align black-text subtituloModal2">obtenha resultados rápidos!</h5>
                        <h3 class="titulo center-align black-text">Agenda</h3>
                        <div class="row">
                            <div class="col l3 m3 s12 ckbListAgenda">
                                <h6 class="fonteGrossa">Dias da semana</h6>
                                <asp:CheckBoxList ID="chbDias" runat="server">
                                    <asp:ListItem>Domingo</asp:ListItem>
                                    <asp:ListItem>Segunda-Feira</asp:ListItem>
                                    <asp:ListItem>Terça-Feira</asp:ListItem>
                                    <asp:ListItem>Quarta-Feira</asp:ListItem>
                                    <asp:ListItem>Quinta-Feria</asp:ListItem>
                                    <asp:ListItem>Sexta-Feira</asp:ListItem>
                                    <asp:ListItem>Sabádo</asp:ListItem>
                                </asp:CheckBoxList>
                            </div>

                            <div class="col l3 m3 s12 ckbListAgenda">
                                <h6 class="fonteGrossa">Período da manhã</h6>
                                <asp:CheckBoxList ID="chbManha" runat="server" ForeColor="Black">
                                    <asp:ListItem>08:00</asp:ListItem>
                                    <asp:ListItem>09:00</asp:ListItem>
                                    <asp:ListItem>10:00</asp:ListItem>
                                    <asp:ListItem>11:00</asp:ListItem>
                                    <asp:ListItem>12:00</asp:ListItem>
                                </asp:CheckBoxList>
                            </div>

                            <div class="col l3 m3 s12 ckbListAgenda">
                                <h6 class="fonteGrossa">Período da tarde</h6>
                                <asp:CheckBoxList ID="chbTarde" runat="server" ForeColor="Black">
                                    <asp:ListItem>13:00</asp:ListItem>
                                    <asp:ListItem>14:00</asp:ListItem>
                                    <asp:ListItem>15:00</asp:ListItem>
                                    <asp:ListItem>16:00</asp:ListItem>
                                    <asp:ListItem>17:00</asp:ListItem>
                                </asp:CheckBoxList>
                            </div>

                            <div class="col l3 m3 s12 ckbListAgenda">
                                <h6 class="fonteGrossa">Período da noite</h6>
                                <asp:CheckBoxList ID="chbNoite" runat="server" ForeColor="Black">
                                    <asp:ListItem>18:00</asp:ListItem>
                                    <asp:ListItem>19:00</asp:ListItem>
                                    <asp:ListItem>20:00</asp:ListItem>
                                    <asp:ListItem>21:00</asp:ListItem>
                                    <asp:ListItem>22:00</asp:ListItem>
                                </asp:CheckBoxList>
                            </div>

                        </div>
                        <div class="row center-align">
                            <asp:Button ID="btnAgenda" runat="server" Text="PRÓXIMO PASSO" CssClass="btn teal waves-effect waves-light btnCadastroAlunoAgenda center-align" OnClick="btnAgenda_Click" />
                        </div>
                        <div class="row center">
                            <h5 class="fonteFina">Etapa 3 de 4: agenda</h5>
                        </div>
                    </div>

                </asp:View>
                <asp:View ID="InfoSociais" runat="server">
                    <div class="col s12 container card-panel-cadastro">
                        <h2 class="titulo center-align black-text">Cadastre-se como professor!</h2>
                        <h5 class="fonteFina center-align black-text subtituloModal2">obtenha resultados rápidos!</h5>
                        <h3 class="titulo center-align black-text">Redes sociais</h3>

                        <div class="row">
                            <div class="input-field col l4 m4 s12 paddingEditCadastro">
                                <asp:TextBox ID="txtSkype" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtSkype">Nome skype</label>
                            </div>
                            <div class="input-field col l4 m4 s12 paddingEditCadastro">
                                <asp:TextBox ID="txtFacebook" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtFacebook">Facebook</label>
                            </div>
                            <div class="input-field col l4 m4 s12 paddingEditCadastro">
                                <asp:TextBox ID="txtLinkedin" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtLinkedin">Linkedin</label>
                            </div>
                        </div>

                        <div class="row">
                            <div class="input-field col l6 m6 s12 paddingEditCadastro">
                                <asp:TextBox ID="txtCanalYoutube" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtCanalYoutube">Canal no Youtube</label>
                            </div>

                            <div class="input-field col l6 m6 s12 paddingEditCadastro">
                                <asp:TextBox ID="txtVideoApresentacao" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtVideoApresentacao">Video de Apresentação</label>
                            </div>
                        </div>

                        <div class="row">
                            <div class="input-field col l6 m6 s12 paddingEditCadastro fileUploadCadastro">
                                <span class="labelImagemCadastro">Imagem do perfil</span>
                                <asp:FileUpload ID="fileUploadImagem" runat="server" CssClass="" />
                                <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
                            </div>

                            <div class="col l6 m6 s12 paddingEditCadastro marginTopBtnFinalizar">
                                <a class="btn waves-effect waves-light teal modal-trigger btnFinalizar" href="#modal5">FINALIZAR</a>

                            </div>
                        </div>
                        <div class="row center">
                            <h5 class="fonteFina">Etapa 4 de 4: social</h5>
                        </div>
                    </div>
                </asp:View>
            </asp:MultiView>

            <!--Modal 5 - Cadastre-se -->
            <div id="modal5" class="modal modal-cadastro">
                <div class="modal-content">
                    <h2 class="titulo center-align black-text">Política de privacidade</h2>
                    <h5 class="fonteFina center-align black-text subtituloModal2">leia e se informe sobre nossas políticas</h5>
                    <div class="row container">
                        <h5 class="fonteFina">O QUE FAZEMOS COM SUAS INFORMAÇÕES</h5>
                        <div class="marginLeftTermos">
                            <p class="textoJustificado">
                                1.	O termo “informações pessoais” usados aqui é definido como qualquer informação que identifica ou pode ser usada para identificar, contatar ou localizar a pessoa, a quem tal informação pertence. As informações pessoais que coletamos estarão sujeita a esta Política de Privacidade, a qual é alterada de tempos em tempos.
                            </p>
                            <p class="textoJustificado">
                                2.	Quando você se cadastra na Studify pedimos o seu endereço de e-mail.
                            </p>
                            <p class="textoJustificado">
                                3.	A Studify utiliza as informações que são coletadas para os seguintes propósitos gerais: fornecimento de serviços, identificação e autenticação, melhoria de serviços, contato e pesquisa.
                            </p>
                            <p class="textoJustificado">
                                4.	Ao aceitar nosso Acordo de Usuário, você concorda que, com respeito às Informações Pessoais de outros usuários que você obtém através da Studify ou através de uma comunicação relacionada da Studify ou transação facilitada do Studify, a Studify concede a você uma licença para utilizar tais informações apenas para comunicações relacionadas à Studify que não sejam mensagens comerciais não solicitadas. A Studify não tolera spam.
                            </p>

                            <h6 class="fonteFina" style="margin-top: 40px;">O QUE SIGINFICA</h6>
                            <p class="textoJustificado">
                                Quando você se cadastra, você fornece informações pessoais que coletamos e usamos. Apenas use as informações dos usuários da Studify para comunicações relacionadas à Studify, a menos que eles lhe permitam fazê-lo. Não faça spam para ninguém!
                            </p>
                        </div>

                        <h5 class="fonteFina" style="margin-top: 40px;">SEGURANÇA</h5>
                        <div class="marginLeftTermos">
                            <p class="textoJustificado">
                                A segurança de suas informações pessoais é importante para nós. Quando você insere informações confidenciais, tais como número do RG ou CPF em nosso formulário de inscrição, nós os matemos em segurança em nossos bancos de dados. Os dados Informados são armazenados e implementamos padrões adicionais geralmente aceitos da indústria, para proteger a informação pessoal que nos é submetida, tanto durante a transmissão quanto assim que a recebemos. Nenhum método de transmissão pela Internet, ou método de armazenamento eletrônico é 100% seguro. Portanto, enquanto nos esforçamos para utilizar meios comercialmente aceitáveis para proteger suas informações pessoais, não podemos garantir sua segurança absoluta. Se você tem dúvidas sobre a segurança em nosso Site, você pode enviar um e-mail para studifyeducacao@gmail.com.
                            </p>
                            

                            <h6 class="fonteFina" style="margin-top: 40px;">O QUE SIGINFICA</h6>
                            <p class="textoJustificado">
                                Vamos armazenar suas informações confidenciais nos padrões da indústria. Porque as coisas acontecem, nós não podemos garantir 100% de segurança de seus dados. Se você tiver dúvidas envie um e-mail para studifyeducacao@gmail.com
                            </p>
                        </div>

                        <h5 class="fonteFina" style="margin-top: 40px;">DIVULGAÇÃO</h5>
                        <div class="marginLeftTermos">
                            <p class="textoJustificado">
                                1.	Studify pode utilizar terceiros prestadores de serviços para fornecer determinados serviços para você e nós podemos compartilhar informações pessoais com esses prestadores de serviços. Exigimos que qualquer empresa com a qual possamos compartilhar Informações Pessoais proteja os dados de uma forma consistente com essa política, e limite o uso de tais Informações Pessoais para o desempenho dos serviços da Studify.
                            </p>
                            <p class="textoJustificado">
                                2.	Studify pode divulgar Informações Pessoais em circunstâncias especiais, como para cumprir ordens judiciais obrigando-nos a fazê-lo ou quando suas ações violam os Termos de Serviço.
                            </p>

                            <p class="textoJustificado">
                                3.	Nós não vendemos ou fornecemos Informações Pessoais para outras empresas, para que elas façam o marketing dos seus próprios produtos ou serviços.
                            </p>
                            

                            <h6 class="fonteFina" style="margin-top: 40px;">O QUE SIGINFICA</h6>
                            <p class="textoJustificado">
                                Vamos armazenar suas informações confidenciais nos padrões da indústria. Porque as coisas acontecem, nós não podemos garantir 100% de segurança de seus dados. Se você tiver dúvidas envie um e-mail para studifyeducacao@gmail.com
                            </p>
                        </div>

                        <h5 class="fonteFina" style="margin-top: 40px;">ARMAZENAMENTO DE DADOS DO CLIENTE</h5>
                        <div class="marginLeftTermos">
                            <p class="textoJustificado">
                                Studify possui o armazenamento de dados, bancos de dados e todos os direitos da aplicação Studify, entretanto, não fazemos nenhuma reivindicação dos direitos dos seus dados. Você retém todos os direitos sobre os seus dados e nós nunca entraremos em contato com seus clientes diretamente, ou usaremos seus dados para a nossa própria vantagem comercial ou para competir com você, ou para divulgar para os seus clientes.
                            </p>
                            

                            <h6 class="fonteFina" style="margin-top: 40px;">O QUE SIGINFICA</h6>
                            <p class="textoJustificado">
                                Você possui seus dados e nós vamos respeitar isso. Não vamos tentar competir com você ou escrever para os seus clientes.
                            </p>
                        </div>

                        <h5 class="fonteFina" style="margin-top: 40px;">AVISO</h5>
                        <div class="marginLeftTermos">
                            <p class="textoJustificado">
                                Divulgações de conteúdo adulto em nossas aplicações são proibidas, caso este aviso seja desrespeitado o usuário será punido judicialmente, sendo desligado permanentemente da Studify.
                            </p>
                        </div>

                        <h5 class="fonteFina" style="margin-top: 40px;">ALTERAÇÕES A ESTA POLÍTICA DE PRIVACIDADE</h5>
                        <div class="marginLeftTermos">
                            <p class="textoJustificado">
                                Reservamos o direito de modificar esta declaração de privacidade a qualquer momento, portanto, revise-a frequentemente. Se fizermos alterações materiais a esta política, iremos notificá-lo aqui ou por meio de um aviso em nossa homepage, de modo que você está ciente das informações que coletamos como as usamos, e sob quais circunstâncias, se houver, as divulgamos.
                            </p>
                            

                            <h6 class="fonteFina" style="margin-top: 40px;">O QUE SIGINFICA</h6>
                            <p class="textoJustificado">
                                Podemos alterar esta Política de Privacidade. Se for uma grande mudança, iremos informá-lo, aqui.
                            </p>
                        </div>

                        <h5 class="fonteFina" style="margin-top: 40px;">PERGUNTAS</h5>
                        <div class="marginLeftTermos">
                            <p class="textoJustificado">
                                Quaisquer dúvidas sobre esta Política de Privacidade devem ser endereçadas a studify@gmail.com ou por correio para:
                            </p>
                            <p class="textoJustificado">
                                Av. Lins de Vasconcelos, 1.264 - Aclimação - São Paulo, SP.
                            </p>
                            <p class="textoJustificado">
                                Última Atualização em 01 de novembro de 2016.
                            </p>
                        </div>
                    </div>
                    <div class="row container rdbAceitarTermo">
                        <%--<asp:RadioButtonList ID="rdbTermosList" runat="server" ValidationGroup="teste">
                            <asp:ListItem>Eu li e aceito a política de privacidade da Studify.</asp:ListItem>
                        </asp:RadioButtonList>--%>
                        <asp:RadioButton ID="rdbTermos" runat="server" Text="Eu li e aceito a política de privacidade da Studify." CssClass="black-text " />
                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ErrorMessage="Favor aceitar os termos de segurança da Studify para concluir o cadastro." ControlToValidate="rdbTermos" ValidationGroup="teste" ValidateRequestMode="Enabled"></asp:RequiredFieldValidator>--%>
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="btnInfoSociais" runat="server" Text="FINALIZAR" CssClass="right btn teal waves-effect waves-light btnInfoSocial " OnClick="btnInfoSociais_Click" />
                        <a href="#!" class="modal-action modal-close deep-orange darken-1 white-text waves-effect waves-light btn ">CANCELAR</a>
                    </div>
                </div>
            </div>


            <!--RODAPÉ-->
            <footer class="page-footer footer grey darken-4" data-sticky-footer>
                <div class="container">
                    <div class="row divMarginRodapeCategorias">
                        <div class="col l3 m6 s12">
                            <h6 class="white-text"><b>CATEGORIAS</b></h6>
                            <ul class="rodape">
                                <li><a class="grey-text text-lighten-5" href="#!">
                                    <asp:Button ID="btnEnsinoFundamentalRodape" CssClass="btnMenu" runat="server" Text="Ensino Fundamental" PostBackUrl="~/paginasPesquisas/pesquisaProfessorFundamental.aspx" /></a></li>
                                <li><a class="grey-text text-lighten-5" href="#!">
                                    <asp:Button ID="btnEnsinoMedioRodape" CssClass="btnMenu" runat="server" Text="Ensino Médio" PostBackUrl="~/paginasPesquisas/pesquisaProfessorMedio.aspx" /></a></li>
                                <li><a class="grey-text text-lighten-5" href="#!">
                                    <asp:Button ID="btnPreVestibularRodape" runat="server" CssClass="btnMenu" Text="Pré-Vestibular" PostBackUrl="~/paginasPesquisas/pesquisaProfessorVestibular.aspx" /></a></li>
                                <li><a class="grey-text text-lighten-5" href="#!">
                                    <asp:Button ID="btnEnsinoTecnicoRodape" runat="server" Text="Ensino Técnico" CssClass="btnMenu" PostBackUrl="~/paginasPesquisas/pesquisaProfessorTecnico.aspx" /></a></li>
                                <li><a class="grey-text text-lighten-5" href="#!">
                                    <asp:Button ID="btnGraduacaoRodape" runat="server" Text="Graduação" CssClass="btnMenu" PostBackUrl="~/paginasPesquisas/pesquisaProfessorGraduacao.aspx" /></a></li>
                            </ul>
                        </div>
                        <div class="col l3 m6 s12">
                            <h6 class="white-text"><b>SUPORTE</b></h6>
                            <ul class="rodape">
                                <li><a class="grey-text text-lighten-3 modal-trigger" href="#modal4">Entre em contato</a></li>
                                <li><a class="grey-text text-lighten-3" href="../PerguntasFrequentes.aspx">Perguntas frequentes</a></li>
                                <li><a class="grey-text text-lighten-3" href="../PoliticaDeSeguranca.aspx">Política de segurança</a></li>
                            </ul>
                        </div>
                        <div class="col l6 s12">
                            <h6 class="white-text"><b>RECEBA NOTÍCIAS</b></h6>
                            <p class="white-text rodape">Envie seu email para receber novidades sobre o Studify.</p>
                            <div class="row divMarginRightRodape">
                                <div class="input-field col s8 white-text">
                                    <asp:TextBox ID="txtEmailRodape" CssClass="validate" runat="server" TextMode="Email"></asp:TextBox>
                                    <label for="txtEmailRodape">Digite seu email</label>
                                </div>
                                <div class=" col s4 left divMarginTopRodape">
                                    <asp:Button ID="btnCadastroEmail" runat="server" Text="Cadastrar" CssClass="btn waves-effect waves-light teal Cadastrar2" OnClick="btnCadastroEmail_Click" />
                                    <!--<a class="waves-effect waves-light btn teal">Cadastrar</a>-->
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
                <div class="footer-copyright">
                    <div class="container">
                        © 2016 Copyright. Todos os direitos reservados.
                    </div>
                </div>
            </footer>

            <!--Modal 4 - Entre em contato!-->
            <div id="modal4" class="modal modalLogin">
                <div class="modal-content">
                    <h2 class="titulo black-text center-align">Entre em contato!</h2>
                    <h4 class="subtitulo subM1 black-text center-align">Responderemos o mais rápido possível!</h4>

                    <div class="row left-align">
                        <div class="input-field col s12">
                            <asp:TextBox ID="TextBox2" CssClass="validate" runat="server"></asp:TextBox>
                            <label for="txtNomeEntreContato">Nome</label>
                        </div>
                    </div>

                    <div class="row left-align">
                        <div class="input-field col s12">
                            <asp:TextBox ID="TextBox3" CssClass="validate" runat="server" TextMode="Email"></asp:TextBox>
                            <label for="txtEmail">Email</label>
                        </div>
                    </div>

                    <div class="row left-align">
                        <div class="input-field col s12">
                            <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine" CssClass="materialize-textarea"></asp:TextBox>
                            <label for="txtMensagemEntreContato">Mensagem</label>

                        </div>
                    </div>

                    <div class="row center-align">
                        <asp:Button ID="btnEnviarContato" CssClass="waves-effect waves-light btn-large teal white-text" runat="server" Text="Enviar" OnClick="btnEnviarContato_Click" />
                    </div>

                </div>
            </div>

            <!--Modal 1 - Fazer Login-->
            <div id="modal1" class="modal modalLogin">
                <div class="modal-content">
                    <h2 class="titulo black-text center-align">Acesse sua conta!</h2>
                    <h4 class="subtitulo subM1 black-text center-align">obtenha resultados rápidos</h4>


                    <div class="row left-align">
                        <div class="input-field col s12">
                            <asp:TextBox ID="txtEmail" CssClass="validate" runat="server" TextMode="Email"></asp:TextBox>
                            <label for="txtEmail">Email</label>
                        </div>
                    </div>

                    <div class="row left-align">
                        <div class="input-field col s12">
                            <asp:TextBox ID="txtSenha" CssClass="validate" runat="server" TextMode="Password"></asp:TextBox>
                            <label for="txtSenha">Senha</label>
                        </div>
                    </div>

                    <div class="row center-align">
                        <asp:Button ID="btnLogar" CssClass="waves-effect waves-light btn-large teal white-text entrarM1" runat="server" Text="ENTRAR" OnClick="btnLogar_Click" />
                    </div>

                    <div class="row center-align">
                    <a href="EsqueciSenha.aspx" style="color:#f4511e;">Esqueceu a senha?</a>
                </div>

                </div>
            </div>

            <!--Modal 2 - Cadastre-se -->
            <div id="modal2" class="modal modal-cadastro">
                <div class="modal-content">
                    <h2 class="titulo center-align black-text">Cadastre-se agora!</h2>
                    <h5 class="fonteFina center-align black-text subtituloModal2">obtenha resultados rápidos</h5>
                    <div class="row">
                        <div class="col s12 m12 l5 offset-l1 center-align">
                            <a href="cadastroProfessor.aspx">
                                <img src="images/professor.png" height="303" width="auto" class="imgModal2" /></a>
                        </div>
                        <div class="col s12 m12 l5 center-align ">
                            <a href="cadastroAluno.aspx">
                                <img src="images/aluno.png" height="303" width="auto" class="imgModal2" /></a>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <a href="#!" class="modal-action modal-close deep-orange darken-1 white-text waves-effect waves-light btn-flat ">Voltar</a>
                    </div>
                </div>
            </div>



            <!--Modal 3 - Entre em contato!-->
            <div id="modal3" class="modal modalLogin">
                <div class="modal-content">
                    <h2 class="titulo black-text center-align">Entre em contato!</h2>
                    <h4 class="subtitulo subM1 black-text center-align">Responderemos o mais rápido possível!</h4>

                    <div class="row left-align">
                        <div class="input-field col s12">
                            <asp:TextBox ID="txtNomeEntreContato" CssClass="validate" runat="server"></asp:TextBox>
                            <label for="txtNomeEntreContato">Nome</label>
                        </div>
                    </div>

                    <div class="row left-align">
                        <div class="input-field col s12">
                            <asp:TextBox ID="txtEmailEntreContato" CssClass="validate" runat="server" TextMode="Email"></asp:TextBox>
                            <label for="txtEmail">Email</label>
                        </div>
                    </div>

                    <div class="row left-align">
                        <div class="input-field col s12">
                            <asp:TextBox ID="txtMensagemEntreContato" runat="server" TextMode="MultiLine" CssClass="materialize-textarea"></asp:TextBox>
                            <label for="txtMensagemEntreContato">Mensagem</label>

                        </div>
                    </div>

                    <div class="row center-align">
                        <asp:Button ID="Button2" CssClass="waves-effect waves-light btn-large teal white-text" runat="server" Text="Enviar" OnClick="btnLogar_Click" />
                    </div>

                </div>
            </div>


        </div>
    </form>
    <script src="materialize/js/jquery-1.12.4.min.js"></script>
    <script src="materialize/js/materialize.js"></script>
    <script src="materialize/js/main.js"></script>
    <script type="text/javascript">
        (function () {
            if (document.body.offsetHeight > window.innerHeight) {
                return;
            }

            var footer = document.querySelector('[data-sticky-footer]');
            var body = document.body;

            body.style.minHeight = '100vh';
            body.style.position = 'relative';
            footer.style.position = 'absolute';
            footer.style.bottom = '0';
            footer.style.left = '0';
            footer.style.right = '0';

            function accommodateFooter() {
                body.style.paddingBottom = footer.offsetHeight + 'px';
            }

            window.addEventListener('resize', accommodateFooter);

            accommodateFooter();
        })();
    </script>

</body>
</html>
