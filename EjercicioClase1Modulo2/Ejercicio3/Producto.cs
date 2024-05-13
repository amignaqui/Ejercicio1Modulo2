namespace EjercicioClase1Modulo2.Ejercicio3
{
    internal class Producto
    {
        [System.Text.Json.Serialization.JsonPropertyName("nombre")]
        public string? Nombre { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("precio")]
        public double? Precio { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("existencias")]
        public int? Existencias { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("descuento_disponible")]
        public bool Descuento { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("etiquetas")]
        public string[]? Etiquetas { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("detalles")]
        public Detalle? Detalles { get; set; }
    }
}
