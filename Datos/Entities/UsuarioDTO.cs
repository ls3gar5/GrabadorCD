using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UsuarioDTO
    {
        [Key]
        public string CODCLI { get; set; }
        public string NOMBRE { get; set; }
        public DateTime? FECHACT { get; set; }
        public string CHLOCK { get; set; }
        public string LSISTEM { get; set; }
        public string MPRTWIN { get; set; }
        public bool SELECCION { get; set; }
        public int? IDDESITEM { get; set; }
    }

}
