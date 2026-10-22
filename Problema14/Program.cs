double Notas = 5.0;
string aprobado = "aprobado";
string reprobado = "reprobado";

string resultado = Notas >= 3.0 ? aprobado : reprobado;

Console.WriteLine($"Nota:{Notas} Estado:{resultado}");