using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rakuten
{
    class LessNoisyMeetingRooms
    {
        public static void fnLessNoisyMeetingRooms(int n, int m, int k)
        {
            int[][] matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    matrix[i][j] = (m * i) + j;
                }
            }

            if ((n * m) % 2 != 0)
                diagonalOrderOdd(matrix, n, m, k);
            else
                diagonalOrderEven(matrix, n, m, k);

            //PrintMatrix(n, m, matrix);

            countAdjacent(matrix);
        }

        private static void PrintMatrix(int n, int m, int[][] matrix)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }

                Console.WriteLine();
            }
        }

        static void diagonalOrderOdd(int[][] matrix, int ROW, int COL, int k)
        {
            int userCount = 0;
            for (int line = 1; line <= (ROW + COL - 1); line = line + 2)
            {
                int start_col = Math.Max(0, line - ROW);
                int count = Math.Min(line, Math.Min((COL - start_col), ROW));
                for (int j = 0; j < count; j++)
                {
                    if (userCount != k)
                    {
                        if (ROW > 1 && COL > 1 && k > ROW * 2 && (Math.Min(ROW, line) - j - 1 == ROW / 2)
                            && start_col + j == COL / 2)
                        {

                        }
                        else
                        {
                            matrix[Math.Min(ROW, line) - j - 1][start_col + j] = -1;
                            userCount++;
                        }

                    }
                    else
                        break;
                }
            }

            for (int line = 2; line <= (ROW + COL - 1); line = line + 2)
            {
                int start_col = Math.Max(0, line - ROW);
                int count = Math.Min(line, Math.Min((COL - start_col), ROW));
                for (int j = 0; j < count; j++)
                {
                    if (userCount != k)
                    {
                        if (/*ROW == COL &&*/ k > ROW * 2 && (Math.Min(ROW, line) - j - 1 == ROW / 2)
                               && start_col + j == COL / 2)
                        {

                        }
                        else
                        {
                            matrix[Math.Min(ROW, line) - j - 1][start_col + j] = -1;
                            userCount++;
                        }
                    }
                    else
                        break;
                }
            }

            if (userCount != k && k > ROW * 2)
            {
                matrix[ROW / 2][COL / 2] = -1;
                userCount++;
            }
        }

        static void diagonalOrderEven(int[][] matrix, int ROW, int COL, int k)
        {
            int userCount = 0;
            for (int line = 1; line <= (ROW + COL - 1); line = line + 2)
            {
                int start_col = Math.Max(0, line - ROW);
                int count = Math.Min(line, Math.Min((COL - start_col), ROW));
                for (int j = 0; j < count; j++)
                {
                    if (userCount != k)
                    {
                        matrix[Math.Min(ROW, line) - j - 1][start_col + j] = -1;
                        userCount++;
                    }
                    else
                        break;
                }
            }

            //PrintMatrix(ROW, COL, matrix);

            if (userCount != k && matrix[ROW - 1][COL - 1] != -1)
            {
                matrix[ROW - 1][COL - 1] = -1;
                userCount++;
            }

            if (userCount != k && matrix[0][COL - 1] != -1)
            {
                matrix[0][COL - 1] = -1;
                userCount++;
            }

            if (userCount != k && matrix[ROW - 1][0] != -1)
            {
                matrix[ROW - 1][0] = -1;
                userCount++;
            }


            for (int line = 2; line <= (ROW + COL - 1); line = line + 2)
            {
                int start_col = Math.Max(0, line - ROW);
                int count = Math.Min(line, Math.Min((COL - start_col), ROW));
                for (int j = 0; j < count; j++)
                {
                    if (userCount != k)
                    {
                        if (matrix[Math.Min(ROW, line) - j - 1][start_col + j] != -1)
                        {
                            matrix[Math.Min(ROW, line) - j - 1][start_col + j] = -1;
                            userCount++;
                        }
                    }
                    else
                        break;
                }
            }
        }

        private static void countAdjacent(int[][] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (i == 0 && j == 0)
                        continue;

                    if (i > 0 && matrix[i][j] == -1 && matrix[i - 1][j] == -1)
                        count++;

                    if (j > 0 && matrix[i][j] == -1 && matrix[i][j - 1] == -1)
                        count++;
                }
            }

            Console.WriteLine(count);
        }

        public static void fnLessNoisyMeetingRoomsExt(int n, int m, int k)
        {
            int[][] matrix = new int[n][];
            var greater = n > m ? n : m;
            int userCount = 0;
            Dictionary<int, Room> dict = new Dictionary<int, Room>();
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    var val = (m * i) + j;
                    matrix[i][j] = val;

                    Room r = new Room(i, j);
                    dict.Add(val, r);
                }
            }

            //Fill alternate elements
            for (int i = 0; i < n; i++)
            {
                int j = 0;
                if (i % 2 != 0)
                    j = 1;
                for (; j < m; j = j + 2)
                {
                    if (k > greater * 2 && i == n / 2 && j == m / 2)
                    {
                    }
                    else
                    {
                        if (userCount != k)
                        {
                            dict.Remove(matrix[i][j]);
                            matrix[i][j] = -1;
                            userCount++;
                        }
                    }
                }
            }
            PrintMatrix(n, m, matrix);

            //Fill empty corner items
            if (userCount != k && matrix[n - 1][m - 1] != -1)
            {
                dict.Remove(matrix[n - 1][m - 1]);
                matrix[n - 1][m - 1] = -1;
                userCount++;
            }

            if (userCount != k && matrix[0][m - 1] != -1)
            {
                dict.Remove(matrix[0][m - 1]);
                matrix[0][m - 1] = -1;
                userCount++;
            }

            if (userCount != k && matrix[n - 1][0] != -1)
            {
                dict.Remove(matrix[n - 1][0]);
                matrix[n - 1][0] = -1;
                userCount++;
            }

            PrintMatrix(n, m, matrix);
            //Fill items alternately from first and last

            while (dict.Count != 0)
            {
                var t1 = dict.First();
                var t2 = dict.Last();
                if (userCount != k && matrix[t1.Value.i][t1.Value.j] != -1)
                {
                    dict.Remove(matrix[t1.Value.i][t1.Value.j]);
                    matrix[t1.Value.i][t1.Value.j] = -1;
                    userCount++;
                }

                if (userCount != k && matrix[t2.Value.i][t2.Value.j] != -1)
                {
                    dict.Remove(matrix[t2.Value.i][t2.Value.j]);
                    matrix[t2.Value.i][t2.Value.j] = -1;
                    userCount++;
                }

                if (userCount == k)
                    break;
            }

            //PrintMatrix(n, m, matrix);


            countAdjacent(matrix);


        }

        public class Room
        {
            public Room(int i, int j)
            {
                this.i = i;
                this.j = j;
            }

            public int i { get; set; }

            public int j { get; set; }

            public bool isVisited { get; set; }
        }
    }
}
