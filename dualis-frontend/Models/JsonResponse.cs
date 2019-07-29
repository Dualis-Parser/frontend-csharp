using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace dualis_frontend.Models
{
    public class JsonResponse
    {
        public int code { get; set; }
        public Data data { get; set; }

        public static async Task<JsonResponse> parseDataForUser(string username, string password)
        {
            var handler = new WinHttpHandler();
            var client = new HttpClient(handler);

            var values = new Dictionary<string, string>
            {
                {"username", username},
                {"password", password}
            };

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("http://localhost:8081/dualis/user"),
                Content = new StringContent(JsonConvert.SerializeObject(values), Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request);


            var responseString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<JsonResponse>(responseString);
        }
    }
}