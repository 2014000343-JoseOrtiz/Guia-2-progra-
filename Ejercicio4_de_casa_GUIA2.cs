internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********************************");
        Console.WriteLine("CONVERSOR DE MEDIDAS DE LONGITUD");
        Console.WriteLine("********************************");
        Console.WriteLine("1- Metrosd");
        Console.WriteLine("2- Pies");
        Console.WriteLine("3- Centimetros");
        Console.WriteLine("4- Pulgadas");

        int opc1, opc2;
        double cant, metros = 0;
        Console.Write("Digite la Unidad de Origen: ");
        opc1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingresa el Valor de tu Medida: ");
        cant = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digita la Unidad Final: ");
        opc2 = Convert.ToInt32(Console.ReadLine());

        switch (opc1)
        {
            case 1:
                metros = cant;
                break;
            case 2:
                metros = cant / 3.281;
                break;
            case 3:
                metros = cant / 100;
                break;
            case 4:
                metros = cant / 39.3701;
                break;
            default:
                Console.WriteLine("Opción invalida");
                break;
        }
        switch (opc2)
        {
            case 1:
                Console.WriteLine("Conversión a Metros: " + (metros));
                break;
            case 2:
                Console.WriteLine("Conversión a Pies: " + (metros * 3.281));
                break;
            case 3:
                Console.WriteLine("Conversión a Centimetros: " + (metros * 100));
                break;
            case 4:
                Console.WriteLine("Conversión a pulgadas: " + (metros * 39.3701));
                break;
            default:
                Console.WriteLine("OPCION invalida");
                break;
        }
    }
}