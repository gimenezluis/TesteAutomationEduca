# language: pt-BR

Funcionalidade: Portal de Inscrições
  Como um usuário
  Quero me cadastrar em um curso
  Para acessar conteúdos educacionais relacionados ao nível de ensino escolhido

  Cenário: Realizar cadastro no nível de ensino - Graduação
    Dado que o usuário está na página de inscrições
    Quando abrir o dropdown de níveis de ensino
    E selecionar a opção "Graduação"
    E clicar no botão "Avançar"
    E preencher os dados do formulário
    Então o título "Sua jornada começa aqui!" deve estar visível
