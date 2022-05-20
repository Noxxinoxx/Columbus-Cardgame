using Newtonsoft.Json.Linq;
namespace sort {
    public static class sortDeck {
        public static JArray Sort(JArray Deck)  {
            //if we dont run tests we dont know if this null references are called.
            //make array for every card suit
            JArray HList = new JArray();
            JArray DList = new JArray();
            JArray CList = new JArray();
            JArray SList = new JArray();
            //plays the card in the right array based on the suit
            foreach (var item in Deck)
            {
                if(item["suit"].ToString() == "hearts") {
                    HList.Add(item);
                }else if(item["suit"].ToString() == "diamonds") {
                    DList.Add(item);
                }else if(item["suit"].ToString() == "clubs") {
                    CList.Add(item);
                }else if(item["suit"].ToString() == "spades") {
                    SList.Add(item);
                }
            }
            //make array that contain the four different suits
            JArray suitsArray = new JArray();
            suitsArray.Add(HList);
            suitsArray.Add(DList); 
            suitsArray.Add(CList);
            suitsArray.Add(SList);

            //make final sorted deck array that holds sorted array used later in code
            JArray SortedDeck = new JArray();
            //loop trouge each suit
            for(int suits = 0; suits < suitsArray.Count(); suits++) {

                var n = suitsArray[suits].Count();
                //use bubble sort to sort the Deck by card value
                for (int i = 0; i < n - 1; i++) {
                    for (int j = 0; j < n - i - 1; j++) 
                    {    
                        //if current array value is larger then the next one 
                        //swap the postions of the array until u get a sorted array based on the card value
                        if (((int)suitsArray[suits][j]["value"]) > (int)suitsArray[suits][j + 1]["value"]) 
                        { 
                            // swap temp with suitsArray[suits][j] (current loop trouge) 
                            int temp = (int)suitsArray[suits][j]["value"]; 
                            suitsArray[suits][j]["value"]  = suitsArray[suits][j + 1]["value"]; 
                            suitsArray[suits][j + 1]["value"] = temp; 
                            
                        }  
                    }
                }  
                //get the type based on the value
                //replace 11, 12, 13, 14 with J, Q, K, A 
                foreach(var item in suitsArray[suits]) {
                    
                    if((int) item["value"] == 11) {
                        item["type"] = "J";
                    }else if((int) item["value"] == 12) {
                        item["type"] = "Q";
                    }else if((int) item["value"] == 13) {
                        item["type"] = "K";
                    }else if((int) item["value"] == 14) {
                        item["type"] = "A";
                    }else {
                        item["type"] = item["value"];
                    }
                    //add the sorted suit to the sorted Deck array for display
                    SortedDeck.Add(item);
                }
               
            }
            //return the sortedDeck
            return SortedDeck;
        }
    }
}