using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class AllGames : MonoBehaviour
{
    public Text GameName;
    public Text Task;
    public void Start()
    {
        List<string> nameOfTheGame = new List<string>();
        nameOfTheGame.Add("Never Have I Ever");
        nameOfTheGame.Add("Randomiser");
        nameOfTheGame.Add("Dare");
        nameOfTheGame.Add("Vote & Win");
        nameOfTheGame.Add("Who Is Most Likely To ?");
        nameOfTheGame.Add("Where's the water ?");
        nameOfTheGame.Add("Would You Rather Choose ?");
        nameOfTheGame.Add("Flip Or Strip");
        nameOfTheGame.Add("Two Truths And One Lie");

        string gameName = nameOfTheGame[Random.Range(0, nameOfTheGame.Count)];
        GameName.text = gameName;

        if(gameName == "Never Have I Ever")
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
        }

        if(gameName == "Randomiser")
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
        }

        if(gameName == "Dare")
        {
            List<string> dare = new List<string>();
            dare.Add("Eat a Spoonful of hot sauce");
            dare.Add("Impersonate someone in the room without pointing it out and let others guess");
            dare.Add("Take a shot for every person available in room");
            dare.Add("Chug an entire beer pint in 20 seconds");
            dare.Add("Eat a raw egg");

            string Dares = dare[Random.Range(0, dare.Count)];
            Task.text = Dares;

        }

        if(gameName == "Vote & Win")
        {
            List<string>voteWin = new List<string>();
            voteWin.Add("Office OR Work from home");
            voteWin.Add("Sleeping OR Playing all night");
            voteWin.Add("Whiskey OR Vodka");
            voteWin.Add("Hundred Million Dollars OR Superpower");
            voteWin.Add("Chicken OR Mutton");
            voteWin.Add("Cat OR Dog");
            voteWin.Add("Summer OR Winters");
            voteWin.Add("IOS OR Android");
            voteWin.Add("Getting High OR Drunk");
            voteWin.Add("Hollywood OR Bollywood");
            voteWin.Add("Childhood OR Adulthood");
            voteWin.Add("Kids OR No Kids");

            string VoteWin = voteWin[Random.Range(0, voteWin.Count)];
            Task.text = VoteWin;
        }

        if(gameName == "Who Is Most Likely To ?")
        {
            List<string>whoIsMostLikelyTo = new List<string>();
            whoIsMostLikelyTo.Add("fall in love with a friend");
            whoIsMostLikelyTo.Add("Come on to security");
            whoIsMostLikelyTo.Add("Get locked out of the house");
            whoIsMostLikelyTo.Add("Do shots with bar staff");
            whoIsMostLikelyTo.Add("Sleep on their own puke");
            whoIsMostLikelyTo.Add("Get plastic surgery in the future");
            whoIsMostLikelyTo.Add("Cry in public places");
            whoIsMostLikelyTo.Add("Eat expired food");
            whoIsMostLikelyTo.Add("Convert all conversations to double meaning");
            whoIsMostLikelyTo.Add("Cheating partner and shoot themselves in head afterwards");
            whoIsMostLikelyTo.Add("Embarass friends in public");
            whoIsMostLikelyTo.Add("Be addicted to alcohol");

            string WhoIsMostLikelyTo = whoIsMostLikelyTo[Random.Range(0, whoIsMostLikelyTo.Count)];
            Task.text = WhoIsMostLikelyTo;
        }

       if(gameName == "Where's the water ?")
       {
            string whereIsMyWater = "Line up selection of various shot glasses and fill them up with clear " +
                "spirits and others with water. Each player then has to take it in turns to drink a" +
                " shot, and say 'mmm, water!' in their convincing voice. If you call their bluff, they drink a shot " +
                "otherwise you will";

            Task.text = whereIsMyWater;
       }

       if(gameName == "Would You Rather Choose ?")
       {
            List<string>WouldYouRatherChoose = new List<string>();
            WouldYouRatherChoose.Add("Get a tattoo OR a Nipple piercing");
            WouldYouRatherChoose.Add("Be homeless OR Prison");
            WouldYouRatherChoose.Add("Eat animal brains OR Intestines");
            WouldYouRatherChoose.Add("Get caught watching adult entertainment videos by your boss OR Parents");
            WouldYouRatherChoose.Add("Dog that looks like a baby OR Baby that looks like a dog");
            WouldYouRatherChoose.Add("Live next to active volcano OR Poorly secured prison");
            WouldYouRatherChoose.Add("Skydive OR Bungee jump" );
            WouldYouRatherChoose.Add("To be Chandler OR Joey from friends TV show");
            WouldYouRatherChoose.Add("Develop a game OR Play a game");

            string wouldYouRatherChoose = WouldYouRatherChoose[Random.Range(0, WouldYouRatherChoose.Count)];
            Task.text = wouldYouRatherChoose;
       }

       if(gameName == "Flip Or Strip")
       {
            string flipOrStrip = "Each player will take turn to flip the coin and has to guess weather it is head or" +
                " tail. If their guess is correct, the coin is passed to their left, otherwise, it is passed to their right and they have " +
                "to drink or take off an iteam of clothing";

            Task.text = flipOrStrip;
       }

       if(gameName == "Two Truths And One Lie")
        {
            string Twotruthsandonelie = "Each one of you has to revel four things about yourself. Out of these 2 are true 2 are lie" +
                ". Your partner will have to guess which of these things are lie. For every wrong guess, You will have to " +
                "take a sip. Otherwise, your partner will take a sip.";

            Task.text = Twotruthsandonelie;
        }

    }
}
