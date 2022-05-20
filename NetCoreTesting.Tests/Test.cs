namespace NetCoreTesting.Tests;
using Newtonsoft.Json.Linq;
[TestClass]
public class Test
{

    //Test for getting data from json file. 
    //if the return data is null then we dont have a loaded deck in the game
    //witch means that the game wont work.
    [TestMethod]
    public void getDataFromJSONTest()
    {
        JArray jsonDataWithParsedDeck = GetJsonData.JsonData.GetParsedData();
        Assert.IsNotNull(jsonDataWithParsedDeck);
    }
    
    //Loadeds the deck to the test class needs to have a loaded deck to work.
    public JArray Deck = GetJsonData.JsonData.GetParsedData();


    //Tests if the Pull card from deck works if we get a return we know it will work.
    //if the test returns null we have a problem in the pull class.
    [TestMethod]
    public void PullTest()
    {
        JToken PulledCard = pull.pullDeck.Pull(Deck);
        Assert.IsNotNull(PulledCard);
    }
    
    //Tests the mix deck class if it returns null we dont have a deck to play with.
    //mix must return a JArray that is mixed.
    [TestMethod]
    public void mixTest()
    {
        JArray mixedDeck = mix.MixDeck.Mix(Deck);
        Assert.IsNotNull(mixedDeck);
    }

    //Test for sorting the deck. if the sort returns null it wont have sorted the deck 
    //and we are still playing with the deck from before. 
    [TestMethod]
    public void sortTest()
    {
        JArray SortedDeck = sort.sortDeck.Sort(Deck);
        Assert.IsNotNull(SortedDeck);
    }
    
}