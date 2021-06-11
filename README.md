# Projeto E-commerce Em Casa Com Estilo 
 Projeto final da faculdade

Banco de Dados MySql - script - ecce.sql
Backend Asp .Net Core 3.1
Frontend Jquery e Ajax


E-commerce: Em casa com estilo
Daniel Leandro Toguti, Elizeu Francisco da Silva Junior, Igor Vieira de Cerqueira, Kaique Domingues de Freitas, Raphael Santos Catalano, Suellen Brunelli, Vanessa Aparecida Borella 
Orientador: Professor Esp. Victor Williams Stafusa da Silva
Faculdade Impacta de Tecnologia
São Paulo, SP, Brasil
10 de junho de 2021
Resumo. A loja virtual Em Casa Com Estilo (ECCE) surgiu após a queda abrupta do faturamento da empresa, devido às atuais condições de saúde no Brasil, ocasionada pela crise pandêmica do coronavírus (COVID-19). A companhia foi gravemente afetada pelas restrições do atendimento presencial impostas pelos governos estaduais e teve prejuízos significativos, chegando a níveis de cortes essenciais em diversas áreas, principalmente em recursos humanos, com o intuito de tentar amenizar a crise e evitar o pedido de falência, como foi o destino de muitas empresas durante a pandemia. A busca pelo desenvolvimento do site foi uma iniciativa inovadora, com os objetivos da loja virtual para que, mesmo com as restrições físicas do estabelecimento, pudessem recuperar as vendas, conquistar novos clientes, novo público e com a comodidade do atendimento on-line de forma simples, dinâmica e eficiente.
Palavras-chave: Loja virtual, desenvolvimento do sistema, banco de dados.
1. Introdução
A alta procura por software/aplicações que atendam a demanda exigida pelo mercado, influencia diretamente na competitividade entre as empresas que são desenvolvedoras. Desenvolver sistemas com qualidade e dentro do prazo previamente estabelecido tem sido um grande desafio. O projeto completo foi desenvolvido em busca de conceitos, práticas e ferramentas para desenvolvimento de sistema no método e-commerce. A ideia deste projeto surgiu diante do cenário que estamos enfrentando atualmente, com medidas restritivas de funcionalidade física dos comércios, onde o objetivo da empresa: “Em Casa Com Estilo” é produzir pijamas que, necessariamente, não tenham “cara” de pijamas e que transmitam bem-estar aos clientes, seja na hora de dormir, para ficar em casa ou até mesmo no dia a dia de trabalho home office, sempre superando os modelos antiquados tradicionais existentes no mercado. Por isso a empresa dispõe de modelos versáteis, que prezam pela melhor experiência de compra, procurando oferecer a melhor qualidade de tecidos, e, sendo assim, resultando em peças que cumpram com a necessidade e satisfação dos clientes e com um dos detalhes mais importantes que é a compra on-line, no conforto da sua casa.
Missão: Oferecer uma sensação de bem-estar através de pijamas confortáveis, modernos e de qualidade para a família e pessoas de todas as idades.
Visão: Ser uma empresa com atendimento on-line, reconhecida nacionalmente pela qualidade e inovação de nossos produtos no mercado de pijamas; buscando a máxima organização e eficiência do setor operacional e estratégico, utilizando mão-de-obra qualificada e tecnologia funcional.
Valores: Comprometimento com o cliente, oferecer a melhor experiência de compra, comprometimento com a qualidade dos nossos produtos, conforto e privacidade aos nossos clientes.
1.1. Apresentação da empresa “Em casa com estilo”
A Em Casa Com Estilo foi fundada em 22 de setembro de 2015 e está localizada em Barueri / SP. O quadro de colaboradores da empresa é composto por oito pessoas, sendo cinco vendedores, um estoquista , um caixa e o proprietário que também exerce função de gerente.
Quando fundada, o primeiro grande desafio foi o pouco capital de giro e as vendas muitas vezes não cobriam os custos básicos. Porém, no segundo ano, houve um grande avanço no número de vendas, o que trouxe mais segurança e estabilidade para a empresa. O terceiro e quarto anos foram de muito crescimento e estabilidade, a ECCE se tornou uma realidade no comércio local, a ponto de trazer de fato um novo objetivo e não distante que seria o de inaugurar uma grande loja no centro de São Paulo. Porém, de 2020 até o momento, por causa da pandemia da COVID-19, esse sonho foi adiado. Existem características que são favoráveis, como a localização e a aparência moderna da loja, porém em virtude disso, a busca por soluções de on-line através de um e-commerce veio à tona e agora deverá cumprir o papal de canal mais importante de vendas.
Os fornecedores são confecções da região e revendedores de diversas marcas. Atuam com toda a linha masculina, feminina e infantil. Não possuem filiais.
1.2. Problema da gestão do fluxo de caixa na empresa “Em casa com estilo”
O proprietário da empresa quer uma solução para conseguir voltar a crescer, baseado em resolver os problemas de vendas on-line, atingindo um público maior para expandir suas vendas. Os vendedores descreveram a dificuldade de não ter o atendimento on-line, pois sempre perguntam por isso pela praticidade da escolha dos produtos e pela tranquilidade do cliente não precisar se deslocar até uma loja física.
1.3. Stakeholders e restrições
Proprietário – responsável por reunir todas as informações importantes e passíveis de análise do negócio, limita as ações de cada usuário do e-commerce e o que é pertinente a cada funcionário e seu devido setor.
Gerente – atua em diversas áreas, como análise de dados, monitoramento da concorrência, supervisão dos fornecedores, gerencia o fluxo de caixa e inventário de produtos e equiparações de preços de mercado.
Vendedor/Estoquista – cadastrar os produtos, precificar as mercadorias, registrar as entradas e saídas de mercadorias.
2. Solução proposta
Foi proposto o desenvolvimento de uma plataforma web (site), para realização de vendas on-line, ter um sistema que realize o controle interno do estoque / quantidade e produtos disponíveis para venda, migração do controle de clientes para um banco de dados, controle de pedidos realizados, balanço geral de vendas, automatização dos processos, cadastrados dos produtos disponíveis, cálculo de frete de forma instantânea.
2.1. Requisitos do sistema
Quadro 1 – Requisitos do sistema.
#	Requisitos do sistema (SSS)
SSS0001	O sistema deve receber os dados do cliente, salvando no banco de dados da loja e validar o cliente apto para realizar compras, após efetuar o login.
SSS0002	O sistema deve receber o e-mail cadastrado do cliente e fazer a verificação se é um cadastro ativo. Após a verificação, o sistema deve enviar um e-mail ao cliente com a senha cadastrada.
SSS0003	O sistema deve disponibilizar ao cliente a opção de escolher o produto e suas características, tais como: cor e tamanho. Após a seleção o sistema deve exibir a opção de enviar o produto ao carrinho de compras.
SSS0004	O sistema deve exibir a lista de produtos selecionados pelo cliente e a opção de finalizar compra. Ao selecionar, o sistema deve verificar se o cliente está logado e exibir o valor do frete e o valor total da compra, dando a opção de pagamento.
SSS0005	O sistema deve exibir as opções de pagamento (crédito e débito) e requisitar uma delas. O Sistema deve realizar a cobrança e assim que concluída, exibir uma mensagem (Se foi realizado – Realizado com sucesso ou se houve um problema – Ocorreu um problema, tente novamente).
SSS0006	O sistema deve receber os dados do novo produto, tais como: nome, tamanhos, descrição, gênero, preço e código do produto. O sistema deve guardar no banco de dados o novo produto.
SSS0007	O sistema deve registrar os produtos que foram recebidos no estoque, especificando o nome e seus dados, previamente cadastrados, com as especificações necessárias. O sistema deve atualizar o banco de dados da loja para atualizar o estoque.
SSS0008	O sistema deve receber a venda realizada, consultar a quantidade no estoque, retirar a quantidade de produtos vendidos e atualizar o estoque. Se não houver a quantidade necessária, será exibida uma mensagem de indisponibilidade do produto na tentativa de finalizar a compra. Caso o produto no estoque for zero, aparecerá a mensagem de produto indisponível.
Fonte: Os autores.
2.2. Regras de negócio
Quadro 2 – Regras de negócio.
#	Regras de negócio
RN0001	O site deve mostrar todos os produtos cadastrados.
RN0002	Deve calcular o frete com base no CEP cadastrado.
RN0003	Só permitir a compra de um pedido caso o cliente esteja logado/cadastrado.
RN0004	Permitir que um novo cliente realize um cadastro no site.
RN0005	Somente o administrador consegue realizar cadastros e editar itens no site.
RN0006	Apenas o administrador deve realizar o cadastro de funcionários.
RN0007	Finalizar o pedido após a confirmação de pagamento.
RN0008	Deve ser permitido que um cliente escolha mais de um produto para compra.
RN0009	Deve ser dado ao cliente, diversas opções de pagamento.
RN0010	Permitir que o cliente edite seu perfil cadastrado.
RN0011	O sistema deve calcular os itens no carrinho de compras e passar um valor total.
Fonte: Os autores.
3. Descrição das funcionalidades
O sistema conta com funcionalidades de vendas on-line, categorização de produtos, controle de estoque, frete e formas de envio, controle de pedidos, banco de dados, controle de vendas e faturamento.
3.1. Layout base
O layout base, é a estrutura das páginas, onde é disponibilizado no header (cabeçalho) e no footer (rodapé), componentes fixos que aparecem em todas as páginas do site, dispondo da Logomarca, onde independente da tela que o usuário estiver, ao clicar será direcionado automaticamente para a Home (página inicial), menu com link com opções de “Meu Carrinho”, “Registre-se” (cadastro) e “Login”. Já no footer, temos três sessões, a “Sobre Nós” com links com opções de “História” e “Termos e Compromissos” direcionando para páginas com os respectivos conteúdos, sendo eles páginas estáticas, a sessão “Contato”, dispondo do telefone fixo e WhatsApp para atendimento, e, a sessão “Horário de Atendimento” com a informação estática de atendimento. Além disso mais abaixo, ainda podemos encontrar a “Política de Privacidade” com link de direcionamento para uma página de conteúdo estática, informando o cumprimento das regras de LGPD, em vigor desde 2020.

