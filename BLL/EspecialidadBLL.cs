using System;
using System.Collections.Generic;
using ENTITY;
using DAL;

namespace BLL
{
    public class EspecialidadBLL
    {
        private static EspecialidadDAL especialidadDAL = new EspecialidadDAL();

        // Método para obtener todas las especialidades
        public static List<Especialidad> ObtenerTodas()
        {
            return especialidadDAL.ObtenerEspecialidades();
        }
    }
}
