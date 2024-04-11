using BlazorClient.Model;
using System.Net.Http.Headers;
using System.Text.Json;
namespace BlazorClient.Services
{
    public class QuestionService
    {
        private HttpClient client;
        private string serverIP;
        public QuestionService(HttpClient client, string serverIP)
        {
            this.client = client;
            this.serverIP = serverIP;
        }

        public List<Question>? GetAllQuestions()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, serverIP);
            //request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AuthService.accessToken); api security stuff
            var response = client.Send(request);
            if (!response.IsSuccessStatusCode) return null;
            var questionList = JsonSerializer.Deserialize<List<Question>>(response.Content.ReadAsStringAsync().Result);
            return questionList;
        }
    }
}
