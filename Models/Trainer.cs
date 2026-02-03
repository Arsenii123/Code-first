using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Models
{
    public class Trainer
    {
        public int TrainerId { get; set; } // первинний ключ
        public string Name { get; set; } = null!; // інші поля
        public Sport IDSport{ get; set; }
        public int Age { get; set; }
        public Squad SquadId{ get; set; }
        public ICollection<Player> Players { get; set; }
        public Trainer(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Trainer() { }
    }
}
