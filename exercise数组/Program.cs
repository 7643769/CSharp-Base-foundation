namespace exercise数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] a = new int[100];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i;
            }
            int[] b = new int[100];
            for(int i = 0; i < b.Length; i++)
            {
                b[i] = a[i]*2;
            }
            */
            //随机生成数组
            /*
            Random r = new Random();
            int[] c = new int[10];
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = r.Next(0, 101);
                Console.WriteLine("c数组第" + (i + 1) + "个元素是：" + c[i]);
            }
            */
            #region C数组的最大值、最小值、和、平均值
            /*
            int max = c[0];
            int min = c[0];
            int sum = 0;
            int avg = 0;
            for (int i = 0;i < c.Length; i++)
            {
                
                if (max < c[i])
                {
                    max = c[i];
                }
             
                if (min > c[i])
                {
                    min = c[i];
                }
                sum += c[i];
                
                
            }
            avg = sum / c.Length;
            Console.WriteLine("数组c的最大值为：" + max);
            Console.WriteLine("数组c的最小值为：" + min);
            Console.WriteLine("数组c的和为：" + sum);
            Console.WriteLine("数组c的平均值为：" + avg);
            */
            #endregion
            #region C数组反转并打印
            /*
            int[] d = new int[10];
            for (int i = 0,j =c.Length - 1; i < c.Length / 2; i++,j--)
            {
                
                    int temp = c[i];
                    c[i] = c[j];
                    c[j] = temp;
                    d[i] = c[i];
                    d[j] = c[j];
                
            }
            for (int i = 0; i < d.Length; i++)
            {
                Console.WriteLine("d数组第" + (i + 1) + "个元素是：" + d[i]);
            }
            */
            #endregion
            #region C数组中正数加1，负数减1，0不变
            /*
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] > 0)
                {
                    c[i] += 1;
                }
                else if (c[i] < 0)
                {
                    c[i] -= 1;
                }
                else
                {
                    c[i] = 0;
                }
            }
            */
            #endregion
            #region 获取输入，存入数组并打印
            /*
            int[] d = new int[10];
            for (int i = 0; i < d.Length; i++)
            {
                Console.WriteLine("请输入第" + (i + 1) + "个同学的数学成绩：");
                while (true)
                {
                    if(int.TryParse(Console.ReadLine(),out d[i]))
                    {
                        break;
                    }
                    Console.WriteLine("输入有误，请重新输入第" + (i + 1) + "个同学的数学成绩：");
                }
            }
            for(int i = 0; i < d.Length; i++)
            {
                Console.WriteLine("d数组第" + (i + 1) + "个同学的数学成绩是：" + d[i]);
            }
            Console.WriteLine("数学最高分：" + d.Max());
            Console.WriteLine("数学最低分：" + d.Min());
            Console.WriteLine("数学平均分：" + d.Average());
            */
            #endregion
            string[] e = new string[25];
            
            for (int i = 0; i < e.Length; i++)
            {
                
                    if (i % 2 != 0)
                    {
                        e[i] = "实";
                        
                    }
                    else if (i % 2 == 0 || i == 0)
                    {
                        e[i] = "虚";
                        
                    }
                
            }
            for(int i = 0; i < e.Length; i++)
            {
                Console.Write(e[i] + " ");
                if((i+1) % 5 == 0)
                {
                    Console.WriteLine();
                }
            }

        }
    }
            
    }

