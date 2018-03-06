using Newtonsoft.Json.Linq;
using System.IO;
using Windows.Storage;
using System;
using System.Threading.Tasks;

namespace RelationshipCalculator.Services
{
    class DataSource
    {
        private string json;
        private JObject obj;

        public DataSource(string path)
        {
            //FileStream fs = new FileStream(@"Data//data.json", FileMode.Open);
            //StreamReader file = new StreamReader(fs, System.Text.Encoding.UTF8);
            Task<string> json_task = GetFileAsync();
            json = json_task.ToString();
            
            JObject obj = JObject.Parse(json);
            this.obj = obj;

        }

        public async System.Threading.Tasks.Task<string> GetFileAsync()
        {
            //var file = new System.Uri("ms-appx:///Assets/Data/Data.json");
            //StorageFile f = await StorageFile.GetFileFromApplicationUriAsync(file);
            var uri = new System.Uri("ms-appx:///Assets/Data/Data.json");
            var file = await StorageFile.GetFileFromApplicationUriAsync(uri);
            string text = await Windows.Storage.FileIO.ReadTextAsync(file);
            
            return text;
        }

        public JObject getJson()
        {
            return this.obj;
        }
    }
}
