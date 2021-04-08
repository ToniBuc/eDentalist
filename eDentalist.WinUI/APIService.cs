using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eDentalist.Model;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentalist.WinUI
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string Role { get; set; }
        public static int UserID { get; set; }

        private string _route = null;
        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            if(search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetStaff<T>(object search)
        {
            try
            {
                var url = $"{Properties.Settings.Default.APIUrl}/{_route}/GetStaff";

                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }

                var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

                return result;
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }
        public async Task<T> GetReportAppointments<T>(object search)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/GetReportAppointments";

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

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> Insert<T>(object request)
        {
            try
            {
                var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

                var result = await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();

                return result;
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach(var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }

        public async Task<T> Update<T>(object id, object request)
        {
            try
            {
                var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

                var result = await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();

                return result;
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }

        public async Task<T> Login<T>(object request)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            var result = await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();

            return result;
        }
    }
}
