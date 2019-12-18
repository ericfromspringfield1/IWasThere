using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace IWasThere.Models
{
        [Authorize]
    public class Game
    {
        public int GameId { get; set; }
        public string GameName { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }

        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }

        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public virtual Team HomeTeam { get; set; }
        public virtual Team AwayTeam { get; set; }
        public float HomeScore { get; set; }
        public float AwayScore { get; set; }

          


    }
}