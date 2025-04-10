using System;
using static System.Console;
using System.Globalization;
class TestSoccerPlayer
{
	static void Main()
	{
		SoccerPlayer player1 = new SoccerPlayer();
        player1.Name = "John";
        player1.JerseyNum = 01;
        player1.Goals = 4;
        player1.Assists = 6;
        WriteLine("Name: {0} \nJersey #{1} \nGoals: {2} \nAssits: {3}",
            player1.Name, player1.JerseyNum, player1.Goals, player1.Assists);
	}
}
class SoccerPlayer 
{
    public string Name {get; set;}
    public int JerseyNum {get; set;}
    public int Goals {get; set;}
    public int Assists {get; set;}
}
