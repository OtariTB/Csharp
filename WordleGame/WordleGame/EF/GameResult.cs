using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleGame.EF
{
    public class GameResult
    {
            public int Id { get; set; }
            public string Word { get; set; }
            public bool IsWin { get; set; }
            public int Attempts { get; set; }
            public DateTime DatePlayed { get; set; }

            [ForeignKey("User")]
            public int UserId { get; set; }
            public virtual User User { get; set; }
        
    }
}
