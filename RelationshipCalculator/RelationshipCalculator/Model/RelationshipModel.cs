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
    class RelationshipModel
    {
        private string result;
        private string inputText;

        public string Result { get; set; }
        public string InputText { get; set; }

        public RelationshipModel()
        {
            result    = "";
            inputText = "";
        }

        public void getResult()
        {
            DataSource src = new DataSource("Data//data.json");

            Searcher searcher = new Searcher(src.getJson());

            Filter simplifier = new Filter("Data//Filter.json");

            ArrayList sim = simplifier.Execute(inputText);

            if(sim.Count!=0)
            {
                foreach(string s in sim)
                {
                    string res = searcher.Who(s);
                    result += res;
                    result += "\n";
                }
            }
        }
    }
}
