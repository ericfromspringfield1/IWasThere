using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IWasThere.Models
{
    [Authorize]
    public class GameEditViewModel
    {
        public Game Game { get; set; }
        public int GameId { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public List<Location> Locations { get; set; }
        


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