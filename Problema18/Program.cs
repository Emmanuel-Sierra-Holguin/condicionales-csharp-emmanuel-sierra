double estatura = 1.50;
int edad = 13;
bool adulto = false;

if(estatura >= 1.40 && edad >= 12 && adulto is false)
{
    Console.WriteLine($"estatura: {estatura:F2}, edad:{edad}, sin acompañante => Puede subir");
}
else if(estatura >= 1.40 && edad < 12 && adulto is true)
{
    Console.WriteLine($"estatura: {estatura:F2}, edad:{edad}, con acompañante => Puede subir");
}
else if(estatura >= 1.40 && edad < 12 && adulto is false)
{
    Console.WriteLine($"estatura: {estatura:F2}, edad:{edad}, sin acompañante => no puede subir");
}
else
{
    Console.WriteLine($"estatura: {estatura:F2}, edad:{edad}, con acompañante => no puede subir");
}
