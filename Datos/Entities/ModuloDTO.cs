using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos
{
    public class ModuloDTO
    {
        [Key]
        public string Modulo { get; set; }
        public string Descrip { get; set; }
    }
}
