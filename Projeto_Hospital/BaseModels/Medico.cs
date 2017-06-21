using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModels
{
    public class Medico
    {
        [Key]
        public int MedicoID { get; set; }

        [Required(ErrorMessage ="Campo obrigatorio!")]
        [StringLength(30,ErrorMessage ="O tamanho Max. é de 30 letras")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio!")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio!")]
        [DataType(DataType.Date)]
        public string DataNasc { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio!")]
        [MaxLength(10,ErrorMessage ="O tamanho Max. é de 10 Caracteres")]
        [MinLength(3, ErrorMessage = "O tamanho Min. é de 3 Caracteres")]
        [DataType (DataType.Password)]
        public string Senha { get; set; }

    }
}
