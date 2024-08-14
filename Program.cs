// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Olá, Mundo!");


// 1. Tipos de variáveis var, int, short, long, decimal, double, bool e string;

int a = 10;
int b = 5;
string str = "Texto Qualquer";
var str2 = "Texto qualquer (Var)";

// Console.WriteLine("Texto: " + str);
// Console.WriteLine("Texto (Var): " + str2);
// Console.WriteLine($"Texto: {str2}");

// 2. Operadores de atribuição, aritméticos, relacionais, lógicos e unários;

int r = a + b;
// Console.WriteLine("Resultado " + r);

Console.WriteLine("Informe a primeira nota: ");
var nota1 = Console.ReadLine();

Console.WriteLine("Informe a segunda nota");
var nota2 = Console.ReadLine();

Console.WriteLine($"Nota 1: {nota1}");
Console.WriteLine($"Nota 2: {nota2}");



// var resultado = Convert.ToDouble(nota1)  + Convert.ToDouble(nota2);
var media = (Convert.ToDouble(nota1)  + Convert.ToDouble(nota2))/2;

Console.WriteLine($"Media: {media}");

if(media >= 6){
    Console.WriteLine("Aprovado");
}else{
    Console.WriteLine("Reprovado");
}

// Console.WriteLine($"Soma da Nota 1 + Nota 2 é: {resultado}");

// 3. Estruturas de decisão if/else, ternárias e switch;

// 4. Estruturas de repetição while, do/while, for, foreach;
// 5. Arrays e List.






