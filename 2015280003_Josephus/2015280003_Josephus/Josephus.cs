using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015280003_Josephus
{
    class Josephus
    {
        private int count;
        private Node head, last;
        public Josephus(int count)
        {
            this.count = count;
            head = null;
            last = null;
        }



        // I created circular linked list
        public void addSoldier()
        {
            for (int i = 1; i <= count; i++)
            {
                Node newSoldier = new Node(i);
                if (head == null)
                {
                    head = newSoldier;
                    last = newSoldier;
                }
                else
                {
                    last.next = newSoldier;
                    newSoldier.prev = last;
                    last = newSoldier;
                }
            }

            head.prev = last;
            last.next = head;


        }

        //I applied josephus 
        //Josephus is based on the principle of kill the one on the left
        public void applyJosephus()
        {

            Node g = head, q = head;
            int temp = count;
            while (temp != 1)
            {


                q = g.next;
                g.next = q.next;
                q.next.prev = g;
                if (q == head)
                    head = head.next;

                g = g.next;
                q = g.next;

                temp--;
            }
            Console.WriteLine("En son kalan asker " + head.val + ".  kişidir -- Ne şanslıymış :)))");

            Console.WriteLine("Formuldeki sonuca göre " + (1 + 2 * count - Math.Pow(2, 1 + Math.Floor(Math.Log(count) / Math.Log(2)))) + ". sıradadır.");



        }





    }
}
