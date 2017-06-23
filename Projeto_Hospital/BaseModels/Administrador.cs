using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModels
{
    public class Administrador
    {
        [Key]
        public int AdministradorID { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio!")]
        [MaxLength(10, ErrorMessage = "O tamanho Max. é de 10 Caracteres")]
        [MinLength(3, ErrorMessage = "O tamanho Min. é de 3 Caracteres")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
