<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pesquisaVestFilo.aspx.cs" Inherits="repeaterProfessor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!--Import Google Icon Font-->
    <link href="http://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" />


    <!--Import materialize.css-->
    <link href="../materialize/css/materialize.min.css" rel="stylesheet" media="screen,projection" />
    <link href="../materialize/css/style.css" rel="stylesheet" media="screen,projection" />

    <!--Let browser know website is optimized for mobile-->
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

    <link rel="icon" href="../images/logo-min.png" sizes="16x16" />
    <title>Pesquisa de professores</title>
</head>
<body style="background-color: #f5f5f5;">
    <form id="form1" runat="server">
        <div>

            <nav class="teal darken-2">
                <div class="nav-wrapper containerColoredMenu row">
                    <div class="col s1 hide-on-med-and-down left-align">
                        <a href="../index.aspx">
                            <img class="logo-img-editCadastro" src="../images/logo.png" />
                        </a>
                    </div>
                    <a class="right hide-on-med-and-up show-on-medium-and-down marginLogoCadMobile" href="../index.aspx">
                        <img class="logo-img" src="../images/logo.png" />
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

            <!--AQUI ISRAEL, EU CHEGUEI A TENTAR COLOCAR DOIS DATA SOURCES, NÃO SEI SE FIZ ERRADO, MAS NÃO FUNCIONOU-->
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudifyConnectionString3 %>" SelectCommand="SELECT * FROM [Tb_Professor] WHERE (([Segmento_Professor] LIKE '%' + @Segmento_Professor + '%') AND ([Disciplina_Professor] LIKE '%' + @Disciplina_Professor + '%'))">
                <SelectParameters>
                    <asp:FormParameter FormField="txtVest" Name="Segmento_Professor" Type="String" />
                    <asp:FormParameter FormField="txtFilo" Name="Disciplina_Professor" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <div class="row marginBottomZero">
                <div class="col offset-l1 l3 m5 s12">
                    <div class="card grey lighten-5">
                        <div class="card-content black-text">
                            <div class="row">
                                <h5 class="fonteFina"><span class="fonteGrossa">Pesquisar </span>professor</h5>
                                <div class="row">
                                    <div class="col s12">
                                        <asp:DropDownList ID="ddlNivelAcademico" CssClass="ddlHome z-depth-1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlNivelAcademico_SelectedIndexChanged">
                                            <asp:ListItem Value="-1">Selecione o nível acadêmico</asp:ListItem>
                                            <asp:ListItem Value="Ensino Fundamental">Ensino Fundamental</asp:ListItem>
                                            <asp:ListItem Value="Ensino Médio">Ensino Médio</asp:ListItem>
                                            <asp:ListItem Value="Pré-Vestibular">Pré-Vestibular</asp:ListItem>
                                            <asp:ListItem Value="Ensino Técnico">Ensino Técnico</asp:ListItem>
                                            <asp:ListItem Value="Graduação">Graduação</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col s12 divDdlMaterias">
                                        <asp:ScriptManager ID="ScriptManager" runat="server"></asp:ScriptManager>

                                        <asp:UpdatePanel ID="UpdatePanel" runat="server" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="ddlMateria" CssClass="ddlHome z-depth-1" runat="server" AutoPostBack="true">
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
                                    <div class=" center-align">
                                        <asp:Button ID="btnPesquisarProfAside" runat="server" Text="Pesquisar" CssClass="btn waves-effect waves-light deep-orange darken-1 btnPesquisarProfessorAside col s12 " OnClick="btnPesquisarProf_Click" PostBackUrl="~/paginasPesquisas/pesquisaProfessor.aspx"/>
                                    </div>
                                </div>
                            </div>
                            <%--<div class="divider"></div>
                            <div class="row">
                                <h5 class="titleCardRepeatFiltro fonteFina"><span class="fonteGrossa">Faixa</span> de preço</h5>

                                <div class="col l2 m3 s3 alignDeAte">
                                    <span class="center-align">De</span>
                                </div>
                                <div class="col l4 m9 s9">
                                    <asp:TextBox ID="TextBox2" runat="server" CssClass="txtDeAteFaixa"></asp:TextBox>
                                </div>
                                <div class="col l2 m3 s3 alignDeAte">
                                    <span class="center-align">até</span>
                                </div>
                                <div class="col l4 m9 s9">
                                    <asp:TextBox ID="TextBox3" runat="server" CssClass="txtDeAteFaixa"></asp:TextBox>
                                </div>
                            </div>--%>
                        </div>
                    </div>
                </div>

                <div class="col l8 m7 s12">
                    <h4 class="fonteFina totalProfessoresEncontrados">Total de professores encontrados:
                        <asp:Label ID="lblTotal" runat="server" CssClass="fonteGrossa" Text=""></asp:Label></h4>
                    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1" OnItemDataBound="Repeater1_ItemDataBound">
                        <ItemTemplate>
                            <div class="row marginBottomZero">
                                <div class="col s12 m12 l12">
                                    <div class="card white left-align">
                                        <a href="../PerfilProfessor.aspx?codigo=<%#Eval("Id_Professor").ToString()%>">
                                            <div class="card-content black-text paddingEditCardRepeaterProf hoverable">
                                                <div class="row">

                                                    <div class="col l2 m12 s12 imgComentarioCol center-align">
                                                        <asp:Image runat="server" ID="imgProfessor" CssClass="circle imgComentario center-align" />
                                                        <asp:Label ID="lblCaminho" runat="server" Text='<%#Eval("Foto_Professor").ToString()%>' Visible="false"></asp:Label>
                                                    </div>

                                                    <div class="col l7 m12 s12">
                                                         <%--<asp:Label ID="Label1" runat="server" Text='<%#Eval("Id_Professor").ToString()%>' Visible="false"></asp:Label>--%>
                                                        <div class="linhaNomeProfessorPesquisa ">
                                                           
                                                            <asp:Label runat="server" CssClass="nomeComentario nomeProfessorPesquisa" Text='<%#Eval("Nome_Professor").ToString()%>'></asp:Label>
                                                        </div>

                                                        <div class="linhaMateriaProfessorPesquisa">
                                                            <asp:Label runat="server" CssClass="comentarioFeito materiaProfessorPesquisa" Text='<%#Eval("Disciplina_Professor").ToString()%>'></asp:Label>
                                                        </div>

                                                    </div>

                                                    <div class="col l3 m12 s12 noFreakingPadding">
                                                        <div class="row">

                                                            <div class="col l12 m12 s12 teal divValorAulaPesquisa">
                                                                <span class="valorAula">R$</span><asp:Label runat="server" CssClass="valorAula" Text='<%#Eval("Valor_Aula_Professor").ToString()%>'></asp:Label><span class="porHora">p/ hora</span>
                                                            </div>

                                                            <div class="col l12 m12 s12 center-align">
                                                                
                                                                <asp:Image ID="imgAvaliacaoCom" runat="server" CssClass="imgRepeaterProf"/>
                                                                <asp:Label ID="lblAvaliacaoImg" runat="server" Text='<%#Eval("Avaliacao_Professor").ToString()%>' Visible="false"></asp:Label>
                                                            </div>

                                                        </div>
                                                    </div>
                                                </div>

                                            </div>
                                        </a>
                                    </div>
                                </div>
                            </div>

                        </ItemTemplate>
                    </asp:Repeater>
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

            <!--Modal 2- Cadastre-se -->
            <div id="modal2" class="modal modal-cadastro">
                <div class="modal-content">
                    <h2 class="titulo center-align black-text">Cadastre-se agora!</h2>
                    <h5 class="fonteFina center-align black-text subtituloModal2">obtenha resultados rápidos</h5>
                    <div class="row">
                        <div class="col s12 m12 l5 offset-l1 center-align">
                            <a href="../cadastroProfessor.aspx">
                                <img src="../images/professor.png" height="303" width="auto" class="imgModal2" /></a>
                        </div>
                        <div class="col s12 m12 l5 center-align ">
                            <a href="../cadastroAluno.aspx">
                                <img src="../images/aluno.png" height="303" width="auto" class="imgModal2" /></a>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <a href="#!" class="modal-action modal-close deep-orange darken-1 white-text waves-effect waves-light btn-flat ">Voltar</a>
                    </div>
                </div>
            </div>

            <!--Modal 1-->
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
                        <a href="../EsqueciSenha.aspx" style="color: #f4511e;">Esqueceu a senha?</a>
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
        </div>
    </form>
    <script src="../materialize/js/jquery-1.12.4.min.js"></script>
    <script src="../materialize/js/materialize.js"></script>
    <script src="../materialize/js/main.js"></script>
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
