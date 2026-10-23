string rol = "instructor";
int hora = 20;

if (rol == "admin")
{
    Console.WriteLine("Acceso permitido");
}
else if (rol == "instructor" && hora >= 6 && hora <= 21)
{
    Console.WriteLine("Acceso permitido");
}
else if (rol == "aprendiz" && hora >= 6 && hora <= 18)
{
    Console.WriteLine("Acceso permitido");
}
else
{
    Console.WriteLine("Acceso denegado");
}