using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace PlayingWithBlazor.Models
{
    public static class MelbourneHousePricesDataset
    {
        public static List<MelbourneHousePricesInput> Dataset { get; set; } = new List<MelbourneHousePricesInput>();

        static MelbourneHousePricesDataset()
        {
            var settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        MissingMemberHandling = MissingMemberHandling.Ignore
                    };
            Dataset = JsonConvert.DeserializeObject<List<MelbourneHousePricesInput>>
                        (File.ReadAllText("Data/MelbourneHousePrices/prices.json"), settings);
        }
    }
}