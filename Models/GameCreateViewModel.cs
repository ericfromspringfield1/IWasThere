using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IWasThere.Models
{
    [Authorize]
    public class GameCreateViewModel
    {
        public Game Game { get; set; }
        public int GameId { get; set; } 
        public virtual ICollection<Team> Teams { get; set; }
        public virtual Team AwayTeam { get; set; }
        public virtual Team HomeTeam { get; set; }

       // [DisplayFormat(ConvertEmptyStringToNull = true)]
       // [Display(Prompt = "Enter A Stadium")]
        public List<Location> Locations { get; set; }
        public Location LocationId { get; set; }
        public string Notes { get; set; }
        public string UserId { get; set; }

        
        public virtual ICollection<SelectListItem> HomeTeamOptions 
        {
            get
            {
                return Teams?.Select(t => new SelectListItem(t.TeamName, t.TeamId.ToString())).ToList();

            }

        }
        
        public virtual ICollection<SelectListItem> AwayTeamOptions
        { 
            get
            {
                return Teams?.Select(t => new SelectListItem(t.TeamName, t.TeamId.ToString())).ToList();

            }

        }
        public List<SelectListItem> LocationOptions 
        {
            get
            {
                return Locations?.Select(l => new SelectListItem(l.StadiumName, l.LocationId.ToString())).ToList();

            }

        }
    }
}
