using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PlayingWithBlazor.Models
{
    public class UniqloStockDataset
    {
        public async Task<List<UniqloStockInput>> GetDataset()
        {
            var settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        MissingMemberHandling = MissingMemberHandling.Ignore
                    };
            return JsonConvert.DeserializeObject<List<UniqloStockInput>>
                        (await File.ReadAllTextAsync("Data/UniqloStockPrice/uniqlo.json"), settings);
        }
    }
}