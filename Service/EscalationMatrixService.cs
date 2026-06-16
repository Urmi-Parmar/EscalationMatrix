using System;
using System.Collections.Generic;
using EscalationMatrix.Models;
using EscalationMatrix.Data;
using EscalationMatrix.IService;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;


namespace EscalationMatrix.Service
{
    public class EscalationMatrixService : IEscalationMatrixService
    {
        private readonly HttpClient _httpClient;

        public async Task<List<EMatrixViewModel>> GetData1()
        {
            try
            {
                var url = APIMapper.EscalationMatrix.GetData1;

                var response = await _httpClient.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    var error = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("API ERROR: " + error);
                    return new List<EMatrixViewModel>();
                }

                var json = await response.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<List<EMatrixViewModel>>(json);

                return data ?? new List<EMatrixViewModel>();
            }
            catch (Exception ex)
            {
                Console.WriteLine("EXCEPTION: " + ex.Message);
                return new List<EMatrixViewModel>();
            }

        }
    }
}