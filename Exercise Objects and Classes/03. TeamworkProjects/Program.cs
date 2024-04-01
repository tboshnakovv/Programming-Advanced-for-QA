namespace TeamProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, Team> teams = new Dictionary<string, Team>();

            for (int i = 0; i < count; i++)
            {
                string data = Console.ReadLine();
                string creator = data.Split("-")[0];
                string teamName = data.Split("-")[1];

                bool creatorExists = false;
                bool teamExists = false;
                foreach (var x in teams.Values)
                {
                    if (x.Creator == creator)
                        creatorExists = true;
                    if (x.Name == teamName)
                        teamExists = true;
                }

                if (creatorExists)
                    Console.WriteLine($"{creator} cannot create another team!");
                else if (teamExists)
                    Console.WriteLine($"Team {teamName} was already created!");
                else
                {
                    Team current = new Team(teamName, creator);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    teams.Add(teamName, current);
                }
            }

            string command = Console.ReadLine();
            while (command != "end of assignment")
            {
                string memeberToJoin = command.Split("->")[0];
                string teamToJoin = command.Split("->")[1];

                bool creatorExists = false;
                bool memberExists = false;
                foreach (Team team in teams.Values)
                {
                    if (team.Creator == memeberToJoin)
                        creatorExists = true;
                    foreach (var member in team.Members)
                    {
                        if (member == memeberToJoin)
                            memberExists = true;
                    }
                }

                if (!teams.ContainsKey(teamToJoin))
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                else if (creatorExists || memberExists)
                    Console.WriteLine($"Member {memeberToJoin} cannot join team {teamToJoin}!");
                else
                    teams[teamToJoin].Members.Add(memeberToJoin);

                command = Console.ReadLine();
            }

            foreach (var team in teams.Where(team => team.Value.Members.Count > 0).OrderByDescending(team => team.Value.Members.Count).ThenBy(team => team.Key))
            {
                Console.WriteLine($"{team.Value.Name}");
                Console.WriteLine($"- {team.Value.Creator}");
                foreach (var memeber in team.Value.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {memeber}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in teams.Where(team => team.Value.Members.Count == 0).OrderBy(x => x.Value.Name))
            {
                Console.WriteLine(team.Key);
            }
        }
    }
}
