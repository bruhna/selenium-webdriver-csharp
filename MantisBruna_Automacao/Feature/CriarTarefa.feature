Feature: CriarTarefa
	As a usuario do sistema
	I want incluir uma nova tarefa no mantis
	So that seja possivel controlar minhas tarefas
	

Background: acessa sistema para criar nova tarefa
	Given que eu acesso login
#	When acesso a opcao no menu "Criar Nova Tarefa"
#	Then deve exibir a opção de incluir tarefa

Scenario Outline: Criar uma tarefa nova preenchendo todos os campos
	Given que acesso a opcao no menu Criar Nova Tarefa
	When  informo dados da tarefa
	| dado       | valor        |
	| categoria  | <categoria>  |
	| frequencia | <frequencia> |
	| gravidade  | <gravidade>  |
	| atribuir   | <atribuir>   |
	| resumo     | <resumo>     |
	| descricao  | <descricao   |
	| passos     | <passos>     |
	| adicionais | <adicionais> |
	And clico em criar nova tarefa
#	Then deve exibir a mensagem de sucesso Operação realizada com sucesso

	Examples: 
	| categoria | frequencia | gravidade | atribuir      | resumo           | descricao           | passos         | adicionais |
	| General   | Sempre     | pequeno   | administrator | Teste Incluir 01 | Incluindo Tarefa    | Passos Criar 1 | add 1      |
	| General   | Sempre     | pequeno   | administrator | Teste Incluir 02 | Criar Tarefa        | Passos Criar 2 | add 2      |
	| General   | Sempre     | pequeno   | administrator | Teste Incluir 03 | Tarefa Criada       | Passos Criar 3 | add 3      |
	| General   | Sempre     | pequeno   | administrator | Teste Incluir 04 | Teste Criar Tarefa  | Passos Criar 4 | add 4      |
	| General   | Sempre     | pequeno   | administrator | Teste Incluir 05 | Incluindo Tarefa 02 | Passos Criar 5 | add 5      |
	| General   | Sempre     | pequeno   | administrator | Teste Incluir 06 | Incluindo Tarefa 03 | Passos Criar 6 | add 6      |

Scenario Outline: Criar uma tarefa nova preenchendo somente os campos obrigatorios
	Given que acesso a opcao no menu Criar Nova Tarefa
	When informo somente campos obrigatorios 
	| dado       | valor        |
	| categoria  | <categoria>  |
	| resumo     | <resumo>     |
	| descricao  | <descricao   |
	And clico em criar nova tarefa
#	Then deve exibir a mensagem de sucesso Operação realizada com sucesso

	Examples: 
	| categoria | resumo              | descricao             | 
	| General   | Teste obrigatorio 1 | Incluindo obrigatorio | 
	| General   | Teste obrigatorio 2 | Criar obrigatorio     | 
	| General   | Teste obrigatorio 3 | Tarefa obrigatorio    | 
	| General   | Teste obrigatorio 4 | Teste obrigatorio     | 



Scenario Outline: Criar uma tarefa sem preenchimento do campo obrigatorio e validar mensagem
	Given que acesso a opcao no menu Criar Nova Tarefa
	When informo somente campos nao obrigatorios
	| dado       | valor        |
	| frequencia | <frequencia> |
	| gravidade  | <gravidade>  |
	| atribuir   | <atribuir>   |
	| passos     | <passos>     |
	| adicionais | <adicionais> |
   And clico em criar nova tarefa
#	Then deve exibir mensagem informando que o campo e obrigatorio

	Examples: 
	| frequencia | gravidade | atribuir      | passos         | adicionais |
	| Sempre     | pequeno   | administrator | Passos Criar 6 | add 0      |
	| Sempre     | pequeno   | administrator | Passos Criar 7 | add 9      |
	| Sempre     | pequeno   | administrator | Passos Criar 8 | add 8      |
	| Sempre     | pequeno   | administrator | Passos Criar 9 | add 7      |
	| Sempre     | pequeno   | administrator | Passos Criar 0 | add 6      |
	


#Scenario: Criar uma tarefa com prioridade urgente
#	Given que acesso a opcao no menu Criar Nova Tarefa
#	When informo dados da tarefa
#	And informo a prioridade como urgente
#	And cliclo em criar nova tarefa
#	Then deve exibir a mensagem de sucesso Operação realizada com sucesso

#Scenario: Criar uma tarefa com gravidade grande
#	Given que acesso a opcao no menu Criar Nova Tarefa
#	When infono dados da tarefa
#	And informo a gravidade como grande
#	And cliclo em criar nova tarefa
#	Then deve exibir a mensagem de sucesso Operação realizada com sucesso

#Scenario: Criar uma tarefa com frequencia sempre
#	Given que acesso a opcao no menu Criar Nova Tarefa
#	When infono dados da tarefa
#	And informo a frequencia como sempre
#	And cliclo em criar nova tarefa
#	Then deve exibir a mensagem de sucesso Operação realizada com sucesso

#Scenario: Criar uma tarefa com atribuicao para outra pessoa
#	Given que acesso a opcao no menu Criar Nova Tarefa
#	When infono dados da tarefa
#	And informo a atribuição para bruna
#	And cliclo em criar nova tarefa
#	Then deve exibir a mensagem de sucesso Operação realizada com sucesso


#Scenario: Criar uma tarefa com visibilidade privada
#	Given que acesso a opcao no menu Criar Nova Tarefa
#	When infono dados da tarefa
#	And informo a visibilidade da tarefa como privada
#	And cliclo em criar nova tarefa
#	Then deve exibir a mensagem de sucesso Operação realizada com sucesso



