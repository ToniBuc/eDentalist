using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eDentalist.Model;
using System.Threading.Tasks;
using Xamarin.Forms;
using eDentalist.Model.Requests;

namespace eDentalist.Mobile
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string Role { get; set; }
        public static int UserID { get; set; }
        public static User User { get; set; }

        private string _route = null;

#if DEBUG
        private string _apiUrl = "http://localhost:44311/api";
        //for android emulator:
        //private string _apiUrl = "http://10.0.2.2:44311/api";
#endif
#if RELEASE
        private string _apiUrl = "https://mywebsite.com/api";
#endif
        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {

            var url = $"{_apiUrl}/{_route}";

            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetStaff<T>(object search)
        {

            var url = $"{_apiUrl}/{_route}/GetStaff";

            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetById<T>(object id)
        {

            var url = $"{_apiUrl}/{_route}/{id}";

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> Insert<T>(object request)
        {

            var url = $"{_apiUrl}/{_route}";

            var result = await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();

            return result;
        }

        public async Task<T> Update<T>(object id, object request)
        {

            var url = $"{_apiUrl}/{_route}/{id}";

            var result = await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();

            return result;
        }

        public async Task<T> Login<T>(object request)
        {

            var url = $"{_apiUrl}/{_route}";

            var result = await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();

            return result;
        }

        public async Task<T> Register<T>(UserInsertRequest request)
        {
            var url = $"{_apiUrl}/{_route}";

            var result = await url.PostJsonAsync(request).ReceiveJson<T>();
            return result;
        }
    }
}
