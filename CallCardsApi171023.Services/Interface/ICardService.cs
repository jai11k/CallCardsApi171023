using CallCardsApi171023.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCardsApi171023.Services.Interface
{
    public interface ICardService
    {
        public Task<CardApiResponse?> GetAllFilteredCards(string? name,string? colors,string? type);
    }
}
