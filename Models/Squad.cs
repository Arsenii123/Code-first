using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Homework5.Models
{
    public class Squad
    {
        [Key]
        public int SquadId { get; set; } // первинний ключ
        [ForeignKey("PlayerId")]
        public ICollection<Player> Players { get; set; }
        [ForeignKey("TrainerId")]
        public Trainer TrainerId { get; set; }
        [ForeignKey("TeamId")]
        public Team Teams { get; set; }
        public Squad() { }
    }
}
