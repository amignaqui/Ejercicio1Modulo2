namespace EjercicioClase1Modulo2.Ejercicio1
{
    internal class Usuario
    {
        [System.Text.Json.Serialization.JsonPropertyName("usuario")]
        public required string NombreUsuario { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("amigos_usuario")]
        public required string[] NombreAmigo { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("notificaciones_usuario")]
        public bool Notificaciones { get; set; }
    }
}
