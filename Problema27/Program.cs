(string dia, bool estudiante) boleta = ("sabado", false);

string precio = boleta switch
{
    ("lunes" or "miercoles" or "jueves" or "viernes", true) => $"$9.000",
    ("lunes" or "miercoles" or "jueves" or "viernes", false) => $"$12.000",
    ("martes", true or false ) => "$7.000",
    ("sabado" or "domingo", true or false) => " $15.000"
};

Console.WriteLine(precio); 