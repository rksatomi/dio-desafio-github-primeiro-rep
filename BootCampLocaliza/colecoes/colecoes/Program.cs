using System;
using colecoes.helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesArray op = new OperacoesArray();
            int[] array =new int[5] {6,3,5,1,9};
         
            System.Console.WriteLine("original");
            op.ImprimirArray(array);
         
            System.Console.WriteLine("ordenado");
            //op.ordenarBubbleSort(ref array);
            op.Ordenar(ref array);
            op.ImprimirArray(array);
         
         
         
         
         
            // int[,] matriz = new int[4, 2]
            // {
            //      { 8, 8 },
            //      { 10, 20 },
            //      { 50, 100 },
            //      { 90, 200 }
            //  };
            // for(int i = 0; i < matriz.GetLength(0); i++)
            // {
            //                  for (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(matriz[i, j]);
            //     }   
            // }
            
            
            
            
            // int[] arrayinteiros =new int[3];
            // arrayinteiros[0]=10;
            // arrayinteiros[1]=20;
            // arrayinteiros[2]=30;

            // System.Console.WriteLine("for");
            // for (int i = 0; i < arrayinteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arrayinteiros[i]);
            // }
            // System.Console.WriteLine("foreach");
            // foreach (int item in arrayinteiros)
            // {
            //     System.Console.WriteLine(item);
            // }
            

        }
    }
}