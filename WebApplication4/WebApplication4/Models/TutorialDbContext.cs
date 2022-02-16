using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class TutorialDbContext:DbContext
    {
        public TutorialDbContext(DbContextOptions<TutorialDbContext>options):base(options)
        {

        }
        public DbSet<Tutorial> tutorial { get; set; }
        
      
        
            
        
    }
}
