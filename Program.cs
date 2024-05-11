//Um pescador amador solicita um software para avaliação da legalidade de sua pesca. Faça um programa que receba o peso do pescado em kg e o local da pesca (C ou M) e exiba, conforme o caso:

Console.Clear();
 
const double pesoMaritima = 15; 

const double pesoContinental = 10; 
 
const decimal multaTotal = 1000;

const decimal multaAdicional = 20; 
 
double pesoPescado, pesoPermitido, pesoUltrapassado;
decimal valorMultaTotal;
 
string localPescado; 
 
ConsoleColor cor;
 
Console.WriteLine("--- Pesca Amadora ---");
 
Console.Write("\nDigite quantos kilos voce pescou: ");
pesoPescado = Convert.ToDouble(Console.ReadLine());
 
Console.WriteLine("\n[C]ontinental ou [M]aritimo");
 
Console.Write("\nOnde voce pescou? ");
localPescado = Console.ReadLine()!.ToUpper().Substring(0, 1);
 
if (localPescado != "M" && localPescado != "C")
{
    cor = ConsoleColor.Red;
    Console.ForegroundColor = cor;
    Console.WriteLine("Local nao identificado");
    Console.ResetColor();
    return;
}
 
if (localPescado == "M" && pesoPescado <= pesoMaritima || localPescado == "C" && pesoPescado <= pesoContinental)
{
    cor = ConsoleColor.Green;
    Console.ForegroundColor = cor;
    Console.WriteLine("Peso permitido");
    Console.ResetColor();
    return;
}
 
pesoPermitido = localPescado == "C" ? pesoContinental : pesoMaritima;
 
pesoUltrapassado = pesoPescado - pesoPermitido;
 
Console.Write("\nO peso ultrapassado é ");
 
cor = ConsoleColor.Magenta;
Console.ForegroundColor = cor;
Console.WriteLine($"{pesoUltrapassado} kg");
Console.ResetColor();
 
valorMultaTotal = multaTotal + multaAdicional * Convert.ToDecimal(pesoUltrapassado);
 
Console.Write("\nO valor da multa à ser pago é de ");
 
cor = ConsoleColor.Magenta;
Console.ForegroundColor = cor;
Console.WriteLine($"R$ {valorMultaTotal:C}");
Console.ResetColor();