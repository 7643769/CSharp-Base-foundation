namespace exerciseArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("练习题");
            //int[,] a = new int[100,100];
            //int num = 1;
            //for (int i=0;i<a.GetLength(0);i++)
            //{
            //    for(int j = 0; j < a.GetLength(1); j++)
            //    {
            //        a[i, j] = num;
            //        num++;
            //    }
            //}
            //for (int i = 0;i<a.GetLength(0);i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.Write(a[i, j]+"\t");
            //        if (j == a.GetLength(1) - 1)
            //        {
            //            Console.WriteLine();
            //        }
            //    }
            //}
            //int[,] b = new int[4, 4];
            //Random r = new Random();
            //for (int i = 0;i<b.GetLength(0);i++)
            //{
            //    for(int j = 0; j < b.GetLength(1); j++)
            //    {
            //        b[i, j] = r.Next(0,101);
            //    }
            //}
            //Console.WriteLine("**********随机数数组**********");
            //for (int i = 0; i < b.GetLength(0); i++)
            //{
            //    for (int j = 0; j < b.GetLength(1); j++)
            //    {
            //        Console.Write(b[i, j] + "\t");
            //        if (j == b.GetLength(1) - 1)
            //        {
            //            Console.WriteLine();
            //        }
            //    }
            //}
            //Console.WriteLine("**********上三角数组**********");
            //for (int i = 0; i < b.GetLength(0); i++)
            //{
            //    for (int j = 0; j < b.GetLength(1); j++)
            //    {
            //        if (j > i)
            //        {
            //            b[i, j] = 0;
            //        }
            //        Console.Write(b[i,j] + "\t");
            //        if (j == b.GetLength(1) - 1)
            //        {
            //            Console.WriteLine();
            //        }
            //    }
            //}
            Console.WriteLine("**********随机数数组**********");
            Random r = new Random();
            int[,] c = new int[5, 5];
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    c[i, j] = r.Next(0, 501);
                    Console.Write(c[i, j] + "\t");
                    if (j == c.GetLength(1) - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine("**********最大值及其行列号**********");
            int m=0, n = 0;
            int max = c[0, 0];
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    if (c[i, j] > max)
                    {
                        max = c[i, j];
                        m = i;
                        n = j;
                    }
                }
            }
            Console.WriteLine("最大值是: " + max);
            Console.WriteLine("最大值的坐标是: (" + m + ", " + n + ")");

        }
    }
}
