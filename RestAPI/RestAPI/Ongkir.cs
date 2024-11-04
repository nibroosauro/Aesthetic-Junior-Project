using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using RestSharp;

namespace RestAPI
{
    internal class Ongkir
    {

        public static List<string> GetKotaList()
        {
            List<string> returnList = new List<string>();
            var client = new RestClient("https://rajaongkir.com/starter/city");
            var request = new RestRequest(Method.GET);
            request.AddHeader("key", "c31a7ac4eaed9d6d966f5af4cf2aa4b9");
            IRestResponse response = client.Execute(request);
            JsonObject obj = (JsonObject)SimpleJson.DeserializeObject(response.Content);
            JsonObject rajaObj = (JsonObject)obj["rajaongkir"];
            JsonArray cityListArray = (JsonArray)rajaObj["results"];
            foreach (JsonObject city in cityListArray)
            {
                returnList.Add((string)city["city_name"]);
            }
            return returnList;
        }

        public static List<string> GetLayananList(int idAsal, int idTujuan, int berat, string kurir)
        {
            List<string> returnList = new List<string>();
            var client = new RestClient("https://api.rajaongkir.com/starter/cost");
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddHeader("key", "c31a7ac4eaed9d6d966f5af4cf2aa4b9");
            request.AddParameter("application/x-www-form-urlencoded",
                "origin=" + idAsal.ToString() + "&destination=" + idTujuan.ToString() +
                "&weight=" + berat.ToString() + "&courier=" + kurir, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);
            JsonObject obj = (JsonObject)SimpleJson.DeserializeObject(response.Content);
            JsonObject rajaObj = (JsonObject)obj["rajaongkir"];
            JsonArray resultsArray = (JsonArray)rajaObj["results"];
            JsonObject courierInfo = (JsonObject)resultsArray[0];
            JsonArray servicesArray = (JsonArray)courierInfo["costs"];

            foreach (JsonObject service in servicesArray)
            {
                string layanan = (string)courierInfo["name"];
                layanan += " - " + (string)service["service"];
                JsonArray detail = (JsonArray)service["cost"];
                JsonObject infoService = (JsonObject)detail[0];
                layanan += "Rp " + Convert.ToInt32(infoService["value"]).ToString();
                layanan += " * " + (string)infoService["etd"] + " Hari";
                returnList.Add(layanan);
            }

            return returnList;
        }

        public static int GetIdKotaList(string kota)
        {
            int idKota = -1;
            var client = new RestClient("https://api.rajaongkir.com/starter/city");
            var request = new RestRequest(Method.GET);
            request.AddHeader("key", "c31a7ac4eaed9d6d966f5af4cf2aa4b9");
            IRestResponse response = client.Execute(request);
            JsonObject obj = (JsonObject)SimpleJson.DeserializeObject(response.Content);
            JsonObject rajaObj = (JsonObject)obj["rajaongkir"];
            JsonArray cityListArray = (JsonArray)rajaObj["results"];

            foreach (JsonObject city in cityListArray)
            {
                if ((string)city["city_name"] == kota)
                {
                    idKota = int.Parse((string)city["city_id"]);
                    break;
                }
            }

            return idKota;
        }

    }
}
