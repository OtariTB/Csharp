using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleGame.EF
{
    public class Guess
    {
        public int Id { get; set; }
        public string GuessedWord { get; set; }
        public int AttemptNumber { get; set; }
        public DateTime Date { get; set; }

        [Column("User_U_Id")]
        [ForeignKey("User")]
        public int User_Id { get; set; }

        public virtual User User { get; set; }
    }
}
