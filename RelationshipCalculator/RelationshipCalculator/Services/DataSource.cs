using Newtonsoft.Json.Linq;
using System.IO;
using Windows.Storage;
using System;
using System.Threading.Tasks;
using RelationshipCalculator.Model;

namespace RelationshipCalculator.Services
{
    class DataSource
    {
        private string data;
        private string filter;
        private JObject obj;

        public DataSource()
        {
            data   = DataStore.Data;
            filter = DataStore.Filter;
            JObject obj = JObject.Parse(data);
            this.obj = obj;

        }

        public JObject GetJson()
        {
            return this.obj;
        }

        public string GetDataText()
        {
            return this.data;
        }

        public string GetFilterText()
        {
            return this.filter;
        }
    }
}
