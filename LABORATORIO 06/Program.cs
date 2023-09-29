using System;

class Program
{
    static void Main()
    {
        int nm = 0;
        int aa = 0;
        int pi = 0;
        int ps = 0;
        int lleno = 0;
        int vacio = 0;

        Console.Write("Ingrese un número máximo de personas: ");
        if (int.TryParse(Console.ReadLine(), out nm) && nm > 0)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("El número máximo establecido es de " + nm);
            Console.WriteLine("personas, presione una tecla para comenzar");
            Console.Write("a contar ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"El número máximo establecido es de {nm} personas.");
            Console.WriteLine("Presione [n] para cambiar de opción");
            Console.WriteLine("Presione [i] si ingresa una persona");
            Console.WriteLine("[s] si sale una persona");
            Console.WriteLine("[x] para terminar");

            string opcion = "i";

            do
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine($"|Asistentes actuales | {aa}");
                Console.WriteLine($"|Aforo               | {aa * 100 / nm} %");
                Console.WriteLine($"|Máximo              | {nm} personas");
                Console.WriteLine("=================================");

                if (opcion == "i")
                {
                    Console.WriteLine("Para cambiar de opcion presione [w]");
                    Console.WriteLine("Presione");
                    Console.WriteLine("[i] si ingresa una persona(Seleccionado)");
                    Console.WriteLine("[s] si sale una persona");
                    Console.WriteLine("[x] para terminar");
                    if (aa == nm)
                    {
                        lleno++;
                    }
                }
                else if (opcion == "s")
                {
                    Console.WriteLine("Para cambiar de opcion presione [w]");
                    Console.WriteLine("Presione");
                    Console.WriteLine("[i] si ingresa una persona");
                    Console.WriteLine("[s] si sale una persona(Seleccionado)");
                    Console.WriteLine("[x] para terminar");
                    if (aa == 0)
                    {
                        vacio++;
                    }
                }
                else if (opcion == "x")
                {
                    Console.WriteLine("Para cambiar de opcion presione [w]");
                    Console.WriteLine("Presione");
                    Console.WriteLine("[i] si ingresa una persona");
                    Console.WriteLine("[s] si sale una persona");
                    Console.WriteLine("[x] para terminar(Seleccionado)");
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.W)
                {
                    if (opcion == "i") opcion = "s";
                    else if (opcion == "s") opcion = "x";
                    else if (opcion == "x") opcion = "i";
                }
                else if (keyInfo.Key == ConsoleKey.I && opcion == "i")
                {
                    if (aa < nm)
                    {
                        aa++;
                        pi++;
                    }
                    else
                    {
                        Console.WriteLine("\nEl local está lleno.");
                        Console.WriteLine("No se pueden ingresar más personas al local.");
                        Console.ReadKey();
                    }
                }
                else if (keyInfo.Key == ConsoleKey.S && opcion == "s")
                {
                    if (aa > 0)
                    {
                        aa--;
                        ps++;
                    }
                    else
                    {
                        Console.WriteLine("\nEl local ya está vacío.");
                        Console.WriteLine("No se puede sacar más personas.");
                        Console.ReadKey();
                    }
                }
                else if (keyInfo.Key == ConsoleKey.X && opcion == "x")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("\nOpción no válida.");
                    Console.WriteLine("Presione [w] seleccionar una opcion y [i], [s] o [x] para confirmarla.");
                    Console.ReadKey();
                }
            } while (true);

            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("El programa ha terminado");
            Console.WriteLine("=================================");
            Console.WriteLine("Estadísticas:");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"{pi} personas ingresaron");
            Console.WriteLine($"{ps} personas salieron");
            Console.WriteLine($"{lleno} veces se llenó el local");
            Console.WriteLine($"Estuvo vacío {vacio} veces");
        }
        else
        {
            Console.WriteLine("El número máximo debe ser mayor que cero.");
        }
        Console.ReadKey();
    }
}
