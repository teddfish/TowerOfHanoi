using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    class Program
    {
        static void Tower(int i, char a, char b, char c)
        {
            if (i == 1)
            {
                Console.WriteLine("Move {0} from {1} to {2}", i, a, c);
                return;
            }
            Tower(i - 1, a, c, b);
            Console.WriteLine("Move {0} from {1} to {2}", i, a, c);
            Tower(i - 1, b, a, c);
        }

        static void Main(string[] args)
        {
            Tower(3, 'A', 'B', 'C');
            Console.Read();
        }

        static void Tower2(int i, char a, char b, char c)
        {
            if (i > 0)
            {
                Tower2(i - 1, a, c, b);
                Console.WriteLine("Move disk " + i + " from " + a + " to " + c);
                Tower2(i - 1, b, a, c);
            }
        }

    }
}