3.2. Home
Na tela inicial (Home) é visível todo o conteúdo do site, todos podem acessar sem restrições. O que diferencia a página home das demais páginas é a disposição da vitrine virtual com todos os produtos cadastrados, independentemente da cor e da categoria.

3.4. Login
Após o cliente realizar o cadastro no site, através do menu “Registrar-se” o usuário dispõe de um login de acesso, onde para acessá-lo, basta inserir o e-mail e a senha previamente cadastrada. Para usuários cadastrados a tela de login é diferenciada, onde fica disponível as opções: “Meus Pedidos”, para visualização de todos os pedidos do cliente e seus status, como faturado, enviado, devolvido etc. “Meus Dados”, onde fica disponível a opção de verificar e editar seus dados pessoais, além da opção “Sair”, onde o usuário pode deslogar de sua conta.

3.5. Cadastro de cliente, menu “Registre-se”
Ao selecionar a opção “Registre-se” o usuário será direcionado automaticamente ao template de cadastro, onde será necessário incluir os dados pessoais / cadastrais, tais como: Nome completo, CPF, telefone, e-mail, senha de acesso e endereço completo.
Todos os campos são obrigatórios. Após preenchimento dos dados será necessário clicar no botão “Adicionar Endereço”, pois o site permite mais de um cadastro de endereço. Após adicionar o endereço, selecione o botão: “Registrar”.

