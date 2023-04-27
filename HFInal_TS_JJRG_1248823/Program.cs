using HFInal_TS_JJRG_1248823;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Ejercicio 1");
        Console.WriteLine("Ejercicio Personas:");
        Console.WriteLine("Ingrese el nombre");
        string nom = Console.ReadLine();
        Console.WriteLine("Ingrese el apellido");
        string ape = Console.ReadLine();
        Console.WriteLine("Ingrese la edad");
        int ed = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la altura en cm");
        double cm = Convert.ToDouble(Console.ReadLine());

        Persona persona1 = new Persona(nom, ape,ed,cm);
        persona1.Imprimir();
        Console.ReadKey();
    }
}