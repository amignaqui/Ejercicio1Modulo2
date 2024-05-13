using System.Text.Json;
using EjercicioClase1Modulo2.Ejercicio1;
using EjercicioClase1Modulo2.Ejercicio2;
using EjercicioClase1Modulo2.Ejercicio3;

namespace EjercicioClase1Modulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INI - Ejercicio clase 1 modulo 2");
            // Consigna:
            // En la ruta principal del proyecto hay 3 archivos json, para cada uno de ellos crear las clases que consideren necesarias para poder deserializar correctamente
            // Uso: JsonSerializer.Deserialize<ClaseCreada>(data);
          
            var pathEjercicio1 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio1.json";
            var pathEjercicio2 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio2.json";
            var pathEjercicio3 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio3.json";

            var dataEjercicio1 = File.ReadAllText(pathEjercicio1);
            var dataEjercicio2 = File.ReadAllText(pathEjercicio2);
            var dataEjercicio3 = File.ReadAllText(pathEjercicio3);

            // Comentario: incorpore JsonSerializer.Serialize y display para ver resultados en pantalla

            Console.WriteLine("\nINI - Ejercicio1");
            Usuario myUsuario = JsonSerializer.Deserialize<Usuario>(dataEjercicio1)!;
            string jsonUsuario = JsonSerializer.Serialize(myUsuario);
            Console.WriteLine(jsonUsuario);
            Console.WriteLine("FIN - Ejercicio1");

            Console.WriteLine("\nINI - Ejercicio2");
            EstadisticaPorEquipo myEstadisticaPorEquipo = JsonSerializer.Deserialize<EstadisticaPorEquipo>(dataEjercicio2)!;  
            string jsonEstadisticaPorEquipo = JsonSerializer.Serialize(myEstadisticaPorEquipo);
            Console.WriteLine(jsonEstadisticaPorEquipo);
            Console.WriteLine("FIN - Ejercicio2");

            Console.WriteLine("\nINI - Ejercicio3");
            ListaDeProductos myListaDeProductos = JsonSerializer.Deserialize<ListaDeProductos>(dataEjercicio3)!;
            string jsonListaDeProductos = JsonSerializer.Serialize(myListaDeProductos);
            Console.WriteLine(jsonListaDeProductos);
            Console.WriteLine("FIN - Ejercicio3");
                        
            Console.WriteLine("\nFIN - Ejercicio clase 1 modulo 2");
        }
    }
}