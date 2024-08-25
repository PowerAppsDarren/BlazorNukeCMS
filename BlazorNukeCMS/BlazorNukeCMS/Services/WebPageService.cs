using BlazorNukeCMS.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorNukeCMS.Services
{
    public class WebPageService
    {
        private readonly string _filePath = "Data/WebPages.json";

        public async Task<List<WebPage>> GetWebPagesAsync()
        {
            if (!File.Exists(_filePath))
            {
                return new List<WebPage>();
            }

            var json = await File.ReadAllTextAsync(_filePath);
            return JsonConvert.DeserializeObject<List<WebPage>>(json) ?? new List<WebPage>();
        }

        public async Task SavePagesAsync(List<WebPage> webPages)
        {
            var json = JsonConvert.SerializeObject(webPages, Formatting.Indented);
            await File.WriteAllTextAsync(_filePath, json);
        }

        // Add methods for Create, Update, Delete operations
    }
}
