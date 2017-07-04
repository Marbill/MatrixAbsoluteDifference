using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void printMatrix(int size, int[][] arr, int answerX, int answerY)
        {
            int t = size;
            int[] x = new int[size];
            int[] y = new int[size];
            string outX = "";
            string outY = "";

            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        x[i] = arr[i][j];
                        string s = "";
                        string o = arr[i][j].ToString();
                        for (int c = 0; c < i; c++)
                        {
                            s += " ";
                        }
                        Console.Write(s + o);
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < x.Length; i++)
            {
                if (i != 0)
                {
                    outX += " + ";
                    if (x[i] < 0)
                    {
                        outX += "(" + x[i] + ")";
                    }
                    else
                    {
                        outX += x[i];
                    }
                }
                else
                {
                    if (x[i] < 0)
                    {
                        outX += "(" + x[i] + ")";
                    }
                    else
                    {
                        outX += x[i];
                    }
                }

            }

            Console.WriteLine(outX + " = " + answerX);
            Console.WriteLine();

            for (int j = 0; j < size; j++)
            {
                string o = arr[j][--t].ToString();
                y[j] = Convert.ToInt32(o);
                string s = "";
                for (int c = 0; c < t; c++)
                {
                    s += " ";
                }
                Console.Write(s + o);
                Console.WriteLine();
            }



            for (int i = 0; i < y.Length; i++)
            {
                if (i != 0)
                {
                    outY += " + ";
                    if (y[i] < 0)
                    {
                        outY += "(" + y[i] + ")";
                    }
                    else
                    {
                        outY += y[i];
                    }
                }
                else
                {
                    if (y[i] < 0)
                    {
                        outY += "(" + y[i] + ")";
                    }
                    else
                    {
                        outY += y[i];
                    }
                }

            }

            Console.WriteLine(outY + " = " + answerY);
            Console.WriteLine();

        }

        static int findX(int size, int[][] arr)
        {
            int x = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        x += arr[i][j];
                    }
                }
            }

            return x;
        }

        static int findY(int size, int[][] arr)
        {
            int tempC = size;
            int y = 0;
            for (int i = 0; i < size; i++)
            {
                y += arr[i][--tempC];
            }

            return y;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = a_temp.Select(element => Convert.ToInt32(element)).ToArray();
            }



            int x = findX(n, a);
            int y = findY(n, a);



            int output = (x) - (y);

            printMatrix(n, a, x, y);
            Console.WriteLine($"|{x} - {y}| = {Math.Abs(output)}");

        }
    }
}
