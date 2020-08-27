Feature: Gerenciar
	As a usuario do sistema
	I want incluir uma nova tarefa no mantis
	So that seja possivel controlar minhas tarefas

Background: acessa sistema para criar nova tarefa
Given que eu acesso login
When acesso a opcao no menu Gerenciar

#Gerenciar Projeto

Scenario: Criar novo projeto
Given que eu acesso a opcao no menu Gerenciar Projetos
And clico na opcao Criar Novo Projeto
When informo os dados do projeto
And clico em Adionar Projeto
#Then deve apresentar mensagem de projeto criado com sucesso

Scenario: Alterar projeto
Given que eu acesso a opcao no menu Gerenciar Projetos
And seleciono um projeto 
#And clico na opcao Alterar projeto  
When altero os dados do projeto
Then clico em Atualizar Projeto

Scenario: Excluir projeto
Given que eu acesso a opcao no menu Gerenciar Projetos
And seleciono um projeto
#When apresenta opção de alterar projeto
And clico em Apagar Projeto
#Then confirmo a solicitacao

Scenario: Criar novo Subprojetos
Given que eu acesso a opcao no menu Gerenciar Projetos
And seleciono um projeto
And clico em criar subprojetos
When informo os dados do projeto
And clico em Adionar Projeto
#Then deve apresentar mensagem de projeto criado com sucesso

#Gerenciar Usuários

Scenario: Criar nova conta
Given que eu acesso a opcao no menu Gerenciar Usuarios
And clico na opcao Criar nova conta
When informo os dados do usuário
And clico em Criar Usuário
#Then deve apresentar mensagem de usuário criado com sucesso

Scenario: Excluir usuário
Given que eu acesso a opcao no menu Gerenciar Usuarios
And seleciono um usuario
#When apresenta opção de alterar usuario
And clico em Apagar Usuario
And confirmo a solicitacao
#Then deve apresentar mensagem de usuário apagado com sucesso

Scenario: Alterar usuário
Given que eu acesso a opcao no menu Gerenciar Usuarios
And seleciono um usuario
When altero os dados do usuário
And clico em Atualizar usuario
#Then deve apresentar mensagem de usuário criado com sucesso

#Gerenciar Marcadores

Scenario: Criar marcador
Given que eu acesso a opcao no menu Gerenciar Marcadores
When informo os dados dos marcadores
Then clico em Criar Marcadores

Scenario: Alterar marcador
Given que eu acesso a opcao no menu Gerenciar Marcadores
And selecione um marcador para alterar
And clico na opcao Atualizar Marcador
When altero os dados dados dos marcadores
Then clico em Atualizar Projeto

Scenario: Excluir marcador
Given que eu acesso a opcao no menu Gerenciar Marcadores
And selecione um marcador para alterar
And clico na opcao Apagar Marcador
Then confirmo a solicitacao