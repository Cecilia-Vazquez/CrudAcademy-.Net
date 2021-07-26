using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViajePlan.Models.ViewModels.PlanesDeViaje
{
    public class ReservacionesViewModel
    {
        public int IdReservacion { get; set; }
        public string Cliente { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public HotelesViewModel Hotel { get; set; }

        public ReservacionesViewModel(Reservaciones Reserva)
        {
            this.IdReservacion = Reserva.IdReservacion;
            this.Cliente = Reserva.Cliente;
            this.Correo = Reserva.Correo;
            this.Telefono = Reserva.Telefono;

            this.Hotel = new HotelesViewModel(Reserva.Hoteles);
        }

    }
    
}