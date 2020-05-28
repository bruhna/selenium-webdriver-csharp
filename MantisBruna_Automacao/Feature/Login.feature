Feature: Login
    As a usuario do sistema
	I want logar no sistema
	So that seja possivel eu criar tarefas


Scenario: Validar login valido e senha invalida
    Given que eu acesso o campo login
	When que eu preencho o campo login 
	And aciono a opcao para entrar
	And preencho o campo senha errado
#	Then deve apresentar mensagem de erro

Scenario: Validar login invalido e senha valida
	Given que eu acesso o campo login
	When preencho o campo login errado
	And aciono a opcao para entrar
	And preencho o campo senha
#	Then deve apresentar mensagem de erro

Scenario: Validar se apresenta mensagem quando não preenchido menhum campo
	Given que eu acesso o campo login
	And aciono a opcao para entrar
#	Then deve apresentar mensagem de erro

Scenario: Validar login e senha validos e se o mesmo apresentou tela inicial
	Given que eu acesso o campo login
	When que eu preencho o campo login 
	And aciono a opcao para entrar
	And preencho o campo senha
	And aciono a opcao para entrar
	Then deve apresentar a tela inicial do mantis


