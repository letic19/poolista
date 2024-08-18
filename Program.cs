//1.Escreva um programa em C# que declare variáveis dos tipos int, float, string e bool. Atribua valores a essas variáveis e imprima-os no console.
/*
//*declarando uma variavel inteira*
int i = 10;
//*declarando uma variavel flutuante*
double d = 5.8;
//*declarando uma variavel flutuante*
float f = 5.6f;
//*declarando uma variavel string*
string s = "atividade";
//*declarando uma variavel booleana*
bool b = false;

//*imprimindo as variaveis no terminal*
Console.WriteLine($"{i}");
Console.WriteLine($"{d}");
Console.WriteLine($"{f}");
Console.WriteLine($"{s}");
Console.WriteLine($"{b}");
*/

//2.Crie um programa que leia dois números inteiros do usuário e exiba a soma, subtração, multiplicação e divisão desses números.
//*declarando uma variavel inteira que tera um valor atribuido pelo usuario*
/*
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());


int soma = n1 + n2;
int subtracao = n1 - n2;
int multiplicacao = n1 * n2;
int divisao = n1 / n2;


Console.WriteLine($"soma:{soma}");
Console.WriteLine($"subtracao:{subtracao}");
Console.WriteLine($"multiplicacao:{multiplicacao}");
Console.WriteLine($"divisao:{divisao}");
*/

//3.Escreva um programa que solicite o nome do usuário e sua idade. O programa deve exibir uma mensagem como "Olá, [nome], você tem [idade] anos.");
/*

string nome = Console.ReadLine();
int idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Olá, {nome}, você tem {idade} anos ");
*/

//4.Faça um programa que leia um número do usuário e informe se ele é positivo, negativo ou zero.
/*
int numero = int.Parse(Console.ReadLine());

if (numero > 0)
{
    Console.WriteLine($"O número {numero} é positivo");
}
else if (numero < 0)
{
    Console.WriteLine($"O número {numero} é negativo");
}
else
{
    Console.WriteLine($"O número {numero} é igual a zero");
}
*/

//5.Crie um programa que exiba os números de 1 a 10 usando um loop for.

// for (int cont = 1; cont <= 10; cont ++)
// {
// Console.WriteLine(cont);
// }

//6.Escreva um programa que leia a idade de uma pessoa e verifique se ela é maior de idade (18 anos ou mais) e se está apta a votar e a dirigir.
// Console.WriteLine("Digite a idade de uma pessoa e direi se ela é maior de idade e esta apta a vota e dirigir.");
// int idade = int.Parse(Console.ReadLine());
// if (idade >= 18)
// {
//     Console.WriteLine("A pessoa é maior de idade e esta apta a votar e dirigir");
// }
// else if(idade == 16)
// {
//     Console.WriteLine("A pessoa é menor de idade e esta apta a votar");
// }
// else
// {
//     Console.WriteLine("A pessoa é menor de idade e não esta apta a votar e dirigir");
// }

//7.Implemente uma função em C# chamada CalcularMedia que recebe três notas (float) como parâmetros e retorna a média dessas notas. Chame essa função a partir do método Main e exiba o resultado no console.

// using System;

// class Program
// {
//     static float CalcularMedia(float nota1, float nota2, float nota3)
//     {
//         return (nota1 + nota2 + nota3) / 3;
//     }

//     static void Main(string[] args)
//     {
//         Console.WriteLine("Digite a nota 1:");
//         float nota1 = float.Parse(Console.ReadLine());
        
//         Console.WriteLine("Digite a nota 2:");
//         float nota2 = float.Parse(Console.ReadLine());
        
//         Console.WriteLine("Digite a nota 3:");
//         float nota3 = float.Parse(Console.ReadLine());

//         float media = CalcularMedia(nota1, nota2, nota3);
//         Console.WriteLine("A média das notas é: " + media);
//     }
// }

//8.Escreva um programa que leia três números e determine o maior e o menor deles. Exiba o resultado no console.
// Console.WriteLine("Digite 3 numeros e direi qual o menor e maior deles.");
// int num1 = int.Parse(Console.ReadLine());
// int num2 = int.Parse(Console.ReadLine());
// int num3 = int.Parse(Console.ReadLine());

