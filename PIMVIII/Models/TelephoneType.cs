using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PIMVIII.Models
{
    public class TelephoneType
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Tipo { get; set; }
        public int TelephoneId { get; set; }
        public Telephone Telephone { get; set; }
    }
}
