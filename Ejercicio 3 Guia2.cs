internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********************");
        Console.WriteLine("   Menu de comida  ");
        Console.WriteLine("********************");

        Console.WriteLine("1- Hamburguesa");
        Console.WriteLine("2- Pizza");
        Console.WriteLine("3- Pollo frito");
        Console.WriteLine("4- Ensalada");

        int opc;
        Console.Write("Digite la Opción: ");
        opc = Convert.ToInt32(Console.ReadLine());

        switch (opc)
        {
            case 1:
                Console.WriteLine("Hamburguesa");
                break;
            case 2:
                Console.WriteLine("Pizaa");
                break;
            case 3:
                Console.WriteLine("Pollo frito");
                break;
            case 4:
                Console.WriteLine("Ensalada");
                break;
            default:
                Console.WriteLine("Número incorrecto");
                break;
        }
        }
}