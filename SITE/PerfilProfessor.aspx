<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PerfilProfessor.aspx.cs" Inherits="PerfilProfessor" %>

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
    <title>Perfil professor - Studify</title>


</head>
<body class="grey lighten-4">
    <form id="form1" runat="server">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudifyConnectionString3 %>" SelectCommand="SELECT * FROM [Tb_Professor] WHERE ([Id_Professor] = @Id_Professor)">
            <SelectParameters>
                <asp:QueryStringParameter Name="Id_Professor" QueryStringField="codigo" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>


        <div>
            <header>

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



            </header>


            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1" OnItemDataBound="Repeater1_ItemDataBound1">
                <ItemTemplate>
                    <%--<!--INICIANDO SCRIPT PARA STARS RATING-->
                            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>--%>
                    <div class="row marginPerfil">
                        <div class="col s12">
                            <div class="card backImagePerfil">
                                <div class="card-content black-text ">
                                    <div class="row">
                                        <div class="col l12 m12 s12">


                                            <div class="col l2 m2 s2">


                                                <img src="<%#Eval("Foto_Professor").ToString()%>" class="imgPerfilProf circle" />
                                                <%--<asp:Image runat="server" ID="professor" ImageUrl='<%#Eval("Foto_Professor").ToString()%>' CssClass="" />--%>
                                                <%--<asp:Image ID="FotoProf" runat="server" ImageUrl='' />--%>
                                            </div>

                                            <div class="col l6 m5 s4 titlePerfil">
                                                <%--<h3 class="white-text tituloPerfil">Alexandre Russi Junior</h3>--%>
                                                <div class="row marginBottomZero">
                                                    <asp:Label ID="Label1" CssClass="white-text tituloPerfil" runat="server" Text='<%#Eval("Nome_Professor").ToString()%>'></asp:Label>
                                                </div>
                                                <div class="row">
                                                    <asp:Label ID="Label2" CssClass="white-text subtituloPerfil" runat="server" Text='<%#Eval("Disciplina_Professor").ToString()%>'></asp:Label>
                                                </div>
                                            </div>

                                            <div class="col l4 m5 s6 ratingsPerfil">
                                                <%--<img src="images/starsrating/4,5.png" class="estrelaProfile" />
                                        
                                        <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
                                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>--%>
                                                <%--<asp:Image ID="imgAvalia" runat="server" ImageUrl="C:/Studify/Site/Studify_SITE57/images/starsrating/0.png" CssClass="estrelaProfile" />--%>

                                                <asp:Image ID="Image1" runat="server" CssClass="estrelaProfile" />

                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>


                    <div class="marginPerfil">
                        <div class="row">
                            <div class="col l8 m12 s12">
                                <div class="card white">
                                    <div class="card-content black-text">
                                        <span class="card-title cardTitulo">Video de apresentação</span>
                                        <p class="center">
                                            <br />
                                            <object width="90%" height="500px">
                                                <param name="movie" value='<%#DataBinder.Eval(Container.DataItem, "Video_Professor") %>'></param>
                                                <param name="allowFullScreen" value="true"></param>
                                                <param name="allowscriptaccess" value="always"></param>
                                                <embed src='<%#DataBinder.Eval(Container.DataItem, "Video_Professor") %>' type="application/x-shockwave-flash" frameborder="0" allowscriptaccess="always" allowfullscreen="true" width="90%" height="500px">
                                                </embed>
                                            </object>
                                        </p>
                                    </div>
                                </div>
                            </div>

                            <div class="col l4 m12 s12">
                                <div class="card white left-align">
                                    <div class="card-content black-text">
                                        <span class="card-title cardTitulo">Qualificações</span>
                                        <p class="cardText readToggle2">
                                            <%--<b>Nível Acadêmico</b>
                                            <br />
                                            <b>Graduação:</b> Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                                    <br />
                                            <b>Ensino Médio:</b> Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eu.
                                    <br />
                                            <b>Pós-Graduação:</b> Lorem ipsum dolor sit amet, adipiscing elit. Curabitur eu.
                                        </p>
                                        <a class="modal-trigger leiaMais" href="#modal5">Expandir</a>--%>
                                            <asp:Label ID="Label3" runat="server" Text='<%#Eval("Formacao_Professor").ToString()%>'></asp:Label>
                                    </div>
                                </div>
                            </div>

                            <div class="col l4 m12 s12">
                                <div class="card white left-align">
                                    <div class="card-content black-text">
                                        <span class="card-title cardTitulo">Contatos</span>
                                        <p class="cardText">
                                            <div class="row">
                                                <div class="col l3 m3 s6 center-align">
                                                    <a href='<%#Eval("Facebook_Professor").ToString()%>' class="linksSociais" target="_blank">
                                                        <img src="images/facebook.png" class="imgContatosPerfil" />
                                                        <p class="legendaVerContatos center-align">Facebook</p>
                                                    </a>
                                                </div>
                                                <div class="col l3 m3 s6  center-align">
                                                    <a class="linksSociais tooltipped" data-position="bottom" data-delay="150" data-tooltip='<%#Eval("Skype_Professor").ToString()%>'>
                                                        <img src="images/skype.png" class="imgContatosPerfil" />
                                                        <p class="legendaVerContatos center-align">Skype</p>
                                                    </a>
                                                </div>
                                                <div class="col l3 m3 s6 center-align">
                                                    <a href='<%#Eval("Youtube_Professor").ToString()%>' class="linksSociais" target="_blank">
                                                        <img src="images/youtube.png" class="imgContatosPerfil" />
                                                        <p class="legendaVerContatos center-align">Youtube</p>
                                                    </a>
                                                </div>
                                                <div class="col l3 m3 s6 center-align">
                                                    <a href='<%#Eval("Linkedin_Professor").ToString()%>' class="linksSociais" target="_blank">
                                                        <img src="images/linkedin.png" class="imgContatosPerfil" />
                                                        <p class="legendaVerContatos center-align">Linkedin</p>
                                                    </a>
                                                </div>
                                            </div>
                                            <div class="row">
                                                <div class="col s12 m6 l6 alignTelefoneVerContatos1">
                                                    <img src="images/phone.png" class="imgTelefoneVerContatos" />
                                                    <asp:Label ID="telefoneVerContatos" runat="server" CssClass="telefoneVerContatos" Text='<%#Eval("Contato1_Professor").ToString()%>'></asp:Label>
                                                </div>
                                                <div class="col s12 m6 l6 alignTelefoneVerContatos2">
                                                    <img src="images/phone.png" class="imgTelefoneVerContatos" />
                                                    <asp:Label ID="telefoneVerContatos2" runat="server" CssClass="telefoneVerContatos" Text='<%#Eval("Contato2_Professor").ToString()%>'></asp:Label>
                                                </div>
                                            </div>
                                        </p>
                                    </div>
                                </div>
                            </div>


                        </div>

                        <div class="row">
                            <div class="col l8 m12 s12">
                                <div class="card white left-align heightPerfilLine2">
                                    <div class="card-content black-text">
                                        <span class="card-title cardTitulo">Descrição</span>
                                        <p class="cardText readToggle1">
                                            <asp:Label ID="Label5" runat="server" Text='<%#Eval("Descricao_Professor").ToString()%>'></asp:Label>
                                        </p>
                                        <a class="modal-trigger leiaMais" href="#modal3">Expandir</a>
                                    </div>

                                </div>
                            </div>

                            <div class="col l4 m12 s12">

                                <div class="card white left-align heightPerfilLine2">

                                    <p class="precoPerfil teal white-text center-align">
                                        R$ <b class="numeroPrecoPerfil">
                                            <asp:Label ID="Label6" runat="server" Text='<%#Eval("Valor_Aula_Professor").ToString()%>'></asp:Label></b> por hora
                                    </p>
                                    <p class="center-align"><a class="btn waves-effect waves-light deep-orange darken-1 btnAgendarPerfil  modal-trigger" href="#modalAgenda">AGENDA</a></p>


                                </div>
                            </div>
                        </div>
                        <!--Modal 3 - Descrição-->
                        <div id="modal3" class="modal modalPerfilProf">
                            <div class="modal-content">
                                <div class="black-text">
                                    <span class="card-title cardTitulo">Descrição</span>
                                    <p class="cardText">
                                        <asp:Label ID="exibirDescricao" runat="server" Text='<%#Eval("Descricao_Professor").ToString()%>'></asp:Label>
                                    </p>
                                </div>
                            </div>
                        </div>
                        </ItemTemplate>
                    </asp:Repeater>
                    <div class="row">
                        <div class="col s12">
                            <h5 class="tituloComentarios center-align">Comentários sobre o professor:</h5>
                        </div>
                    </div>
                    <asp:Repeater ID="RepeaterComentario" runat="server" DataSourceID="SqlDataSource2" OnItemDataBound="RepeaterComentario_ItemDataBound">
                        <ItemTemplate>
                            <div class="row">
                                <div class="col s12">
                                    <div class="card white left-align">
                                        <div class="card-content black-text">
                                            <div class="row">

                                                <div class="col l1 m12 s12 imgComentarioCol">
                                                    <img src='<%#Eval("Img_Perfil").ToString()%>' class="circle imgComentario center-align" />
                                                </div>

                                                <div class="col l8 m12 s12 comentCol">
                                                    <h6 class="nomeComentario">
                                                        <asp:Label ID="Label4" runat="server" Text='<%#Eval("Nome_Aluno").ToString()%>'></asp:Label>
                                                    </h6>
                                                    <p class="comentarioFeito">
                                                        <asp:Label ID="Label6" runat="server" Text='<%#Eval("Comentario").ToString()%>'></asp:Label>
                                                    </p>
                                                </div>

                                                <div class="col l3 m12 s12 ratingsComentario">
                                                    <h6 class="legendaRating center-align">
                                                        <asp:Label ID="lblAvaliacao" runat="server" Text='<%#Eval("Avaliacao").ToString()%>' Visible="false"></asp:Label>
                                                    </h6>

                                                    <div class="vote votoComentario center-align">
                                                        <div class="center-align">
                                                            <asp:Image ID="imgAvaliacaoCom" runat="server" CssClass="estrelaComentProfile" />
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:StudifyConnectionString3 %>" SelectCommand="SELECT * FROM [Tb_Comentario] WHERE ([Id_Professor] = @Id_Professor)">
                        <SelectParameters>
                            <asp:QueryStringParameter Name="Id_Professor" QueryStringField="codigo" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>

                    <asp:Panel ID="pnFacaLogin" runat="server">
                        <div class="row">
                            <div class="col s12">
                                <h5 class="tituloComentarios center-align">Faça login ou cadastre-se para enviar um comentário</h5>
                                <br />
                                <br />
                            </div>
                        </div>
                    </asp:Panel>

                    <asp:Panel ID="pnEnviarCom" runat="server">
                        <div class="row">
                            <div class="col s12">
                                <h5 class="tituloComentarios center-align">Deixe um comentário o professor:</h5>
                            </div>
                        </div>



                        <div class="row">
                            <div class="col s12">
                                <div class="card white left-align">
                                    <div class="card-content black-text">
                                        <div class="row">


                                            <div class="col l1 m12 s12 center-align marginTop10">
                                                <%--<img src="images/oi2.jpg" class="circle imgComentario center-align" />--%>
                                                <asp:Image ID="ImgPerfil" class="circle imgComentario center-align" runat="server" />
                                            </div>
                                            <%-- A parte do comentario começa aqui --%>
                                            <div class="col l8 m12 s12 marginTop30">
                                                <div class="input-field col s12 inputComentario">
                                                    <asp:TextBox ID="txtComentario" runat="server" CssClass="materialize-textarea" TextMode="MultiLine"></asp:TextBox>
                                                    <label for="txtComentario" class="labelTextarea">Comente aqui</label>
                                                </div>
                                            </div>

                                            <div class="col l3 m12 s12 ratingsComentario">
                                                <h6 class="legendaRating center-align">Avalie o professor</h6>

                                                <div class="center-align">
                                                    <asp:DropDownList ID="ddlAvaliarComentario" CssClass="ddlAvaliarComentario" runat="server">

                                                        <asp:ListItem Value="0">0/5</asp:ListItem>
                                                        <asp:ListItem Value="1">1/5</asp:ListItem>
                                                        <asp:ListItem Value="2">2/5</asp:ListItem>
                                                        <asp:ListItem Value="3">3/5</asp:ListItem>
                                                        <asp:ListItem Value="4">4/5</asp:ListItem>
                                                        <asp:ListItem Value="5">5/5</asp:ListItem>
                                                    </asp:DropDownList>
                                                </div>

                                                <asp:Button ID="ButtonEnviarComentario" runat="server" Text="Enviar comentário" CssClass="btn waves-effect waves-light teal btnComentar center-align" OnClick="ButtonEnviarComentario_Click" />
                                            </div>

                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>
                    </asp:Panel>

                    <asp:Repeater ID="RepeaterAgenda" runat="server" DataSourceID="SqlDataSource3">
                        <ItemTemplate>
                            <div id="modalAgenda" class="modal modalLogin">
                                <div class="modal-content">
                                    <h3 class="titulo black-text center-align">Horários disponíveis do professor!</h3>


                                    <div class="row center-align">
                                        <h5 class="fonteFina">Dias da semana:</h5>
                                        <asp:Label ID="Dia" runat="server" CssClass="fonteFina fonteAgenda" Text='<%#Eval("Dia").ToString()%>'></asp:Label>
                            
                                    </div>

                                    <div class="row center-align">
                                        <h5 class="fonteFina">Manhã:</h5>
                                        <asp:Label ID="Horario" runat="server" CssClass="fonteFina fonteAgenda" Text='<%#Eval("Manha").ToString()%>'></asp:Label>
                                    </div>

                                    <div class="row center-align">
                                        <h5 class="fonteFina">Tarde:</h5>
                                        <asp:Label ID="Label7" runat="server" CssClass="fonteFina fonteAgenda" Text='<%#Eval("Tarde").ToString()%>'></asp:Label>
                                    </div>

                                    <div class="row center-align">
                                        <h5 class="fonteFina">Noite:</h5>
                                        <asp:Label ID="Label8" runat="server" CssClass="fonteFina fonteAgenda" Text='<%#Eval("Noite").ToString()%>'></asp:Label>
                                    </div>

                                </div>
                            </div>

                        </ItemTemplate>
                    </asp:Repeater>
                    <!--Modal 1 - Fazer Login-->

                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:StudifyConnectionString3 %>" SelectCommand="SELECT * FROM [Agenda] WHERE ([Id_Professor] = @Id_Professor)">
                        <SelectParameters>
                            <asp:QueryStringParameter Name="Id_Professor" QueryStringField="codigo" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
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
                                    <li><a class="grey-text text-lighten-3 modal-trigger" href="#modal7">Entre em contato</a></li>
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

                <!--Modal 3 - Descrição-->
                <%--<div id="modal3" class="modal modalPerfilProf">
                    <div class="modal-content">
                        <div class="black-text">
                            <span class="card-title cardTitulo">Descrição</span>
                            <p class="cardText">
                                <asp:Label ID="exibirDescricao" runat="server" Text='<%#Eval("Descricao_Professor").ToString()%>'></asp:Label>
                            </p>
                        </div>
                    </div>
                </div>--%>

                <!--Modal 4 - Experiência-->
                <div id="modal4" class="modal modalPerfilProf">
                    <div class="modal-content">
                        <div class="card-content black-text">
                            <span class="card-title cardTitulo">Experiência</span>
                            <p class="cardText">
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque molestie porta justo, eu dignissim urna gravida nec. Aliquam vitae orci non neque interdum finibus sed in eros. Suspendisse euismod et urna non sodales. Duis mattis, justo laoreet rutrum aliquet, arcu est tempus eros, ac efficitur lorem justo sit amet ligula. 
                            </p>
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
                            <asp:Button ID="btnEnviarContato" CssClass="waves-effect waves-light btn-large teal white-text" runat="server" Text="Enviar" OnClick="btnEnviarContato_Click" />
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

