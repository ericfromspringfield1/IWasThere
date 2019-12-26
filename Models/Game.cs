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

        [Display(Name = "Game Name")]
        public string GameName { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }

        [Display(Name = "Home Team")]
        public int HomeTeamId { get; set; }

        [Display(Name = "Away Team")]
        public int AwayTeamId { get; set; }

        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        [Display(Name = "Stadium")]
        public int LocationId { get; set; }

        [Display(Name = "Stadium")]
        public Location Location { get; set; }
        public virtual ICollection<Team> Teams { get; set; }

        [Display(Name = "Home Team")]
        public virtual Team HomeTeam { get; set; }

        [Display(Name = "Away Team")]
        public virtual Team AwayTeam { get; set; }

        [Display(Name = "Home Score")]
        public float HomeScore { get; set; }

        [Display(Name = "Away Score")]
        public float AwayScore { get; set; }

        [Display(Name = "Memories From That Day")]
        public string Notes { get; set; }






    }
}