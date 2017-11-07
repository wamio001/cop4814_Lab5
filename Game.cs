﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This change was added in Step 7


//Change3

namespace GameLibrary
{
    public class Game
    {
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Team1Score { get; set; }
        public int Team2Score { get; set; }

        public Game() { }
        

        public Game(string Team1, string Team2, int Team1Score, int Team2Score)
        {
            this.Team1 = Team1;
            this.Team2 = Team2;
            this.Team1Score = Team1Score;
            this.Team2Score = Team2Score;
        }

        public override string ToString()
        {
            return (Team1+" ("+Team1Score+") - "+Team2+" ("+Team2Score+")");
        }

    }
}
