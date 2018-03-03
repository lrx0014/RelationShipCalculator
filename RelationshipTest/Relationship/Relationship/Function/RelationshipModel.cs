using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationship.Function
{
    class RelationshipModel
    {
        private JObject obj;
        private GetFilter filter;

        public RelationshipModel()
        {
            JObject obj;

            GetData data = new GetData("Data//data.json");

            obj = data.getJson();

            this.obj = obj;

            GetFilter filter = new GetFilter("Data//Filter.json");

            this.filter = filter;
        }

        public void Who(string my)
        {
            GetResult result = new GetResult(obj);

            ArrayList simplify = filter.Execute(my);

            if(simplify.Count==0)
            {
                Console.WriteLine("你们不是很熟哦~");
                return;
            }

            foreach (string s in simplify)
            {
                string res = result.Relationship(s);
                if(res=="null")
                {
                    continue;
                }
                Console.WriteLine(res);
            }
        }

        public string easyGetText(string my)
        {
            var input = my.Split('的');
            my = ",";
            foreach (var i in input)
            {
                switch (i)
                {
                    case "爸爸":
                        my += "f,";
                        break;
                    case "妈妈":
                        my += "m,";
                        break;
                    case "哥哥":
                        my += "ob,";
                        break;
                    case "弟弟":
                        my += "lb,";
                        break;
                    case "姐姐":
                        my += "os,";
                        break;
                    case "妹妹":
                        my += "ls,";
                        break;
                    case "儿子":
                        my += "s,";
                        break;
                    case "女儿":
                        my += "d,";
                        break;
                    case "老公":
                        my += "h,";
                        break;
                    case "老婆":
                        my += "w,";
                        break;
                }
            }

            my = my.Substring(0, my.Length - 1);

            return my;
        }
    }
}
