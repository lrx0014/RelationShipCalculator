using Newtonsoft.Json.Linq;
using System.IO;

namespace RelationshipCalculator.Services
{
    class DataSource
    {
        private JObject obj;

        public DataSource(string path)
        {
            FileStream fs = new FileStream(@"Data//data.json", FileMode.Open);
            StreamReader file = new StreamReader(fs, System.Text.Encoding.UTF8);
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
