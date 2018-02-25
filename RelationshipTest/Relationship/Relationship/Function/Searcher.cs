using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationship.Function
{
    class Searcher
    {
        public string Relationship(string my)
        {
            JObject obj = new getJson().GetJson("Data\\json.data");

            string ret = "";

            ret = obj[my].ToString();

            if(ret=="")
            {
                return "你们不是很熟哦~ ";
            }

            return ret;
        }
        
}
}
