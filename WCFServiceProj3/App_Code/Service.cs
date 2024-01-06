using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;


public class TeamInfo
{
    public string TeamName { get; set; }
    public List<string> UserNames { get; set; }

    public List<string> Emails { get; set; }

    public int Seed { get; set; }

    public TeamInfo(string teamname)
    { //initializations
        TeamName = teamname;
        UserNames = new List<string>();
        Emails = new List<string>();
        this.Seed = Seed;
    }

}

public class Game
{
    public string Team1 { get; set; }
    public string Team2 { get; set; }

    public Game(string Team1, string Team2)
    {
        this.Team1 = Team1;
        this.Team2 = Team2;
    }
}

public class Service : IService
{
    public static List<TeamInfo> TeamsRegistered = new List<TeamInfo>();
    public string WebDownload(string url)
    {
        string s;
        using (WebClient client = new WebClient()) //create webclient
        {
            s = client.DownloadString(url);
        }
        return s;
    }

    public string RandomNameGenerator() //generates random username
    {
        string username = "";
        string[] firstName = { "Flame", "Ravage", "Iron", "Mega", "Ultra", "Fox", "Gotham", "Dragon", "Vicous" };
        string[] secondName = { "Rhino", "King", "Queen", "Lion", "Slayer", "Recker", "Knight", "Hero", "Beast" };
        Random rnd = new Random();
        int max = firstName.Length;
        int first = rnd.Next(0, max);
        int second = rnd.Next(0, max);

        username = firstName[first] + secondName[second];
        return username;
    }


    public string WordFilter(string str)
    {
        var stopWords = @"\b(a|an|in|on|the|is|are|am|i|my|it|be|was|and)\b"; //list of stopwords
        string result = "";
        foreach (string word in str.Split(' '))
        {
            result = Regex.Replace(str, stopWords, "", RegexOptions.IgnoreCase); //remove stopwords
            result = Regex.Replace(result, @"\s+", " ");
        }
        result = Regex.Replace(result, @"\<.*?\>", ""); //remove xml tags
        result = Regex.Replace(result, @"\s{2,}", " ");

        return result;
    }

    //public string Encrypt(string pw) //generates random username
    //{
    //    char key = (char)3;
    //    string toEncrypt = pw;
    //    char[] cArray = toEncrypt.ToCharArray();

    //    for (var i = 0; i < cArray.Length; i++)
    //    {
    //        cArray[i] = (char)(cArray[i] + key);
    //    }
    //    string encrypted = new string(cArray);
    //    return encrypted;
    //}

    public string RandomUserNameGenerator(int num) //generates random username
    {
        string username = "";
        string[] firstName = { "Flame", "Ravage", "Iron", "Mega", "Ultra", "Fox", "Gotham", "Dragon", "Vicous" };
        string[] secondName = { "Rhino", "King", "Queen", "Lion", "Slayer", "Recker", "Knight", "Hero", "Beast" };
        Random rnd = new Random();
        int max = firstName.Length;
        int first = rnd.Next(0, max);
        int second = rnd.Next(0, max);
        string number = num.ToString();
        username = firstName[first] + secondName[second] + number;
        return username;
    }

    public string Registration(string teamName, string email, string usernames)
    {
        string regmsg = "";

        TeamInfo team = new TeamInfo(teamName);
        team.TeamName = teamName;
        for (int i = 0; i < usernames.Length; i++)
        {
            team.UserNames.Add(usernames);
            team.Emails.Add(email);
        }
        TeamsRegistered.Add(team);

        regmsg = "Congratulations, you have sucessfully registered for the tournament. Registered Teams: ";
        for (int i = 0; i < TeamsRegistered.Count; i++)
        {
            regmsg += TeamsRegistered[i].TeamName + ", ";
        }
        return regmsg;
    }

    public string Seeding(string team1, string team2, string team3, string team4, string team5, string team6, string team7, string team8)
    {
        List<TeamInfo> TeamList = new List<TeamInfo>();
        string[] teams = new string[8];
        teams[0] = team1;
        teams[1] = team2;
        teams[2] = team3;
        teams[3] = team4;
        teams[4] = team5;
        teams[5] = team6;
        teams[6] = team7;
        teams[7] = team8;
        
        int numTeams = teams.Length;
        int min = 1;
        int max = numTeams;
        Random rnd = new Random();
        int[] seeding = new int[numTeams];
        List<int> possibleNums = Enumerable.Range(min, max).ToList();
        List<int> randomizedList = new List<int>();
        for (int i = 0; i < numTeams; i++) //generate random list of nums with no duplicates.
        {
            int index = rnd.Next(0, possibleNums.Count);
            randomizedList.Add(possibleNums[index]);
            possibleNums.RemoveAt(index);
        }
        for (int i = 0; i < numTeams; i++) //assign random list to arr.
        {
            seeding[i] = randomizedList[i];
            TeamInfo team = new TeamInfo(teams[i]);
            TeamList.Add(team);
        }
        for (int i = 0; i < numTeams; i++)
        {
            TeamList[i].Seed = seeding[i];
        }

        List<Game> GameList = new List<Game>();
        int numGames = numTeams / 2;
        int lowseed = numTeams;
        int highseed = 1;
        int team1Ind = 0;
        int team2Ind = 0;
        for (int i = 0; i < numGames; i++) //for loops to put in groups based on seeding
        {
            for (int j = 0; j < numTeams; j++)
            {
                if (TeamList[j].Seed == highseed)
                {
                    team1Ind = j;

                }
            }
            highseed++;
            for (int k = 0; k < numTeams; k++)
            {
                if (TeamList[k].Seed == lowseed)
                {
                    team2Ind = k;
                }
            }
            lowseed--;
            Game newGame = new Game(TeamList[team1Ind].TeamName, TeamList[team2Ind].TeamName);
            GameList.Add(newGame);
        }
        string finalResult = "";
        for (int i = 0; i < numGames; i++)
        {
            finalResult += "Game " + (i+1) + ": " + GameList[i].Team1 + " vs. " + GameList[i].Team2 + "  |  ";
        }
        return finalResult;
    }






}
