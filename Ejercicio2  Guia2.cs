internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Evaluacion de notas");
        Console.Write("Dime tu nota en letras: ");
        //variable
        string nota;
        nota = Console.ReadLine();
        switch (nota)
        {
            case "A":
                Console.WriteLine("Exelente");
                break;
            case "B":
                Console.WriteLine("Bueno");
                break ;
            case "C":
                Console.WriteLine("Regular");
                break;
            case "D":
                Console.WriteLine("Deficiente");
                break;
            case "F":
                Console.WriteLine("Reprobado");
                break;
            default:
                Console.WriteLine("Letra invalida");
                break;
        }
    }
}
