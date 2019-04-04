State 

State serve para gerenciar estados de um objeto. 

A principal situação que faz emergir o Design Pattern State é a necessidade de implementação de uma máquina de estados. Geralmente, o controle das possíveis transições são vários e complexos, fazendo com que a implementação não seja simples. O State auxilia a manter o controle dos estados simples e organizados através da criação de classes que representem cada estado e saiba controlar as transições. 

 

Dependendo do estado que o orçamento se encontra, algumas ações podem ser diferentes. Por exemplo, podemos adicionar um desconto extra ao orçamento: quando o orçamento está em aprovação, a empresa oferece 5% a mais de desconto; quando já está aprovado, a empresa oferece 2% de desconto. Orçamentos reprovados e finalizados não recebem nada de desconto extra. 