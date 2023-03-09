internal class Program
{
    private static void Main(string[] args)
    {
        // faça um programa que copie os valores de uma matriz em uma nova de forma inversa
        // (o primeiro valor de uma matriz entra no último da segunda matriz e assim por diante)

        int[,] matriz = new int[3, 3];
        int[,] matrizInversa = new int[3, 3];

        // montagem da matriz

        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                matriz[linha, coluna] += (linha * coluna) + 1;
            }
        }

        // Impressao da matriz
        Console.WriteLine("Matriz");
        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.Write($" [{matriz[linha, coluna]}]");
            }
            Console.WriteLine("\n");
        }


        // Inversao da matriz
        //  matriz original[linha,coluna]
        // matriz inversa[i,j]

        for (int linha = 0,  i = 2; linha < 3; linha++, i--)
        {
            for (int coluna = 0, j = 2; coluna < 3; coluna++, j--)
            {

                matrizInversa[i,j] += matriz[linha, coluna];

            }
        }

        // Impressao da matriz
        Console.WriteLine("Matriz Inversa");
        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.Write($" [{matrizInversa[linha, coluna]}]");
            }
            Console.WriteLine("\n");
        }
    }
}