Feature: VerTarefa
	As a usuario do sistema
	I want ver uma tarefa no mantis
	So that seja possivel controlar minhas tarefas

Background: acessa sistema para criar nova tarefa
	Given que eu acesso o login 

Scenario: Alterar resumo da tarefa
	Given que eu acesso a opcao no menu Ver Tarefas
	And clico na opcao para alterar tarefa
	When altero a informacao do campo Resumo
	And clico em atualizar informacao
	#Then deve apresentar Ver detalhes da Tarefa

Scenario: Altere uma tarefa e crie um clone
	Given que eu acesso a opcao no menu Ver Tarefas
	And clico na opcao para alterar tarefa
	And clico em atualizar informacao
	When apresentar Ver detalhes da Tarefa
	Then clico em Criar Clone da tarefa

Scenario: Altere uma tarefa e apague-a
	Given que eu acesso a opcao no menu Ver Tarefas
	And clico na opcao para alterar tarefa
	And clico em atualizar informacao
	When apresentar Ver detalhes da Tarefa
	Then clico em Apagar tarefa

Scenario: Selecione uma tarefa  coloque como resolvido
	Given que eu acesso a opcao no menu Ver Tarefas
	And clico em uma opcao no grid
	When seleciono a opcao de Resolver
	And clico em OK
	And adiciono uma anotação
	Then resolvo tarefa clicando em Resolver Tarefas

Scenario: Altere uma tarefa e anexe um arquivo
	Given que eu acesso a opcao no menu Ver Tarefas
	And clico na opcao para alterar tarefa
	When altero a informacao do campo Resumo
	And clico em atualizar informacao
	#Then deve apresentar Ver detalhes da Tarefa

Scenario: Pesquise por uma tarefa excluida
	Given que eu acesso a opcao no menu Ver Tarefas
	When informo a tarefa excluida
	And clico na opcao de Aplicar filtro
#	Then nao deve apresentar nenhuma tarefa

Scenario: Altere o filtro para aprsentar somente 2 registos
	Given que eu acesso a opcao no menu Ver Tarefas
	And clico na opcao para expandir menu
	And clico na opcao exibir 
	When informo a quantidade de tarefas
	And clico na opcao de Aplicar filtro
#	Then deve apresentar somente 2 tarefas
