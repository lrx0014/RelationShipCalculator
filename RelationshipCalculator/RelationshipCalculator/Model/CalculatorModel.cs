using Newtonsoft.Json.Linq;
using RelationshipCalculator.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationshipCalculator.Model
{
    class CalculatorModel
    {
        private string result;
        private string inputText;

        private DataSource src;

        public string Result { get { return result; } set { result = value;  } }
        public string InputText { get { return inputText; } set { inputText = value; } }

        public CalculatorModel()
        {
            result    = "";
            inputText = "";

            this.src = new DataSource();
        }

        public void getResult()
        {
            Result = string.Empty;

            Searcher searcher = new Searcher(src.getJson());

            Filter simplifier = new Filter(src.getFilterText());

            ArrayList sim = simplifier.Execute(InputText);

            Dictionary<string, bool> record = new Dictionary<string, bool>();

            if(sim.Count!=0)
            {
                foreach(string s in sim)
                {
                    if(record.ContainsKey(s))
                    {
                        continue;
                    }
                    else
                    {
                        record.Add(s, true);
                        string res = searcher.Who(s);
                        if(res!= "你们好像不是很熟哦~~ ")
                        {
                            Result += res;
                            Result += "\n";
                        }
                    }
                    
                }
                if(Result=="")
                {
                    Result = "你们好像不是很熟哦~~ ";
                }
            }
        }
    }
}
