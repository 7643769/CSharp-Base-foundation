namespace Lesson2一维数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("一维数组");
            int[]arr = new int[5];
            int[ ] arr1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[] { 1, 2 };
            int[] arr3 = { 1, 2, 3 };
            Console.WriteLine(arr2.Length);
            Console.WriteLine(arr1[3]);
            arr1[3] = 10;
            Console.WriteLine(arr1[3]);

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.WriteLine("***************************");
            Console.WriteLine("数组arr2的长度：" + arr2.Length);
            //增加数组长度
            int[] arr4 = new int[6];
            for (int i = 0;i<arr.Length;i++)
            {
                arr4[i] = arr[i];
            }
            arr = arr4;
            Console.WriteLine(arr[5]);
            //删除数组长度
            int[] arr5 = new int[4];
            for (int i = 0; i < arr5.Length; i++)
            {
                arr5[i] = arr[i];
            }
            arr = arr5;
            Console.WriteLine("数组arr的长度：" + arr.Length);

            Console.WriteLine("************删除数组中间的数据**************");
            int[] arr6 = new int[7] {99, 1, 2, 3, 66, 5, 6};
            int[] arr7 = new int[6];
            for(int i = 0; i < arr7.Length; i++)
            {
                if (i < 3)
                {
                    arr7[i] = arr6[i];
                }
                else
                {
                    arr7[i] = arr6[i + 1];
                }
            }
            for (int i = 0; i < arr7.Length; i++)
            {
                Console.WriteLine(arr7[i]);
            }


        }
    }
}
