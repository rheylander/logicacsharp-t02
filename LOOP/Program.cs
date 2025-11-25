// loop

//loop FOR 


for (int i = 1; i < +10; i++)
{
    Console.WriteLine(i);
    Thread.Sleep(600);
}


int soma = 0;
for (int i = 1; i <= 100; i++)
{
    soma += i; // Soma o valor de i à variável soma, exemplo: 1=2=3=4... +99 +100
}

Console.WriteLine("A soma dos números de 1 a 100 é: " + soma);


// loop infinito
/*
for (; ; )
{
    Console.WriteLine("Este é um loop infinito");
}
*/

Console.WriteLine("\n");

//loop WHILE (enquanto)

int c = 1;
while (c < 5)

{
    Console.WriteLine(c);
    c++;
    if (c == 5)
    {
        break;
    }
}

Console.WriteLine("\n");

//loop DO WHILE (faça enquanto)
int novocontador = 2;

do
{
    Console.WriteLine(novocontador);
    novocontador++; // Incrementa o contador

} while (novocontador <= 10); // se for menor que 10 continue

// do while loop infinito
/*
while (true) // é errado escrever um código "do while" que não termine em false.
{
    Console.WriteLine("Este é um loop infinito");
}
*/

Console.WriteLine("\n");

// loop foreach

string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
    foreach (string i in cars)
    {
        Console.WriteLine(i);
    }

Console.WriteLine("\n"); //pula uma linha

string[] names = { "Ana", "Carlos", "João", "Maria" };
    foreach (string n in names)
    {
        Console.WriteLine(n);
    }

    Console.WriteLine("\n");

//Uma lista de strings
List<string> nomes = new List<string> { "Ana", "Carlos", "João", "Maria" };

// Usando o foreach para percorrer a lista
    foreach (string nome in nomes)
    {
        Console.WriteLine(nome); // Imprime cada nome exibindo na tela
    }

    Console.WriteLine("\n");

//um vetor de números inteiros
    int[] numeros = { 1, 2, 3, 4, 5 };

//usando o foreach para percorrer o vetor
    foreach (int numero in numeros)
    {
        Console.WriteLine(numero); // Imprime cada número exibindo na tela
    }


// solicitando ao usuário a digitação
    double preco, total = 0;

do
{
    Console.WriteLine("Digite o preço do produto (0 para finalizar):");
    preco = Convert.ToDouble(Console.ReadLine());
    total += preco;
} while (preco != 0);

Console.WriteLine($"\nTotal da compra: R$ {total:F2}");