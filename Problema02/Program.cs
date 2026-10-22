decimal peso = -3.0m;


if (peso > 0.0m && peso < 1.0m)
{
    Console.WriteLine("$8.000");
}
else if (peso >= 1.0m && peso < 5.0m)
{
    Console.WriteLine("$15.000");
}
else if (peso >= 5.0m && peso < 20.0m)
{
    Console.WriteLine("$32.000");
}
else if (peso >= 20.0m)
{
    Console.WriteLine("$60.000");
} 
else
{
    Console.WriteLine("tarifa: 0 o negativa. peso invalido.");
}

Console.WriteLine($"peso: {peso}kg");