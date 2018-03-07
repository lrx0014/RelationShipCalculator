using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.Storage;

namespace RelationshipCalculator.Services
{
    class DataGetter
    {
        private string json;
        private string filter;

        public DataGetter()
        {
            json = "init";
            Task<string> json_task   = GetJsonFileAsync();
            Task<string> filter_task = GetFilterFileAsync();

            json   = json_task.Result;

            filter = filter_task.Result;

        }

        private async System.Threading.Tasks.Task<string> GetJsonFileAsync()
        {
            var uri = new System.Uri("ms-appx:///Assets/Data/Data.json");
            var file = await StorageFile.GetFileFromApplicationUriAsync(uri);
            string text = await Windows.Storage.FileIO.ReadTextAsync(file);
            return text;
        }

        private async System.Threading.Tasks.Task<string> GetFilterFileAsync()
        {
            var uri = new System.Uri("ms-appx:///Assets/Data/Filter.json");
            var file = await StorageFile.GetFileFromApplicationUriAsync(uri);
            string text = await Windows.Storage.FileIO.ReadTextAsync(file);
            return text;
        }

        public string getDataJson()
        {
            return json;
        }

        public string getFilterJson()
        {
            return filter;
        }
    }
}
