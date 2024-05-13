namespace EjercicioClase1Modulo2.Ejercicio3
{
    internal class ListaDeProductos
    {
        [System.Text.Json.Serialization.JsonPropertyName("productos")]
        //public required string[] Estadistica { get; set; }
        public List<Producto>? Productos { get; set; }
    }
}