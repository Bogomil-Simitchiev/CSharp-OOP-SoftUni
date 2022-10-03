using FootballTeamGenerator;
using System;
using System.Xml.Linq;

namespace MyApp 
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Team;Arsenal
            //Add;Arsenal;Kieran_Gibbs;75;85;84;92;67
            //Add;Arsenal;Aaron_Ramsey;95;82;82;89;68
            //Remove;Arsenal;Aaron_Ramsey
            //Rating;Arsenal
            //END

            Dictionary<string, Team> teams = new Dictionary<string, Team>();

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] splited = command.Split(";");

                string action = splited[0];
                try
                {
                    if (action == "Team")
                    {
                        string teamName = splited[1];
                        if (!teams.ContainsKey(teamName))
                        {
                            Team team = new Team(teamName);

                            teams.Add(teamName, team);
                        }
                    }
                    else if (action == "Add")
                    {
                        string teamName = splited[1];

                        if (!teams.ContainsKey(teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                            command = Console.ReadLine();
                            continue;
                        }

                        string playerName = splited[2];
                        int endurance = int.Parse(splited[3]);
                        int sprint = int.Parse(splited[4]);
                        int dribble = int.Parse(splited[5]);
                        int passing = int.Parse(splited[6]);
                        int shooting = int.Parse(splited[7]);
                        Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);

                        teams[teamName].AddPlayer(player);



                    }
                    else if (action == "Remove")
                    {
                        string teamName = splited[1];
                        string playerName = splited[2];

                        teams[teamName].RemovePlayer(playerName);

                    }
                    else if (action == "Rating")
                    {
                        string teamName = splited[1];

                        if (!teams.ContainsKey(teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                            command = Console.ReadLine();
                            continue;

                        }

                        Console.WriteLine($"{teamName} - {teams[teamName].Rating}");

                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                command = Console.ReadLine();
            }
        }
        
    }
}