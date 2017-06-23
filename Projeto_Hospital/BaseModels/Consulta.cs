using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModels
{
    public class Consulta
    {
        [Key]
        public int ConsultaID { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio!")]
        public Paciente paciente { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio!")]
        public Medico medico { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio!")]
        public TipoConsulta tipoConsulta { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio!")]
        [DataType(DataType.Date)]
        public string DataConsulta { get; set; }
    }
}
