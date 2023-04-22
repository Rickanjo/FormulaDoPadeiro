// Faça um programa que calcule a quantidade de ingredientes necessários para a confecção de um pão italiano (a partir da receita acima) para que o peso obtido ao final coincida com o peso desejado.

Console.WriteLine("--- Formula do padeiro ---\n");

Console.Write("Digite o peso desejado para o pão (em gramas): ");
double pesoDesejado = double.Parse(Console.ReadLine()!);

double percentualTotal = 1 + 0.7 + 0.4 + 0.02;
double quantidadeFarinha = pesoDesejado / percentualTotal;
double quantidadeAgua = quantidadeFarinha * 0.7;
double quantidadeFermento = quantidadeFarinha * 0.4;
double quantidadeSal = quantidadeFarinha * 0.02;

Console.WriteLine($"Para fazer um pão italiano com {pesoDesejado:N0} gramas, você vai precisar de:");
Console.WriteLine($"{quantidadeFarinha:N0} g de farinha");
Console.WriteLine($"{quantidadeAgua:N0} g de água");
Console.WriteLine($"{quantidadeFermento:N0} g de fermento");
Console.WriteLine($"{quantidadeSal:N0} g de sal");






