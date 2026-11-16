namespace 变长参数和参数默认值
{
    internal class Program
    {
        static (int,float) Math(params int[] arr)
        {
            if (arr.Length == 0)
            {
                return (0, 0);
            }
            int sum = 0;
            float ave = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            ave =(float) sum / arr.Length;
            return ( sum, ave );
        }
        //static void Speak(string str = "我没什么话可说")
        //{
        //    Console.WriteLine(str);
        //}
        static int[] Sum(params int[] arr)
        {
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                
                if (arr[i] % 2 == 0)
                {
                    sum1 += arr[i];
                }
                else
                {
                    sum2 += arr[i];
                }
               
            }
            return new int[] { sum1, sum2 };
        }
        static void Main(string[] args)
        {
            (int sum, float ave) a = Math(3,30,60,600,7);
            Console.WriteLine("总和是"+a.sum+",平均数是"+a.ave);
            int[] b = Sum(1,2,3,4,5,6,7,8,9,10);
            Console.WriteLine("奇数和是" + b[1] + ",偶数和是" + b[0]);
            //Speak();
        }
    }
}
