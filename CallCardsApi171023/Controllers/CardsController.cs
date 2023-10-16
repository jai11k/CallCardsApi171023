using CallCardsApi171023.Contracts;
using CallCardsApi171023.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CallCardsApi171023.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CardsController : ControllerBase
    {
        private readonly ICardService _cardService;

        public CardsController(ICardService cardService)
        {
            this._cardService = cardService;
        }

        [HttpGet(Name = "GetAllFilteredCards")]
        public async Task<IActionResult> GetAllFilteredCardsAsync(string? name=null, string? colors=null, string? type=null)
        {
            var cards = await _cardService.GetAllFilteredCards(name,colors,type);
            return Ok(cards);
        }
    }
}
