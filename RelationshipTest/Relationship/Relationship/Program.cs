using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Relationship.Function;
using System;
using System.Collections;
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

            /*
            string str = "";
            Filter f = new Filter("Data//Filter.json");

            str = Console.ReadLine();
            while(str!="exit")
            {
                string output = f.Execute(str);
                Console.WriteLine(output);
                str = Console.ReadLine();
            }
            */
            /*
            StreamReader file = new StreamReader("Data//Filter.json", System.Text.Encoding.UTF8);
            var _filter = file.ReadToEnd().Split('%');
            JObject[] _temp = new JObject[50];
            int j = 0;
            for(int i=0;i<_filter.Length-1;i++)
            {
                Console.WriteLine(j);
                Console.WriteLine(_filter[i]);
                _temp[j++] = JObject.Parse(_filter[i]);
            }
            */

            JObject obj;

            GetData data = new GetData("Data//data.json");

            obj = data.getJson();

            string my = "";

            my = Console.ReadLine();

            GetText text = new GetText(obj);

            GetFilter filter = new GetFilter("Data//Filter.json");

            GetResult result = new GetResult(obj);

            while(my!="exit")
            {
                my = text.easyGetText(my);
                ArrayList simplify = filter.Execute(my);
                foreach(string s in simplify)
                {
                    string res = result.Relationship(s);
                    Console.WriteLine(res);
                    
                }
                my = Console.ReadLine();
            }
        }
    }
}
