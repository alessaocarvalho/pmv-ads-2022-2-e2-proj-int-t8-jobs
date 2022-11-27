# Plano de Testes de Software

## Historico de Revisões 

<table>
  <tr>
   <td width="100" align="center"><strong>Data</strong></td>
   <td width="100" align="center"><strong>Versões</strong></td>
   <td width="350" align="center"><strong>Descrição</strong></td>
   <td width="250" align="center"><strong>Autor</strong></td>
  </tr>
  <tr>
   <td align="center">02/10/2022</td>
   <td align="center">DOC</td>
   <td align="left">Criação do documento</td>
   <td align="left">Bruno Selas</td>
  </tr>
 </table>

## Introdução 

`Objetivos` 

Esse documento do Plano de Testes da Plataforma Job’s. compõe-se dos seguintes objetivos: 

-	Identificar informações de projeto existentes e os componentes de software que devem ser testados. 

-	Listar e testar os Requisitos funcionais (alto nível). 

-	Recomendar e descrever as estratégias de teste a serem empregadas. 

-	Identificar os recursos necessários e prover uma estimativa dos esforços de teste. 

- 	Listar os elementos resultantes do projeto de testes. 


`JOBS`

A plataforma de integração de serviços especializados (Job’s) consiste em um sistema de apoio a trabalhadores autônomos. Tal apoio consiste no provimento de um espaço personalizado, ajustado e de grande visibilidade para que trabalhadores autônomos possam expor seus serviços e conseguir gerenciar seu trabalho como empresários da sua própria mão de obra especializada, como uma grande “vitrine” do que seu serviço pode oferecer no mais amplo leque de diversificação desse serviço. 

Um subgrupo específico de usuários da plataforma por sua vez tem a oportunidade de aproveitar essa grande “vitrine” de serviços a fim conseguir mão de obra especializada e de qualidade, com poder de barganha e garantia de efetividade, tranquilidade e segurança na busca desses serviços.  

Além do módulo de exibição de informações e de buscador de serviços, a Job’s deverá ser capaz de acessar a base de dados desses perfis para sugestões de novos perfis de trabalhadores baseado no histórico de busca e perfil do usuário, ranqueamento dos trabalhadores e opiniões de outros usuários clientes. 

## Escopo de Testes

O sistema Job’s passará por testes funcionais direcionados ao nível de cumprimento de requisitos e testes de sistema sendo eles não-funcionais mensurando como a plataforma se comporta em determinados casos e situações. 
Os testes Funcionais validarão a qualidade funcional, das bases de dados, interface gráfica e fluxo de execução da aplicação; enquanto que os testes de sistema tratarão das questões de performance e usabilidade. 

Os testes de instalação e configuração não serão realizados uma vez que se trata de uma aplicação do tipo Web sendo desnecessária a preocupação com os mesmos. Pelo mesmo motivo excluem-se os testes de stress, de volume e de falha/recuperação por se considerar que o ambiente de implantação do sistema trata-se de um meio equilibrado em que essas situações não têm muito espaço para ocorrer sejam grandes cargas de stress ao hardware ou falhas que comprometam o funcionamento do dispositivo que acessar a aplicação. 

Para a execução dos testes serão utilizadas máquinas distintas, em termos de hardware e/ou software, a fim de garantir performance e compatibilidade nos mais variados ambientes de usuários e sistemas operacionais. 

Todos os testes serão observados e avaliados pela equipe responsável do começo ao fim não contendo nenhum tipo de interferência externa que atrapalhe o resultado dos mesmos. 

Os testes mais críticos serão os testes de banco de dados, que compõe grande parte do sistema, verificando a sua correta atualização e funcionamento para as tarefas de cadastrar, atualizar, remover e requisitar dados de clientes e prestadores de serviços. 


## Identificação do Projeto 

A tabela abaixo identifica a documentação e disponibilidade usados para desenvolver o plano de testes: 