3.6. Detalhes do produto
Nesta opção, o usuário poderá clicar na opção “Detalhes” e visualizar detalhadamente cada produto, conforme ilustrado na Figura 6.

3.7. Carrinho de compras
Ao navegar no site, o usuário poderá selecionar os itens que deseja adquirir e ir adicionando ao carrinho de compras, sempre ao adicionar itens no carrinho é obrigatório selecionar a quantidade e o tamanho (sujeito a alteração de acordo com o estoque disponível). Para todos os itens existe um código cadastrado. As informações referentes ao carrinho de compras são exibidas em uma tela conforme evidencia a Figura 7.

3.8. Conclusão da compra e pagamento
Nesta opção o sistema traz todos os endereços disponíveis cadastrados para que o cliente selecione em qual deseja receber os itens referente à esta compra. O frete é calculado automaticamente logo após a escolha do endereço. Após as definições de envio do pedido, na mesma página é disponibilizada a opção para que seja realizado o pagamento, conforme apresentado na Figura 8.

Após inserir o endereço de entrega e ter sido validado o pagamento, o pedido é confirmado com a mensagem apresentada na Figura 9.

A lista de itens da compra ficará disponível para consulta em formas diferentes, conforme a ilustração mais abaixo. No menu “Minhas Compras” ficará disponível todo histórico de compras realizadas pelo cliente, com a visualização do pedido mais recente para mais fácil acompanhamento.
Ao clicar em qualquer um dos pedidos (se mais de um, tal como demonstrado na Figura 10) é possível selecioná-lo e visualizar detalhadamente os seus itens, tal como apresentado na Figura 11.


