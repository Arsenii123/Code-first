using Homework5.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Infrastructure.Builder
{
    public class TrainerBuilder
    {
        private Trainer p = new Trainer();
        public TrainerBuilder SetName(string name)
        {
            p.Name = name;
            return this;
        }
        public TrainerBuilder SetAge(int age)
        {
            p.Age = age;
            return this;
        }
        public Trainer Build() => p;
    }
}
