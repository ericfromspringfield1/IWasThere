using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IWasThere.Models
{
    public class ApplicationUser: IdentityUser
    {
        public ApplicationUser()
        {

        }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        //Do we need Game, Team, and Location or just UserGame?
        public virtual ICollection<Game> Games { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<Location> Locations { get; set; }

        //public virtual ICollection<UserGame> UserGames { get; set; }
    }
}
