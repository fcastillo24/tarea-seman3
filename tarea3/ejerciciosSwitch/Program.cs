while (true)
{
    Console.WriteLine("Seleccione que Ejercicio Desea Realizar:\n");
    Console.WriteLine("1. Convertir un Numero de Letras a Numero");
    Console.WriteLine("2. Mostrar un Dia de la Semana a Prtir de un Numero");
    Console.WriteLine("3. Calcular el Importe a Pagar de un Servicio");
    Console.WriteLine("4. Mostrar un Mensaje de Bienvenida en Diferentes Idioms");
    Console.WriteLine("5. Evaluar la Calificacion de un Examen");
    Console.WriteLine("6. Salir\n");

    int opcion = int.Parse(Console.ReadLine());
    Console.WriteLine("\n");

    switch (opcion)
    {
        case 1:
            Ejercicio1();
            break;
        case 2:
            Ejercicio2();
            break;
        case 3:
            Ejercicio3();
            break;
        case 4:
            Ejercicio4();
            break;
        case 5:
            Ejercicio5();
            break;
        case 6:
            return;
        default: // Opción Invalida
            Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 5.");
            break;
    }
}
static void Ejercicio1()
{
    {
        Console.WriteLine("Ingrese un número en letras (uno, dos, tres, cuatro, cinco):");
        string numeroEnLetras = Console.ReadLine().ToLower(); // Convertir a minúsculas para comparar sin importar mayúsculas/minúsculas

        int numeroEnNumero = ConvertirNumero(numeroEnLetras);

        if (numeroEnNumero != -1)
        {
            Console.WriteLine($"El número en letras '{numeroEnLetras}' es equivalente al número '{numeroEnNumero}'.");
        }
        else
        {
            Console.WriteLine("Número en letras ingresado no válido.");
        }
    }

    static int ConvertirNumero(string numeroEnLetras)
    {
        switch (numeroEnLetras)
        {
            case "uno":
                return 1;
            case "dos":
                return 2;
            case "tres":
                return 3;
            case "cuatro":
                return 4;
            case "cinco":
                return 5;
            default:
                return -1; // Retornar -1 si la entrada no es válida
        }
    }
}
static void Ejercicio2()
{
    Console.WriteLine("Ingrese un número del 1 al 7:");
    int numero = int.Parse(Console.ReadLine());

    string diaDeLaSemana = ObtenerDiaDeLaSemana(numero);

    if (diaDeLaSemana != "")
    {
        Console.WriteLine($"El día correspondiente al número {numero} es {diaDeLaSemana}.");
    }
    else
    {
        Console.WriteLine("Número fuera de rango.");
    }
}

   static string ObtenerDiaDeLaSemana(int numero)
    {
    switch (numero)
    {
        case 1:
            return "Lunes";
        case 2:
            return "Martes";
        case 3:
            return "Miércoles";
        case 4:
            return "Jueves";
        case 5:
            return "Viernes";
        case 6:
            return "Sábado";
        case 7:
            return "Domingo";
        default:
            return "";
    }
 }
static void Ejercicio3()
{
    {
        Console.WriteLine("Seleccione el servicio:");
        Console.WriteLine("1. Lavado de auto");
        Console.WriteLine("2. Cambio de aceite");
        Console.WriteLine("3. Revisión mecánica");

        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                CalcularImporte(30);
                break;
            case 2:
                CalcularImporte(100);
                break;
            case 3:
                CalcularImporte(300);
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }

    static void CalcularImporte(double costoServicio)
    {
        Console.WriteLine($"El importe a pagar es: {costoServicio} quetzales");
    }
}
static void Ejercicio4()
{
    Console.WriteLine("Seleccione su idioma / Choose your language / Choisissez votre langue:");
    Console.WriteLine("1. Español");
    Console.WriteLine("2. English");
    Console.WriteLine("3. Français");

    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            MostrarBienvenida("Bienvenido al programa!");
            break;
        case 2:
            MostrarBienvenida("Welcome to the program!");
            break;
        case 3:
            MostrarBienvenida("Bienvenue dans le programme!");
            break;
        default:
            Console.WriteLine("Opción no válida / Invalid option / Option invalide");
            break;
    }
}

static void MostrarBienvenida(string mensaje)
{
    Console.WriteLine(mensaje);
}
static void Ejercicio5()
{
    Console.WriteLine("Ingrese la Calificacion");
    int calificacion = int.Parse(Console.ReadLine());
    switch (calificacion)
    {
        case >= 90 and <= 100:
            Console.WriteLine("Usted es Sobresaliente");
            break;
        case >= 80 and <= 89:
            Console.WriteLine("usted es Notable");
            break;
        case >= 70 and <= 79:
            Console.WriteLine("usted es Aprobatoria");
            break;
        case >= 60 and <= 69:
            Console.WriteLine("usted no es Aprobatoria");
            break;
        default:
            Console.WriteLine("califiacion invalida");
            break;
    }
}

