using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wimbledon
{
    class Tournament
    {
        private String Name { get; set; }
        private DateTime Year { get; set; }
        private DateTime FromDate { get; set; }
        private DateTime ToDate { get; set; }
        private List<string> PlayerList= new List<string>();
        private int numberPlayers;
        private int Match { get; set; }

        public Tournament(string name, DateTime year, DateTime fd, DateTime td, int match, int numberPlayers)
        {
            Name = name;
            Year = year;
            FromDate = fd;
            ToDate = td;
            Match = match;
            numberPlayers = 64;


        }
/*
        public void addPlayer(int player)
        {
            if(PlayerList.Count == numberPlayers)
            {
                return;
            }
            else
            {
                Player.Add(player);
            }

        }


        static void Main(string[] args)
        {
        }
    */
    }
    
    
}

