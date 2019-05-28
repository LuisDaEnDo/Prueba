using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Huellitas.DTO.Mascotas;
using HuellitasService.Common.Interfaces;
using HuellitasService.DAO;

namespace HuellitasService.BL
{
    public class MascotasBL : IMascotaBL
    {
        public MascotaDTO GuardarMascota(MascotaDTO mascota)
        {
            mascota = new MascotasDAO().CrearMascota(mascota);
            return mascota;
        }

        public List<MascotaDTO> ListarMascotas()
        {
            List<MascotaDTO> mascotas = new MascotasDAO().ReadMascotas();
            return mascotas;
        }
    }
}
