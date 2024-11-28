A arquitetura do projeto foi estruturada seguindo o padrão Page Object para automação de testes. Este padrão foi escolhido porque:

Manutenção Facilitada: Centraliza a lógica de manipulação de elementos em classes específicas, facilitando ajustes caso os elementos da página mudem.
Reutilização de Código: Métodos de interação podem ser reutilizados em diferentes cenários de teste.
Separação de Responsabilidades: Os testes são desacoplados da lógica de manipulação de elementos, mantendo os cenários mais legíveis e claros.




Cenarios Validados.

Cenarios Sucesso - Onde se percorre o caminho "Feliz da aplicação"

Criar inscrição Graduação - OK
-Seleciona curso
-Preenche formulario

Criar inscrição Pós-Graduação - OK
-Seleciona curso
-Preenche formulario

Login Autenticado - OK


Cenarios Erros - Onde se percorre caminhos alternativos, afim de validar problemas de implementação ou regra de negocio;

Input dos campos com informações diferente da esperada
    -CPF com mais caracteres - OK
    -Telefone diferente do esperado - OK
    -Email diferente do esperado - OK
Validação dos campos obrigatorios - OK

Selecionar Nivel de ensino e retornar para tela principal - BUG
