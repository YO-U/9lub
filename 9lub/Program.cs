using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двоичное число до запятой");
            var per = Console.ReadLine();
            Console.WriteLine("Введите двоичное число после запятой");
            var vtor = Console.ReadLine();
            try
            {
                long nach1 = Convert.ToInt32(per, 2);
                long nach2 = Convert.ToInt32(vtor, 2);
                string res1 = Convert.ToString(nach1, 10);
                string res2 = Convert.ToString(nach2, 10);
                Console.WriteLine(res1 + "." + res2);               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}