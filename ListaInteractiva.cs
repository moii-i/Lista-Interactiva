using System;
using System.Collections.Generic;

namespace InteractiveList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>(); // Crear una lista para almacenar elementos
            bool salir = false; // Variable para controlar la salida del programa

            while (!salir)
            {
                // Mostrar el menú de opciones
                Console.WriteLine("\n--- Menú de Lista Interactiva ---");
                Console.WriteLine("1. Agregar elemento");
                Console.WriteLine("2. Eliminar elemento");
                Console.WriteLine("3. Mostrar lista");
                Console.WriteLine("4. Salir");
                Console.Write("Selecciona una opción: ");

                string opcion = Console.ReadLine(); // Leer la opción del usuario

                switch (opcion)
                {
                    case "1": // Agregar elemento
                        Console.Write("Ingresa el elemento a agregar: ");
                        string elemento = Console.ReadLine();
                        lista.Add(elemento);
                        Console.WriteLine($"Elemento '{elemento}' agregado a la lista.");
                        break;

                    case "2": // Eliminar elemento
                        Console.Write("Ingresa el elemento a eliminar: ");
                        string elementoEliminar = Console.ReadLine();
                        if (lista.Contains(elementoEliminar))
                        {
                            lista.Remove(elementoEliminar);
                            Console.WriteLine($"Elemento '{elementoEliminar}' eliminado de la lista.");
                        }
                        else
                        {
                            Console.WriteLine($"Elemento '{elementoEliminar}' no encontrado en la lista.");
                        }
                        break;

                    case "3": // Mostrar lista
                        if (lista.Count > 0)
                        {
                            Console.WriteLine("\nElementos en la lista:");
                            foreach (var item in lista)
                            {
                                Console.WriteLine($"- {item}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("La lista está vacía.");
                        }
                        break;

                    case "4": // Salir
                        salir = true;
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default: // Opción no válida
                        Console.WriteLine("Opción no válida. Intenta de nuevo.");
                        break;
                }
            }
        }
    }
}