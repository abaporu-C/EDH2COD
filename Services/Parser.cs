namespace EDH2COD.Services{
    public class Parser{
        private readonly HttpClient _httpClient;

        public Parser(HttpClient httpClient){
            _httpClient = httpClient;
        }

        private async Task<string> CallUrl(string url){
            var response = await _httpClient.GetStringAsync(url);
            return response;
        }
    }
}
