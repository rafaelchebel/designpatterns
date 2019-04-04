Builder 

Builder serve para criar objetos complexos. 

Um construtor comu é extenso e difícil de entender. Além do mais, a regra de criação do objeto acabou ficando espalhado pelo código do método Main(). 

Pior, as vezes ainda temos o problema de parâmetros opcionais. Nesse caso, o programador começa a criar diferentes construtores, cada um com uma possível combinação de parâmetros de entrada, tornando a sua classe mais difícil ainda de ser lida. 

 

Sempre que tivermos um objeto complexo de ser criado, que possui diversos atributos, ou que possui uma lógica de criação complicada, podemos esconder tudo isso em um Builder. 

Além de centralizar o código de criação e facilitar a manutenção, ainda facilitamos a vida das classes que precisam criar essa classe complexa, afinal a interface do Builder tende a ser mais clara e fácil de ser usada. 