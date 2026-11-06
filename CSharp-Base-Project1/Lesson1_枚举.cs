namespace CSharp_Base_Project1
{
    internal class Lesson1_枚举
    {
        enum E_自定义枚举名
        {
            自定义枚举项名字 = 5,
            自定义枚举项名字2,//自定义枚举项名字2的值为6(累加)
            
        }
        enum E_MonsterType
        {
            small = 1,
            medium = 2,
            large = 3,
            Boss = 4
        }
        enum E_PlayerType
        {
            Main,
            Other,
        }

        static void Main(string[] args)
        {
            Console.WriteLine("枚举");
            //注意：枚举不能在函数语句块中定义，只能在类中定义
            E_PlayerType playerType = E_PlayerType.Main;
            if(playerType == E_PlayerType.Main)
            {
                Console.WriteLine("玩家类型是主角");
            }
            else
            {
                Console.WriteLine("玩家类型是其他");
            }
            E_MonsterType monsterType = E_MonsterType.Boss;
            switch(monsterType)
            {
                case E_MonsterType.small:
                    Console.WriteLine("小怪");
                    break;
                case E_MonsterType.medium:
                    Console.WriteLine("中怪");
                    break;
                case E_MonsterType.large:
                    Console.WriteLine("大怪");
                    break;
                case E_MonsterType.Boss:
                    Console.WriteLine("Boss");
                    break;
            }

            int i = (int)playerType;
            Console.WriteLine("玩家类型的枚举值为：" + i);

            string str = E_PlayerType.Main.ToString();
            Console.WriteLine("玩家类型的枚举名称为：" + str);
            //parse后 第一个参数是枚举类型，第二个参数是枚举名称的字符串
            playerType = (E_PlayerType) Enum.Parse(typeof(E_PlayerType), "Other");
            Console.WriteLine(playerType);
        }
    }
}