// if (num1 > num2 && num1 > num3)
// {
//     Console.WriteLine($"O maoir numero é {num1}");
// }
// else if(num2 > num1 && num2 > num3)
// {
//     Console.WriteLine($"O maoir numero é {num2}");
// }
// else
// {
//     Console.WriteLine($"O maoir numero é {num3}");
// }

// if(num1 < num2 && num1 < num3)
// {
//     Console.WriteLine($"E o menor numero é {num1}");
// }
// else if(num2 < num1 && num2 < num3)
// {
//     Console.WriteLine($"E o menor numero é {num2}");
// }
// else
// {
//     Console.WriteLine($"E o menor numero é {num3}");
// }

//9.Crie um programa que solicite números ao usuário até que ele digite zero. Ao final, o programa deve exibir a soma de todos os números digitados.
// Console.WriteLine("Descubra o numero secreto");
// int soma = 0;

// while (true)
// {
    
//     int numero = int.Parse(Console.ReadLine());

//     if (numero == 0)
//     {
//         Console.WriteLine("Voce descobriu o numero secreto");
//         break;
//     }
//     else
//     {
//         Console.WriteLine("Digite outro numero");
//         soma += numero;
//     }
   

// }

// Console.WriteLine($"A soma é {soma}");

//10.Escreva um programa que leia um valor em reais e o converta para dólares. Considere que a taxa de câmbio seja informada pelo usuário. Exiba o valor convertido no console.
// Console.WriteLine("Digite o valor em reais");
// double reais = double.Parse(Console.ReadLine());
// Console.WriteLine("Digite a taxa de cambio");
// double taxaDeCambio = double.Parse(Console.ReadLine());


// double convertido = reais / taxaDeCambio;

// Console.WriteLine($"O valor em dolares é igual a: {convertido}");

//11.Implemente uma função recursiva em C# chamada CalcularFatorial que recebe um número inteiro n e retorna o fatorial dele. Utilize operadores lógicos para garantir que a função trate adequadamente os casos de entrada negativa e zero. Teste a função a partir do método Main.

// Console.WriteLine("Insira um número para calcular o fatorial:");
// int n = int.Parse(Console.ReadLine());

// if (n < 0)
// {
//     Console.WriteLine("Não é possivel calcular um fatorial de um numero negativo.");
// }
// else
// {
//     int resultado = CalcularFatorial(n);
//      Console.WriteLine($"O fatorial de {n} é {resultado}");
// }
// static int CalcularFatorial(int n)
// {
//     if (n == 0 || n == 1)
//         {
//             return 1;
//         }
//     else
//         {
//             return n * CalcularFatorial(n - 1);
//         }

//   }

//12.Crie um programa que gere a sequência de Fibonacci até um número n fornecido pelo usuário. Utilize um loop while para gerar a sequência e uma estrutura condicional para evitar números negativos e zero como entrada.
// Console.WriteLine("Digite um numero.");
// int n = int.Parse(Console.ReadLine());

// while(n <= 0 )
// {
//     Console.WriteLine("Digite um numero positivo");
//     n = int.Parse(Console.ReadLine());
// }

// int a = 0;
// int b = 1;
// Console.WriteLine($"Sequencia de fibonacci ate {n}:");

// while(a <= n)
// {
//     Console.WriteLine(a);
//     int aux = a;
//     a = b;
//     b = aux + b; 
// }

//13.Escreva um programa que leia uma lista de nomes do usuário e ordene essa lista em ordem alfabética. Utilize uma função para realizar a ordenação (pode ser um algoritmo de ordenação simples, como bubble sort ou insertion sort) e exiba a lista ordenada no console.

// string nomes = Console.ReadLine();
// string[] nomesArray = nomes.Split(' ');
// Array.Sort(nomesArray);
// foreach (string nome in nomesArray)
// {
//     Console.WriteLine(nome);

//  }