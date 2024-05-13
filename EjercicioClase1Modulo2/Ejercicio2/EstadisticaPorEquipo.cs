namespace EjercicioClase1Modulo2.Ejercicio2
{
    internal class EstadisticaPorEquipo
    {
        [System.Text.Json.Serialization.JsonPropertyName("estadistica")]
        public List<Equipo>? Estadistica { get; set; }
    }
}