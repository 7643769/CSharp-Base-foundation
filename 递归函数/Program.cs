namespace 递归函数
{
    internal class Program
    {
        static int Fun(int n)
        {
            Console.WriteLine(n);
            n += 1;
            if (n == 11)
            {
                return 0;
            }
            else
            {
                Fun(n);
                return 0;
            }
            
        }
        static int JieCheng(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * JieCheng(n - 1);
        }
        static void Main(string[] args)
        {
            Fun(0);
            Console.WriteLine(JieCheng(5));
        }
    }
}
