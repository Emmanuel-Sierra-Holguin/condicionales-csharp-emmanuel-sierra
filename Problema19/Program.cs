int velocidad = 100;

string sancion = velocidad switch
{
  < 0 => $"velocidad: {velocidad}, sancion: Lectura invalida",  
  >= 0 and <= 50 => $"velocidad: {velocidad}, sancion: Sin infraccion",
  > 50 and <= 70 => $"velocidad: {velocidad}, sancion: Multa leve",
  > 70 and <= 90 => $"velocidad: {velocidad}, sancion: Multa grave",
  > 90 => $"velocidad: {velocidad}, sancion: Multa gravisima e inmovilizacion"
};

Console.WriteLine(sancion);