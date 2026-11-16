namespace 函数重载
{
    internal class Program
    {
        static int Compare(int a,int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static float Compare(float a,float b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static int Compare(params int[] arr)
        {
            int max = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        static double Compare(params double[] arr)
        {
            double max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Compare(13, 36));
            Console.WriteLine(Compare(23.6f,21.2f));
            Console.WriteLine(Compare(13,36,92,74,18));
            Console.WriteLine(Compare(13.6, 36.9));
        }
    }
}
