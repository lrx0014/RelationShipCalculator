using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Relationship.Function
{
    class GetText
    {

        private JObject obj;

        public GetText(JObject obj)
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
