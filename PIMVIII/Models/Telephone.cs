using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PIMVIII.Models
{
    public class Telephone
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int Ddd { get; set; }
        public int PersonId { get; set; }

        public Person Person { get; set; }
        public TelephoneType TipoTelefone { get; set; }
    }
}
