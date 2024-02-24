while (true)
{
Console.WriteLine("Seleccione que Ejercicio Desea Realizar:\n");
Console.WriteLine("1. Calcular el Mayor de 3 Numeros");
Console.WriteLine("2. Validar Edad para Ingresar a un Club");
Console.WriteLine("3. Calcular Precio Final de un Producto");
Console.WriteLine("4. Validar  Usuario y Contraseña");
Console.WriteLine("5. Determinar si un Numero es Par o Impar");
Console.WriteLine("6. Mostrar un Mensaje de Aprovacion o Rechazo");
Console.WriteLine("7. Calcular el Area de una Figura Geometrica");
    Console.WriteLine("8. Salir\n");

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
Ejercicio6();
break;
case 7:
Ejercicio7();
break;
case 8:
return;
default: // Opción Invalida
Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 5.");
break;
}
}
static void Ejercicio1()
{
    try
    {
        Console.WriteLine("Ingrese el primer número:");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer número:");
        int numero3 = Convert.ToInt32(Console.ReadLine());

        int mayor = numero1;

        if (numero2 > mayor)
        {
            mayor = numero2;
        }

        if (numero3 > mayor)
        {
            mayor = numero3;
        }

        Console.WriteLine($"El mayor de los tres números es: {mayor}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Por favor, asegúrese de ingresar números enteros válidos.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error inesperado: {ex.Message}");
    }
}

static void Ejercicio2()
{
    bool ingresoPermitido = false;

    while (!ingresoPermitido)
        try
    {
        Console.WriteLine("Ingrese su edad:");
        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine("¡Bienvenido al Club! Puede ingresar.");
            ingresoPermitido = true;
        }
        else
        {
            Console.WriteLine("Lo siento, debe tener al menos 18 años para ingresar.");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Por favor, ingrese un número entero válido como edad.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error inesperado: {ex.Message}");
    }
}
static void Ejercicio3()
{
    try
    {
        Console.WriteLine("Ingrese el precio del producto:");
        double precio = Convert.ToDouble(Console.ReadLine());

        if (precio > 100)
        {
            double descuento = precio * 0.10; // Calcula el descuento del 10%
            double precioConDescuento = precio - descuento;
            Console.WriteLine($"El precio del producto con descuento del 10% es: {precioConDescuento:C}");
        }
        else
        {
            Console.WriteLine("El precio del producto es menor a Q100 No se aplica ningún descuento.");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Por favor, ingrese un precio válido.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error inesperado: {ex.Message}");
    }
}
static void Ejercicio4()
{
    string nombreUsuario = "usuario";
    string contraseña = "contraseña";

    bool accesoPermitido = false;

    while (!accesoPermitido)
    {
        try
        {
            Console.WriteLine("Ingrese su nombre de usuario:");
            string usuarioIngresado = Console.ReadLine();

            Console.WriteLine("Ingrese su contraseña:");
            string contraseñaIngresada = Console.ReadLine();

            if (usuarioIngresado == nombreUsuario && contraseñaIngresada == contraseña)
            {
                Console.WriteLine("Acceso concedido. ¡Bienvenido!");
                accesoPermitido = true;
            }
            else
            {
                Console.WriteLine("Nombre de usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inesperado: {ex.Message}");
        }
    }
}
    static void Ejercicio5()
    {

        {
            try
            {
                Console.WriteLine("Ingrese un número:");
                int numero = int.Parse(Console.ReadLine());

                if (EsPar(numero))
                {
                    Console.WriteLine("El número es par.");
                }
                else
                {
                    Console.WriteLine("El número es impar.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Por favor, ingrese un número válido.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: El número ingresado es demasiado grande o pequeño.");
            }
            catch (Exception)
            {
                Console.WriteLine( "Error: {ex.Message}");
            }
        }

        static bool EsPar(int num)
        {
            return num % 2 == 0;
        }
    }


    static void Ejercicio6()
    {
    try
    {
        Console.WriteLine("Ingrese el monto del préstamo:");
        double montoPrestamo = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese su edad:");
        int edad = int.Parse(Console.ReadLine());

        if (montoPrestamo < 5000)
        {
            Console.WriteLine("El préstamo es aprobado.");
        }
        else if (edad > 60)
        {
            Console.WriteLine("El préstamo es rechazado debido a su edad.");
        }
        else
        {
            Console.WriteLine("El préstamo es rechazado.");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Por favor, ingrese un formato válido.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}

static void Ejercicio7()
    {
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Elija el tipo de figura para calcular el área:");
                    Console.WriteLine("1. Cuadrado");
                    Console.WriteLine("2. Círculo");
                    Console.WriteLine("3. Triángulo");
                    Console.WriteLine("4. Salir");

                    Console.Write("Ingrese su opción: ");
                    int opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            CalcularAreaCuadrado();
                            break;
                        case 2:
                            CalcularAreaCirculo();
                            break;
                        case 3:
                            CalcularAreaTriangulo();
                            break;
                        case 4:
                            Console.WriteLine("Saliendo del programa...");
                            return;
                        default:
                            Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Ingrese un número entero válido para la opción.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error: El número ingresado es demasiado grande o pequeño.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        static void CalcularAreaCuadrado()
        {
            try
            {
                Console.WriteLine("Ingrese la longitud del lado del cuadrado:");
                double lado = double.Parse(Console.ReadLine());
                double area = lado * lado;
                Console.WriteLine($"El área del cuadrado es: {area}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingrese un número válido para la longitud del lado.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: El número ingresado es demasiado grande o pequeño.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void CalcularAreaCirculo()
        {
            try
            {
                Console.WriteLine("Ingrese el radio del círculo:");
                double radio = double.Parse(Console.ReadLine());
                double area = Math.PI * radio * radio;
                Console.WriteLine($"El área del círculo es: {area}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingrese un número válido para el radio.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: El número ingresado es demasiado grande o pequeño.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void CalcularAreaTriangulo()
        {
            try
            {
                Console.WriteLine("Ingrese la longitud de la base del triángulo:");
                double baseTriangulo = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del triángulo:");
                double altura = double.Parse(Console.ReadLine());
                double area = (baseTriangulo * altura) / 2;
                Console.WriteLine($"El área del triángulo es: {area}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingrese un número válido para la longitud de la base o la altura.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: El número ingresado es demasiado grande o pequeño.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
