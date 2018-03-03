using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                ret = "你们不是很熟哦~";
            }

            return ret;
        }
    }
}
