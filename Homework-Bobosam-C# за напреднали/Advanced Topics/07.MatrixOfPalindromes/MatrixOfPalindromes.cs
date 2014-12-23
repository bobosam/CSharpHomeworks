using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        bool check;
        int rows;
        int columns;

        do
        {
            Console.Write("rows --> ");
            check = int.TryParse(Console.ReadLine(), out rows);
        } while (false == check);

        do
        {
            Console.Write("columns --> ");
            check = int.TryParse(Console.ReadLine(), out columns);
        } while (false == check);

        string[,] palindromeas = new string[rows, columns];
        Console.WriteLine();

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                palindromeas[row,col] = "" + (char)('a' + row) + (char)('a' + col + row) + (char)('a' + row) + " ";
                Console.Write(palindromeas[row,col]);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}
