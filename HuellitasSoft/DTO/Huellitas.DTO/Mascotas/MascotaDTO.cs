using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huellitas.DTO.Mascotas
{
    public class MascotaDTO
    {
        public Status Estado { get; set; }
        public string Msg   { get; set; }

        public int IdMascota { get; set; }
        public string RazaMascota { get; set; }
        public string ColorMascota { get; set; }
        public string NombreMascota { get; set; }
        public int EdadMascota { get; set; }
        public string TipoMascota { get; set; }
    }
}
