using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HuellitasService.DAL;
using Huellitas.DTO.Mascotas;

namespace HuellitasService.DAO
{
    public class MascotasDAO
    {
       public MascotaDTO CrearMascota(MascotaDTO mascotaDTO)
        {
            try
            {
                using (HuellitasContext context = new HuellitasContext())
                {
                    Mascotas mascota = new Mascotas()
                    {
                        color = mascotaDTO.ColorMascota,
                        edad = mascotaDTO.EdadMascota,
                        nombre = mascotaDTO.NombreMascota,
                        raza  = mascotaDTO.RazaMascota,
                        tipo = mascotaDTO.TipoMascota
                    };

                    context.Mascotas.Add(mascota);
                    context.SaveChanges();

                    mascotaDTO.IdMascota = context.Mascotas.Max(x => x.id);
                }

                mascotaDTO.Estado = Status.Success;
            }
            catch (Exception)
            {
                mascotaDTO.Estado = Status.Error;
                mascotaDTO.Msg = "Error en el servidor";
            }
            return mascotaDTO;
        }
       public List<MascotaDTO>ReadMascotas()
        {
            List<MascotaDTO> mascotasDTO = new List<MascotaDTO>();
            try
            {
                using (HuellitasContext context = new HuellitasContext())
                {
                    List<Mascotas> mascotas = context.Mascotas.ToList();
                    foreach(Mascotas m in mascotas)
                    {
                        MascotaDTO mdto = new MascotaDTO()
                        {
                            IdMascota = m.id,
                            ColorMascota = m.color,
                            EdadMascota = int.Parse(m.edad.ToString()),
                            NombreMascota = m.nombre,
                            RazaMascota = m.raza,
                            TipoMascota = m.tipo
                        };

                        mascotasDTO.Add(mdto);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return mascotasDTO;
        }

        public MascotaDTO UpdateMascota(MascotaDTO mascota)
        {
            try
            {
                using (HuellitasContext context = new HuellitasContext())
                {
                    Mascotas m = context.Mascotas.Where(x => x.id == mascota.IdMascota).First();
                }

            }
            catch (Exception)
            {

                throw;
            }

            return mascota;
        }


    }
}
