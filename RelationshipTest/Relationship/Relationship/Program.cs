using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Relationship.Function;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationship
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Searcher s = new Searcher();
            string my = "";
            my = Console.ReadLine();
            while(my!="exit")
            {
                Console.WriteLine(s.Relationship(my));
                my = Console.ReadLine();
            }
            */

            Simplifier sf = new Simplifier();
            string str = "";
            str = Console.ReadLine();
            while (str != "exit")
            {
                sf.getSelectors(str);
                str = Console.ReadLine();
            }
        }
    }
}
