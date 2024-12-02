using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        try
        {
            // Obtén el tipo COM
            Type comType = Type.GetTypeFromProgID("DCOMServer.Sumador");
            if (comType == null)
            {
                Console.WriteLine("No se pudo obtener el tipo COM.");
                return;
            }

            // Crea una instancia del objeto COM
            object comObject = Activator.CreateInstance(comType);

            // Llama a un método del objeto COM (supón que el objeto tiene un método llamado Sumar)
            var metodoSumar = comObject.GetType().GetMethod("Sumar");
            if (metodoSumar != null)
            {
                // Suponiendo que Sumar devuelve un resultado
                var resultado = metodoSumar.Invoke(comObject, new object[] { 5, 3 }); // Sumando 5 y 3
                Console.WriteLine($"Resultado de la suma: {resultado}");
            }
            else
            {
                Console.WriteLine("Método 'Sumar' no encontrado en el objeto COM.");
            }

            Console.WriteLine("Objeto COM creado exitosamente.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Se produjo un error: {ex.Message}");
            Console.WriteLine($"Pila de llamadas: {ex.StackTrace}");
        }

        // Espera hasta que el usuario presione una tecla
        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadLine();
    }
}

