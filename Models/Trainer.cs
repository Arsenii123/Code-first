using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homework5.Models
{
    public class Trainer
    {
        [Key]
        public int TrainerId { get; set; } // первинний ключ
        [StringLength(100, ErrorMessage="Invalid name")]
        public string Name { get; set; } = null!; // інші поля
        [ForeignKey("SportId")]
        public Sport IDSport{ get; set; }
        [AllowedValues(typeof(int))]
        public int Age { get; set; }
        [AllowedValues(typeof(Squad))]
        public Squad SquadId{ get; set; }
        [Range(10,15, ErrorMessage ="Invalid count")]
        [ForeignKey("PlayerId")]
        public ICollection<Player> Players { get; set; }
        public Trainer(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Trainer() { }
    }
}
