using System.Net.Http.Json;

namespace disc_golf_blazor_ui.Services
{
    public class AuthService
    {
        private readonly HttpClient httpClient;

        public AuthService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<bool> LoginAsync(string email, string password)
        {
            var loginRequest = new LoginRequest
            {
                Email = email,
                Password = password
            };

            var response = await httpClient.PostAsJsonAsync(
                "http://localhost:24001/api/axion-auth-service/public/auth/login",
                loginRequest
            );

            return response.IsSuccessStatusCode;
        }
    }
}
