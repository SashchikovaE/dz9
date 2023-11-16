using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz9
{
    enum Country
    {
        russia,
        kazakhstan,
        france,
        china
    }
    internal class Team
    {
        public List<string> players;
        public Country country;
        public Team()
        {
            players = new List<string>();
        }
        public void AddPlayer(string player)
        {
            players.Add(player);
        }
        public void Play(Game game)
        {
            Console.WriteLine("команда играет в:");
            game.Play();
        }
        public Team CreateTeam(string country)
        {
            Team team = new Team();
            for (int i = 1; i <= 15; i++)
            {
                team.AddPlayer(country + " участник " + i);
            }
            return team;
        }

        public void Win(Team team)
        {
            Console.WriteLine($"команда {team} выиграла");
        }
    }
}
