using System;

namespace SistemaReparacionesWeb.modelo
{
    public class cls_reparacion
    {
        public int ReparacionID { get; set; }
        public int EquipoID { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string Estado { get; set; }
    }
}