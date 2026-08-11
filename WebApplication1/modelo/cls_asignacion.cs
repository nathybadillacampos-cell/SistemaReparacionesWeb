using System;

namespace SistemaReparacionesWeb.modelo
{
    public class cls_asignacion
    {
        public int AsignacionID { get; set; }

        public int ReparacionID { get; set; }

        public int TecnicoID { get; set; }

        public DateTime FechaAsignacion { get; set; }
    }
}
