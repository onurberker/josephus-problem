using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015280003_Josephus
{
    class Program
    {
        private static Node head = null, last = null;

        static void Main(string[] args)
        {


            int count;
            while (true)
            {

                try
                {
                    Console.WriteLine("Enter the soldier count");
                    string temp;
                    temp = Console.ReadLine();
                    count = Convert.ToInt32(temp);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input");
                }

            }

            Josephus js = new Josephus(count);
            js.addSoldier();
            js.applyJosephus();
            Console.ReadKey();
           




        }

     
    }
}
