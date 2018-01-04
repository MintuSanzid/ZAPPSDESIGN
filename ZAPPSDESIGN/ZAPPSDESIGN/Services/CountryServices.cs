//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ZAPPSDESIGN.Services
//{
//    class CountryServices
//    {
//    }
//}


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ZAPPSDESIGN.Models;

namespace ZAPPSDESIGN.Services
{
    public class CountryServices
    {
        public static async Task GetAllNewsAsync(Action<IEnumerable<CountryModels>> action)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("http://192.168.15.117:8090/api/Countries");

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var list = JsonConvert.DeserializeObject<IEnumerable<CountryModels>>(await response.Content.ReadAsStringAsync());
                action(list);
            }
        }
    }
}

