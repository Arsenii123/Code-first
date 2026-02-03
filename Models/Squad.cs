using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Models
{
    public class Squad
    {
        public int SquadId { get; set; } // первинний ключ
        public int Players { get; set; }
        public Trainer TrainerId { get; set; }
        public Team Teams { get; set; }
        public Squad( int players)
        {
            Players = players;
        }
        public Squad() { }
    }
}
