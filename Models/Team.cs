using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homework5.Models
{
    public  class Team
    {
        [Key]
        public int TeamId { get; set; } // первинний ключ
        [StringLength(100, ErrorMessage="Invalid name")]
        public string Name { get; set; } = null!; // інші поля
        [Range(0,50,ErrorMessage ="Invalid Squad")]
        [ForeignKey("SquadId")]
        public ICollection<Squad> Squads{ get; set; }
        [ForeignKey("TrainerId")]
        public Trainer Trainer { get; set; }
        public Team(string name)
        {
            Name = name;
        }
        public Team() { }
    }
}
