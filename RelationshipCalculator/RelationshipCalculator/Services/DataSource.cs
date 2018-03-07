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
            //var task =  GetJsonFileAsync().ConfigureAwait(false);
            //var arr = json.Split('Y');
            //data   = arr[0];
            //filter = arr[1];

            data   = DataStore.Data;
            filter = DataStore.Filter;
            JObject obj = JObject.Parse(data);
            this.obj = obj;

        }

        /*
        private async Task<string> GetJsonFileAsync()
        {
            var uri = new System.Uri("ms-appx:///Assets/Data/Data.json");
            var file = await StorageFile.GetFileFromApplicationUriAsync(uri);

            
            string text = await Windows.Storage.FileIO.ReadTextAsync(file);
            this.json = text;
            return text;
        }
       */

        public JObject getJson()
        {
            return this.obj;
        }

        public string getDataText()
        {
            return this.data;
        }

        public string getFilterText()
        {
            return this.filter;
        }
    }
}
