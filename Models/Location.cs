using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IWasThere.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string StadiumName { get; set; }
        public int GameId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}