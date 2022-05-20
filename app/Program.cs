using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using GetJsonData;
using mix;
namespace main {
    public class Program {
        

        //holds the Deck information throughout out the game.
        public static JArray Deck = new JArray();
        public static void Main(string[] args) {
            //get the deck from Json file. (data.json)
            Deck = JsonData.GetParsedData();
            //game loop
            gameloop();
        }
        //gameloop function.
        public static void gameloop() {
                //ask the player what it wants todo!
                Console.WriteLine(" (pull, mix, sort, deck) command: ");
                //read the input from the player
                string reedLine = Console.ReadLine();
                
                if(reedLine == "pull") {
                    //call the function thats pulls the card on top
                    JToken CardDrawn = pull.pullDeck.Pull(Deck);
                    //removes the card on top from the deck
                    //cant draw the same card
                    Deck.RemoveAt(0);
                    //show the player the card
                    Console.WriteLine(CardDrawn);
                    //restart the gameloop
                    gameloop();
                }else if(reedLine == "mix") {
                    //get the mixed deck from the function
                    Deck = mix.MixDeck.Mix(Deck);
                    //show the player the mixed deck
                    Console.WriteLine(Deck);
                    //restart the gameloop
                    gameloop();
                }else if(reedLine == "sort") {
                    //call the sort function
                    Deck = sort.sortDeck.Sort(Deck);
                    //show the player the sorted deck
                    Console.WriteLine(Deck);
                    //restart gameloop
                    gameloop();
                }else if(reedLine == "deck") {
                    //show player the current deck
                    Console.WriteLine(Deck);
                    //restart the gameloop
                    gameloop();
                }
        }
    }
}