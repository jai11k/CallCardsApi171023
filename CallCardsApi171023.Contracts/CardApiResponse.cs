using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCardsApi171023.Contracts
{
    public class CardApiResponse
    {
        public List<CardViewModel> Cards { get; set; }
        public int Count { get; set; }
    }
}
