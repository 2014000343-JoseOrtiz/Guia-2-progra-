internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Calculadora basica");
        Console.WriteLine("1-Suma");
        Console.WriteLine("2-RESTA");
        Console.WriteLine("3-Multriplicacion");
        Console.WriteLine("4-division");

        int opc;
        Double n1, n2;
        Console.WriteLine("Ingrese una opcion");
        opc = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el primer numero");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        n2 = Convert.ToDouble(Console.ReadLine());

        switch (opc)
        {
            case 1:
                Console.WriteLine("La suma es: " + (n1 + n2));
                break;
            case 2:
                Console.WriteLine("La resta es: " + (n1 - n2));
                break;
            case 3:
                Console.WriteLine("La multiplicacion es: " + (n1 * n2));
                break;
           
            default:
                Console.WriteLine("Opcion no valida");
                break;
        }


    }


    }
