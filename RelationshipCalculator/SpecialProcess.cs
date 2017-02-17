using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RelationshipCalculator
{
    class SpecialProcess
    {
        public string Replace(string str)
        {
            if (Regex.IsMatch(str, "^(.+)&o([^#]+)&l"))
            {
                str = Regex.Replace(str, "^(.+)&o([^#]+)&l", "$1$2");
            }
            if (Regex.IsMatch(str, "(,[ds],(.+),[ds])&[ol]"))
            {
                str = Regex.Replace(str, "(,[ds],(.+),[ds])&[ol]", "$1");
            }
            if (Regex.IsMatch(str, "(,o[sb])+(,o[sb])"))
            {
                str = Regex.Replace(str, "(,o[sb])+(,o[sb])", "$2");
            }
            if (Regex.IsMatch(str, "(,l[sb])+(,l[sb])"))
            {
                str = Regex.Replace(str, "(,l[sb])+(,l[sb])", "$2");
            }
            if (Regex.IsMatch(str, "^(.*)(,[fh1])(,[olx][sb])+,[olx]b(.*)$"))
            {
                str = Regex.Replace(str, "^(.*)(,[fh1])(,[olx][sb])+,[olx]b(.*)$", "$1$2,xb$4#$1$2$4");
            }
            if (Regex.IsMatch(str, "^(.*)(,[mw0])(,[olx][sb])+,[olx]s(.*)$"))
            {
                str = Regex.Replace(str, "^(.*)(,[mw0])(,[olx][sb])+,[olx]s(.*)$", "$1$2,xs$4#$1$2$4");
            }
            if (Regex.IsMatch(str, "(,[fh1])(,[olx][sb])+,[olx]s"))
            {
                str = Regex.Replace(str, "(,[fh1])(,[olx][sb])+,[olx]s", "$1,xs");
            }
            if (Regex.IsMatch(str, "(,[mw0])(,[olx][sb])+,[olx]b"))
            {
                str = Regex.Replace(str, "(,[mw0])(,[olx][sb])+,[olx]b", "$1,xb");
            }
            if (Regex.IsMatch(str, "^,[olx][sb],[olx]b(.+)?$"))
            {
                str = Regex.Replace(str, "^,[olx][sb],[olx]b(.+)?$", "$1#,xb$1");
            }
            if (Regex.IsMatch(str, "^,[olx][sb],[olx]s(.+)?$"))
            {
                str = Regex.Replace(str, "^,[olx][sb],[olx]s(.+)?$", "$1#,xs$1");
            }
            if (Regex.IsMatch(str, "^,x([sb])$"))
            {
                str = Regex.Replace(str, "^,x([sb])$", ",o$1#,l$1");
            }
            if (Regex.IsMatch(str, "m,h"))
            {
                str = Regex.Replace(str, "m,h", "f");
            }
            if (Regex.IsMatch(str, "f,w"))
            {
                str = Regex.Replace(str, "f,w", "m");
            }

            if (Regex.IsMatch(str, ",[xol][sb](,[mf])"))
            {
                str = Regex.Replace(str, ",[xol][sb](,[mf])", "$1");
            }
            if (Regex.IsMatch(str, ",[mf],d&([ol])"))
            {
                str = Regex.Replace(str, ",[mf],d&([ol])", ",$1s");
            }
            if (Regex.IsMatch(str, ",[mf],s&([ol])"))
            {
                str = Regex.Replace(str, ",[mf],s&([ol])", ",$1b");
            }
            if (Regex.IsMatch(str, "^(.*)(,[fh1]|[xol]b),[mf],s(.*)$"))
            {
                str = Regex.Replace(str, "^(.*)(,[fh1]|[xol]b),[mf],s(.*)$", "$1$2,xb$3#$1$2$3");
            }
            if (Regex.IsMatch(str, "^(.*)(,[mw0]|[xol]s),[mf],d(.*)$"))
            {
                str = Regex.Replace(str, "^(.*)(,[mw0]|[xol]s),[mf],d(.*)$", "$1$2,xs$3#$1$2$3");
            }
            if (Regex.IsMatch(str, "(,[mw0]|[xol]s),[mf],s"))
            {
                str = Regex.Replace(str, "(,[mw0]|[xol]s),[mf],s", "$1,xb");
            }
            if (Regex.IsMatch(str, "(,[fh1]|[xol]b),[mf],d"))
            {
                str = Regex.Replace(str, "(,[fh1]|[xol]b),[mf],d", "$1,xs");
            }
            if (Regex.IsMatch(str, "^,[mf],s(.+)?$"))
            {
                str = Regex.Replace(str, "^,[mf],s(.+)?$", ",1$1#,xb$1");
            }
            if (Regex.IsMatch(str, "^,[mf],d(.+)?$"))
            {
                str = Regex.Replace(str, "^,[mf],d(.+)?$", ",0$1#,xs$1");
            }
            if (Regex.IsMatch(str, ",[ds]&o,ob"))
            {
                str = Regex.Replace(str, ",[ds]&o,ob", ",s&o");
            }

            if (Regex.IsMatch(str, ",[ds]&o,os"))
            {
                str = Regex.Replace(str, ",[ds]&o,os", ",d&o");
            }
            if (Regex.IsMatch(str, ",[ds]&l,lb"))
            {
                str = Regex.Replace(str, ",[ds]&l,lb", ",s&l");
            }
            if (Regex.IsMatch(str, ",[ds]&l,ls"))
            {
                str = Regex.Replace(str, ",[ds]&l,ls", ",d&l");
            }
            if (Regex.IsMatch(str, ",[ds](&[ol])?,[olx]s"))
            {
                str = Regex.Replace(str, ",[ds](&[ol])?,[olx]s", ",d");
            }
            if (Regex.IsMatch(str, ",[ds](&[ol])?,[olx]b"))
            {
                str = Regex.Replace(str, ",[ds](&[ol])?,[olx]b", ",s");
            }
            if (Regex.IsMatch(str, "(,[mwd0](&[ol])?|[olx]s),[ds](&[ol])?,m"))
            {
                str = Regex.Replace(str, "(,[mwd0](&[ol])?|[olx]s),[ds](&[ol])?,m", "$1");
            }
            if (Regex.IsMatch(str, "(,[mwd0](&[ol])?|[olx]s),[ds](&[ol])?,f"))
            {
                str = Regex.Replace(str, "(,[mwd0](&[ol])?|[olx]s),[ds](&[ol])?,f", "$1,h");
            }
            if (Regex.IsMatch(str, "(,[fhs1](&[ol])?|[olx]b),[ds](&[ol])?,f"))
            {
                str = Regex.Replace(str, "(,[fhs1](&[ol])?|[olx]b),[ds](&[ol])?,f", "$1");
            }
            if (Regex.IsMatch(str, "(,[fhs1](&[ol])?|[olx]b),[ds](&[ol])?,m"))
            {
                str = Regex.Replace(str, "(,[fhs1](&[ol])?|[olx]b),[ds](&[ol])?,m", "$1,w");
            }
            if (Regex.IsMatch(str, "^,[ds],m(.+)?$"))
            {
                str = Regex.Replace(str, "^,[ds],m(.+)?$", "$1#,w$1");
            }
            if (Regex.IsMatch(str, "^,[ds],f(.+)?$"))
            {
                str = Regex.Replace(str, "^,[ds],f(.+)?$", "$1#,h$1");
            }
            if (Regex.IsMatch(str, ",[wh](,[ds])"))
            {
                str = Regex.Replace(str, ",[wh](,[ds])", "$1");
            }
            if (Regex.IsMatch(str, ",w,h|,h,w"))
            {
                str = Regex.Replace(str, ",w,h|,h,w", "self");
            }
            if (Regex.IsMatch(str, "(.+)?\\[(.+)\\|(.+)\\](.+)?"))
            {
                str = Regex.Replace(str, "(.+)?\\[(.+)\\|(.+)\\](.+)?", "$1$2$4#$1$3$4");
            }
            return str;
        }

        public string SearchId(string str)
        {
            string doc = System.IO.File.ReadAllText("data/_data.txt", Encoding.Unicode);
            string[] splits = doc.Split('\n');
            for (int i = 0; i < splits.Length; i++)
            {
                if (splits[i].Split(':')[0] == str)
                {
                    return splits[i].Split(':')[1];
                }
            }
            return "NONE";
        }
    }
}
