using System;

class SpiralMatrix
{
    static void Main()
    {
        bool check;
        int numberN;
        int row = 0;
        int col = 0;
        string direction = "right";

        do
        {
            Console.Write("N --> ");
            check = int.TryParse(Console.ReadLine(), out numberN);
        } while (false == check);

        Console.WriteLine();

        int[,] matrix = new int[numberN, numberN];

        for (int i = 1; i <= (numberN * numberN); i++)
        {

            if (("right" == direction) && ((col >= numberN) || (0 != matrix[row,col])))
            {
                col--;
                row++;
                direction = "down";
            }

            if (("down" == direction) && ((row >= numberN) || (0 != matrix[row,col])))
            {
                row--;
                col--;
                direction = "left";
            }

            if (("left" == direction) && ((0 > col) || (0 != matrix[row,col])))
            {
                col++;
                row--;
                direction = "up";
            }

            if (("up" == direction) && ((0 > row) || (0 != matrix[row,col])))
            {
                row++;
                col++;
                direction = "right";
            }

            matrix[row, col] = i;

            if ("right"== direction)
            {
                col++;
            }

            if ("down" == direction)
            {
                row++;
            }

            if ("left" == direction)
            {
                col--;
            }

            if ("up" == direction)
            {
                row--;
            }
        }

        for (int i = 0; i < numberN; i++)
        {
            for (int j = 0; j < numberN; j++)
            {
                Console.Write("{0,4}",matrix[i,j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
