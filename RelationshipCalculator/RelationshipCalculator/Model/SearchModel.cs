using Newtonsoft.Json.Linq;
using RelationshipCalculator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RelationshipCalculator.Model
{
    class SearchModel
    {
        private DataSource src;
        private JObject obj;
        private string keyword;
        private string result;

        public string Keyword { get { return this.keyword; } set { this.keyword = value; } }

        public string Result { get { return this.result; } set { this.result = value; } }

        public SearchModel()
        {
            this.src = new DataSource();
            try
            {
                this.obj = src.GetJson();
            }catch(Exception e)
            {
                Console.Write("ERROR: " + e.Message + "\n");
            }
            
        }

        public void GetChain()
        {
            bool found = false;
            string temp = Regex.Replace(Keyword, "^[一|二|三|四|五|六|七|八|九|十]+","x");
            string k1 = "|" + temp + ",";
            string k2 = "," + temp + ",";
            string k3 = "," + temp + "|";
            string k4 = "|" + temp + "|";
            foreach(var i in obj)
            {
                if(i.Value.ToString().Contains(k1) || i.Value.ToString().Contains(k2) || i.Value.ToString().Contains(k3) || i.Value.ToString().Contains(k4))
                {
                    Result = Transfer(i.Key);
                    found = true;
                    break;
                }
            }
            if(found==false)
            {
                Result = "尚未收录[" + Keyword + "] ...";
            }
            
            return;
        }

        private string Transfer(string str)
        {
            string s = str;

            s = Regex.Replace(s, "f", "爸爸");
            s = Regex.Replace(s, "m", "妈妈");
            s = Regex.Replace(s, "h", "老公");
            s = Regex.Replace(s, "w", "老婆");
            s = Regex.Replace(s, "lb", "弟弟");
            s = Regex.Replace(s, "ls", "妹妹");
            s = Regex.Replace(s, "ob", "哥哥");
            s = Regex.Replace(s, "os", "姐姐");
            s = Regex.Replace(s, "xb", "兄弟");
            s = Regex.Replace(s, "xs", "姐妹");
            s = Regex.Replace(s, "s", "儿子");
            s = Regex.Replace(s, "d", "女儿");
            s = Regex.Replace(s, ",", "的");

            return s;
        }
    }
}
