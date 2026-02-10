using System;
using System.Collections.Generic;
using System.Text;
using Homework5.Models;

namespace Homework5.Infrastructure.Builder
{
    public class PlayerBuilder
    {
        private Player p = new Player();
        public PlayerBuilder SetName(string name) { 
            p.Name = name;
            return this;
        }
        public PlayerBuilder SetNumber(int number)
        {
            p.Number = number;
            return this;
        }
        public Player Build() => p;
    }
}
