using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IWasThere.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        public string GameName { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }

        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public int? TeamId { get; set; }
        public Team Team { get; set; }
        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }
        public int HomeScore { get; set; }
        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; }
        public int AwayScore { get; set; }
        

    }
}