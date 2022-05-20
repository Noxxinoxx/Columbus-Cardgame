using Newtonsoft.Json.Linq;

namespace GetJsonData {

    public class JsonData {

       //gives us the current playing path. 
       public static string DataPath = Directory.GetCurrentDirectory();
        
        public static JArray GetParsedData() {
            
            //reads the data from the JSON file witch contains the playing deck.
            var data = File.ReadAllText(DataPath + "/data.json");
            //parses the deck to a JArray format.
            JArray parsedDecksData = JArray.Parse(data);

            //returns the parsed deck.
            return parsedDecksData;
        }
    }
}