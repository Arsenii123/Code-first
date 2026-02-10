using Homework5.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Infrastructure.Builder
{
    public  class SportBuilder
    {
        private Sport p = new Sport();
        public SportBuilder SetName(string name)
        {
            p.Name = name;
            return this;
        }
        public SportBuilder SetNumber(int number)
        {
            p.Player = number;
            return this;
        }
        public Sport Build() => p;
    }
}