<table>
 <tr>
  <td width="400" align="left">Documento</td>
  <td width="200" align="center">Criado ou Disponível</td>
  <td width="200" align="center">Recebido ou Revisado</td>
 </tr>
 <tr>
  <td align="left">Especificação de Requisitos</td>
  <td align="center">Sim</td>
  <td align="center">Não</td>
 </tr>
  <tr>
  <td align="left">Plano de Projeto</td>
  <td align="center">Sim</td>
  <td align="center">Sim</td>
 </tr>
  <tr>
  <td align="left">Modelo de Análise</td>
  <td align="center">Não</td>
  <td align="center">Não</td>
 </tr>
  <tr>
  <td align="left">Modelo de Projeto</td>
  <td align="center">Não</td>
  <td align="center">Não</td>
 </tr>
  <tr>
  <td align="left">Documento de Arquitetura</td>
  <td align="center">Sim</td>
  <td align="center">Sim</td>
 </tr>
  <tr>
  <td align="left">Protótipo</td>
  <td align="center">Não</td>
  <td align="center">Não</td>
 </tr>
 <tr>
  <td align="left">Manual do Usuário</td>
  <td align="center">Não</td>
  <td align="center">Não</td>
 </tr>
 <tr>
  <td align="left">Lista de Riscos</td>
  <td align="center">Sim</td>
  <td align="center">Sim</td>
 </tr>
</table>

## Requisitos a Testar

A lista abaixo identifica os requisitos funcionais e não-funcionais do projeto que serão testados:   

`TESTE DE BANCO DE DADOS `

- RF-01 Verificar se as informações do usuário podem ser cadastradas, consultadas e removidas. 
 

- RF-02 Verificar se as informações armazenadas do perfil dos usuários podem ser editadas ou atualizadas. 
 

- RF-03 Verifique se perfis, serviços e demais informações podem ser inseridos, atualizados e consultados. 
 

- RF-04Verificar se o usuário consegue visualizar informações de um serviço antes de contatar o anunciante 
 

- RNF-02 A plataforma deve verificar existe disponibilidade do serviço requisitado pelo usuário antes de notificar o anunciante


`TESTE FUNCIONAL`

- RF-06 Verificar se o usuário deve conseguir publicar serviços na plataforma. 
 
- RF-07 O Anunciante deve conseguir informar valores para seus serviços.   

`TESTE DA INTERFACE DO USUARIO`

- Navegar através do fluxo de execução, verificando que cada tela de interface gráfica pode ser rapidamente entendida e facilmente utilizada. 
 

- Verificar se não há nenhum tipo de mensagem, balão ou botão que gere confusão ao usuário. 
 

- Verifique se o sistema como um todo consegue cumprir os objetivos que os usuários alvo da plataforma sejam concluídos. 
 

- RNF-03 Verificar se a plataforma tem ícones representando visualmente as funcionalidades do site.  
 

- RNF-04 A plataforma deve utilizar técnicas de responsividade para permitir a utilização em dispositivos móveis.  
 
`TESTE DE PERFORMANCE`

- RNF-01 A plataforma deve retornar os resultados da busca de serviços em até 5 segundos.   

`TESTE DE CARGA` 
- Verificar a resposta do sitema com 10 usúarios simultâneos.

`TESTE DE CARGA`

- Nehhum 

`TESTE DE STRESS`
 - Nenhum 

`TESTE DE VOLUME`

- Nenhum 

`TESTE DE FALHA/ RECUPERAÇÃO`

- Nenhum 

## Estrategia De Teste 

`TIPOS DE TESTE`

**Nota:** As informações abaixo se referem à uma simulação de funções específicas que um usuário final do sistema é suposto de executar ao usar a aplicação, tais como adicionar ou modificar uma dada informação.  

`TESTE DE INTEGRIDADE DE BANCOS DE DADOS`

| Objetivo do Teste: | Garantir que os métodos e processos de acesso a informações do banco de dados funcionam apropriadamente e sem corrupção dos dados. |
| ------------------- | --------------------- | 
|Técnica | - Invocar cada método e processo de acesso ao banco de dados, alimentando cada um com dados ou requisições de dados válidos e inválidos. <br> - Inspecionar o banco de dados para garantir que os dados foram executados como pretendido, que todos os eventos do banco de dados ocorreram apropriadamente, ou revisar os dados retornados para garantir que os dados corretos foram recuperados pelas razões corretas |
| Critério de Finalização | Todos os métodos e processos de acesso à base de dados funcionam como projetados e sem nenhuma corrupção de dados. |
| Considerações Especiais | Processos podem ser invocados manualmente |


