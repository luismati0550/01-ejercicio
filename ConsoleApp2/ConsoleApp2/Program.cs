using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            char b;
            int l;
            string op = "si";
            char[] dato = new char[10];



            while (op == "si")
            {
                Console.Clear();
                Console.WriteLine(" \n1. Ingresar valores \n2. Mostrar valores \n3. Buscar valores");
                l = int.Parse(Console.ReadLine());



                if (l == 1)
                {
                    for (int i = 0; i <= 9; i++)
                    {
                        Console.WriteLine("i: " + i);
                        Console.Write("Ingrese una letra:  ");
                        dato[i] = char.Parse(Console.ReadLine());
                    }
                }
                
                Console.ReadKey();
            }
        }
    }
}