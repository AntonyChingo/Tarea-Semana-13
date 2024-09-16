using System;
using System.Collections.Generic;

class Program
{
    // Método para realizar la búsqueda iterativa de un título
    static bool BuscarTitulo(List<string> catalogo, string tituloBuscado)
    {
        foreach (string titulo in catalogo)
        {
            if (titulo.Equals(tituloBuscado, StringComparison.OrdinalIgnoreCase))
            {
                return true; // Se encontró el título
            }
        }
        return false; // No se encontró el título
    }

    static void Main()
    {
        // Creación del catálogo de revistas
        List<string> catalogoRevistas = new List<string>()
        {
            "Revista de Tecnología",
            "Ciencia y Futuro",
            "Mundo Informático",
            "Ingeniería Hoy",
            "Innovación Digital",
            "Tecnología Médica",
            "Energía y Sostenibilidad",
            "Robótica Avanzada",
            "Biotecnología Moderna",
            "Desarrollo de Software"
        };

        // Menú de búsqueda
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\nMenú de Búsqueda en Catálogo de Revistas:");
            Console.WriteLine("1. Buscar un título");
            Console.WriteLine("2. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("\nIngrese el título que desea buscar: ");
                    string tituloBuscado = Console.ReadLine();

                    // Realizar la búsqueda
                    bool encontrado = BuscarTitulo(catalogoRevistas, tituloBuscado);

                    if (encontrado)
                    {
                        Console.WriteLine($"El título '{tituloBuscado}' ha sido encontrado en el catálogo.");
                    }
                    else
                    {
                        Console.WriteLine($"El título '{tituloBuscado}' no se encuentra en el catálogo.");
                    }
                    break;

                case "2":
                    continuar = false;
                    Console.WriteLine("Saliendo del programa.");
                    break;

                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }
        }
    }
}
