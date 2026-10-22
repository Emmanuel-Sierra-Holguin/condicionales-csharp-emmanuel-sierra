string usuario = "sin empleo";
int credito = 1800000;

if (usuario is "sin empleo")
{
    Console.WriteLine($"credito rechazado");
}
else if (usuario is "empleo")
{
    if (credito is 3000000)
    {
        Console.WriteLine($"{credito}: Credito alto aprobado");
    }
    else if (credito is 1800000)
    {
        Console.WriteLine($"{credito}: Credito basico aprobado");
    }
}