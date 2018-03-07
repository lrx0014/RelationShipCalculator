using Newtonsoft.Json.Linq;
using System.IO;
using Windows.Storage;
using System;
using System.Threading.Tasks;

namespace RelationshipCalculator.Services
{
    class DataSource
    {
        private string data;
        private string filter;
        private JObject obj;

        public DataSource()
        {
            Task<string> json_task = GetJsonFileAsync();
            string json = json_task.Result;
            var arr = json.Split('Y');
            data   = arr[0];
            filter = arr[1];
            JObject obj = JObject.Parse(data);
            this.obj = obj;

        }

        private async System.Threading.Tasks.Task<string> GetJsonFileAsync()
        {
            var uri = new System.Uri("ms-appx:///Assets/Data/Data.json");
            var file = await StorageFile.GetFileFromApplicationUriAsync(uri);
            string text = await Windows.Storage.FileIO.ReadTextAsync(file);
            return text;
        }

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
