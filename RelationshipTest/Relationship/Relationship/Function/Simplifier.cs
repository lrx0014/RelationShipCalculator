using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Relationship.Function
{
    class Simplifier
    {

        private JObject obj;

        Simplifier(JObject obj)
        {
            this.obj = obj;
        }

        public string getSelectors(string str)
        {
            string myStr = Regex.Replace(str, @"[二|三|四|五|六|七|八|九|十]{1,2}", "x");
            List<string> lists = myStr.Split('的').ToList();
            string result = "";
            var match = true;

            for(int i=0;i<lists.Count;i++)
            {
                var name = lists[i];
                List<string> arr = new List<string>();
                var has = false;
                foreach(var x in obj)
                {
                    var value = x.Value.ToString();
                    if(value.Contains(name))
                    {
                        if(x.Key=="" || lists.Count==0)
                        {
                            arr.Add(x.Key);
                        }
                        has = true;
                    }
                }
                if(!has)
                {
                    match = false;
                }
                if(result.Length!=0)
                {
                    List<string> res = new List<string>();
                    for(int ii=0;ii<result.Length;ii++)
                    {
                        for(int jj=0;jj<arr.Count;jj++)
                        {
                            res.Add(result[ii] + ',' + arr[jj]);
                        }
                    }
                    foreach(string s in res)
                    {
                        result += s;
                    }
                }
                else
                {
                    for(int ii=0;ii<arr.Count;ii++)
                    {
                        result += (',' + arr[ii]);
                    }
                }
            }
            return match ? result : "";
        }

        private void getId(ref string selector, ref Dictionary<string, bool> hash)
        {
            string s = "";
            if(!hash[selector])
            {
                hash[selector] = true;
                bool status = true;
                do
                {
                    s = selector;
                    foreach(var i in )
                }
            }
        }

        public string selector2id(string selector,int sex)
        {
            string result = "";
            int sex2 = -1;
            Dictionary<string,bool> hash = new Dictionary<string,bool>();
            if(sex<0)
            {
                if(selector.IndexOf(",w")==0)
                {
                    sex = 1;
                }else if (selector.IndexOf(",h") == 0)
                {
                    sex = 0;
                }
            }
            if(sex>-1)
            {
                selector = ',' + sex + selector;
            }
            if(Regex.IsMatch(selector, @",[w0],w|,[h1],h"))
            {
                return "RainBow!!";
            }

        }
    }
}
