using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval.ORM
{
    public class Jeu
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Nom { get; set; }

        [StringLength(50)]
        [Required]
        public string Plateforme { get; set; }

        [Required]
        public bool DispoEnMagasin { get; set; }

        [Required]
        public bool DispoPourRevendre { get; set; }

        public virtual ICollection<Client> Clients { get; set; }

        public Jeu()
        {
            Clients = new List<Client>();
        }
    }
}
