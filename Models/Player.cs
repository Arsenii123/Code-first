using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Models
{
    public class Player
    {
        public int PlayerId { get; set; } // первинний ключ
        public string Name { get; set; } = null!; // інші поля
        public int Number { get; set; }
        public Team Team { get; set; }
        public Player(string name, int number)
        {
            Name = name;
            Number = number;
        }
        public Player() { }
    }
}
