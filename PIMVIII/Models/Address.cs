using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PIMVIII.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int Cep { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Estado { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
