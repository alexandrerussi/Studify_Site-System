<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<%--<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>--%>

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
    <title>Studify</title>

    <!--ANIMAÇÃO DE DIVS JQUERY-->
    <link href="animationDivs/animations.css" rel="stylesheet" />

    <!--VERTICAL TIMELINE-->
    <link href="timeline/css/style.css" rel="stylesheet" />
    <script src="timeline/js/modernizr.js"></script>


</head>
<body>
    <form id="form1" runat="server">
        <div>
            <header>
                <div class="banner">
                    <nav class="menuHome">
                        <div class="nav-wrapper containerMenu">
                            <div class="col s8 hide-on-med-and-down">
                                <ul>
                                    <li>
                                        <a href="#">
                                            <asp:Button ID="btnEnsinoFundamental" CssClass="btnMenu" runat="server" Text="Ensino Fundamental" PostBackUrl="~/paginasPesquisas/pesquisaProfessorFundamental.aspx" />
                                            <asp:TextBox ID="txtEnsinoFundamental" runat="server">Ensino Fundamental</asp:TextBox>
                                        </a>
                                    </li>

                                    <li class="">
                                        <a href="#">
                                            <asp:Button ID="btnEnsinoMedio" CssClass="btnMenu" runat="server" Text="Ensino Médio" PostBackUrl="~/paginasPesquisas/pesquisaProfessorMedio.aspx" />
                                            <asp:TextBox ID="txtEnsinoMedio" runat="server">Ensino Médio</asp:TextBox>
                                        </a>
                                    </li>

                                    <li class="">
                                        <a href="#">
                                            <asp:Button ID="btnPreVestibular" runat="server" CssClass="btnMenu" Text="Pré-Vestibular" PostBackUrl="~/paginasPesquisas/pesquisaProfessorVestibular.aspx" />
                                            <asp:TextBox ID="txtPreVestibular" runat="server">Pré-Vestibular</asp:TextBox>
                                        </a>
                                    </li>

                                    <li class="">
                                        <a href="#">
                                            <asp:Button ID="btnEnsinoTecnico" runat="server" Text="Ensino Técnico" CssClass="btnMenu" PostBackUrl="~/paginasPesquisas/pesquisaProfessorTecnico.aspx" />
                                            <asp:TextBox ID="txtEnsinoTecnico" runat="server">Ensino Técnico</asp:TextBox>
                                        </a>
                                    </li>

                                    <li class="">
                                        <a href="#">
                                            <asp:Button ID="btnGraduacao" runat="server" Text="Graduação" CssClass="btnMenu" PostBackUrl="~/paginasPesquisas/pesquisaProfessorGraduacao.aspx" />
                                            <asp:TextBox ID="txtGraduacao" runat="server">Graduação</asp:TextBox>
                                        </a>
                                    </li>
                                </ul>
                            </div>
                            <div class="col s4 hide-on-med-and-down right-align">
                                <asp:Label ID="lblUsuario" runat="server"></asp:Label>

                                <div class="col s12">
                                    <asp:DropDownList ID="ddlPerfil" CssClass="ddlPerfilHome" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlPerfil_SelectedIndexChanged">
                                        <asp:ListItem Value="Perfil" Class="left circle">Editar perfil</asp:ListItem>
                                        <asp:ListItem Value="Sair" Class="left circle">Sair</asp:ListItem>
                                    </asp:DropDownList>
                                </div>

                                <asp:Panel ID="Cadastro" runat="server">
                                    <a class="btn waves-effect waves-light deep-orange darken-1 modal-trigger" href="#modal1">LOGIN</a>
                                    <a class="btn waves-effect waves-light teal modal-trigger" href="#modal2">CADASTRO</a>
                                </asp:Panel>

                            </div>

                            <a href="#" data-activates="mobile-demo" class="button-collapse left marginMenu"><i class="material-icons">menu</i></a>
                            <ul class="side-nav" id="mobile-demo">
                                <li class="center-align"><a href="#">
                                    <img class="logo-img" src="images/logo.png" /></a></li>
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

                    <div class="middle-contentHome">
                        <div class="row container logoHomeDiv ">

                            <div class="col s12 center-align">
                                <a href="#">
                                    <img src="images/logo.png" class="logoHome slideUp" /></a>
                            </div>
                        </div>
                        <div class="row container">
                            <div class="col s12">
                                <h3 id="demo" class="tituloHome center-align">Encontre o melhor professor para você</h3>
                            </div>

                        </div>
                        <div class="row container divDropdowns">
                            <div class="col l6 m12 s12">
                                <asp:DropDownList ID="ddlNivelAcademico" CssClass="ddlHome" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlNivelAcademico_SelectedIndexChanged">
                                    <asp:ListItem Value="-1">Selecione o nível acadêmico</asp:ListItem>
                                    <asp:ListItem Value="Ensino Fundamental">Ensino Fundamental</asp:ListItem>
                                    <asp:ListItem Value="Ensino Médio">Ensino Médio</asp:ListItem>
                                    <asp:ListItem Value="Pré-Vestibular">Pré-Vestibular</asp:ListItem>
                                    <asp:ListItem Value="Ensino Técnico">Ensino Técnico</asp:ListItem>
                                    <asp:ListItem Value="Graduação">Graduação</asp:ListItem>
                                </asp:DropDownList>
                            </div>

                            <div class="col l6 m12 s12 divDdlMaterias">

                                <asp:ScriptManager ID="ScriptManager" runat="server"></asp:ScriptManager>

                                <asp:UpdatePanel ID="UpdatePanel" runat="server" UpdateMode="Conditional">
                                    <ContentTemplate>
                                        <asp:DropDownList ID="ddlMateria" CssClass="ddlHome" runat="server" AutoPostBack="true" AppendDataBoundItems="True">
                                            <asp:ListItem>Selecione a matéria</asp:ListItem>
                                        </asp:DropDownList>
                                    </ContentTemplate>
                                    <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="ddlNivelAcademico" EventName="SelectedIndexChanged" />
                                    </Triggers>
                                </asp:UpdatePanel>
                            </div>
                        </div>
                        <div class="row container">
                            <div class="col s12 center-align">
                                <asp:Button ID="btnPesquisarProf" runat="server" Text="Pesquisar professores" CssClass="btn waves-effect waves-light deep-orange darken-1 btnPesquisarProf" PostBackUrl="~/paginasPesquisas/pesquisaProfessor.aspx" />
                                <!--<button class="btn waves-effect waves-light deep-orange darken-1" type="submit" name="action">Pesquisar professores</button>-->
                            </div>
                        </div>
                    </div>
                </div>

            </header>
        </div>

        <img src="images/hexagono_icon_1.png" class="hexagonoIcon" />

        <!--PARTE 2-->
        <div class="parte2">
            <div class="row container">
                <section id="cd-timeline" class="cd-container">
                    <div class="cd-timeline-block">
                        <div class="cd-timeline-img cd-picture">
                            <img src="images/timeline/icones/search.png" />
                        </div>
                        <!-- cd-timeline-img -->
                        <div class="cd-timeline-content">
                            <h2 class="titleParte2">Encontre professores</h2>
                            <p class="textoJustificado">Na Studify, você encontra professores de diversas matérias, como, exatas, humanas, biológicas e até técnicas! Com a Studify você conseguirá a maior nota da turma e até a tão esperada vaga na universidade.</p>
                            <span class="cd-date">
                                <img src="images/timeline/ap_01.png" width="250" height="250" class="imgParte2" />
                            </span>
                        </div>
                        <!-- cd-timeline-content -->
                    </div>
                    <!-- cd-timeline-block -->
                    <div class="cd-timeline-block">
                        <div class="cd-timeline-img cd-movie">
                            <img src="images/timeline/icones/calendar.png" />
                        </div>
                        <!-- cd-timeline-img -->
                        <div class="cd-timeline-content">
                            <h2 class="titleParte2">Verifique a disponibilidade</h2>
                            <p class="textoJustificado">Encontre o melhor professor na hora que precisar de forma rápida, prática e simples. Pode também visualizar a agenda completa do professor!</p>
                            <span class="cd-date">
                                <img src="images/timeline/ap_02_2.png" width="250" height="250" class="imgParte2" />
                            </span>
                        </div>
                        <!-- cd-timeline-content -->
                    </div>
                    <!-- cd-timeline-block -->
                    <div class="cd-timeline-block">
                        <div class="cd-timeline-img cd-picture">
                            <img src="images/timeline/icones/star.png" />
                        </div>
                        <!-- cd-timeline-img -->
                        <div class="cd-timeline-content">
                            <h2 class="titleParte2">Avalie os professores</h2>
                            <p class="textoJustificado">Você pode avaliar os professores, podendo assim, ajudar outros alunos com a escolha dos melhores e mais capacitados professores.</p>
                            <span class="cd-date">
                                <img src="images/timeline/ap_03.png" width="250" height="250" class="imgParte2" />
                            </span>
                        </div>
                        <!-- cd-timeline-content -->
                    </div>
                    <!-- cd-timeline-block -->
                    <div class="cd-timeline-block">
                        <div class="cd-timeline-img cd-location">
                            <img src="images/timeline/icones/share.png" />
                        </div>
                        <!-- cd-timeline-img -->
                        <div class="cd-timeline-content">
                            <h2 class="titleParte2">Anuncie suas aulas na Studify</h2>
                            <p class="textoJustificado">Você professor que anunciar suas aulas na Studify, terá uma grande divulgação e aumentará o número de aulas, podendo aumentar sua renda significativamente. </p>
                            <span class="cd-date">
                                <img src="images/timeline/ap_04.png" width="250" height="250" class="imgParte2" />
                            </span>
                        </div>
                        <!-- cd-timeline-content -->
                    </div>
                    <!-- cd-timeline-block -->
                </section>
            </div>
        </div>

        <div class="parte3">
            <div class="hide-on-med-and-down">
                <div class="row">
                    <div class="col s12 m12 l12">
                        <h2 class="titulo white-text center-align">Algumas disciplinas lecionadas</h2>
                    </div>
                </div>
                <div class="row">
                    <div class="col s12 m12 l12">
                        <h4 class="subtitulo white-text center-align">Studify, mudando o conceito de aprender!</h4>
                    </div>
                </div>
                <div class="row container">
                    <div class="col s12">

                        <ul class="tabs">
                            <li class="tab col s2"><a href="#fund">Ensino Fundamental</a></li>
                            <li class="tab col s2"><a href="#medio">Ensino Médio</a></li>
                            <li class="tab col s2"><a class="active" href="#vestibular">Pré-Vestibular</a></li>
                            <li class="tab col s2"><a href="#tecnico">Ensino Técnico</a></li>
                            <li class="tab col s2"><a href="#graduacao">Graduação</a></li>
                        </ul>
                    </div>
                </div>

                <%--Texts para pesquisa parte3--%>
                <asp:TextBox ID="txtFund" runat="server">Ensino Fundamental</asp:TextBox>
                <asp:TextBox ID="txtMedio" runat="server">Ensino Médio</asp:TextBox>
                <asp:TextBox ID="txtVest" runat="server">Pré-Vestibular</asp:TextBox>
                <asp:TextBox ID="txtTec" runat="server">Ensino Técnico</asp:TextBox>
                <asp:TextBox ID="txtGrad" runat="server">Graduação</asp:TextBox>

                <asp:TextBox ID="txtMat" runat="server">Matemática</asp:TextBox>
                <asp:TextBox ID="txtPort" runat="server">Português</asp:TextBox>
                <asp:TextBox ID="txtCienc" runat="server">Ciências</asp:TextBox>
                <asp:TextBox ID="txtIng" runat="server">Inglês</asp:TextBox>
                <asp:TextBox ID="txtHist" runat="server">História</asp:TextBox>
                <asp:TextBox ID="txtGeo" runat="server">Geografia</asp:TextBox>
                <asp:TextBox ID="txtArtes" runat="server">Artes</asp:TextBox>
                <asp:TextBox ID="txtEsp" runat="server">Espanhol</asp:TextBox>
                <asp:TextBox ID="txtFis" runat="server">Física</asp:TextBox>
                <asp:TextBox ID="txtQui" runat="server">Química</asp:TextBox>
                <asp:TextBox ID="txtBio" runat="server">Biologia</asp:TextBox>
                <asp:TextBox ID="txtFilo" runat="server">Filosofia</asp:TextBox>
                <asp:TextBox ID="txtSocio" runat="server">Sociologia</asp:TextBox>

                <asp:TextBox ID="txtInfo" runat="server">Informática</asp:TextBox>
                <asp:TextBox ID="txtMark" runat="server">Marketing</asp:TextBox>
                <asp:TextBox ID="txtEnfermagem" runat="server">Enfermagem</asp:TextBox>
                <asp:TextBox ID="txtMeca" runat="server">Mecatrônica</asp:TextBox>
                <asp:TextBox ID="txtArtVis" runat="server">Artes Visuais</asp:TextBox>
                <asp:TextBox ID="txtNutri" runat="server">Nutrição</asp:TextBox>
                <asp:TextBox ID="txtEven" runat="server">Eventos</asp:TextBox>
                <asp:TextBox ID="txtBioComb" runat="server">Biocombustíveis</asp:TextBox>

                <asp:TextBox ID="txtEng" runat="server">Engenharia</asp:TextBox>
                <asp:TextBox ID="txtMed" runat="server">Medicina</asp:TextBox>
                <asp:TextBox ID="txtLetras" runat="server">Letras</asp:TextBox>
                <asp:TextBox ID="txtDir" runat="server">Direito</asp:TextBox>
                <asp:TextBox ID="txtCiencSoc" runat="server">Ciências sociais</asp:TextBox>
                <asp:TextBox ID="txtEco" runat="server">Econômia</asp:TextBox>
                <asp:TextBox ID="txtArq" runat="server">Arquitetura</asp:TextBox>

                <div class="row container">
                    <div class="col s12">
                        <div id="fund" class="col s12">
                            <div class="row">
                                <div class="col s3 center">
                                    <p class="center-align">
                                        <img class="iconeDisciplina" src="images/iconesMaterias/matematica.png" />
                                    </p>
                                    <p class="center-align textDisciplina">
                                        <a class="linkDisciplina" href="#">
                                            <asp:Button ID="btnFundMat" runat="server" Text="Matemática" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaFundMat.aspx" />
                                        </a>
                                    </p>
                                </div>
                                <div class="col s3 center">
                                    <p class="center-align">
                                        <img class="iconeDisciplina" src="images/iconesMaterias/portugues.png" />
                                    </p>
                                    <p class="center-align textDisciplina">
                                        <a class="linkDisciplina" href="#">
                                            <asp:Button ID="btnFundPort" runat="server" Text="Português" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaFundPort.aspx" />
                                        </a>
                                    </p>
                                </div>
                                <div class="col s3 center">
                                    <p class="center-align">
                                        <img class="iconeDisciplina" src="images/iconesMaterias/ciencias.png" />
                                    </p>
                                    <p class="center-align textDisciplina">
                                        <a class="linkDisciplina" href="#">
                                            <asp:Button ID="btnFundCienc" runat="server" Text="Ciências" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaFundCienc.aspx" />
                                        </a>
                                    </p>
                                </div>
                                <div class="col s3 center">
                                    <p class="center-align">
                                        <img class="iconeDisciplina" src="images/iconesMaterias/ingles.png" />
                                    </p>
                                    <p class="center-align textDisciplina">
                                        <a class="linkDisciplina" href="#">
                                            <asp:Button ID="btnFundIng" runat="server" Text="Inglês" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaFundIng.aspx" />
                                        </a>
                                    </p>
                                </div>

                            </div>

                            <div class="row">
                                <div class="col s3 center">
                                    <p class="center-align">
                                        <img class="iconeDisciplina" src="images/iconesMaterias/historia.png" />
                                    </p>
                                    <p class="center-align textDisciplina">
                                        <a class="linkDisciplina" href="#">
                                            <asp:Button ID="btnFundHist" runat="server" Text="História" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaFundHist.aspx" /></a>
                                    </p>
                                </div>
                                <div class="col s3 center">
                                    <p class="center-align">
                                        <img class="iconeDisciplina" src="images/iconesMaterias/geografia.png" />
                                    </p>
                                    <p class="center-align textDisciplina">
                                        <a class="linkDisciplina" href="#">
                                            <asp:Button ID="btnFundGeo" runat="server" Text="Geografia" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaFundGeo.aspx" /></a>
                                    </p>
                                </div>
                                <div class="col s3 center">
                                    <p class="center-align">
                                        <img class="iconeDisciplina" src="images/iconesMaterias/artes.png" />
                                    </p>
                                    <p class="center-align textDisciplina">
                                        <a class="linkDisciplina" href="#">
                                            <asp:Button ID="btnFundArtes" runat="server" Text="Artes" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaFundArtes.aspx" /></a>
                                    </p>
                                </div>
                                <div class="col s3 center">
                                    <p class="center-align">
                                        <img class="iconeDisciplina" src="images/iconesMaterias/espanhol.png" />
                                    </p>
                                    <p class="center-align textDisciplina">
                                        <a class="linkDisciplina" href="#">
                                            <asp:Button ID="btnFundEsp" runat="server" Text="Espanhol" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaFundEsp.aspx" /></a>
                                    </p>
                                </div>
                            </div>
                        </div>

                        <div id="medio" class="col s12">
                            <div class="row">
                                <div class="col s3 center">
                                    <p class="center-align">
                                        <img class="iconeDisciplina" src="images/iconesMaterias/matematica.png" />
                                    </p>
                                    <p class="center-align textDisciplina">
                                        <a class="linkDisciplina" href="#">
                                            <asp:Button ID="btnMedMat" runat="server" Text="Matemática" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaMedMat.aspx" />
                                        </a>
                                    </p>
                                </div>
                                <div class="col s3 center">
                                    <p class="center-align">
                                        <img class="iconeDisciplina" src="images/iconesMaterias/portugues.png" />
                                    </p>
                                    <p class="center-align textDisciplina">
                                        <a class="linkDisciplina" href="#">
                                            <asp:Button ID="btnMedPort" runat="server" Text="Português" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaMedPort.aspx" />
                                        </a>
                                    </p>
                                </div>
                                <div class="col s3 center">
                                    <p class="center-align">
                                        <img class="iconeDisciplina" src="images/iconesMaterias/fisica.png" />
                                    </p>
                                    <p class="center-align textDisciplina">
                                        <a class="linkDisciplina" href="#">
                                            <asp:Button ID="btnMedFis" runat="server" Text="Física" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaMedFis.aspx" />
                                        </a>
                                    </p>
                                </div>
                                <div class="col s3 center">
                                    <p class="center-align">
                                        <img class="iconeDisciplina" src="images/iconesMaterias/quimica.png" />
                                    </p>
                                    <p class="center-align textDisciplina">
                                        <a class="linkDisciplina" href="#">
                                            <asp:Button ID="btnMedQui" runat="server" Text="Química" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaMedQui.aspx" />
                                        </a>
                                    </p>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col s3 center">
                                    <p class="center-align">
                                        <img class="iconeDisciplina" src="images/iconesMaterias/biologia.png" />
                                    </p>
                                    <p class="center-align textDisciplina">
                                        <a class="linkDisciplina" href="#">
                                            <asp:Button ID="btnMedBio" runat="server" Text="Biologia" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaMedBio.aspx" />
                                        </a>
                                    </p>
                                </div>
                                <div class="col s3 center">
                                    <p class="center-align">
                                        <img class="iconeDisciplina" src="images/iconesMaterias/historia.png" />
                                    </p>
                                    <p class="center-align textDisciplina">
                                        <a class="linkDisciplina" href="#">
                                            <asp:Button ID="btnMedHist" runat="server" Text="História" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaMedHist.aspx" />
                                        </a>
                                    </p>
                                </div>
                                <div class="col s3 center">
                                    <p class="center-align">
                                        <img class="iconeDisciplina" src="images/iconesMaterias/filosofia.png" />
                                    </p>
                                    <p class="center-align textDisciplina">
                                        <a class="linkDisciplina" href="#">
                                            <asp:Button ID="btnMedFilo" runat="server" Text="Filosofia" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaMedFilo.aspx" />
                                        </a>
                                    </p>
                                </div>
                                <div class="col s3 center">
                                    <p class="center-align">
                                        <img class="iconeDisciplina" src="images/iconesMaterias/sociologia.png" />
                                    </p>
                                    <p class="center-align textDisciplina">
                                        <a class="linkDisciplina" href="#">
                                            <asp:Button ID="btnMedSocio" runat="server" Text="Sociologia" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaMedSocio.aspx" />
                                        </a>
                                    </p>
                                </div>
                            </div>
                        </div>

                        <div id="vestibular" class="col s12">
                            <div class="row">
                                <div class="col s3 center">
                                    <p class="center-align">
                                        <img class="iconeDisciplina" src="images/iconesMaterias/matematica.png" />
                                    </p>
                                    <p class="center-align textDisciplina">
                                        <a class="linkDisciplina" href="#">
                                            <asp:Button ID="btnVestMat" runat="server" Text="Matemática" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaVestMat.aspx" />
                                        </a>
                                    </p>
                                </div>
                                <div class="col s3 center">
                                    <p class="center-align">
                                        <img class="iconeDisciplina" src="images/iconesMaterias/portugues.png" />
                                    </p>
                                    <p class="center-align textDisciplina">
                                        <a class="linkDisciplina" href="#">
                                            <asp:Button ID="btnVestPort" runat="server" Text="Português" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaVestPort.aspx" />
                                        </a>
                                    </p>
                                </div>
                                <div class="col s3 center">
                                    <p class="center-align">
                                        <img class="iconeDisciplina" src="images/iconesMaterias/fisica.png" />
                                    </p>
                                    <p class="center-align textDisciplina">
                                        <a class="linkDisciplina" href="#">
                                            <asp:Button ID="btnVestFis" runat="server" Text="Física" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaVestFis.aspx" />
                                        </a>
                                    </p>
                                </div>
                                <div class="col s3 center">
                                    <p class="center-align">
                                        <img class="iconeDisciplina" src="images/iconesMaterias/quimica.png" />
                                    </p>
                                    <p class="center-align textDisciplina">
                                        <a class="linkDisciplina" href="#">
                                            <asp:Button ID="btnVestQui" runat="server" Text="Química" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaVestQui.aspx" />
                                        </a>
                                    </p>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col s3 center">
                                    <p class="center-align">
                                        <img class="iconeDisciplina" src="images/iconesMaterias/biologia.png" />
                                    </p>
                                    <p class="center-align textDisciplina">
                                        <a class="linkDisciplina" href="#">
                                            <asp:Button ID="btnVestBio" runat="server" Text="Biologia" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaVestBio.aspx" />
                                        </a>
                                    </p>
                                </div>
                                <div class="col s3 center">
                                    <p class="center-align">
                                        <img class="iconeDisciplina" src="images/iconesMaterias/historia.png" />
                                    </p>
                                    <p class="center-align textDisciplina">
                                        <a class="linkDisciplina" href="#">
                                            <asp:Button ID="btnVestHist" runat="server" Text="História" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaVestHist.aspx" />
                                        </a>
                                    </p>
                                </div>
                                <div class="col s3 center">
                                    <p class="center-align">
                                        <img class="iconeDisciplina" src="images/iconesMaterias/filosofia.png" />
                                    </p>
                                    <p class="center-align textDisciplina">
                                        <a class="linkDisciplina" href="#">
                                            <asp:Button ID="btnVestFilo" runat="server" Text="Filosofia" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaVestFilo.aspx" />
                                        </a>
                                    </p>
                                </div>
                                <div class="col s3 center">
                                    <p class="center-align">
                                        <img class="iconeDisciplina" src="images/iconesMaterias/sociologia.png" />
                                    </p>
                                    <p class="center-align textDisciplina">
                                        <a class="linkDisciplina" href="#">
                                            <asp:Button ID="btnVestSocio" runat="server" Text="Sociologia" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaVestSocio.aspx" />
                                        </a>
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div id="tecnico" class="col s12">
                        <div class="row">
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/ti.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnTecInfo" runat="server" Text="Informática" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaTecInfo.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/enfermagem.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnTecEnfermagem" runat="server" Text="Enfermagem" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaTecEnfermagem.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/marketing.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnTecMark" runat="server" Text="Marketing" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaTecMark.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/mecatronica.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnTecMeca" runat="server" Text="Mecatrônica" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaTecMeca.aspx" />
                                    </a>
                                </p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/artesVisuais.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnTecArtVis" runat="server" Text="Artes visuais" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaTecArtVis.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/alimentos.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnTecNutri" runat="server" Text="Nutrição" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaTecNutri.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/eventos.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnTecEven" runat="server" Text="Eventos" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaTecEven.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/biocombustiveis.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnTecBioComb" runat="server" Text="Biocombustíveis" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaTecBioComb.aspx" />
                                    </a>
                                </p>
                            </div>
                        </div>
                    </div>


                    <div id="graduacao" class="col s12">
                        <div class="row">
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/engenharias.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnGradEng" runat="server" Text="Engenharia" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaGradEng.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/medicina.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnGradMed" runat="server" Text="Medicina" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaGradMed.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/ingles.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnGradLetras" runat="server" Text="Letras" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaGradLetras.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/direito.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnGradDir" runat="server" Text="Direito" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaGradDir.aspx" />
                                    </a>
                                </p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/biologia.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnGradBio" runat="server" Text="Biologia" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaGradBio.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/sociologia.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnGradCiencSoc" runat="server" Text="Ciências Sociais" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaGradCiencSoc.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/economia.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnGradEco" runat="server" Text="Econômia" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaGradEco.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/arquitetura.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnGradArq" runat="server" Text="Arquitetura" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaGradArq.aspx" />
                                    </a>
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!--DISCIPLINAS MOBILE-->
        <div class="show-on-medium-and-down hide-on-large-only parte3">
            <div class="row">
                <div class="col s12 m12 l12">
                    <h2 class="titulo white-text center-align">Ranking dos melhores professores</h2>
                </div>
            </div>
            <div class="row">
                <div class="col s12 m12 l12">
                    <h4 class="subtitulo white-text center-align">Aprenda com os melhores, seja o melhor!</h4>
                </div>
            </div>

            <ul class="collapsible" data-collapsible="accordion">
                <li>
                    <div class="collapsible-header"><i class="material-icons">school</i>Ensino Fundamental</div>
                    <div class="collapsible-body">
                        <div class="row">
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/matematica.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnFundMatMob" runat="server" Text="Matemática" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaFundMat.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/portugues.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnFundPortMob" runat="server" Text="Português" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaFundPort.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/ciencias.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnFundCiencMob" runat="server" Text="Ciências" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaFundCienc.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/ingles.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnFundIngMob" runat="server" Text="Inglês" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaFundIng.aspx" />
                                    </a>
                                </p>
                            </div>

                        </div>

                        <div class="row">
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/historia.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnFundHistMob" runat="server" Text="História" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaFundHist.aspx" /></a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/geografia.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnFundGeoMob" runat="server" Text="Geografia" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaFundGeo.aspx" /></a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/artes.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnFundArtesMob" runat="server" Text="Artes" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaFundArtes.aspx" /></a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/espanhol.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnFundEspMob" runat="server" Text="Espanhol" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaFundEsp.aspx" /></a>
                                </p>
                            </div>
                        </div>
                    </div>
                </li>
                <li>
                    <div class="collapsible-header"><i class="material-icons">school</i>Ensino Médio</div>
                    <div class="collapsible-body">
                        <div class="row">
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/matematica.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnMedMatMob" runat="server" Text="Matemática" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaMedMat.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/portugues.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnMedPortMob" runat="server" Text="Português" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaMedPort.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/fisica.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnMedFisMob" runat="server" Text="Física" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaMedFis.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/quimica.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnMedQuiMob" runat="server" Text="Química" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaMedQui.aspx" />
                                    </a>
                                </p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/biologia.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnMedBioMob" runat="server" Text="Biologia" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaMedBio.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/historia.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnMedHistMob" runat="server" Text="História" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaMedHist.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/filosofia.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnMedFiloMob" runat="server" Text="Filosofia" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaMedFilo.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/sociologia.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnMedSocioMob" runat="server" Text="Sociologia" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaMedSocio.aspx" />
                                    </a>
                                </p>
                            </div>
                        </div>
                    </div>
                </li>
                <li>
                    <div class="collapsible-header"><i class="material-icons">school</i>Pré-Vestibular</div>
                    <div class="collapsible-body">
                        <div class="row">
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/matematica.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnVestMatMob" runat="server" Text="Matemática" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaVestMat.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/portugues.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnVestPortMob" runat="server" Text="Português" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaVestPort.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/fisica.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnVestFisMob" runat="server" Text="Física" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaVestFis.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/quimica.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnVestQuiMob" runat="server" Text="Química" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaVestQui.aspx" />
                                    </a>
                                </p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/biologia.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnVestBioMob" runat="server" Text="Biologia" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaVestBio.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/historia.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnVestHistMob" runat="server" Text="História" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaVestHist.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/filosofia.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnVestFiloMob" runat="server" Text="Filosofia" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaVestFilo.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/sociologia.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnVestSocioMob" runat="server" Text="Sociologia" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaVestSocio.aspx" />
                                    </a>
                                </p>
                            </div>
                        </div>
                    </div>
                </li>
                <li>
                    <div class="collapsible-header"><i class="material-icons">school</i>Ensino Técnico</div>
                    <div class="collapsible-body">
                        <div class="row">
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/ti.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnTecInfoMob" runat="server" Text="Informática" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaTecInfo.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/enfermagem.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnTecEnfermagemMob" runat="server" Text="Enfermagem" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaTecEnfermagem.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/marketing.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnTecMarkMob" runat="server" Text="Marketing" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaTecMark.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/mecatronica.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnTecMecaMob" runat="server" Text="Mecatrônica" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaTecMeca.aspx" />
                                    </a>
                                </p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/artesVisuais.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnTecArtVisMob" runat="server" Text="Artes visuais" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaTecArtVis.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/alimentos.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnTecNutriMob" runat="server" Text="Nutrição" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaTecNutri.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/eventos.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnTecEvenMob" runat="server" Text="Eventos" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaTecEven.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/biocombustiveis.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnTecBioCombMob" runat="server" Text="Biocombustíveis" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaTecBioComb.aspx" />
                                    </a>
                                </p>
                            </div>
                        </div>
                    </div>
                </li>
                <li>
                    <div class="collapsible-header"><i class="material-icons">school</i>Graduação</div>
                    <div class="collapsible-body">
                        <div class="row">
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/engenharias.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnGradEngMob" runat="server" Text="Engenharia" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaGradEng.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/medicina.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnGradMedMob" runat="server" Text="Medicina" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaGradMed.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/ingles.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnGradLetrasMob" runat="server" Text="Letras" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaGradLetras.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/direito.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnGradDirMob" runat="server" Text="Direito" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaGradDir.aspx" />
                                    </a>
                                </p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/biologia.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnGradBioMob" runat="server" Text="Biologia" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaGradBio.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/sociologia.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnGradCiencSocMob" runat="server" Text="Ciências Sociais" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaGradCiencSoc.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/economia.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnGradEcoMob" runat="server" Text="Econômia" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaGradEco.aspx" />
                                    </a>
                                </p>
                            </div>
                            <div class="col s3 center">
                                <p class="center-align">
                                    <img class="iconeDisciplina" src="images/iconesMaterias/arquitetura.png" />
                                </p>
                                <p class="center-align textDisciplina">
                                    <a class="linkDisciplina" href="#">
                                        <asp:Button ID="btnGradArqMob" runat="server" Text="Arquitetura" CssClass="fonteFina btnMenu" PostBackUrl="~/paginasPesquisasParte3/pesquisaGradArq.aspx" />
                                    </a>
                                </p>
                            </div>
                        </div>
                    </div>
                </li>
            </ul>
        </div>

        <!--DIV PARTE 4-->
        <div class="parte4">
            <div class="row container">
                <div class="col s12">
                    <h2 class="titulo white-text center-align effectSlideUp">Sempre aumentando!</h2>
                </div>
            </div>
            <div class="row container">
                <div class="col s12">
                    <h4 class="subtitulo white-text center-align effectSlideUp">Mais professores a cada dia!</h4>
                </div>
            </div>
            <div class="row lastRowP4 container effectSlideUp">
                <div class="col s6 m3 l3 center">
                    <asp:Label ID="lblNumEstudantes" runat="server" CssClass="deep-orange-text text-darken-1 center-align fonteGrossa lblParte4" Text="200"></asp:Label>
                    <h6 class="deep-orange-text text-darken-1 center-align fonteFina textinhoParte4">estudantes</h6>
                </div>

                <div class="col s6 m3 l3 center">
                    <asp:Label ID="lblNumProfessores" runat="server" CssClass="teal-text center-align fonteGrossa lblParte4" Text="70"></asp:Label>
                    <h6 class="teal-text center-align fonteFina textinhoParte4">professores</h6>
                </div>
                <div class="col s6 m3 l3 center">
                    <asp:Label ID="lblNumVideos" runat="server" CssClass="deep-orange-text text-darken-1 center-align fonteGrossa lblParte4" Text="50"></asp:Label>
                    <h6 class="deep-orange-text text-darken-1 center-align fonteFina textinhoParte4">vídeos</h6>
                </div>
                <div class="col s6 m3 l3 center">
                    <asp:Label ID="lblNumDownloads" runat="server" CssClass="teal-text center-align fonteGrossa lblParte4" Text="100"></asp:Label>
                    <h6 class="teal-text center-align fonteFina textinhoParte4">downloads</h6>
                </div>
            </div>
        </div>

        <!--DIV PARTE 5-->
        <div class="parte5">
            <div class="row container">
                <div class="col s12">
                    <h2 class="titulo center-align effectSlideUp">Cadastre-se agora!</h2>
                </div>
            </div>
            <div class="row container">
                <div class="col s12">
                    <h4 class="subtitulo center-align effectSlideUp">obtenha resultados rápidos</h4>
                </div>
            </div>
            <div class="row container">
                <div class="col s12 m12 l5 offset-l1 center-align">

                    <img src="images/professor.png" width="383" height="433" class="imgParte5 effectExpandUp" usemap="#mapaImgParte5Professor" />

                </div>
                <div class="col s12 m12 l5 center-align">
                    <img src="images/aluno.png" width="383" height="433" class="imgParte5 effectExpandUp " usemap="#mapaImgParte5Aluno" />
                </div>

                <map name="mapaImgParte5Professor">
                    <area class="mapaImgParte5Professor" shape="poly" coords="192,0,402,123,402,305,192,431,0,322,0,111" href="cadastroProfessor.aspx" />
                </map>

                <map name="mapaImgParte5Aluno">
                    <area shape="poly" coords="192,0,402,123,402,305,192,431,0,322,0,111" href="cadastroAluno.aspx" />
                </map>
            </div>
        </div>

        <!--DIV PARTE 6-->
        <div class="parte6">
            <div class="row container">
                <div class="col s12 m12 l5 fotoCelParte6 effectSlideUp">
                    <img src="images/celular.png" width="345" height="395" />
                </div>
                <div class="col s12 m12 l6 ContentPart6">
                    <h2 class="titulo white-text titleParte6 effectSlideUp">Studify no seu bolso!</h2>
                    <p class="textParte6 effectSlideUp">Agora você pode baixar nosso aplicativo e achar professores rapidamente. Faça o download nas lojas e deixe sua avaliação. Seja esperto, seja Studify!</p>
                    <div class="btnParte6 effectSlideUp">
                        <a href="https://play.google.com/store/apps/details?id=com.crieapp.studify&hl=pt_BR">
                            <img src="images/botaoGoogle.png" /></a>
                    </div>
                </div>
            </div>
        </div>

        <img src="images/hexagono_icon.png" class="hexagonoIcon" />

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

        <div id="sticky2" class="buscaFixedMobile hide-on-large-only">
            <a class="btnPesquisarMobileFixed modal-trigger" href="#modal3">
                <img src="images/search.png" class="btnPesquisarImgFixed" width="75" height="75" />
            </a>
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
                    <a href="EsqueciSenha.aspx" style="color: #f4511e;">Esqueceu a senha?</a>
                </div>

            </div>
        </div>

        <!--Modal 2- Cadastre-se -->
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

        <!--Modal 3 - Modal fixed on scroll mobile-->
        <div id="modal3" class="modal modalPesquisa deep-orange darken-1">
            <div class="modal-content">
                <div class="row container">
                    <div class="col s12">
                        <h4 id="demo1" class="tituloHome center-align">Encontre o melhor professor para você</h4>
                    </div>

                </div>
                <div class="row container">

                    <div class="col s12">
                        <asp:DropDownList ID="DropDownList3" CssClass="ddlHome" runat="server" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged" AutoPostBack="true">
                            <asp:ListItem Value="-1">Selecione o nível acadêmico</asp:ListItem>
                            <asp:ListItem Value="Ensino Fundamental">Ensino Fundamental</asp:ListItem>
                            <asp:ListItem Value="Ensino Médio">Ensino Médio</asp:ListItem>
                            <asp:ListItem Value="Pré-Vestibular">Pré-Vestibular</asp:ListItem>
                            <asp:ListItem Value="Ensino Técnico">Ensino Técnico</asp:ListItem>
                            <asp:ListItem Value="Graduação">Graduação</asp:ListItem>
                        </asp:DropDownList>
                    </div>

                    <div class="col s12 ">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                            <ContentTemplate>
                                <asp:DropDownList ID="DropDownList4" CssClass="ddlHome" runat="server" AppendDataBoundItems="true" AutoPostBack="true">
                                    <asp:ListItem>Selecione a matéria</asp:ListItem>
                                </asp:DropDownList>
                            </ContentTemplate>
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="DropDownList3" EventName="SelectedIndexChanged" />
                            </Triggers>
                        </asp:UpdatePanel>

                    </div>

                    <div class="col s12">
                        <asp:Button ID="Button1" runat="server" Text="Pesquisar professores" CssClass="btn waves-effect waves-light teal btnPesquisarProfFixed" PostBackUrl="~/paginasPesquisas/pesquisaProfessorScroll.aspx" />
                    </div>
                </div>

            </div>
        </div>

        <!--Modal 4 - Entre em contato!-->
        <div id="modal4" class="modal modalLogin">
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
                    <asp:Button ID="btnEnviarContato" CssClass="waves-effect waves-light btn-large teal white-text" runat="server" Text="Enviar" OnClick="btnEnviarContato_Click" />
                </div>

            </div>
        </div>



        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudifyConnectionString3 %>" SelectCommand="SELECT * FROM [Tb_Professor]"></asp:SqlDataSource>

        <!--VERTICAL TIMELINE-->
        <script src="materialize/js/jquery-1.12.4.min.js"></script>
        <script src="timeline/js/main.js"></script>


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


        <!--ANIMAÇÃO DE DIVS JQUERY-->
        <script src="animationDivs/animations.js"></script>


    </form>



</body>
</html>
