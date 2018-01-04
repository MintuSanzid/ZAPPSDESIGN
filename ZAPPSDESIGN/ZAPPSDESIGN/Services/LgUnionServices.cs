

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ZAPPSDESIGN.Models;

namespace ZAPPSDESIGN.Services
{
    public class LgUnionServices
    {
        public static async Task GetAllNewsAsync(Action<IEnumerable<LgUnionModels>> action)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("http://192.168.15.117:8090/api/LgUnions");

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var list = JsonConvert.DeserializeObject<IEnumerable<LgUnionModels>>(await response.Content.ReadAsStringAsync());
                action(list);
            }
        }
    }
}

