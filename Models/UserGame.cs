using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IWasThere.Models
{
    public class UserGame
    {
        public int UserGameId { get; set; }
        public string UserId { get; set; }
        public int GameId { get; set; }
        public int Story { get; set; }
    }
}
