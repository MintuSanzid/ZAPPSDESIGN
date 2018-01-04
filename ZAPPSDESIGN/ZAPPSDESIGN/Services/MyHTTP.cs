using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ZAPPSDESIGN.Models;

namespace ZAPPSDESIGN.Services
{
   public class MyHTTP
    {
        public static async Task GetAllNewsAsync(Action<IEnumerable<BldUserReg>> action)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("http://192.168.15.117:8090/api/BldUserRegs");

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var list = JsonConvert.DeserializeObject<IEnumerable<BldUserReg>>(await response.Content.ReadAsStringAsync());
                action(list);
            }
        }
    }
}
