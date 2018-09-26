using System;
using System.Linq;

namespace RubiksMatrix
{
    class Program
    {
        private static int[,] matrix;
        private static int row;
        private static int col;

        static void Main(string[] args)
        {
            var rowsAndColumns = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            matrix = new int[rowsAndColumns[0], rowsAndColumns[1]];
            int inp = 1;
            row = matrix.GetLength(0);
            col = matrix.GetLength(1);

            for (int rows = 0; rows < row; rows++)
            {
                for (int cols = 0; cols < col; cols++)
                {
                    matrix[rows, cols] = inp;
                    inp++;
                }
            }

            int commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)
            {
                ParseCommand();
            }
        }
        public static void ParseCommand()
        {
            string[] commandArgs = Console.ReadLine().Split(' ').ToArray();
            string command = commandArgs[1];
            int index = int.Parse(commandArgs[0]);
            int rotations = int.Parse(commandArgs[2]);

            switch(command)
            {
                case "up":
                    MoveColumn(index, row - rotations);
                    break;
                case "down":
                    MoveColumn(index, rotations);
                    break;
                case "left":
                    MoveRow(index, col - rotations);
                    break;
                case "right":
                    MoveRow(index, rotations);
                    break;
            }
        }
        private static void MoveColumn(int index, int rotations)
        {
            rotations %= col;

            int[] tempArray = new int[col];

            for (int c = 0; c < col; c++)
            {
                int replacementIndex = c + rotations;
                replacementIndex %= col;
                tempArray[replacementIndex] = matrix[index, c];
            }
        }
        private static void MoveRow(int index, int rotation)
        {
        }
    }
}
