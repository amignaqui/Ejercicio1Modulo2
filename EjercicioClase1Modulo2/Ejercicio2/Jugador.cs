namespace EjercicioClase1Modulo2.Ejercicio2
{
    internal class Jugador
    {
        [System.Text.Json.Serialization.JsonPropertyName("nombre")]
        public required string Nombre { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("kills")]
        public int Kills { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("death")]
        public int Death { get; set; }
    }
}
