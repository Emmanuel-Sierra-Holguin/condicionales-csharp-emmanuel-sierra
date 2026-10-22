(string jugador1, string jugador2) jugadores = ("piedra", "piedra");

string jugada = jugadores switch
{
     ("piedra", "tijera") => "gana jugador 1",
     ("tijera", "piedra") => "gana jugador 2",
     ("tijera", "papel") => "gana jugador 1",
     ("papel", "tijera") => "gana jugador 2",
     ("papel", "piedra") => "gana jugador 1",
     ("piedra", "papel") => "gana jugador 2",
     _ => "Empate o eso no hace parte del juego"
};
Console.WriteLine(jugadores);
Console.WriteLine(jugada);