using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MosPracWebApp.Models
{
    public class DataContext : DbContext
    {
        public DbSet<QuestionSet> QuestionSets { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DataContext(DbContextOptions<DataContext> opts) : base(opts) { }
    }
}
