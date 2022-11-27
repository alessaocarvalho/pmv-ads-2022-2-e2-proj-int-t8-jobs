# Registro de Testes de Software

Este é um registro de testes executados para caso de teste definido no <a href="docs/08-Plano de Testes de Software.md">Plano de Testes de Software</a>, nele estão os registros das evidências dos testes feitos na aplicação pela equipe, e indicações de que os critérios de êxito foram alcançados ou não. A tabela será preenchida de acordo com o andamento das etapas do projeto.

<table>
    <tr>
        <th>Responsável pelo Teste</th>
        <th>Etapa de Referência</th>
        <th>Data</th>
        <th>Item</th>
        <th>Ações Executadas</th>
        <th>Validação</th>
        <th>Avaliação</th>
    </tr>
    <tr>
        <td>Alisson A. Carvalho</td>
        <td>Etapa 3</td>
        <td>28/10/2022</td>
        <td>RF-01: Verificar se as informações do usuário podem ser cadastradas, consultadas e removidas.</td>
        <td>1. Cadastrar novo usuário; 2. Verificar existência no banco de dados; 3. Remover informações.</td>
        <td>O teste foi executado com sucesso</td>
        <td>O cadastro foi executado com sucesso e armazenado no banco de dados, após consulta os dados foram alterados e removidos pela própria interface.</td>
    </tr>
    <tr>
        <td>Alisson A. Carvalho</td>
        <td>Etapa 3</td>
        <td>28/10/2022</td>
        <td>RF-02: Verificar se as informações armazenadas do perfil dos usuários podem ser editadas ou atualizadas.</td>
        <td>1. Executar alteração de dados de usuário existente no banco de dados; 2. Verificar se as mudanças foram aplicadas no banco.</td>
        <td>O teste foi executado com sucesso</td>
        <td>Os dados foram alterados e atualizados corretamente no banco de dados.</td>
    </tr>
    <tr>
        <td>Alisson A. Carvalho</td>
        <td>Etapa 4</td>
        <td>27/11/2022</td>
        <td>RF-03: Verificar se perfis, serviços e demais informações podem ser inseridos, atualizados e consultados.</td>
        <td>1. Entrar na página referente ao perfil do usuário e conferir os dados; 2. Editar os dados inserindo as informações correspondentes a cada campo; 3. Salvar as alterações e verificar o banco de dados.</td>
        <td>O teste foi executado com sucesso</td>
        <td>Informações adicionais de Perfil e Serviços foram inseridas e armazenadas corretamente no banco de dados da aplicação.</td>
    </tr>
    <tr>
        <td>Vinicius L. Oliveira</td>
        <td>Etapa 4</td>
        <td>27/11/22</td>
        <td>RF-04: Verificar se o usuário consegue visualizar informações de um serviço antes de contatar o anunciante.</td>
        <td>1.Entrar na página referente a busca de serviços; 2. Pesquisar pelo serviço desejado; Visualizar as informações do serviço. </td>
        <td>O teste foi executado com sucesso</td>
        <td>Informações sobre o anúncio foram visualizadas na página de busca. </td>
    </tr>
    <tr>
        <td>Vinicius L. Oliveira</td>
        <td>Etapa 4</td>
        <td>27/11/22</td>
        <td>RF-04: Verificar se o usuário deve conseguir buscar por serviços vinculados a um determinado anunciante.</td>
        <td>1.Entrar na página de busca; 2. Digitar o serviço desejado; 3. Verificar se foi retornado o serviço procurado. </td>
        <td>O teste foi excutado com sucesso</td>
        <td>A busca  dos anúncios no banco de dados teve o retorno do serviço dos anunciantes desejado. </td>
    </tr>
    <tr>
        <td>Vinicius L. Oliveira</td>
        <td>Etapa 4</td>
        <td>27/11/22</td>
        <td>RF-06: Verificar se o usuário deve conseguir publicar serviços na plataforma.</td>
        <td>1. Entrar na página referente ao anúncio; 2. Preencher os dados do serviço e publicá-lo; 3. Verificar se o serviço está disponível no banco de dados.   </td>
        <td>O teste foi excutado com sucesso</td>
        <td>A publicação do anúncio foi executada e armazenada no banco de dados com sucesso. </td>
    </tr>
    <tr>
        <td>Vinicius L. Oliveira</td>
        <td>Etapa 4</td>
        <td>27/11/22</td>
        <td>RF-07: O Anunciante deve conseguir informar valores para seus serviços.</td>
        <td>1. Na página Anunciar, inserir o preço na coluna correspondente; 2. Publicar. </td>
        <td>O teste foi excutado com sucesso</td>
        <td>O preço foi inserido com sucesso na barra de dados do anúncio. </td>
    </tr>
</table>

## Capturas de Tela

Abaixo temos capturas de tela ilustrando a execução de cada uma das referências de teste.

A imagem a seguir ilustra como o banco de dados é atualizado conforme os requisitos RF-01, RF-02 e RF-03:

![banco-usuario](https://user-images.githubusercontent.com/100442612/204148566-2e4a2e54-4fb6-4da3-b959-e355dd8e9ceb.png)
