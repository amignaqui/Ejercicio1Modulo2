namespace EjercicioClase1Modulo2.Ejercicio3
{
    internal class Dimension
    {
        [System.Text.Json.Serialization.JsonPropertyName("alto")]
        public int Alto { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("ancho")]
        public int Ancho { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("profundidad")]
        public int Profundidad { get; set; }
    }
}
