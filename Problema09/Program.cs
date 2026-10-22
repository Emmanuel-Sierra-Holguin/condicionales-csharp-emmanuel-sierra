int año = 2025;

if( año % 400 == 0)
{
    Console.WriteLine($"el año {año} es divisible por 400, es bisiesto ");
}
else if (año % 100 == 0)
{
    Console.WriteLine($"el año {año}  es divisible por 100, no es bisiesto");
}
else if (año % 4 == 0)
{
    Console.WriteLine($"el año {año} es divisible por 4, es bisiesto");
}
else
{
    Console.WriteLine($"el año {año} no es divisible por 4 o 400, no es bisiesto");
}