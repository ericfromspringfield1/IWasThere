using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IWasThere.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string Nickname { get; set; }
        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }


    }
}