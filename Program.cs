using System;

class Program
{
    public static int NumeroMaisProximo(int[] arr, int X)
    {
        int esquerda = 0;
        int direita = arr.Length - 1;
        int resultado = arr[0];

        while (esquerda <= direita)
        {
            int meio = (esquerda + direita) / 2;

            if (arr[meio] == X)
            {
                return arr[meio];
            }

            if (Math.Abs(arr[meio] - X) < Math.Abs(resultado - X))
            {
                resultado = arr[meio];
            }

            if (arr[meio] < X)
            {
                esquerda = meio + 1;
            }
            else
            {
                direita = meio - 1;
            }
        }

        return resultado;
    }

    static void Main()
    {
        int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        int X = 8;

        int resultado = NumeroMaisProximo(arr, X);

        Console.WriteLine("O número mais próximo de " + X + " é: " + resultado);
    }
}
