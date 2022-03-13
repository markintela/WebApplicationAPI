using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebApplicationAPI.Entity;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace WebApplicationAPI.Services
{
    public class PostCodeService : IPostCodeService
    {
        private readonly HttpClient _httpClient;
        public PostCodeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            
        }

   
        public async Task<PostCode> GetCoordinatesByCodePost(string codePost)
        {
            try
            {
              
                var APIURL = $"{codePost}";
                var response = await _httpClient.GetAsync(APIURL);
                var content = await response.Content.ReadAsStringAsync();
               
                dynamic jsonObject = JsonConvert.DeserializeObject<dynamic>(content);
                var postcode = jsonObject["result"];

                var postCodeEntity = new PostCode{
                    Local = postcode["primary_care_trust"],
                    Postcode = postcode["postcode"],
                    Latitude = postcode["latitude"],
                    Longitude = postcode["longitude"]
                   
                };

              return postCodeEntity;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public async Task<PostCode> GetCoordinatesByGeoCoordinates(string longitude, string latitude)
        {
            try
            {

                var apiquery = $"?lon={longitude}&lat={latitude}";
                var response = await _httpClient.GetAsync(apiquery);
                var content = await response.Content.ReadAsStringAsync();

                dynamic jsonObject = JsonConvert.DeserializeObject<dynamic>(content);

                var postcode = jsonObject["result"][0];
                
                var postCodeEntity = new PostCode
                {
                    Local = postcode["primary_care_trust"],
                    Postcode = postcode["postcode"],
                    Latitude = postcode["latitude"],
                    Longitude = postcode["longitude"]
                   
                };

                return postCodeEntity;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

    }
}
