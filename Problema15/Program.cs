double peso = 100;
double estatura = 1.75;

double IMC = peso /(estatura * estatura);


if (IMC < 18.5)
{
    Console.WriteLine($"peso: {peso}, estatura:{estatura} , IMC: {IMC:F1} - bajo peso");
}
else if ( IMC >= 18.5 && IMC < 25)
{
        Console.WriteLine($"peso: {peso}, estatura:{estatura} , IMC: {IMC:F1} - Peso normal");
}
else if (IMC >= 25 && IMC < 30)
{
        Console.WriteLine($"peso: {peso}, estatura:{estatura} , IMC: {IMC:F1} - Sobrepeso");
}
else if (IMC == 30 || IMC > 30)
{
        Console.WriteLine($"peso: {peso}, estatura:{estatura} , IMC: {IMC:F1} - Obesidad");
}
