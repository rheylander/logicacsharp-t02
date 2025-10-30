//Declarando constantes

const int valor1 = 10;
const int valor2 = 5;


//Soma
int soma = valor1 + valor2;
Console.WriteLine($"Soma: {valor1} + {valor2} = {soma}");

//Subtracação
int subtracao = valor1 - valor2;
Console.WriteLine($"Subtração: {valor1} - {valor2}");

//MULTIPLICAÇÃO
int multiplicacao = valor1 * valor2;
Console.WriteLine($"Multiplicação: {valor1} * {valor2}");

//DIVISÃO (resultado)
int divisao = valor1 / valor2;
Console.WriteLine($"Divisão: {valor1} / {valor2}");

//Resto da Divisão
int restoDivisao = valor1 % valor2;
Console.WriteLine($"Resto da divisão de: {valor1} / {valor2}");

//Potenciação (usando Math.Pow para calcular a potência
double potencia = Math.Pow(valor1, valor2);
Console.WriteLine($"{valor1} elevado {valor2} = { potencia}");

/* (comentário de mais de uma linha ao mesmo tempo
  ordem 
  de 
  grandeza */

// Exemplo 1: Sem parênteses
int resultado1 = 3 + 5 * 2; // Multiplicação tem prioridade
Console.WriteLine($"Resultado 1; (sem parentes): 3 + 5 * 2 = {resultado1}");

// Exemplo 1: Com parênteses
int resultado2 = (3 + 5) * 2; // Parênteses alteram a ordem
Console.WriteLine($"Resultado 2 (Com parênteses): (3 + 5 ) * 2 = {resultado2}");

// Exemplo 2: Sem parênteses
int resultado3 = 8 / 4 + 3; // Multiplicação tem prioridade
Console.WriteLine($"Resultado 3; (sem parentes): 8 / 4 + 3 = {resultado3}");

// Exemplo 2: Com parênteses
double resultado4 = 8.0 / (4 + 3) ; // Parênteses alteram a ordem
Console.WriteLine($"Resultado 4 (Com parênteses): 8 / (4 + 3) = {resultado4}");
