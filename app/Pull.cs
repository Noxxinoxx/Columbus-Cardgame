using Newtonsoft.Json.Linq;
namespace pull {
    public static class pullDeck {
        public static  JToken Pull(JArray Deck) {
            //as I understood the problem u should draw one card at a time
            //and not put it can in the deck
            //so you can use the pull function to pull one card from the deck
            //and it will be added to a new deck
            
            //get the current deck from the main class
           
            //draw the first card from the deck
            JToken firstCard = Deck[0];
            //return the card on top of the deck
            return firstCard;
        }
    }
}