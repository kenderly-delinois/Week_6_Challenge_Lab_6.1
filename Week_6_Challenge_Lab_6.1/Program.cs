using System.IO;

namespace Week_6_Challenge_Lab_6._1
{
    internal class Program
    {
        //You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees(clockwise).
        //You have to rotate the image in-place, which means you have to modify the input 2D matrix directly.
        //DO NOT allocate another 2D matrix and do the rotation.


        // O(n^2)
        public static  void Rotate(int[][] matrix)
        {
            int n = matrix.Length;

            
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    // Swap matrix[i][j] with matrix[j][i]
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            // Reverse each row
            for (int i = 0; i < n; i++)
            {
                Array.Reverse(matrix[i]);
            }
        }

        // Display
        static void Main(string[] args)
        {
            int[][] matrix = new int[][]
            {
               new int[] {1, 2, 3},
               new int[] {4, 5, 6},
               new int[] {6, 7, 8}
            };

            // Display original matrix
            Console.WriteLine("Original Matrix: ");
            foreach (var row in matrix)
                Console.WriteLine(string.Join(" ", row));

            Console.WriteLine();

            Rotate(matrix);

            // Display Rotate Matrix 90 Degree
            Console.WriteLine("Rotate Matrix 90 Degree: ");
            foreach (var row in matrix)
            Console.WriteLine(string.Join(" ", row));
        }
    }
}
