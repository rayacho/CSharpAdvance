using System;

using System.Collections.Generic;

using System.Linq;

namespace RubiksMatrix

{

    class Program

    {

        public static void Main()

        {

            int[] size = Console.ReadLine()

                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)

                .Select(int.Parse)

                .ToArray();
            
            int[][] rubik = new int[size[0]][];
            
            for (int i = 0; i < size[0]; i++)

            {

                rubik[i] = new int[size[1]];

                for (int j = 0; j < size[1]; j++)

                {

                    rubik[i][j] = i * (size[1]) + j + 1;

                }

            }
            
            int numberOfCommands = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numberOfCommands; i++)

            {

                string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int comObj = int.Parse(command[0]);

                int comMoves = int.Parse(command[2]);
                
                switch (command[1])

                {

                    case "up":

                        moveUp(rubik, comObj, comMoves);

                        break;



                    case "down":

                        moveDown(rubik, comObj, comMoves);

                        break;



                    case "right":

                        moveRight(rubik, comObj, comMoves);

                        break;



                    case "left":

                        moveLeft(rubik, comObj, comMoves);

                        break;

                }

            }
            
            int numOfElements = size[0] * size[1];
            
            int[] flatRubik = new int[numOfElements];

            int k = -1;
            
            for (int i = 0; i < size[0]; i++)

            {

                for (int j = 0; j < size[1]; j++)

                {

                    k++;

                    flatRubik[k] = rubik[i][j];

                }

            }

            for (int ie = 0; ie < numOfElements; ie++)

            {

                if (flatRubik[ie] == ie + 1)

                {

                    Console.WriteLine("No swap required");

                }

                else

                {

                    int temp = flatRubik[ie];

                    int srch = Array.IndexOf(flatRubik, ie + 1);
                    
                    flatRubik[srch] = temp;

                    flatRubik[ie] = ie + 1;
                    
                    Console.WriteLine($"Swap ({ie / size[0]}, {ie % size[1]}) with ({srch / size[0]}, {srch % size[1]})");

                }

            }
            
        }
        
        private static void moveUp(int[][] matrix, int col, int moves)

        {

            int rows = matrix.Length;

            int rest = moves % rows;

            Queue<int> column = new Queue<int>();
            
            for (int j = 0; j < rows; j++)

            {

                column.Enqueue(matrix[j][col]);

            }
            

            for (int i = 0; i < rest; i++)

            {

                column.Enqueue(column.Dequeue());

            }

            for (int j = 0; j < rows; j++)

            {

                matrix[j][col] = column.Dequeue();

            }

        }
        
        private static void moveDown(int[][] matrix, int col, int moves)

        {

            int rows = matrix.Length;

            int rest = moves % rows;

            Queue<int> column = new Queue<int>();
            
            for (int j = (rows - 1); j >= 0; j--)

            {

                column.Enqueue(matrix[j][col]);

            }
            
            for (int i = 0; i < rest; i++)

            {

                column.Enqueue(column.Dequeue());

            }
            
            for (int j = (rows - 1); j >= 0; j--)

            {

                matrix[j][col] = column.Dequeue();

            }

        }
        
        private static void moveLeft(int[][] matrix, int row, int moves)

        {

            int cols = matrix[row].Length;

            int rest = moves % cols;

            Queue<int> rowQueue = new Queue<int>();
            
            for (int i = 0; i < cols; i++)

            {

                rowQueue.Enqueue(matrix[row][i]);

            }
            
            for (int j = 0; j < rest; j++)

            {

                rowQueue.Enqueue(rowQueue.Dequeue());

            }
            
            for (int i = 0; i < cols; i++)

            {

                matrix[row][i] = rowQueue.Dequeue();

            }

        }
        
        private static void moveRight(int[][] matrix, int row, int moves)

        {

            int cols = matrix[row].Length;

            int rest = moves % cols;

            Queue<int> rowQueue = new Queue<int>();
            
            for (int i = (cols - 1); i >= 0; i--)

            {

                rowQueue.Enqueue(matrix[row][i]);

            }
            
            for (int j = 0; j < rest; j++)

            {

                rowQueue.Enqueue(rowQueue.Dequeue());

            }
            
            for (int i = (cols - 1); i >= 0; i--)

            {

                matrix[row][i] = rowQueue.Dequeue();

            }

        }

    }

}