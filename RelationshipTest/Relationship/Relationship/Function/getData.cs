using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationship.Function
{
    class GetData
    {
        private JObject obj;

        public GetData(string path)
        {
            StreamReader file = new StreamReader(path, System.Text.Encoding.UTF8);
            string json = file.ReadToEnd();
            JObject obj = JObject.Parse(json);
            this.obj = obj;
        }

        public JObject getJson()
        {
            return this.obj;
        }
    }
}
