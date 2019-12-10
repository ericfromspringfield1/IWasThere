using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IWasThere.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }

        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int LocationId { get; set; }
        public int HomeTeamId { get; set; }
        public int HomeScore { get; set; }
        public int AwayTeamId { get; set; }
        public int AwayScore { get; set; }
        public virtual ICollection<UserGame> UserGames { get; set; }
    }
}