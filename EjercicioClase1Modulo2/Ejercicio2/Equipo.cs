namespace EjercicioClase1Modulo2.Ejercicio2
{
    internal class Equipo
    {     
        [System.Text.Json.Serialization.JsonPropertyName("equipo")]
        public string? NombreEquipo { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("jugadores")]
        public List<Jugador>? Jugadores { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("campeon")]
        public bool Campeon { get; set; }
    }
}
