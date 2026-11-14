namespace 函数
{
    internal class Program
    {
        // 无参无返回
        static void SayHello()
        {
            Console.WriteLine("Hello World!");
        }

        // 有参无返回
        static void Player(int def, string name)
        {
            Console.WriteLine("玩家昵称：{0}", name);
        }

        // 有参多返回
        static (string, int) Sum(string name, int b)
        {
            return (name + "玩家", b + 1);
        }
        //return
        static void speak(string str)
        {
            if (str == "混蛋")
            {
                return;
            }
            Console.WriteLine(str);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("函数");

            // 基本语法
            // static 返回类型 函数名(参数类型 参数名,...) {函数体}
            // return 返回值;(如果有返回类型才返回)
            // 关于函数名 myName(参数名用驼峰命名法) MyName(函数名用帕斯卡命名法)
            SayHello();
            Player(6, "舟舟");
            (string name, int def) a = Sum("gemini", 6);
            Console.WriteLine(a.name);
            Console.WriteLine(a.def);
            speak("grok");
        }
    }
}
