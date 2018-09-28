using System;
using System.Linq;

namespace RubiksMatrix
{
    class Program
    {
        private static int[,] matrix;

        private static int rows;

        private static int columns;
        
        static void Main(string[] args)

        {

            int[] dimensions = Console.ReadLine()

                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)

                .Select(int.Parse).ToArray();

            rows = dimensions[0];

            columns = dimensions[1];

            matrix = new int[dimensions[0], dimensions[1]];
            
            int number = 0;
            
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)

                {
                    matrix[row, col] = ++number;
                }

            }
            
            int commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)

            {
                ParseCommand();

            }
            RearrangeMatrix();
        }
        
        private static void RearrangeMatrix()

        {

            int expected = 1;

            for (int row = 0; row < rows; row++)

            {

                for (int col = 0; col < columns; col++)

                {

                    if (matrix[row, col] == expected)

                    {

                        Console.WriteLine("No swap required");

                    }

                    else

                    {

                        for (int r = 0; r < rows; r++)

                        {

                            for (int c = 0; c < columns; c++)

                            {

                                if (matrix[r, c] == expected)

                                {

                                    int temp = matrix[row, col];

                                    matrix[row, col] = matrix[r, c];

                                    matrix[r, c] = temp;

                                    Console.WriteLine($"Swap({row},{col}) with({r},{c})");

                                    break;

                                }

                            }

                        }

                    }

                    expected++;

                }

            }

        }

        private static void ParseCommand()

        {

            string[] commandArgs = Console.ReadLine().Split();

            string command = commandArgs[1];

            int index = int.Parse(commandArgs[0]);

            int rotations = int.Parse(commandArgs[2]);

            switch (command)

            {

                case "up":

                    MoveColumn(index, rows - (rotations % rows));

                    break;

                case "down":

                    MoveColumn(index, (rotations % rows));

                    break;

                case "left":

                    MoveRow(index, columns - (rotations % columns));

                    break;

                case "right":

                    MoveRow(index, (rotations % columns));

                    break;

            }

        }
    private static void MoveRow(int index, int rotations)

        {

            //rotations %= columns;

            int[] tempArray = new int[columns];

            for (int col = 0; col < columns; col++)

            {

                int replacementIndex = col + rotations;
                replacementIndex %= columns;
                tempArray[replacementIndex] = matrix[index, col];

            }

            for (int col = 0; col < columns; col++)

            {
                matrix[index, col] = tempArray[col];
            }

        }
        
        private static void MoveRow()

        {



        }
        
        private static void MoveColumn(int index, int rotations)

        {
            
            // rotations %= rows;

            int[] tempArray = new int[rows];

            for (int row = 0; row < columns; row++)

            {
            
                int replacementIndex = row + rotations;
                
                replacementIndex %= rows;

                tempArray[replacementIndex] = matrix[index, row];

            }

            for (int row = 0; row < rows; row++)

            {

                matrix[row, index] = tempArray[row];
            }

        }
    }
}
