using Cloud.Ocr.Contracts;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cloud.Ocr.Models
{
    public class MockOcrClient : IOcrClient
    {
        public string Name => "Mock OCR";

        public async Task<JObject> RecognizeAsync(string recognizerName, string imagePath, Dictionary<string, object> options = null)
        {
            return new JObject(new JProperty("result", "mock"));
        }
    }
}
