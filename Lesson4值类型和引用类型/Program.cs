namespace Lesson4值类型和引用类型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("值类型和引用类型");
            //sbyte a = 1;
            //Console.WriteLine(a);
            ////引用类型：string、object、Array、class等
            ////值类型：int、float、double、decimal、bool、char、enum、struct等 
            //sbyte b = a;
            //Console.WriteLine(b);
            //b = 3;
            //Console.WriteLine(a);
            //Console.WriteLine(b); 
            //int[] arr1 = { 1, 2, 3 };
            //Console.WriteLine(string.Join(", ", arr1));
            //int[] arr2 = arr1;
            //Console.WriteLine(string.Join(", ", arr2));
            //arr2[0] = 10;
            //Console.WriteLine(string.Join(", ", arr1));
            //Console.WriteLine(string.Join(", ", arr2));

            string str = "123";
            string str2 = str;
            str2 = "321";
            Console.WriteLine(str);
            Console.WriteLine(str2);

        }
    }
}
