using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ZAPPSDESIGN.Models;

namespace ZAPPSDESIGN.Services
{
    public class LgDistrictServices
    {
        public static async Task GetAllNewsAsync(Action<IEnumerable<LgDistrictModels>> action)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("http://192.168.15.117:8090/api/LgDistricts");

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var list = JsonConvert.DeserializeObject<IEnumerable<LgDistrictModels>>(await response.Content.ReadAsStringAsync());
                action(list);
            }
        }
    }
}
