using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleGame.EF
{
    internal class Guess
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public int AttemptNumber { get; set; }

        public int GameId { get; set; }
        public virtual Game Game { get; set; }
    }
}
