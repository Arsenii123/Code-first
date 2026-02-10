using Homework5.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Infrastructure.Builder
{
    public class TeamBuilder
    {
        private Team p = new Team();
        public TeamBuilder SetName(string name)
        {
            p.Name = name;
            return this;
        }
        public Team Build() => p;
    }
}
