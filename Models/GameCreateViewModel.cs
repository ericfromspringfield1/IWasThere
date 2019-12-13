using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IWasThere.Models
{
    public class GameCreateViewModel
    {
        public Game Game { get; set; }
        public List<Team> Teams { get; set; }
        public List<Location> Locations { get; set; }

        public List<SelectListItem> HomeTeamOptions 
        {
            get
            {
                return Teams?.Select(t => new SelectListItem(t.TeamName, t.TeamId.ToString())).ToList();

            }

        }
        public List<SelectListItem> AwayTeamOptions
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
