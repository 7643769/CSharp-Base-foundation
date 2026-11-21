namespace 排序初探
{
    internal class Program
    {
        static void SortArray(ref int[]arr,bool isAscending)
        {
            int temp;
            for (int k = 0; k < arr.Length; k++)
            {
                for (int i = 0, j = i + 1; i < arr.Length - 1 - k; i++, j++)
                {

                    if (isAscending == true && arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                    if (isAscending == false && arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                }
            }
            
        }
        static void Main(string[] args)
        {
            int[] arr = new int[6] { 12, 63, 21, 96, 33, 31 };
            SortArray(ref arr,false);
            for (int i = 0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
