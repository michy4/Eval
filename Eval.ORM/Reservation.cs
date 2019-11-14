using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval.ORM
{
    public class Reservation
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public Client client { get; set; }

        [Required]
        public Jeu jeu { get; set; }

        [Required]
        public DateTime date { get; set; }

        public Reservation()
        {
            date = DateTime.Now;
        }

        
    }
}
