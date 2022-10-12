using RestSharp;

var client = new RestClient("https://free-football-soccer-videos.p.rapidapi.com/");
var request = new RestRequest();
request.AddHeader("X-RapidAPI-Key", "468f7462bdmsh9e2bcd97b71b95cp139dc0jsnedb83d6f5cc5");
request.AddHeader("X-RapidAPI-Host", "free-football-soccer-videos.p.rapidapi.com");
var response = client.Execute(request);

Console.WriteLine(response.Content);