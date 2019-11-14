using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval.ORM
{
    public class Client
    {
        [Key][Required]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Mdp { get; set; }

        [StringLength(100)]
        [Required]
        public string mail { get; set; }

        [Required]
        public bool Admin { get; set; }

        public virtual ICollection<Jeu> Jeux { get; set; }
        public Client()
        {
            Jeux = new List<Jeu>();
        }
    }
}
