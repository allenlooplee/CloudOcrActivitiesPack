using Cloud.Ocr.Contracts;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cloud.Ocr.Models
{
    public class MockOcrClient : IOcrClient
    {
        public MockOcrClient(string content)
        {
            Name = "Mock OCR";
            _result = JObject.Parse(content ?? "{ 'result': 'mock' }");
        }

        public string Name { get; }

        public async Task<JObject> RecognizeAsync(string recognizerName, string imagePath, Dictionary<string, object> options = null)
        {
            return _result;
        }

        private JObject _result;
    }
}
