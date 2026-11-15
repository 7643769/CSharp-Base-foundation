namespace exercise函数
{
    internal class Program
    {
        static int Compare(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else if (a < b)
            {
                return b;
            }
            else
            {
                return 0;
            }
        }
        static int[] CaclArray(int[] arr)
        {
            int sum = 0;
            int max = arr[0];
            int min = arr[0];
            int ave = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            ave = sum / arr.Length;
            return new int[] { sum, max, min, ave };
        }
        static string RunNian(int a)
        {
            if ((a % 400 == 0) || (a % 4 == 0 && a % 100 != 0))
            {
                return a+"年是闰年";
            }

            return a+"年不是闰年";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Compare(5, 10));
            int[] res = CaclArray(new int[] { 10, 36, 68, 89, 91 });
            Console.WriteLine($"总和:{res[0]},最大值：{res[1]},最小值：{res[2]},平均值：{res[3]}");
            Console.WriteLine(RunNian(2000));
            Console.WriteLine(RunNian(2008));
        }
    }
}
