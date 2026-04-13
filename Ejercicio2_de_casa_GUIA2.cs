internal class Program
{
    private static void Main(string[] args)
    {
        char ca;
        Console.Write("Ingresa un Carácter (Vocal o Digito): ");
        ca = Convert.ToChar(Console.ReadLine());
        switch (ca)
        {
            case 'a':
            case 'A':
            case 'e':
            case 'E':
            case 'i':
            case 'I':
            case 'o':
            case 'O':
            case 'u':
            case 'U':
                Console.WriteLine("Es una vocal");
                break;
            default:
                if (ca >= '1' && ca <= '9')
                    Console.WriteLine("Es un digito ");
                else
                    Console.WriteLine("No es digito ni vocal");
                break;
        }
    }
}