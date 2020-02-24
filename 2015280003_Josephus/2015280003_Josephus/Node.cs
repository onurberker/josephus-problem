using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015280003_Josephus
{
    class Node
    {
       public int val;
       public Node prev = null;
       public Node next = null;
        
        public Node(int val)
        {
            this.val = val;
        }
    }
}
