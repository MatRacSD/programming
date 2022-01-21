﻿using Weboo.Examen;


class Program
{
    static void Main()
    {
        Case1();
    }

    static void Case1()
    {
        // Entrada
        bool[,] mapa = new bool[5,5];
        int[,] posiciones = {{2,2}};

        // Salida esperada
        int[,] esperado =
        {
            {2,2,2,2,2},
            {2,1,1,1,2},
            {2,1,0,1,2},
            {2,1,1,1,2},
            {2,2,2,2,2},
        };

        PrintArray(esperado);

        int[,] respuesta = Senderismo.CalculaDistancias(mapa, posiciones);
        PrintArray(respuesta);
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i, j].ToString().PadLeft(3));

            Console.WriteLine();
        }
    }
}
