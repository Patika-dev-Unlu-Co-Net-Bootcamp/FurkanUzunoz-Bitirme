using Blazzor.Data;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using UnluCo.Bitirme.Blazzor.Data;

namespace UnluCo.Bitirme.Blazzor.Services
{
    public class UserService:IUserService
    {
        public HttpClient _httpClient { get; }
        public AppSettings _appSettings { get; }

        public UserService(HttpClient httpClient, IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;

            httpClient.BaseAddress = new Uri(_appSettings.UnluCoBase);
            httpClient.DefaultRequestHeaders.Add("User-Agent", "BlazorServer");

            _httpClient = httpClient;
        }

        public async Task<User> LoginAsync(User user)
        {
            
            string serializedUser = JsonConvert.SerializeObject(user);

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "User/SignIn");
            requestMessage.Content = new StringContent(serializedUser);

            requestMessage.Content.Headers.ContentType
                = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.SendAsync(requestMessage);

            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            var returnedUser = JsonConvert.DeserializeObject<User>(responseBody);

            return await Task.FromResult(returnedUser);

        }

        public async Task<User> RegisterUserAsync(User user)
        {
            
            string serializedUser = JsonConvert.SerializeObject(user);

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "Users/RegisterUser");
            requestMessage.Content = new StringContent(serializedUser);

            requestMessage.Content.Headers.ContentType
                = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.SendAsync(requestMessage);

            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            var returnedUser = JsonConvert.DeserializeObject<User>(responseBody);

            return await Task.FromResult(returnedUser);
        }

        

        public async Task<User> GetUserByAccessTokenAsync(string accessToken)
        {
            string serializedRefreshRequest = JsonConvert.SerializeObject(accessToken);

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "Users/GetUserByAccessToken");
            requestMessage.Content = new StringContent(serializedRefreshRequest);

            requestMessage.Content.Headers.ContentType
                = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.SendAsync(requestMessage);

            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            var returnedUser = JsonConvert.DeserializeObject<User>(responseBody);

            return await Task.FromResult(returnedUser);
        }

        public async Task<Response> CreateAccount(User user)
        {
            string serializedUser = JsonConvert.SerializeObject(user);

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "User/SignUp");
            requestMessage.Content = new StringContent(serializedUser);

            requestMessage.Content.Headers.ContentType
                = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.SendAsync(requestMessage);

            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            var returnedUser = JsonConvert.DeserializeObject<Response>(responseBody);

            return await Task.FromResult(returnedUser) ;
        }
    }
}
