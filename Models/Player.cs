using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Homework5.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; } // первинний ключ
        [StringLength(100,ErrorMessage ="Invalid name")]
        public string Name { get; set; } = null!; // інші поля
        [Required]
        public int Number { get; set; }
        [Required]
        [AllowedValues(typeof(Team))]
        public Team Team { get; set; }
        [AllowedValues(typeof (Squad))]
        public Squad Squad { get; set; }    
        public Player(string name, int number)
        {
            Name = name;
            Number = number;
        }
        public Player() { }
    }
}
