﻿using Newtonsoft.Json.Linq;
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
            string ret = "null";

            try
            {
                ret = obj[my].ToString();
            }catch(Exception e)
            {
                ///
            }

            return ret;
        }
        
}
}
