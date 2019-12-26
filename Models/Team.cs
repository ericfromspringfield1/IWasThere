using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IWasThere.Models
{
    [Authorize]
    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        [Display(Name = "Team Name")]
        public string TeamName { get; set; }

        [Display(Name = "Team Nickname")]
        public string Nickname { get; set; }
        public virtual ICollection<Game> HomeGames { get; set; } 
        public virtual ICollection<Game> AwayGames { get; set; }
        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }

    }
