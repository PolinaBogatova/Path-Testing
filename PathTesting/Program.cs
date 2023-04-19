using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            double cost = 0;
            int discount = 0;

            Console.WriteLine("Введите стоимость покупки:");
            cost = (Convert.ToDouble(Console.ReadLine()));
           
            if (cost >= 1000 && cost < 1500)
            {
                discount = 3;
                cost = cost - ((cost * discount) / 100);             

            }

            else if(cost >= 1500 && cost < 3000)
            {
                discount = 5;
                cost = cost - ((cost * discount) / 100);
                
            }

            else if (cost >= 3000)
            {
                discount = 15;
                cost = cost - ((cost * discount) / 100);
                

            }
            else
            {
                Console.WriteLine("Скидки нет");
            }

            Console.WriteLine("Итог: " + cost);

        }
    }
}
