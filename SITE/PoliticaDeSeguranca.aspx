<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PoliticaDeSeguranca.aspx.cs" Inherits="PoliticaDeSeguranca" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Perguntas Frequentes - Studify</title>
    <!--Import Google Icon Font-->
    <link href="http://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" />


    <!--Import materialize.css-->
    <link href="materialize/css/materialize.min.css" rel="stylesheet" media="screen,projection" />
    <link href="materialize/css/style.css" rel="stylesheet" media="screen,projection" />

    <!--Let browser know website is optimized for mobile-->
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

    <link rel="icon" href="images/logo-min.png" sizes="16x16" />


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

            <div class="row container">
                <h2 class="titulo center-align black-text">Política de privacidade!</h2>
                <h5 class="fonteFina center-align black-text subtituloModal2">Conheça a nossa política!</h5>

                <ul class="collapsiblePerguntas collapsible" data-collapsible="expandable">
                    <li>
                        <div class="collapsible-header headerCollapsiblePerguntas headerCollapsiblePoliticaSeguranca white black-text">
                            1 - O que fazemos com as suas informações?
                        </div>
                        <div class="conteudoExpandablePerguntas collapsible-body white">
                            <p class="collapsibleContentPerguntas collapsiblePoliticaSeguranca">
                                1.	O termo “informações pessoais” usados aqui é definido como qualquer informação que identifica ou pode ser usada para identificar, contatar ou localizar a pessoa, a quem tal informação pertence. As informações pessoais que coletamos estarão sujeita a esta Política de Privacidade, a qual é alterada de tempos em tempos.
                                <br />
                                2.	Quando você se cadastra na Studify pedimos o seu endereço de e-mail.
                                <br />
                                3.	A Studify utiliza as informações que são coletadas para os seguintes propósitos gerais: fornecimento de serviços, identificação e autenticação, melhoria de serviços, contato e pesquisa.
                                <br />
                                4.	Ao aceitar nosso Acordo de Usuário, você concorda que, com respeito às Informações Pessoais de outros usuários que você obtém através da Studify ou através de uma comunicação relacionada da Studify ou transação facilitada do Studify, a Studify concede a você uma licença para utilizar tais informações apenas para comunicações relacionadas à Studify que não sejam mensagens comerciais não solicitadas. A Studify não tolera spam.
                                <br />
                                <br />
                                <span class="oquesignificaPolitica">O que significa?</span>
                                <br />
                                Quando você se cadastra, você fornece informações pessoais que coletamos e usamos. Apenas use as informações dos usuários da Studify para comunicações relacionadas à Studify, a menos que eles lhe permitam fazê-lo. Não faça spam para ninguém!
                            </p>
                        </div>
                    </li>

                    <li>
                        <div class="collapsible-header headerCollapsiblePerguntas headerCollapsiblePoliticaSeguranca2 white black-text">
                            2 - Segurança
                        </div>
                        <div class="conteudoExpandablePerguntas collapsible-body white">
                            <p class="collapsibleContentPerguntas collapsiblePoliticaSeguranca2">
                                A segurança de suas informações pessoais é importante para nós. Quando você insere informações confidenciais, tais como número do RG ou CPF em nosso formulário de inscrição, nós os matemos em segurança em nossos bancos de dados. Os dados Informados são armazenados e implementamos padrões adicionais geralmente aceitos da indústria, para proteger a informação pessoal que nos é submetida, tanto durante a transmissão quanto assim que a recebemos. Nenhum método de transmissão pela Internet, ou método de armazenamento eletrônico é 100% seguro. Portanto, enquanto nos esforçamos para utilizar meios comercialmente aceitáveis para proteger suas informações pessoais, não podemos garantir sua segurança absoluta. Se você tem dúvidas sobre a segurança em nosso Site, você pode enviar um e-mail para studify@gmail.com.
                                <br />
                                <br />
                                <span class="oquesignificaPolitica">O que significa?</span>
                                <br />
                                Vamos armazenar suas informações confidenciais nos padrões da indústria. Porque as coisas acontecem, nós não podemos garantir 100% de segurança de seus dados. Se você tiver dúvidas envie um e-mail para studify@gmail.com.
                            </p>
                        </div>
                    </li>

                    <li>
                        <div class="collapsible-header headerCollapsiblePerguntas headerCollapsiblePoliticaSeguranca white black-text">
                            3 - Divulgação
                        </div>
                        <div class="conteudoExpandablePerguntas collapsible-body white">
                            <p class="collapsibleContentPerguntas collapsiblePoliticaSeguranca">
                                1.	Studify pode utilizar terceiros prestadores de serviços para fornecer determinados serviços para você e nós podemos compartilhar informações pessoais com esses prestadores de serviços. Exigimos que qualquer empresa com a qual possamos compartilhar Informações Pessoais proteja os dados de uma forma consistente com essa política, e limite o uso de tais Informações Pessoais para o desempenho dos serviços da Studify.
                                <br />
                                2.	Studify pode divulgar Informações Pessoais em circunstâncias especiais, como para cumprir ordens judiciais obrigando-nos a fazê-lo ou quando suas ações violam os Termos de Serviço.
                                <br />
                                3.	Nós não vendemos ou fornecemos Informações Pessoais para outras empresas, para que elas façam o marketing dos seus próprios produtos ou serviços.

                                <br />
                                <br />
                                <span class="oquesignificaPolitica">O que significa?</span>
                                <br />
                                Em certas circunstâncias, podemos divulgar suas informações pessoais, como no caso de ordens judiciais.
                            </p>
                        </div>
                    </li>

                    <li>
                        <div class="collapsible-header headerCollapsiblePerguntas headerCollapsiblePoliticaSeguranca2 white black-text">
                            4 - Armazenamento de dados dos clientes
                        </div>
                        <div class="conteudoExpandablePerguntas collapsible-body white">
                            <p class="collapsibleContentPerguntas collapsiblePoliticaSeguranca2">
                                Studify possui o armazenamento de dados, bancos de dados e todos os direitos da aplicação Studify, entretanto, não fazemos nenhuma reivindicação dos direitos dos seus dados. Você retém todos os direitos sobre os seus dados e nós nunca entraremos em contato com seus clientes diretamente, ou usaremos seus dados para a nossa própria vantagem comercial ou para competir com você, ou para divulgar para os seus clientes.

                                <br />
                                <br />
                                <span class="oquesignificaPolitica">O que significa?</span>
                                <br />
                                Você possui seus dados e nós vamos respeitar isso. Não vamos tentar competir com você ou escrever para os seus clientes.
                            </p>
                        </div>
                    </li>

                    <li>
                        <div class="collapsible-header headerCollapsiblePerguntas headerCollapsiblePoliticaSeguranca white black-text">
                            5 - Aviso
                        </div>
                        <div class="conteudoExpandablePerguntas collapsible-body white">
                            <p class="collapsibleContentPerguntas collapsiblePoliticaSeguranca">
                                Divulgações de conteúdo adulto em nossas aplicações são proibidas, caso este aviso seja desrespeitado o usuário será punido judicialmente, sendo desligado permanentemente da Studify.
                            </p>
                        </div>
                    </li>

                    <li>
                        <div class="collapsible-header headerCollapsiblePerguntas headerCollapsiblePoliticaSeguranca2 white black-text">
                            6 - Alterações a esta política de privacidade
                        </div>
                        <div class="conteudoExpandablePerguntas collapsible-body white">
                            <p class="collapsibleContentPerguntas collapsiblePoliticaSeguranca2">
                                Reservamos o direito de modificar esta declaração de privacidade a qualquer momento, portanto, revise-a frequentemente. Se fizermos alterações materiais a esta política, iremos notificá-lo aqui ou por meio de um aviso em nossa homepage, de modo que você está ciente das informações que coletamos como as usamos, e sob quais circunstâncias, se houver, as divulgamos.

                                <br />
                                <br />
                                <span class="oquesignificaPolitica">O que significa?</span>
                                <br />
                                Podemos alterar esta Política de Privacidade. Se for uma grande mudança, iremos informá-lo, aqui.
                            </p>
                        </div>
                    </li>

                    <li>
                        <div class="collapsible-header headerCollapsiblePerguntas headerCollapsiblePoliticaSeguranca white black-text">
                            7 - Perguntas
                        </div>
                        <div class="conteudoExpandablePerguntas collapsible-body white">
                            <p class="collapsibleContentPerguntas collapsiblePoliticaSeguranca">
                                Quaisquer dúvidas sobre esta Política de Privacidade devem ser endereçadas a studify@gmail.com ou por correio para:
                                <br />
                                Av. Lins de Vasconcelos, 1.264 - Aclimação - São Paulo, SP.
                                <br />
                                Última Atualização em 01 de novembro de 2016.

                            </p>
                        </div>
                    </li>


                </ul>

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
                                <li><a class="grey-text text-lighten-3 modal-trigger" href="#modal3">Entre em contato</a></li>
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
                        <asp:Button ID="btnLogar" CssClass="waves-effect waves-light btn-large teal white-text entrarM1" runat="server" Text="ENTRAR" OnClick="btnLogar_Click1" />
                    </div>

                    <div class="row center-align">
                        <a href="EsqueciSenha.aspx" style="color: #f4511e;">Esqueceu a senha?</a>
                    </div>

                </div>
            </div>

            <!--Modal 2-->
            <div id="modal2" class="modal modal-cadastro">
                <div class="modal-content">
                    <h2 class="titulo center-align black-text">Cadastre-se agora!</h2>
                    <h5 class="fonteFina center-align black-text subtituloModal2">obtenha resultados rápidos</h5>
                    <div class="row">
                        <div class="col s12 m12 l5 offset-l1 center-align">
                            <a href="cadastroProfessor.aspx">
                                <img src="images/professor.png" height="303" class="imgModal2" /></a>
                        </div>
                        <div class="col s12 m12 l5 center-align ">
                            <a href="cadastroAluno.aspx">
                                <img src="images/aluno.png" height="303" class="imgModal2" /></a>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <a href="#!" class="modal-action modal-close deep-orange darken-1 white-text waves-effect waves-light btn-flat ">Voltar</a>
                    </div>
                </div>
            </div>

            <!--Modal 3-->
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
                        <asp:Button ID="btnEnviarContato" CssClass="waves-effect waves-light btn-large teal white-text" runat="server" Text="Enviar" OnClick="btnEnviarContato_Click" />
                    </div>

                </div>
            </div>

        </div>

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
    </form>
</body>
</html>
