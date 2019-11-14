using DocumentFormat.OpenXml.Math;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval.ORM
{
    public class ContexteBDD : DbContext
    {
        public ContexteBDD() : base("Eval")
        {
            
        }
        public DbSet<Jeu> Jeux { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
    }
}
