using System;
using System.Collections.Generic;
using System.Linq;

namespace FundC204
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var teams = new List<Team>();
            for (int i = 0; i < n; i++)
            {
                var teamCommands = Console.ReadLine().Split("-");
                var creator = teamCommands[0];
                var teamName = teamCommands[1];
                if (teams.Any(currteam => currteam.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(currname => currname.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    var team = new Team
                    {
                        Creator = creator,
                        Name = teamName,
                        Members = new List<string>()
                    };
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            var line = Console.ReadLine();
            while (line != "end of assignment")
            {
                var member = line.Split(new string[] { "->" }, StringSplitOptions.None)[0];
                var teamJoin = line.Split(new string[] { "->" }, StringSplitOptions.None)[1];

                if (teams.Any(team => team.Members.Contains(member)) || teams.Any(creator =>
                        creator.Creator == member))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamJoin}!");
                }
                else if (teams.All(teama => teama.Name != teamJoin))
                {
                    Console.WriteLine($"Team {teamJoin} does not exist!");
                }
                else
                {
                    var currteam = teams.Find(team => team.Name == teamJoin);
                    currteam.Members.Add(member);
                }

                line = Console.ReadLine();
            }

            var complete = teams.Where(x => x.Members.Count > 0);
            var disbanded = teams.Where(team => team.Members.Count == 0);

            foreach (var team in complete.OrderByDescending(x => x.Members.Count).ThenBy(y => y.Name))
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var disband in disbanded.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{disband.Name}");
            }
        }
    }

    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
}
