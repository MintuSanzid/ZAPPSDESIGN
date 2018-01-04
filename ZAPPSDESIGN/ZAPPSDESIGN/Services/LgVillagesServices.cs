using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ZAPPSDESIGN.Models;

namespace ZAPPSDESIGN.Services
{
    public class LgVillagesServices
    {
        public static async Task GetAllNewsAsync(Action<IEnumerable<LgVillagesModels>> action)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("http://192.168.15.117:8090/api/LgVillages");

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var list = JsonConvert.DeserializeObject<IEnumerable<LgVillagesModels>>(await response.Content.ReadAsStringAsync());
                action(list);
            }
        }
    }
}