Na opção “Meus dados” é permitido ao usuário, que já possui uma conta no site, verificar e editar seus dados pessoais, assim como adicionar mais que um endereço de cadastro, tal como demonstrado na Figura 12.

A página onde são listados os endereços do cliente com a opções de editar e excluir é a demonstrada na Figura 13.

Ao ser escolhida a opção de editar o endereço, a página exibida na Figura 14 será exibida.

3.9. Dashboard
O acesso ao dashboard só é possível com permissão de administrador. O layout, tal como demonstrado na Figura 15, é composto por: Nome do administrador, com uma mensagem de boas-vindas com o nome do usuário e com a opção de sair. Essa opção, além de fazer com que o administrador saia do dashboard, também o desloga do site.

3.10. Dashboard – home
Na página principal do site, estando o usuário logado como administrador, é possível visualizar-se, na aba “Pedidos”, as informações de compras realizadas pelos clientes com seus respectivos nomes, valor, data e status com a opção de editar (entregue, separado, enviado) além do ícone de visualizar os itens de determinada venda, tal como demonstra a Figura 16.

Ao clicar no ícone de visualizar os itens da venda, é possível visualizar os produtos contidos naquela venda, tal como evidencia a Figura 17.

3.11. Dashboard – produtos
A aba de produtos, possui uma seta que contém um dropdown com as opções “produtos” e “gêneros”. Na opção “produtos” aparece a lista com os dados do produto como código interno, nome, valor, quantidade, ativo, tamanho com a opção de editar o produto caso seja necessária alguma mudança. Ao clicar em “Novo Produto”, é exibida a tela de inserção de novos produtos para a loja, conforme evidencia a Figura 18.

A aba “Gênero” segue o mesmo padrão, com a lista de gêneros cadastrados com a opção de editar e cadastrar novo gênero, tal como exibido na Figura 19.

Ao clicar-se no botão “Novo Gênero” ou escolher editar um dos gêneros existentes, é possível alterar-se sua descrição conforme demonstra a Figura 20.

3.12. Dashboard – colaborador
Ao clicar sobre “colaborador” é exibida uma lista com os colaboradores e algumas de suas informações, como código, nome, e-mail, telefone e CPF. Não há opção de “novo colaborador”, mas existem os botões de “editar” e “nova senha”, conforme a Figura 21.

Na opção de edição, além de ser possível alterar os dados, também é possível editar o “tipo” de usuário, ou seja, se ele é administrador ou cliente, tal como exibe a Figura 22.

Na opção “nova senha”, é possível realizar o cadastro de uma nova senha, tal como demonstra a Figura 23.

3.13. Dashboard – cliente
A opção de clientes possui uma lista com todos os clientes cadastrados e informações de dados cadastrais como código (interno), nome, e-mail, telefone e CPF, tal como aparece na Figura 24. Cada item dessa listagem possui um campo “Ativo” que identifica se o cliente está com o cadastro ativo ou não. Caso não esteja ativo, não é possível mais realizar login através desse usuário. Dispõe-se também das opções “Editar” e “Nova Senha” que possui a mesma funcionalidade de colaboradores.

3.14. Dashboard – painel de controle
Nesta tela é possível ter detalhamento geral dos pedidos realizados, faturamento total, maior venda realizada, produtos cadastros, produtos em estoque e total de clientes registrados, tal como é evidenciado pela Figura 25.

4. Arquitetura, módulos e subsistemas
No diagrama de componentes exibido na Figura 26, é demonstrado e explicado quais linguagens estamos utilizando para front-end, back-end e banco de dados.
Figura 26 – Diagrama de componentes. 
Fonte: Os autores.
5. Projeto de banco de dados
Foi utilizado como banco de dados o MySQL, por ser gratuito e termos experiência em desenvolvimento com a ferramenta. Para operá-lo com facilidade, foi utilizado o HeidiSQL. O banco de dados é constituído por oito tabelas sendo divididas em três partes:
5.1. Cadastro de usuários
a)	tb_login – Registra os dados pessoais do usuário.
b)	tb_endereco – Registramos os endereços dos usuários.
5.2. Produtos
a)	tb_produto – Registra os produtos que serão utilizados em diversas partes do site.
b)	tb_produto_foto – Registra as fotos do produto, permitindo colocar quantas quiser.
c)	tb_genero – Registra os gêneros possíveis para utilizar nos produtos.
d)	tb_produto_genero – Registra os gêneros selecionados de cada produto.
5.3. Venda
a)	tb_venda – Registra cada venda realizada.
b)	tb_venda_itens – Registra os itens de cada venda.
Abaixo, na Figura 27, é detalhado o banco de dados com suas tabelas e respectivas colunas:

