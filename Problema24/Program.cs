int dia = 0;
string tipoDia;

if (dia >= 1 && dia <= 5)
{
    tipoDia = "Día hábil";
}
else if (dia == 6 || dia == 7)
{
    tipoDia = "Fin de semana";
}
else
{
    tipoDia = "Día inválido";
}

Console.WriteLine(tipoDia);
