namespace Lesson3二维数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("二维数组");
            int[,] arr;
            int[,] arr1 = new int[3, 6] {{1, 2, 3, 4, 5, 6}, {7, 8, 9, 10, 11, 12}, {13, 14, 15, 16, 17, 18}};
            int[,] arr2 = new int[3, 4] {{1, 2, 3, 4}, {5, 6, 7, 8}, {9, 10, 11, 12}};

            //长度
            /*
            Console.WriteLine(arr2.Length);
            Console.WriteLine(arr2.GetLength(0));
            Console.WriteLine(arr2.GetLength(1));
            */
            //遍历二维数组
            /*
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write(arr2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            */
            //增加
            int[,] arr3 = new int[3, 5];
            for(int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr3[i, j] = arr2[i, j];
                }
            }
            arr2 = arr3;
            //删除
            int[,] arr4 = new int[3, 3];
            for(int i = 0;i<arr4.GetLength(0);i++)
            {
                for(int j = 0;j<arr4.GetLength(1);j++)
                {
                    arr4[i, j] = arr1[i, j];
                }
            }
            arr1 = arr4;
            for(int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.Write(arr1[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
