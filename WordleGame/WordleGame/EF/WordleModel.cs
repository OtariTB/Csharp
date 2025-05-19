using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WordleGame.EF
{
    public partial class WordleModel : DbContext
    {
        public WordleModel()
            : base("name=WordleModel")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Word> Words { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Guess> Guesses { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
