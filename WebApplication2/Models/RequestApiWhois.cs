using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using RestSharp;
using Newtonsoft.Json.Linq;


namespace WebApplication2.Models
{
    public class RequestApiWhois
    {
        public readonly RestClient httpClient;
        public RequestApiWhois()
        {
            httpClient = new RestClient("http://jsonwhoisapi.com");
        }

        public WhoisParsed SearchDomain(string dominio)
        {
            var request = new RestRequest("/api/v1/whois?identifier=" + dominio, Method.GET);
            request.AddHeader("Authorization", "9XGXolqglOWnpM4_teQYVQ");

            var response = httpClient.Execute(request);

            var WhoisParsed = JsonConvert.DeserializeObject<WhoisParsed>(response.Content);
            

            return WhoisParsed;
        }
    }
}