using RestSharp;

namespace DeckOfCards.Models
{
    public class CardDAL
    {
        public NewDeck GetDeck()
        {
            var client = new RestClient($"https://deckofcardsapi.com/api/deck/new/shuffle");
            var request = new RestRequest();
            var response = client.GetAsync<NewDeck>(request);
            NewDeck nd = response.Result;
            return nd;
        }

        public DrawFive GetCards(string uniqueid)
        {
            var client = new RestClient($"https://deckofcardsapi.com/api/deck/{uniqueid}/draw/?count=5");
            var request = new RestRequest();
            var response = client.GetAsync<DrawFive>(request);
            DrawFive df = response.Result;
            return df;
        }
    }
}
