using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Interfaces;
namespace SmartMirror.WebAPI_Client
{
    public class Client
    {
        HttpClient client = new HttpClient();
        public Client() :this("http://localhost:51819/") { }
        public Client(string adress)
        {
            client.BaseAddress = new Uri(adress);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public IEnumerable<User> getUsers()
        {
            return getUsers_().GetAwaiter().GetResult();
        }
        private async Task<IEnumerable<User>> getUsers_()
        {
            IEnumerable<User> users;
            HttpResponseMessage response = await client.GetAsync("api/Web/users");
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                users = JsonConvert.DeserializeObject<IEnumerable<User>>(json);
            }
            else
            {
                throw new Exception(response.StatusCode.ToString());
            }
            return users;
        }
        public User getUser(int id)
        {
            return getUser_(id).GetAwaiter().GetResult();
        }
        private async Task<User> getUser_(int id)
        {
            User user;
            HttpResponseMessage response = await client.GetAsync("http://localhost:51819/api/Web/users/" + id.ToString());
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                user = JsonConvert.DeserializeObject<User>(json);
            }
            else
            {
                throw new Exception(response.StatusCode.ToString());
            }
            return user;
        }

    }
}
