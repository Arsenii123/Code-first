using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Models
{
    public  class Team
    {
        public int TeamId { get; set; } // первинний ключ
        public string Name { get; set; } = null!; // інші поля
        public ICollection<Squad> Squads{ get; set; }
        public Trainer Trainer { get; set; }
        public Team(string name)
        {
            Name = name;
        }
        public Team() { }
    }
}