6. Estrutura do sistema
O projeto foi desenvolvido na arquitetura MVC utilizando o framework Asp.Net Core 3.1. Consumimos três APIs:
a)	API dos correios – Utilizada para calcular o frete.
b)	API ViaCep – Utilizada para preenchimento de endereços.
c)	API do PagSeguro – Utilizada para realizar a cobrança das vendas realizadas.
Para o front-end foram utilizados, HTML, CSS, Bootstrap, JavaScript, jQuery e AJAX.

7. Tecnologias utilizadas
Quadro 3 – Tecnologias utilizadas.
Tecnologia	Justificativa
Trello	Ferramenta para organização de acordo com a tecnologia ágil e atualizada no final das reuniões com funções para adicionar etiquetas, comentários e prazos para planejar e desenvolver o projeto.
GitHub	Site para facilitar o controle de versões do projeto e repositório de códigos-fontes.
Visual Studio Community 2019	Ferramenta utilizado para desenvolver todo o projeto.
MySQL	Banco de dados utilizado para armazenar os dados da aplicação.
C#	Linguagem de programação utilizada para desenvolver o back-end do projeto.
HTML	Padrão no qual as páginas servidas ao navegador cliente estão codificadas.
CSS	Padrão utilizado pelo navegador para estilizar e formatar as páginas adequadamente.
Heroku	A Plataforma utilizada para deploy da aplicação foi a Heroku com a implementação de virtualização de containers com a tecnologia Docker.
JavaScript	Linguagem de programação utilizada para desenvolver o front-end do projeto.
Bootstrap	Framework utilizado para simplificar e padronizar a estilização do front-end.
jQuery	Biblioteca em JavaScript utilizada para simplificar e agilizar o desenvolvimento de diversas funcionalidades do front-end.
Fonte: Os autores.
8. Hospedagem
Utilizamos a AWS (Amazon Web Services) para hospedagem do banco de dados com o Sistema gerenciador de bancos de dados MySQL na versão 8.0.20. Utilizamos o serviço RDS (Relational Database Service) na modalidade gratuito. A Plataforma utilizada para deploy da aplicação foi a Heroku com a implementação de virtualização de containers com a tecnologia Docker.
Referências bibliográficas
W3Schools.
https://www.w3schools.com/ 

Bóson Treinamentos.
http://www.bosontreinamentos.com.br/ 

Desenvolvedor.io
https://desenvolvedor.io/

jQuery
https://api.jquery.com/

Bootstrap:
https://getbootstrap.com.br/docs/4.1/getting-started/introduction/ >

ViaCEP.
https://viacep.com.br/ >
Glossário
Quadro 4 – Glossário.
Item	Descrição
ECCE - Em Casa Com Estilo	Nome da empresa.
Cliente - Cl	Potencial comprador ou usuário dos produtos.
Venda - vd	É a ação e o efeito de vender mediante o pagamento de um preço estipulado.
Estoque - est	São materiais ou produtos que ficam fisicamente disponíveis pela empresa.
Envio - env	Ato ou efeito de enviar produtos para os clientes.
Pijama - pj	Um tipo de roupa usado para dormir, para quem não quer dormir sem roupas.
Masculino - masc	Destinado só a homens ou que se compõe só de roupas masculinas.
Feminino - fem	Destinado só a mulher ou que se compõe só de roupas femininas.
Infantil - inf	Destinado só a criança ou que se compõe só de roupas para crianças.
Tamanho - tam	Cada uma das medidas de roupa padronizadas pela indústria.
Pequeno - p	Medida das roupas à escolha do cliente.
Médio - m	Medida das roupas à escolha do cliente.
Grande - g	Medida das roupas à escolha do cliente.
Extra Grande - eg	Medida das roupas à escolha do cliente.
Único - u	Medida das roupas à escolha do cliente.
Fonte: Os autores.
Agradecimentos
Primeiramente gostaríamos de agradecer a Deus por ter nos dado força e saúde para superar as dificuldades, aos nossos familiares, a esta universidade pela oportunidade de conhecimento com expansão à novas oportunidades ao mercado de trabalho ao concluir o ensino superior, aos orientadores por todo suporte e aos integrantes do grupo pelo empenho e comprometimento desde o início do projeto de OPE.

