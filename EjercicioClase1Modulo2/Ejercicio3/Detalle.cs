namespace EjercicioClase1Modulo2.Ejercicio3
{
    internal class Detalle
    {
        [System.Text.Json.Serialization.JsonPropertyName("peso")]
        public double Peso { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("dimensiones")]
        public Dimension? Dimensiones { get; set; }
    }
}
