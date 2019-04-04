using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            string[] valores = { "-", "-", "O", "X" };
            int n = 10;
            int m = 15;

            string[,] tablero = new string[n, m];


            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    int indice = aleatorio.Next(0, valores.Length);
                    tablero[i, j] = valores[indice];
                }
            }

            while (true)
            {
                Console.WriteLine("ENTRADA: ");
                for (int i = 0; i < tablero.GetLength(0); i++)
                {
                    for (int j = 0; j < tablero.GetLength(1); j++)
                    {
                        Console.Write("|" + tablero[i, j]);
                    }
                    Console.Write("|\n");
                }

                Console.WriteLine("En que fila desea poner una X?");
                int fila = int.Parse(Console.ReadLine());
                Console.WriteLine("En que columna desea poner una X?");
                int columna = int.Parse(Console.ReadLine());

                string valor = tablero[fila, columna];
                while (valor != "-")
                {
                    Console.WriteLine("Esa posicion ya esta tomada, intentalo de nuevo");
                    Console.WriteLine("En que fila desea poner una X?");
                    fila = int.Parse(Console.ReadLine());
                    Console.WriteLine("En que columna desea poner una X?");
                    columna = int.Parse(Console.ReadLine());
                    valor = tablero[fila, columna];
                }

                tablero[fila, columna] = "X";
            }
        }
    }
}
