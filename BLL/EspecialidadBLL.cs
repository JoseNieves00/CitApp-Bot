using System;
using System.Collections.Generic;
using ENTITY;
using DAL;

namespace BLL
{
    public class EspecialidadBLL
    {
        private static EspecialidadDAL especialidadDAL = new EspecialidadDAL();

        
        public static List<Especialidad> ObtenerTodas()
        {
            return especialidadDAL.ObtenerEspecialidades();
        }

        public static Especialidad ObtenerEspecialidadPorId(long id)
        {
            return especialidadDAL.ObtenerEspecialidadPorId(id);
        }

    }
}
