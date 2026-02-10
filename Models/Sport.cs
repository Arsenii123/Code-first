using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Homework5.Models
{
    public class Sport
    {
        [Key]
        public int SportId { get; set; } // первинний ключ
        [StringLength(100, ErrorMessage = "Invalid name")]
        public string Name { get; set; } = null!; // інші поля
        [Range(1,11,ErrorMessage ="Invalid name")]
        public int Player { get; set; }
        [ForeignKey("TrainerId")]
        public ICollection<Trainer> Trainers { get; set; }
        public Sport(string name, int players)
        {
            Name = name;
            Player = players;
        }
        public Sport() { }
    }
}
