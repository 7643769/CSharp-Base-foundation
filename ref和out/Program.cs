using System.Runtime.InteropServices;

namespace ref和out
{
    internal class Program
    {
        static bool CheckLogin(string name,string pwd,out string msg)
        {
            if(name == "admin" && pwd == "123456")
            {
                msg = "登录成功";
                return true;
            }
            else if(name != "admin")
            {
                msg = "用户名错误";
                return false;
            }
            else 
            {
                msg = "密码错误";
                return false;
            }
        }
        //static void ChangeValue(int value)
        //{
        //    value = 3;
        //}
        //static void ChangeArrayValue(int[] arr)
        //{
        //    arr[0] = 99;
        //}
        //static void ChangeArray(ref int[] arr)
        //{
        //    arr = new int[] {10,20,30};
        //}
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //int a = 1;
            //ChangeValue(a);
            //Console.WriteLine(a);

            //int[] arr2 = new int[] { 1, 2, 3 };
            //ChangeArrayValue(arr2);
            //Console.WriteLine(arr2[0]);

            //ChangeArray(ref arr2);
            //Console.WriteLine(arr2[0]); 
            Console.WriteLine("请输入用户名：");
            string name =Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string pwd = Console.ReadLine();
            bool ok = CheckLogin(name,pwd,out string a);
            Console.WriteLine($"登陆结果：{ok},登录信息：{a}");
        }
    }
}
