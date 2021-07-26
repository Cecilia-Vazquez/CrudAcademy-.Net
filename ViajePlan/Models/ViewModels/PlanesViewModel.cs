using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViajePlan.Models.ViewModels
{
    public class PlanesViewModel
    {
        public int IdPlan { get; set; }
        public string Nombre { get; set; }
        public string Lugar { get; set; }
        public int Disponibilidad { get; set; }
        public string Cupo { get; set; }


        public PlanesViewModel(Planes planes)
        {
            this.IdPlan = planes.IdPlan;
            this.Nombre = planes.Nombre;
            this.Lugar = planes.Lugar;
            this.Disponibilidad = (int)planes.Disponibilidad;
            this.Cupo = planes.Cupo;

        }
    }
  
}