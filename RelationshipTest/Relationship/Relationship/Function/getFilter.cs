using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Relationship.Function
{
    class GetFilter
    {
        private JObject[] _Filter;
        private int _FilterSize;

        public GetFilter(string path)
        {
            StreamReader file = new StreamReader(path, System.Text.Encoding.UTF8);
            var _filter = file.ReadToEnd().Split('%');
            JObject[] _temp = new JObject[50];
            int j = 0;
            for(int i=0;i<_filter.Length-1;i++)
            {
                _temp[j++] = JObject.Parse(_filter[i]);
            }
            this._Filter = _temp;
            this._FilterSize = j-1;
       
        }

        private void getId(ref string selector, ref Dictionary<string, bool> hash, ref ArrayList result)
        {
            string s = "";
            if (!hash.ContainsKey(selector))
            {
                hash.Add(selector, true);
                string status = "true";
                do
                {
                    s = selector;
                    
                    for (int i = 0; i < _FilterSize+1; i++)
                    {

                        string patterm =_Filter[i].GetValue("exp").ToString();
                        
                        string str = _Filter[i].GetValue("str").ToString();

                        selector = Regex.Replace(selector, patterm, str);

                        if (selector.IndexOf('#') > -1)
                        {
                            var arr = selector.Split('#');

                            for (int j = 0; j < arr.Length; j++)
                            {
                                getId(ref arr[j], ref hash,ref result);
                            }
                            status = "false";
                            break;
                        }
                    }
                } while (s != selector);
                if(status=="true")
                {
                    if(Regex.IsMatch(selector, @",[w0],w|,[h1],h"))
                    {
                        return; 
                    }

                    selector = Regex.Replace(selector, @",[01]", "");

                    if (selector.Length!=0)
                    {
                        selector = selector.Substring(1);
                    }
                    
                    result.Add(selector);
                }
            }
        }

        public ArrayList Execute(string selector,int sex=-1)
        {
            /* Console.WriteLine("in:"+selector); */

            ArrayList result = new ArrayList();

            if (selector == "")
            {
                result.Add("");
                return result;
            }
      
            Dictionary<string, bool> hash = new Dictionary<string, bool>();

            if (sex < 0)
            {
                if (selector.IndexOf(",w") == 0)
                {
                    sex = 1;
                }
                else if (selector.IndexOf(",h") == 0)
                {
                    sex = 0;
                }
            }
            if (sex > -1)
            {
                //selector = ',' + sex.ToString() + selector;
            }
            if (Regex.IsMatch(selector, @",[w0],w|,[h1],h"))
            {
                result.Add("false");
                return result; // 同志关系
            }

            getId(ref selector, ref hash, ref result);

            /*
            Console.Write("out:");
            foreach(string s in result)
            {
                if (s == "") Console.Write("_ ");
                else Console.Write(s+" ");
            }
            Console.Write("\n");
            */

            return result;
        }
    }
}
