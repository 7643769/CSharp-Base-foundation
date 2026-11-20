namespace 结构体
{
    //结构体
    #region 练习题一
    //struct Player
    //{
    //    public enum Career
    //    {
    //        zhanshi,
    //        lieren,
    //        fashi
    //    }
    //    public string PlayerName;
    //    public Career Type;
    //    public string skill;
    //    public void skills()
    //    {
    //        switch (Type)
    //        {
    //            case Career.zhanshi:
    //                skill = "冲锋";
    //                break;
    //            case Career.lieren:
    //                skill = "假死";
    //                break;
    //            case Career.fashi:
    //                skill = "奥术冲击";
    //                break;
    //        }
    //    }
    //    public Player(string name,Career career)
    //    {
    //        this.PlayerName = name;
    //        this.Type = career;
    //        skills();
    //    }

    //}
    #endregion
    struct Monster
    {
        public string MonsterName;
        public int atk;
        public int def;
        public int hp;
        public int MAtk(ref AoTeMan a)
        {
            int harm = atk - a.def;
            if (harm <= 0)
            {
                harm = 0;
            }
            a.hp -= harm;
            return harm;
        }
    }
    struct AoTeMan
    {
        public string AoTeManName;
        public int atk;
        public int def;
        public int hp;
        public int AAtk(ref Monster m)
        {
            int harm = atk - m.def;
            if (harm <= 0)
            {
                harm = 0;
            }
            m.hp -= harm;
            return harm;
        }
    }
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region 练习题一
            //        Console.WriteLine("请用户输入玩家姓名：");
            //        string name = Console.ReadLine();
            //        Console.WriteLine("请用户选择玩家职业：");
            //        Console.WriteLine("可供选择的职业有：");
            //        Console.WriteLine("zhanshi");
            //        Console.WriteLine("lieren");
            //        Console.WriteLine("fashi");
            //        Player.Career career = (Player.Career)Enum.Parse(typeof(Player.Career),Console.ReadLine());
            //        Player a = new Player(name,career);
            //        Console.WriteLine($"{a.Type}{a.PlayerName}释放了{a.skill}");
            #endregion
            
            Monster[] m = new Monster[10];
            Random r = new Random();
            for(int i = 0; i < m.Length; i++)
            {
                m[i].hp = 100;
                m[i].def = 10;
                m[i].atk = r.Next(1,11);
                m[i].MonsterName = $"小怪兽{i}";
            }
            for(int i = 0; i < m.Length; i++)
            {
                Console.WriteLine($"{m[i].MonsterName}的攻击力为{m[i].atk}");
            }

            AoTeMan[] A = new AoTeMan[3];
            for (int i = 0; i < A.Length; i++)
            {
                A[i].hp = 200;
                A[i].def = 5;
                A[i].atk = r.Next(6, 18);
                A[i].AoTeManName = $"奥特曼{i}";
            }
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine($"{A[i].AoTeManName}的攻击力为{A[i].atk}");
            }

            Console.WriteLine("****************************************************");
            Console.WriteLine("奥特曼1攻击小怪兽3");
            int h = A[1].AAtk(ref m[3]);
            Console.WriteLine($"小怪兽3受到伤害{h}，还剩余血量{m[3].hp}");

            Console.WriteLine("小怪兽2攻击奥特曼1");
            int h2 = m[2].MAtk(ref A[1]);
            Console.WriteLine($"奥特曼1受到伤害{h2}，还剩余血量{A[1].hp}");
        }
    }
}
