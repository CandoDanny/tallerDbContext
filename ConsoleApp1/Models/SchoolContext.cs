using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
   
    
        public class SchoolContext : DbContext
        {
            public DbSet<Cliente> Clientes { get; set; }
            
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=Clientedatabase;Trusted_Connection=True; MultipleActiveResultSets = True ;Encrypt=False");
            }
        }
    
}