`TESTE DE FUNÇÃO`

| Objetivo do Teste: |Garantir a funcionalidade apropriada do alvo do teste, incluindo navegação, entrada de dados, processamento e recuperação |
| ---- | --- | 
| Técnica | Executar cada caso de uso, fluxo de caso de uso, usando dados válidos e inválidos, para verificar o seguinte:<br>  Os resultados esperados ocorrem quando dados válidos são usados <br> As mensagens de erro ou aviso apropriadas são exibidas quando dados inválidos são usados.  |
| Critério de Finalização | Todos os testes planejados foram executados.<br> Todos os defeitos identificados foram tratados <br> | 
| Considerações Especiais |Nenhum|

`TESTE DA INTERFACE DO USUÁRIO`
| Objetivo do Teste: | Se a navegação através dos alvos do teste reflete de forma apropriada as funções e os requisitos estipulados, incluindo janela-a-janela, campo-a-campo, e o uso de métodos de acesso (tecla tab, movimentos do mouse, teclas aceleradoras) <br> Objetos e características da janela, tais como menus, tamanho, posição, estado e foco conformam-se aos padrões desktop e sua devida responsividade para dispositivos mobile. |
| ---- | --- | 
| Técnica | Documentar os testes para cada tela alvo para verificar a navegação e a resposta da aplicação como resultado. |
| Critério de Finalização | É verificado que cada janela permanece consistente com a versão de comparação ou dentro de padrões aceitáveis. |
| Considerações Especiais | Nenhum| 

`TESTE DE PERFORMACE`
| Objetivo do Teste: | Verificar que os comportamentos de performance para as funções da plataforma ao cumprir os objetivos do usuário. |
| ---- | --- | 
| Técnica | Usar procedimentos de teste desenvolvidos/automatizados para teste da aplicação. |
| Critério de Finalização |Retorno do conteúdo buscado pela plataforma dentro do tempo esperado para critério de êxito. |
| Considerações Especiais |Um teste abrangente de performance inclui ter uma carga de trabalho ou ação na base de dados da aplicação. <br>  Há vários métodos que podem ser usados para executar isso, incluindo: <br> O teste de performance deve ser executado em uma máquina dedicada ou em um tempo dedicado. Isso permite controle total e mensuração precisa <br> As bases de dados usadas para o Teste de Performance devem ser ou do tamanho real ou proporcionalmente iguais. <br>|

## Ferramentas
**As seguintes ferramentas serão empregadas para esse projeto:**

| | Ferramenta |Vendedor |
| --- | --- | -----| 
| Gerenciamento | Visual studio code | Microsoft|
| Projeto de teste | Microsoft Word | Microsoft |
| Gerenciamento de Projeto | Github<br> Microsoft Word | Microsoft <br> Microsoft | 
| Ferramentas de Desenvolvimento | Visual Studio Code | Microsoft |

`RECURSOS`
**Essa seção apresenta os recursos recomendados para os testes da plataforma Job's **

## Sistema 

A tabela seguinte expõe os recursos do sistema para o projeto de teste e desenvolvimento da aplicação. 

| Recursos do sistema|
| ------------------|
| Servidor de Banco de Dados |
| Terminais Clientes<br> 7 PCs (disponíveis para desenvolvimento e testes da aplicação) <br> — 7 dispositivos móveis com tela sensível ao toque (disponíveis para testes de responsividade)  | 
|Repositorio de Testes <br>  Git/Github para integração/controle de versão do código (desenvolvimento e testes) <br> — 7 PCs de Desenvolvimento de Teste integrados por meio dos repositórios|

| Milestone | Data no Incio | Data de termino|
| ---------- | ------------ | -------------  |
| Planejar Teste | 12/09/22 | 02/10//22
| Implementar Teste | 03/10/22 | 31/10/22 |
| Executar Teste| 31/10//22 | 27/11/22 |
| Avaliar Teste | 28/11/22 | 11/12/22 | 


