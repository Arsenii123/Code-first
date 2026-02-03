using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Models
{
    public class Sport
    {
        public int SportId { get; set; } // первинний ключ
        public string Name { get; set; } = null!; // інші поля
        public int Player { get; set; }
        public ICollection<Trainer> Trainers { get; set; }
        public Sport(string name, int players)
        {
            Name = name;
            Player = players;
        }
        public Sport() { }
    }
}
