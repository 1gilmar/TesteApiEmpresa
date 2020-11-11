# ApiPatrimonioEmpresa

Crie uma Web API REST para o gerenciamento de patrimônios de uma empresa.
Requisitos

Patrimônio

Campos:

`Nome - obrigatório

MarcaId – obrigatório

Descrição

No do tombo`

Regras: O no do tombo deve ser gerado automaticamente pelo sistema e não pode ser
alterado pelos usuários.

Marca

Campos:

`Nome – obrigatório

MarcaId - obrigatório`

Regras: Não deve permitir a existência de duas marcas com o mesmo nome.
Usuário

Campos:

`Nome – obrigatório

Email – obrigatório

Senha - obrigatório`

Regras: Não permitir e-mail repetido

Requisitos técnicos

● Deve se utilizar C#;

● Os dados devem ser salvos em SQL Server/PostgreSQL;

● Os endpoints devem utilizar o formato JSON;

● A sua aplicação deve conter um arquivo README explicando a solução adotada na sua
implementação do desafio;

● Implementar Autenticação com Token (como preferir);

● Os endpoints só poderão ser acessados por usuário autenticados (com exceção do POST de
criação de usuário);

Observações/Dicas

● Não se limite às funcionalidades acima. Qualquer outra feature extra é bem-vinda;

● A arquitetura é por sua conta;

● Coloque um script de criação do banco de dados junto ao projeto;

● Não é necessária a criação de telas;

● Comunique qualquer impedimento/dúvida o quanto antes, para que possamos analisar;

Critérios de avaliação

● Organização e qualidade do código;

● Organização da estrutura e arquitetura desenvolvida;

● Documentação do projeto (readme);
