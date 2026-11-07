using System;
using System.Collections.Generic;
using System.Text;
namespace exercise枚举
{
        internal class exercise枚举
        {
            enum QQsitcuation
            {
                online = 1,
                leave = 2,
                busy = 3,
                none = 4
            }
            enum coffee
        {
            medium = 35,
            large = 40,
            superlarge = 43
        }
        enum gentle
        {
            male,
            female
        }
        enum occupation
        {
            warrior,
            hunter,
            mage
        }
            public static void Main(string[] args)
            {
                Console.WriteLine("请输入在线状态：");
                string input = Console.ReadLine();
                QQsitcuation qqsitcuation = (QQsitcuation)Enum.Parse(typeof(QQsitcuation), input);
                Console.WriteLine("你的在线状态是"+qqsitcuation);

            Console.WriteLine("请用户选择购买的咖啡类型：");
            String str = Console.ReadLine();
            coffee c = (coffee)Enum.Parse(typeof(coffee), str);
            switch (c)
            {
                case coffee.medium:
                    Console.WriteLine("你选择的咖啡类型是中杯，花了35元");
                    break;
                case coffee.large:
                    Console.WriteLine("你选择的咖啡类型是大杯，花了40元");
                    break;
                case coffee.superlarge:
                    Console.WriteLine("你选择的咖啡类型是超大杯，花了43元");
                    break;
            }

            int atack = 0;
            int def = 0;
            string skill = " ";
            Console.WriteLine("请选择英雄性别:");
            string m = Console.ReadLine();
            gentle g = (gentle)Enum.Parse(typeof(gentle), m);
            switch (g)
            {
                case gentle.male:
                    atack += 50;
                    def += 100;
                    break;
                case gentle.female:
                    atack += 150;
                    def += 20;
                    break;
            }
            Console.WriteLine("请选择英雄职业：");
            string o = Console.ReadLine();
            occupation oc = (occupation)Enum.Parse(typeof(occupation), o);
            switch(oc)
            {
                case occupation.warrior:
                    atack += 20;
                    def += 100;
                    skill = "冲锋";
                    break;
                case occupation.hunter:
                    atack += 120;
                    def += 30;
                    skill = "假死";
                    break;
                case occupation.mage:
                    atack += 200;
                    def += 10;
                    skill = "奥数冲击";
                    break;
            }
            Console.WriteLine("你选择了"+g+" "+oc+"，攻击力："+atack+",防御力："+def+",职业技能："+skill);

            }
        }




    
}
