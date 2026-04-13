internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Meses del año");
        //Variable
        int mes;
        //Solicitar datos
        Console.Write("Dime un número del 1 al 12: ");
        mes = Convert.ToInt32(Console.ReadLine());

        switch (mes)
        {
            case 1:
                Console.WriteLine("Enero, Días:31");
                break;
            case 2:
                Console.WriteLine("Febrero, Días:28 (Si es año bisiesto 29)");
                break;
            case 3:
                Console.WriteLine("Marzo, Días:31");
                break;
            case 4:
                Console.WriteLine("Abril, Días:30");
                break;
            case 5:
                Console.WriteLine("Mayo, Días:31");
                break;
            case 6:
                Console.WriteLine("Junio, Días:30");
                break;
            case 7:
                Console.WriteLine("Julio, Días:31");
                break;
            case 8:
                Console.WriteLine("Agosto, Días:31");
                break;
            case 9:
                Console.WriteLine("Septiembre, Días:30");
                break;
            case 10:
                Console.WriteLine("Octubre, Días:31");
                break;
            case 11:
                Console.WriteLine("Noviembre, Días:30");
                break;
            case 12:
                Console.WriteLine("Diciembre, Días:31");
                break;
            default:
                Console.WriteLine("Numero del mes incorrecto");
                break;
        }
    }
}