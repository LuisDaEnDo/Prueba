using Huellitas.DTO.Mascotas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuellitasService.Common.Interfaces
{
    public interface IMascotaBL
    {
        List<MascotaDTO> ListarMascotas();
        MascotaDTO GuardarMascota(MascotaDTO mascota);
    }
}
