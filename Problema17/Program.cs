Console.WriteLine("Reproductor de musica.");
Console.WriteLine(@"Comandos disponibles:
play,
pause,
stop,
next");
Console.Write("selecciona comando: ");
string usuario = Console.ReadLine();

switch (usuario)
{
    case "play":
    Console.WriteLine("Reproduciendo..."); 
    break; 
    case "pause":
    Console.WriteLine("En pausa");
    break;   
    case "stop":
    Console.WriteLine("Detenido");
    break;   
    case "next":
    Console.WriteLine("Siguiente cancion");
    break;    
    default:
    Console.WriteLine("comando no reconocido");
    break; 
}