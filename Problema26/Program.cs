string categoria = "N";

string tarifa = categoria switch 
{
    "M" => $"{categoria} Categoria:moto  ,Tarifa: $0 (exenta) ",
    "A" => $"{categoria} Categoria:automovil ,Tarifa: $12.000 ",
    "B" => $"{categoria} Categoria:bus, Tarifa:$25.000 ",
    "C" => $"{categoria} Categoria:camion,Tarifa:  $38.000  ",
    _ => $" {categoria} categoria desconocida"
};

Console.WriteLine(tarifa);

