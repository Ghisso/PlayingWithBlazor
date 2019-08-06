using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PlayingWithBlazor.Models
{
    public class MelbourneHousePricesDataset
    {
        public async Task<List<MelbourneHousePricesInput>> GetDataset()
        {
            var settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        MissingMemberHandling = MissingMemberHandling.Ignore
                    };
            return JsonConvert.DeserializeObject<List<MelbourneHousePricesInput>>
                        (await File.ReadAllTextAsync("Data/MelbourneHousePrices/prices.json"), settings);
        }
    }
}