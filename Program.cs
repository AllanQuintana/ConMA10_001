using System.IO;
using System;

namespace conMA01_001
{
    class Program // Creación de un arreglo a partir de la asignación de valores leídos por teclado //
    {
        static void Main(string[] args)
        {
            int[] valores = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un número ");
                string strNumero = Console.ReadLine();

                if (int.TryParse(strNumero, out int numero))
                {
                    valores[i] = numero;
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es un número válido");
                    i--;
                }

            }
            Console.WriteLine("Números ingresados: ");
            for (int i= 0; i < 5; i++)
            {
                Console.WriteLine("Elemento de la posición" +i+ "Corresponde a : "+valores[i]);
            }

            
        }
    }
}