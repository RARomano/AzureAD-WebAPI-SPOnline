using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AzureAD.WebApi.SPOnline.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = "";
            string clientId = "";
            string userName = "";
            string userPassword = "";
            string apiUrl = "";

          var user = new UserCredential(userName, userPassword);
            
            var authContext = new Microsoft.IdentityModel.Clients.ActiveDirectory.AuthenticationContext("https://login.windows.net/common");
           
            /// Get an Access Token to Access the Web API on behalf of the user
            AuthenticationResult authResult = authContext.AcquireTokenAsync(resource, clientId, user).Result;

            /// Call WebAPI passing Access token on header
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authResult.AccessToken);

            /// Get the result 
            HttpResponseMessage response = client.GetAsync(apiUrl).Result;
            string text = response.Content.ReadAsStringAsync().Result;
        }
    }
}
