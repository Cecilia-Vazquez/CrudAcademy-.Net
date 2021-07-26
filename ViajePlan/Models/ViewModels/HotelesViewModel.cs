using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViajePlan.Models.ViewModels.PlanesDeViaje
{
    public class HotelesViewModel
    {
        public int IdHotel { get; set; }
       
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public string Descripcion { get; set; }
        public PlanesViewModel Plan { get; set; }


        public HotelesViewModel(Hoteles hotel)
        {
            this.IdHotel = hotel.IdHotel;
            
            this.Nombre = hotel.Nombre;
            this.Precio = (int)hotel.Precio;
            this.Descripcion = hotel.Descripcion;

            this.Plan = new PlanesViewModel(hotel.Planes);


            


        }


    }

   
}