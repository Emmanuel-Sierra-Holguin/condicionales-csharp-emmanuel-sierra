

string semaforo = "Verde";

if (semaforo is "Rojo")
{
    Console.WriteLine($"{semaforo} Detengase");
}
else if (semaforo is "Amarillo")
{
     Console.WriteLine($"{semaforo} Precaucion, preparese para detenerse");
}
else if (semaforo is "Verde")
{
    Console.WriteLine($"{semaforo} Avance");
}