double nota1 = 85;
double nota2 = 78;
double nota3 = 92;

double promedio = (nota1 + nota2 + nota3) / 3.0;

char letra;
string retroalimentacion;

if (promedio >= 90)
{
    letra = 'A';
    retroalimentacion = "Desempeño excelente";
}
else if (promedio >= 80)
{
    letra = 'B';
    retroalimentacion = "Buen desempeño, sigue así";
}
else if (promedio >= 70)
{
    letra = 'C';
    retroalimentacion = "Buen desempeño, sigue así";
}
else if (promedio >= 60)
{
    letra = 'D';
    retroalimentacion = "Aprobado, refuerza los temas";
}
else
{
    letra = 'F';
    retroalimentacion = "Debe presentar plan de mejoramiento";
}

string estado = (promedio >= 60) ? "Aprobado" : "Reprobado";

Console.WriteLine($"Promedio: {promedio:F1} | Letra: {letra} | {retroalimentacion} | {estado}");

if (promedio == 100)
{
    Console.WriteLine("¡Mención de honor!");
}
