using HFInal_TS_JJRG_1248823;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Trabajo Supervisado - Julio Javier Robles - 1248823");
        Console.WriteLine("");
        Console.WriteLine("Ejercicio 1");
        bool seguir = true;
        int numero = 1;
        string sn;
        Console.WriteLine("Ejercicio Personas:");
        while (seguir)
        {
        Console.WriteLine("Persona " + numero);
        Console.WriteLine("Ingrese el nombre");
        string nom = Console.ReadLine();
        Console.WriteLine("Ingrese el apellido");
        string ape = Console.ReadLine();
        Console.WriteLine("Ingrese la edad");
        int ed = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la altura en cm");
        double cm = Convert.ToDouble(Console.ReadLine());

        Persona persona1 = new Persona(nom, ape, ed, cm);
            persona1.Imprimir(numero);
            Console.WriteLine();
            do
            {
                Console.WriteLine("¿Desea agregar otra persona? s = si, n = no");
                sn = Console.ReadLine().ToLower();

                if (sn == "s")
                {
                    seguir = true;
                    numero++;
                }
                else if (sn == "n")
                {
                    seguir = false;

                }
                else
                {

                    Console.WriteLine("Entrada no válida. Por favor, ingrese s o n.");
                }
            } while (sn != "s" && sn != "n");
        }
        Console.WriteLine("Presione enter para el ejercicio 2");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Trabajo Supervisado - Julio Javier Robles - 1248823");
        Console.WriteLine("");
        Console.WriteLine("Ejercicio 2: matriz multiplicaroria");
        Console.WriteLine("Por favor ingrese la altura de su matriz");
        int altura = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Por favor ingrese el ancho de su matriz");
        int ancho = Convert.ToInt32(Console.ReadLine());
        int[,] matriz = new int[altura, ancho];
        for (int i = 0; i < ancho; i++)
        {
            matriz[0, i] = (i + 1);
        }
        int z = 2;
        for(int i = 1; i < altura; i++)
        {
            for(int t = 0; t < ancho; t++) 
            {
               
                    matriz[i, t] = z * (matriz[i-i, t]);
                
            }
            z++;
        }
        for(int i = 0; i < altura; i++)
        {
            Console.WriteLine();
            for(int t = 0; t< ancho; t++)
            {
                Console.Write(matriz[i,t]+" ");
            }
        }
        Console.WriteLine(); 
        Console.WriteLine();
        Console.WriteLine("Presione enter para salir");
        Console.ReadKey();
    }
}