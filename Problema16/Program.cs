(int X, int Y)  Dron = (0,5);

string centro = Dron switch
{
    (3,4) => $"Coordenadas: {Dron}; Primer cuadrante.",
    (-2,-7) => $"Coordenadas: {Dron}; Tercer cuadrante.",
    (0,0) => $"Coordenadas: {Dron}; origen.",
    (0,5) => $"Coordenadas: {Dron}; sobre un eje."
};

Console.WriteLine(centro);