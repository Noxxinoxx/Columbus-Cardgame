using Newtonsoft.Json.Linq;

namespace mix {

    public class MixDeck {
        
        public static JArray Mix(JArray Deck) {
            //put all the cards in random order then display the array for the user.
            //save the array to a file so you can use the same array for both mix pull and sort.

            //declear the random function for randomizing the deck
            Random random = new Random();

            //mixarray uses the orderby to order the array in a random order using the function random.Next()
            var mixarray = new JArray(Deck.OrderBy(x => random.Next()));

            //return the random ordered array so the main class can use it.
            return mixarray;
        }




    }
}