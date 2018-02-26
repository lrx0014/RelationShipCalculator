using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationship.Function
{
    class GetResult
    {
        private JObject obj;

        public GetResult(JObject obj)
        {
            this.obj = obj;
        }
        public string Relationship(string my)
        {
            string ret = "";

            ret = this.obj[my].ToString();

            if(ret=="")
            {
                return "你们不是很熟哦~ ";
            }

            return ret;
        }
        
}
}
