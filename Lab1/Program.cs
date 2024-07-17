using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Angle angle;
            try
            {
                do
                {
                    Console.WriteLine("Введите градусы");
                    int gradus = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите минуты");
                    int min = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите секунды");
                    int sec = Convert.ToInt32(Console.ReadLine());

                    angle = new Angle(gradus, min, sec);

                } while (angle.isCorrect == false);
                double rad = angle.ToRadians();
                Console.WriteLine("В радианнах:{0}", rad);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
            Console.ReadKey();
        }
    }
}
