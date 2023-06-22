using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Personas")]
    public class Persona
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public String Nombre { get; set; }
        [Required]
        [StringLength(100)]
        public string Apellidos { get; set; }
    }
}
