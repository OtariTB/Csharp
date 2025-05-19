using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleGame.EF
{
    internal class Game
    {
        public int Id { get; set; }
        public string TargetWord { get; set; }
        public DateTime PlayedAt { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Guess> Guesses { get; set; }
    }
}
