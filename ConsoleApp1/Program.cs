using ejercicio;
byte opcion;
string regresar;

do
{

    Console.WriteLine("BIENVENDIOS AL SISTEMA DE REGISTRO DE EDADES\n");

    Console.WriteLine("******* MENÚ *******");

    Console.WriteLine("* 1. Insentar   *");

    Console.WriteLine("* 2. Mostrar    *");

    Console.WriteLine("* 3. Eliminar   *");

    Console.WriteLine("* 4. Ordenar    *");

    Console.WriteLine("* 0. Salir     *");

    Console.WriteLine("********************\n");



    Console.Write("Ingrese opcion: ");



    while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 4)
    {

        Console.Write("Error: Ingrese opcion: ");

    }



    switch (opcion)
    {

        case 0: Environment.Exit(0); break;

        case 1:
            en.insertar();
                break;

        case 2: break;

        case 3: break;

        case 4: break;

    }

    Console.WriteLine("Desea regresar al menú? [si]: ");

    regresar = Console.ReadLine();

    Console.Clear();

} while (regresar == "si");