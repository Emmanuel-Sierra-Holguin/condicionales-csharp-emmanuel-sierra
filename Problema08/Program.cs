string letra = "1";

string leer = letra switch
{
    "a" or "e" or "i" or "o" or "u" => $"{letra} es una vocal",
    "b" or "c" or "d" or "f" or "g" or "h" or "j" or "k" or "l" or "m" or "n" or "ñ" or "p" or "q" or "r" or "s" or "t" or "v" or "w" or "x" or "y" or "z" => $"{letra} es una consonante",
    _ => $"{letra} no es una letra"
};

Console.WriteLine(leer);
