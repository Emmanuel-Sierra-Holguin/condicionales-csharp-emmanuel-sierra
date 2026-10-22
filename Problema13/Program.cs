string codigo = "UR";

string pais = codigo switch 
{
    "CO" => $"codigo: {codigo} , pais: Colombia",
    "MX" => $"codigo: {codigo} , pais: Mexico",
    "AR" => $"codigo: {codigo}, pais: Argentina",
    "PE" => $"codigo: {codigo}, Pais: Peru  ",
    "CL" => $"codigo: {codigo}, pais: Chile",
    _ => $" {codigo} Pais no registrado"
};


Console.WriteLine(pais);
