using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCollections;

namespace MyCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList ll = new LinkedList();

            ll.Add("One");
            ll.Add("Two");
            ll.Add("Three");
            ll.Add("Four");
            ll.Add("Five");

            ll.PrintList();

            Console.ReadKey();
        }
    }
}
