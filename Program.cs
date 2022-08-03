using Newtonsoft.Json.Linq;
using RestSharp;

var client = new RestClient("https://call-of-duty-modern-warfare.p.rapidapi.com/warzone-matches/Amartin743/psn");
var request = new RestRequest();
request.AddHeader("X-RapidAPI-Key", "fc919fbd73mshceedb3a21b01ea0p150a7ejsnfe09c559839c");
request.AddHeader("X-RapidAPI-Host", "call-of-duty-modern-warfare.p.rapidapi.com");
var response = client.Execute(request).Content;


var jsonObject = JObject.Parse(response);

var kdRatio = jsonObject["matches"][0]["playerStats"]["kdRatio"].ToString();
var kills = jsonObject["matches"][0]["playerStats"]["kills"].ToString();
var deaths= jsonObject["matches"][0]["playerStats"]["deaths"].ToString();




Console.WriteLine($"You have this many kills: {kills}" + 
                  $" You have this many deaths: {deaths}"+ 
                  $" This means you Kill/Death ratio is: {kdRatio}");

