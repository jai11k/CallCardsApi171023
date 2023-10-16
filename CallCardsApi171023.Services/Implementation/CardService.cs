using CallCardsApi171023.Contracts;
using CallCardsApi171023.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CallCardsApi171023.Services.Implementation
{
    public class CardService : ICardService
    {
        private readonly HttpClient _httpClient;

        public CardService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<CardApiResponse?> GetAllFilteredCards(string? name, string? colors, string? type)
        {
            
            CardApiResponse? cardApiResponse= await _httpClient.GetFromJsonAsync<CardApiResponse>(prepareRelativeUrl(name, colors, type));
            if(cardApiResponse is not null) cardApiResponse.Count = cardApiResponse.Cards.Count();
            return cardApiResponse;
        }

        private static string prepareRelativeUrl(string name, string colors, string type)
        {
            var queryParameters = new List<string>();
            if (!string.IsNullOrWhiteSpace(name))
                queryParameters.Add($"name={name}");
            if (!string.IsNullOrWhiteSpace(colors))
                queryParameters.Add($"colors={colors}");
            if (!string.IsNullOrWhiteSpace(type))
                queryParameters.Add($"type={type}");

            return  "cards" + (queryParameters.Any() ? "?" + string.Join("&", queryParameters) : "");
        }
    }
}
