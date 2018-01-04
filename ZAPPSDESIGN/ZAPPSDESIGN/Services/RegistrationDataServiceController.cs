using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using ZAPPSDESIGN.Models;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ZAPPSDESIGN.Services 
{
    public class RegistrationDataServiceController
    {
        HttpClient client = new HttpClient();
        public RegistrationDataServiceController() 
        {
        }

        /// <summary>
        /// Gets the todo items async.
        /// </summary>
        /// <returns>The todo items async.</returns>
        public async Task<List<BldUserReg>> GetLoginModelAsync()
        {
            var response = await client.GetStringAsync("http://localhost:6649/api/LoginApi");
            var RegistrationModelItems = JsonConvert.DeserializeObject<List<BldUserReg>>(response);
            return RegistrationModelItems;
        }

        /// <summary>
        /// Adds the todo item async.
        /// </summary>
        /// <returns>The todo item async.</returns>
        /// <param name="itemToAdd">Item to add.</param>
        public async Task<int> AddRegistrationModelAsync(BldUserReg model) 
        {
            var data = JsonConvert.SerializeObject(model);
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("http://localhost:2998/api/UserReg/item", content);
            var result = JsonConvert.DeserializeObject<int>(response.Content.ReadAsStringAsync().Result);
            return result;
        }

        /// <summary>
        /// Updates the todo item async.
        /// </summary>
        /// <returns>The todo item async.</returns>
        /// <param name="itemIndex">Item index.</param>
        /// <param name="itemToUpdate">Item to update.</param>
        public async Task<int> UpdateLoginModelAsync(int itemIndex, LoginModel itemToUpdate)
        {
            var data = JsonConvert.SerializeObject(itemToUpdate);
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            var response = await client.PutAsync(string.Concat("http://localhost:5000/api/todo/", itemIndex), content);
            return JsonConvert.DeserializeObject<int>(response.Content.ReadAsStringAsync().Result);
        }

        /// <summary>
        /// Deletes the todo item async.
        /// </summary>
        /// <returns>The todo item async.</returns>
        /// <param name="itemIndex">Item index.</param>
        public async Task DeleteLoginModelAsync(int itemIndex)
        {
            await client.DeleteAsync(string.Concat("http://localhost:5000/api/todo/", itemIndex));
        }
    }
}
