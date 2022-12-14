using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeSelecter : MonoBehaviour
{
    public Text Task;
    public Text GameName;
    [SerializeField]AllGames allGames;

    public void NeverHavIEverPlay()
    {
        List<string> neverHaveIEver = new List<string>();
        neverHaveIEver.Add("Drunk Dial His/Her Ex");
        neverHaveIEver.Add("Stolen Anything");
        neverHaveIEver.Add("Fake ID");
        neverHaveIEver.Add("Fought In Public");
        neverHaveIEver.Add("Trolled Someone On Social Media");
        neverHaveIEver.Add("Been Blackout Drunk And Got Married");

        string neverHaveIEverTask = neverHaveIEver[Random.Range(0, neverHaveIEver.Count)];
        Task.text = neverHaveIEverTask;
        GameName.text = "Never Have I Ever";
    }

    public void RandomiserPlay()
    {
        List<string> random = new List<string>();
        random.Add("Balance your drink on your head from one side of the room to another");
        random.Add("Whoever is playing music right now gets to handout 5 sips");
        random.Add("Do bottle flip in 3 tries");
        random.Add("Make a human pyramid with additonal 2 players, if you succeed everyone else drinks");
        random.Add("Make a human pyarmind with 4 additional player, if you succeed everyone else downs their drink");
        random.Add("Send last 4th photo from your camera roll to 4th chat on your any social media");
        random.Add("All females do a little bit of makeup on males");
        random.Add("Rock paper scissors challenge between youngest and oldest player");
        random.Add("Place two ice cubes under your arm pit for next 5 mins, drop it and you down your drink");

        string randomisser = random[Random.Range(0, random.Count)];
        Task.text = randomisser;
        GameName.text = "Randomisser";
    }

    public void DarePlay()
    {
        List<string> dare = new List<string>();
        dare.Add("Eat a Spoonful of hot sauce");
        dare.Add("Impersonate someone in the room without pointing it out and let others guess");
        dare.Add("Take a shot for every person available in room");
        dare.Add("Chug an entire beer pint in 20 seconds");
        dare.Add("Eat a raw egg");

        string dares = dare[Random.Range(0, dare.Count)];
        Task.text = dares;
        GameName.text = "Dare";
    }

    public void VoteWinPlay()
    {
        List<string> VoteWin = new List<string>();
        VoteWin.Add("Office OR Work from home");
        VoteWin.Add("Sleeping OR Playing all night");
        VoteWin.Add("Whiskey OR Vodka");
        VoteWin.Add("Hundred Million Dollars OR Superpower");
        VoteWin.Add("Chicken OR Mutton");
        VoteWin.Add("Cat OR Dog");
        VoteWin.Add("Summer OR Winters");
        VoteWin.Add("IOS OR Android");
        VoteWin.Add("Getting High OR Drunk");
        VoteWin.Add("Hollywood OR Bollywood");
        VoteWin.Add("Childhood OR Adulthood");
        VoteWin.Add("Kids OR No Kids");

        string voteWin = VoteWin[Random.Range(0, VoteWin.Count)];
        Task.text = voteWin;
        GameName.text = "Vote & Win";
    }

    public void WhoIsMostLikelyToPlay()
    {
        List<string> WhoIsMostLikelyTo = new List<string>();
        WhoIsMostLikelyTo.Add("fall in love with a friend");
        WhoIsMostLikelyTo.Add("Come on to security");
        WhoIsMostLikelyTo.Add("Get locked out of the house");
        WhoIsMostLikelyTo.Add("Do shots with bar staff");
        WhoIsMostLikelyTo.Add("Sleep on their own puke");
        WhoIsMostLikelyTo.Add("Get plastic surgery in the future");
        WhoIsMostLikelyTo.Add("Cry in public places");
        WhoIsMostLikelyTo.Add("Eat expired food");
        WhoIsMostLikelyTo.Add("Convert all conversations to double meaning");
        WhoIsMostLikelyTo.Add("Cheating partner and shoot themselves in head afterwards");
        WhoIsMostLikelyTo.Add("Embarass friends in public");
        WhoIsMostLikelyTo.Add("Be addicted to alcohol");

        string whoIsMostLikelyTo = WhoIsMostLikelyTo[Random.Range(0, WhoIsMostLikelyTo.Count)];
        Task.text = whoIsMostLikelyTo;
        GameName.text = "Who Is Most Likely To: ";
    }

    public void WhereIsTheWaterPlay()
    {
        string whereIsMyWater = "Line up selection of various shot glasses and fill them up with clear " +
                "spirits and others with water. Each player then has to take it in turns to drink a" +
                " shot, and say 'mmm, water!' in their convincing voice. If you call their bluff, they drink a shot " +
                "otherwise you will";

        Task.text = whereIsMyWater;
        GameName.text = "Where's The Water";
    }

    public void WouldYouRatherChoosePlay()
    {
        List<string> WouldYouRatherChoose = new List<string>();
        WouldYouRatherChoose.Add("Get a tattoo OR a Nipple piercing");
        WouldYouRatherChoose.Add("Be homeless OR Prison");
        WouldYouRatherChoose.Add("Eat animal brains OR Intestines");
        WouldYouRatherChoose.Add("Get caught watching adult entertainment videos by your boss OR Parents");
        WouldYouRatherChoose.Add("Dog that looks like a baby OR Baby that looks like a dog");
        WouldYouRatherChoose.Add("Live next to active volcano OR Poorly secured prison");
        WouldYouRatherChoose.Add("Skydive OR Bungee jump");
        WouldYouRatherChoose.Add("To be Chandler OR Joey from friends TV show");
        WouldYouRatherChoose.Add("Develop a game OR Play a game");

        string wouldYouRatherChoose = WouldYouRatherChoose[Random.Range(0, WouldYouRatherChoose.Count)];
        Task.text = wouldYouRatherChoose;
        GameName.text = "Would You Rather Choose:";
    }

    public void FlipOrStrip()
    {
        string flipOrStrip = "Take out a coin. Each player will take turn to flip the coin and has to guess weather it is head or" +
                " tail. If their guess is correct, the coin is passed to their left, otherwise, it is passed to their right and they have " +
                "to drink or take off an iteam of clothing";

        Task.text = flipOrStrip;
        GameName.text = "Flip Or Strip";
    }

    public void TwoTruthsAndOneLie()
    {
        string Twotruthsandonelie = "Each one of you has to revel four things about yourself. Out of these 2 are true 2 are lie" +
                ". Your partner will have to guess which of these things are lie. For every wrong guess, You will have to " +
                "take a sip. Otherwise, your partner will take a sip.";

        Task.text = Twotruthsandonelie;
        GameName.text = "Two Truth And One Lie";
    }

    public void SelectAllPlay()
    {
        allGames.Start();
    }

}
