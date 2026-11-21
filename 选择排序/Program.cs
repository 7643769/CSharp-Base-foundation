namespace 选择排序
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[9] { 36, 89, 51, 12, 29, 71, 96, 43, 67 };
            int temp = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1;j<arr.Length;j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
