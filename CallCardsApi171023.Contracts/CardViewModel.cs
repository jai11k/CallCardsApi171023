namespace CallCardsApi171023.Contracts
{
    public class CardViewModel
    {
        public string Name { get; set; }
        public List<string> Colors { get; set; }
        public string Type { get; set; }

    }

    public class CardFilterOptions
    {
        public string Name { get; set; }
        public List<string> Colors { get; set; }
        public string Type { get; set; }

    }
}