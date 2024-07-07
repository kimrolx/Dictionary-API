using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Berame___DictionaryApp
{
    internal class DictionarySearchService
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<List<DictionaryResponse>> GetWordDefinitionAsync(string word)
        {
            string url = $"https://api.dictionaryapi.dev/api/v2/entries/en/{word}";

            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            List<DictionaryResponse> dictionaryResponse = JsonConvert.DeserializeObject<List<DictionaryResponse>>(responseBody);

            return dictionaryResponse;
        }
    }
}
