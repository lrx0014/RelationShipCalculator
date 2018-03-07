using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RelationshipCalculator.Services
{
    class Searcher
    {
        private JObject obj;

        public Searcher(JObject obj)
        {
            this.obj = obj;
        }

        public string Who(string my)
        {
            string ret = "";

            if(obj.ContainsKey(my))
            {
                ret = obj[my].ToString();
            }
            else
            {
                string key = "l|o";
                my = Regex.Replace(my,key,"x");

                if (obj.ContainsKey(my))
                {
                    ret = obj[my].ToString();
                }
                else
                {
                    ret = "你们好像不是很熟哦~~ ";
                }
            }

            return ret;
        }
    }
}
