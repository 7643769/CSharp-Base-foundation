namespace 结构体
{
    struct Player
    {
        public enum Career
        {
            zhanshi,
            lieren,
            fashi
        }
        public string PlayerName;
        public Career Type;
        public string skill;
        public void skills()
        {
            switch (Type)
            {
                case Career.zhanshi:
                    skill = "冲锋";
                    break;
                case Career.lieren:
                    skill = "假死";
                    break;
                case Career.fashi:
                    skill = "奥术冲击";
                    break;
            }
        }
        public Player(string name,Career career)
        {
            this.PlayerName = name;
            this.Type = career;
            skills();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请用户输入玩家姓名：");
            string name = Console.ReadLine();
            Console.WriteLine("请用户选择玩家职业：");
            Console.WriteLine("可供选择的职业有：");
            Console.WriteLine("zhanshi");
            Console.WriteLine("lieren");
            Console.WriteLine("fashi");
            Player.Career career = (Player.Career)Enum.Parse(typeof(Player.Career),Console.ReadLine());
            Player a = new Player(name,career);
            Console.WriteLine($"{a.Type}{a.PlayerName}释放了{a.skill}");
        }
    }
}
