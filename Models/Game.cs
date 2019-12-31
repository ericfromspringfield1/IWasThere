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

        [Display(Name = "Game Name", Prompt = "Enter Name Of Game")]
        public string GameName { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }

        [Display(Name = "Home Team", Prompt = "Select A Home Team")]
        public int HomeTeamId { get; set; }

        [Display(Name = "Away Team", Prompt = "Select An Away Team")]
        public int AwayTeamId { get; set; }

        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        
        [Display(Prompt = "Select A Stadium", Name = "Stadium")]
        public int LocationId { get; set; }

        [Display(Name = "Stadium")]
        public Location Location { get; set; }
        public virtual ICollection<Team> Teams { get; set; }

        [Display(Name = "Home Team")]
        public virtual Team HomeTeam { get; set; }

        [Display(Name = "Away Team")]
        public virtual Team AwayTeam { get; set; }

        [Display(Name = "Home Score", Prompt = "Enter Home Team's Score")]
        public float HomeScore { get; set; }

        [Display(Name = "Away Score", Prompt = "Enter Away Team's Score")]
        public float AwayScore { get; set; }

        [Display(Name = "Memories From That Day", Prompt = "What Are The Most Memorable Moments?")]
        public string Notes { get; set; }

       /* [Display(Name = "Image")]
        public string ImagePath { get; set; }
        public bool Active { get; set; }*/






    }
}