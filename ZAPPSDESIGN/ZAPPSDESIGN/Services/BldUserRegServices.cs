using Newtonsoft.Json;
using Plugin.RestClient;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ZAPPSDESIGN.Models;

namespace ZAPPSDESIGN.Services
{
    class BldUserRegServices
    {

        //public async Task<List<BldUserReg>> GetBldUserRegsAsync() 
        //{
        //    RestClient<BldUserReg> restClient = new RestClient<BldUserReg>();
        //    var bldUserRegList = await restClient.GetAsync();
        //    return bldUserRegList;
        //}
        /// <summary>
        /// Gets the todo items async.
        /// </summary>
        /// <returns>The todo items async.</returns>

        //public  List<BldUserReg> GetAsync()
        //{
        //    var httpClient = new HttpClient();
        //    var json =  httpClient.GetStringAsync("http://192.168.15.117:8090/api/BldUserRegs");
        //    var response = JsonConvert.DeserializeObject<List<BldUserReg>>(json);
        //    return response;
        //}

        //public async Task<List<BldUserReg>> GetAsync()
        //{
        //    var httpClient = new HttpClient();
        //    var json = await httpClient.GetStringAsync("http://192.168.15.117:8090/api/BldUserRegs");
        //    var response = JsonConvert.DeserializeObject<List<BldUserReg>>(json);
        //    return response;
        //}

        public async Task<List<BldUserReg>> getEmployeesAsync()
        {
            RestClient<BldUserReg> restClient = new RestClient<BldUserReg>();
            var employeeList = await restClient.GetAsync();
            return employeeList;
        }

        // Get new data rows
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
        public async Task<bool> RegisterAsync(string userName, string UserAddress, string UserPhoneNo, string UserEmail, string LoginId, string Password)
        {  
            var client = new HttpClient();
            var model = new BldUserReg
            {
                userName = userName,
                UserAddress = UserAddress,
                UserPhoneNo=UserPhoneNo,
                UserEmail=UserEmail,
                LoginId=LoginId,
                Password=Password
            };
            var json = JsonConvert.SerializeObject(model);
            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await client.PostAsync("http://192.168.15.117:8090/api/BldUserRegs", httpContent);
            return response.IsSuccessStatusCode;

        }
    }
}

