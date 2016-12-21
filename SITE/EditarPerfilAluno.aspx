<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditarPerfilAluno.aspx.cs" Inherits="EditarPerfilAluno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!--Import Google Icon Font-->
    <link href="http://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" />


    <!--Import materialize.css-->
    <link href="materialize/css/materialize.min.css" rel="stylesheet" media="screen,projection" />
    <link href="materialize/css/style.css" rel="stylesheet" media="screen,projection" />

    <!--Let browser know website is optimized for mobile-->
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

    <link rel="icon" href="images/logo-min.png" sizes="16x16" />
    <title>Editar perfil do aluno - Studify</title>
</head>
<body class="grey lighten-4">
    <form id="form1" runat="server">
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
                                    <asp:Button ID="btnEnsinoFundamental" CssClass="btnMenu" runat="server" Text="Ensino Fundamental" PostBackUrl="~/paginasPesquisas/pesquisaProfessorFundamental.aspx" />
                                    <asp:TextBox ID="txtEnsinoFundamental" runat="server">Ensino Fundamental</asp:TextBox>
                                </a>
                            </li>

                            <li class="fontColoredMenu">
                                <a href="#">
                                    <asp:Button ID="btnEnsinoMedio" CssClass="btnMenu" runat="server" Text="Ensino Médio" PostBackUrl="~/paginasPesquisas/pesquisaProfessorMedio.aspx" />
                                    <asp:TextBox ID="txtEnsinoMedio" runat="server">Ensino Médio</asp:TextBox>
                                </a>
                            </li>

                            <li class="fontColoredMenu">
                                <a href="#">
                                    <asp:Button ID="btnPreVestibular" runat="server" CssClass="btnMenu" Text="Pré-Vestibular" PostBackUrl="~/paginasPesquisas/pesquisaProfessorVestibular.aspx" />
                                    <asp:TextBox ID="txtPreVestibular" runat="server">Pré-Vestibular</asp:TextBox>
                                </a>
                            </li>

                            <li class="fontColoredMenu">
                                <a href="#">
                                    <asp:Button ID="btnEnsinoTecnico" runat="server" Text="Ensino Técnico" CssClass="btnMenu" PostBackUrl="~/paginasPesquisas/pesquisaProfessorTecnico.aspx" />
                                    <asp:TextBox ID="txtEnsinoTecnico" runat="server">Ensino Técnico</asp:TextBox>
                                </a>
                            </li>

                            <li class="fontColoredMenu">
                                <a href="#">
                                    <asp:Button ID="btnGraduacao" runat="server" Text="Graduação" CssClass="btnMenu" PostBackUrl="~/paginasPesquisas/pesquisaProfessorGraduacao.aspx" />
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
                                <asp:Button ID="btnEnsinoFundamentalMobile" CssClass="btnMenu" runat="server" Text="Ensino Fundamental" PostBackUrl="~/paginasPesquisas/pesquisaProfessorFundamental.aspx" />
                            </a>
                        </li>

                        <li>
                            <a href="#" class="waves-effect waves-blue">
                                <asp:Button ID="btnEnsinoMediolMobile" CssClass="btnMenu" runat="server" Text="Ensino Médio" PostBackUrl="~/paginasPesquisas/pesquisaProfessorMedio.aspx" />
                            </a>
                        </li>

                        <li>
                            <a href="#" class="waves-effect waves-blue">
                                <asp:Button ID="btnPreVestibularlMobile" CssClass="btnMenu" runat="server" Text="Pré-Vestibular" PostBackUrl="~/paginasPesquisas/pesquisaProfessorVestibular.aspx" />
                            </a>
                        </li>

                        <li>
                            <a href="#" class="waves-effect waves-blue">
                                <asp:Button ID="btnEnsinoTecnicoMobile" CssClass="btnMenu" runat="server" Text="Ensino Técnico" PostBackUrl="~/paginasPesquisas/pesquisaProfessorTecnico.aspx" />
                            </a>
                        </li>

                        <li>
                            <a href="#" class="waves-effect waves-blue">
                                <asp:Button ID="btnGraduacaoMobile" CssClass="btnMenu" runat="server" Text="Graduação" PostBackUrl="~/paginasPesquisas/pesquisaProfessorGraduacao.aspx" />
                            </a>
                        </li>

                    </ul>
                </div>
            </nav>

            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <asp:View ID="cadastroAlunoParte1" runat="server">
                    <div class="col s12 container card-panel-cadastro cardEditarPerfil">
                        <h2 class="titulo center-align black-text">Altere seus dados!</h2>
                        <h5 class="fonteFina center-align black-text subtituloModal2">fique sempre atualizado!</h5>
                        <div class="row">
                            <div class="input-field col l6 m12 s12 paddingEditCadastro">
                                <asp:TextBox ID="txtNomeCompleto" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtNomeCompleto">Nome Completo*</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="red-text" ErrorMessage="Campo obrigatório" ControlToValidate="txtNomeCompleto"></asp:RequiredFieldValidator>
                            </div>
                            <div class="input-field col l6 m12 s12 marginEditCadastro ddlEditDivs">
                                <asp:DropDownList ID="ddlSexo" CssClass="ddlSexo" runat="server">
                                    <asp:ListItem>Sexo*</asp:ListItem>
                                    <asp:ListItem data-icon="images/simbolo_homem.png" Class="left circle">Masculino</asp:ListItem>
                                    <asp:ListItem data-icon="images/simbolo_mulher.png" Class="left circle">Feminino</asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" CssClass="red-text" ErrorMessage="Obrigatório a seleção" ControlToValidate="ddlSexo" InitialValue="Sexo*"></asp:RequiredFieldValidator>
                            </div>

                        </div>
                        <div class="row">
                            <div class="input-field col l6 m12 s12 paddingEditCadastro">
                                <asp:TextBox ID="txtEmailCadastro" CssClass="validate" runat="server" TextMode="Email"></asp:TextBox>
                                <label for="txtEmailCadastro">Email*</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" CssClass="red-text" ErrorMessage="Campo obrigatório" ControlToValidate="txtEmailCadastro"></asp:RequiredFieldValidator>
                            </div>
                            <div class="input-field col l3 m6 s12 paddingEditCadastro">
                                <asp:TextBox ID="txtContato1" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtContato1">Contato 1*</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" CssClass="red-text" ErrorMessage="Campo obrigatório" ControlToValidate="txtContato1"></asp:RequiredFieldValidator>
                            </div>
                            <div class="input-field col l3 m6 s12 paddingEditCadastro">
                                <asp:TextBox ID="txtContato2" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtContato2">Contato 2</label>
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


                            <div class="input-field col l3 m6 s12 paddingEditCadastro">
                                <asp:TextBox ID="txtRG" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtRG">RG*</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" CssClass="red-text" ErrorMessage="Campo obrigatório" ControlToValidate="txtRG"></asp:RequiredFieldValidator>
                            </div>

                            <div class="input-field col l3 m6 s12 paddingEditCadastro">
                                <asp:TextBox ID="txtCEP" CssClass="validate" runat="server"></asp:TextBox>
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
                            <div class="input-field col l3 m6 s12 paddingEditCadastro">
                                <asp:TextBox ID="txtNumero" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtNumero">Número*</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" CssClass="red-text" ErrorMessage="Campo obrigatório" ControlToValidate="txtNumero"></asp:RequiredFieldValidator>
                            </div>
                            <div class="input-field col l3 m6 s12 paddingEditCadastro">
                                <asp:TextBox ID="txtComplemento" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtComplemento">Complemento</label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="input-field col l3 m4 s12 paddingEditCadastro">
                                <asp:TextBox ID="txtBairro" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtBairro">Bairro*</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" CssClass="red-text" ErrorMessage="Campo obrigatório" ControlToValidate="txtBairro"></asp:RequiredFieldValidator>
                            </div>

                            <div class="input-field col l3 m4 s12 paddingEditCadastro ddlEditDivs">
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

                            <div class="input-field col l6 m4 s12 paddingEditCadastro">
                                <asp:TextBox ID="txtCidade" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="cidade">Cidade*</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" CssClass="red-text" ErrorMessage="Campo obrigatório" ControlToValidate="txtCidade"></asp:RequiredFieldValidator>
                            </div>


                        </div>


                        <div class="row">
                            <div class="row">
                                <div class="input-field col l6 m6 s12 paddingEditCadastro fileUploadCadastro">
                                    <span class="labelImagemCadastro">Imagem do perfil</span>
                                    <asp:FileUpload ID="fileUploadImagem" runat="server" CssClass="" />
                                    <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
                                </div>

                                <div class="col l6 m6 s12 paddingEditCadastro marginTopBtnFinalizar">
                                    <asp:Button ID="btnEditarPerfilAluno" runat="server" Text="FINALIZAR" CssClass="btnFinalizar right btn teal waves-effect waves-light " OnClick="btnEditarPerfilAluno_Click" />
                                </div>
                            </div>
                        </div>
                </asp:View>
                <asp:View ID="cadastroAlunoParte2" runat="server">
                    <div class="col s12 container card-panel-cadastro">

                        <h5 class="fonteFina center-align black-text">Dados do responsável</h5>

                        <div class="row">
                            <div class="input-field col l6 m12 s12 paddingEditCadastro">
                                <asp:TextBox ID="txtNomeCompletoResponsavel" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtNomeCompletoResponsavel">Nome Completo do responsável*</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" CssClass="red-text" ErrorMessage="Campo obrigatório" ControlToValidate="txtNomeCompletoResponsavel"></asp:RequiredFieldValidator>
                            </div>
                            <div class="input-field col l6 m12 s12 marginEditCadastro ddlEditDivs">
                                <asp:DropDownList ID="ddlSexoResponsavel" CssClass="ddlSexo" runat="server">
                                    <asp:ListItem>Sexo do responsável*</asp:ListItem>
                                    <asp:ListItem data-icon="images/simbolo_homem.png" Class="left circle">Masculino</asp:ListItem>
                                    <asp:ListItem data-icon="images/simbolo_mulher.png" Class="left circle">Feminino</asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" CssClass="red-text" ErrorMessage="Obrigatório a seleção" ControlToValidate="ddlSexoResponsavel" InitialValue="Sexo*"></asp:RequiredFieldValidator>
                            </div>

                        </div>
                        <div class="row">
                            <div class="input-field col l6 m12 s12 paddingEditCadastro">
                                <asp:TextBox ID="txtEmailCadastroResponsavel" CssClass="validate" runat="server" TextMode="Email"></asp:TextBox>
                                <label for="txtEmailCadastroResponsavel">Email do responsável*</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" CssClass="red-text" ErrorMessage="Campo obrigatório" ControlToValidate="txtEmailCadastroResponsavel"></asp:RequiredFieldValidator>
                            </div>
                            <div class="input-field col l6 m12 s12 paddingEditCadastro">
                                <asp:TextBox ID="txtContatoResponsavel" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtContatoResponsavel">Contato do responsável*</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" CssClass="red-text" ErrorMessage="Campo obrigatório" ControlToValidate="txtContatoResponsavel"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="row">
                            <div class="input-field col l3 m12 s12 paddingEditCadastro">
                                <asp:TextBox ID="txtRgCadastroResponsavel" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtRgCadastroResponsavel">RG do responsável*</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" CssClass="red-text" ErrorMessage="Campo obrigatório" ControlToValidate="txtRgCadastroResponsavel"></asp:RequiredFieldValidator>
                            </div>
                            <div class="input-field col l3 m12 s12 paddingEditCadastro">
                                <asp:TextBox ID="txtCpfCadastroResponsavel" CssClass="validate" runat="server"></asp:TextBox>
                                <label for="txtCpfCadastroResponsavel">CPF do responsável*</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" CssClass="red-text" ErrorMessage="Campo obrigatório" ControlToValidate="txtCpfCadastroResponsavel"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col l6 m12 s12 paddingEditCadastro">
                                <asp:Button ID="FinalizarAluno" runat="server" Text="FINALIZAR" CssClass="btnFinalizar right btn teal waves-effect waves-light " OnClick="FinalizarAluno_Click" />
                            </div>
                        </div>
                    </div>

                </asp:View>
            </asp:MultiView>
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
                                <asp:Button ID="btnCadastroEmail" runat="server" Text="Cadastrar" CssClass="btn waves-effect waves-light teal Cadastrar2" />
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

        <!--Modal 7 - Entre em contato!-->
        <div id="modal7" class="modal modalLogin">
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
                    <asp:Button ID="btnEnviarContato" CssClass="waves-effect waves-light btn-large teal white-text" runat="server" Text="Enviar" />
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
